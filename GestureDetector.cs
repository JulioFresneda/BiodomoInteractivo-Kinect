using Microsoft.Kinect;
using Microsoft.Kinect.Face;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    public class GestureDetector : IDisposable
    {
        public event EventHandler GestoDetectado;
        public event EventHandler GestoNoDetectado;
        private BodyFrameReader bodyReader = null;
        private Body[] bodies = null;
        private KinectSensor _kinectSensor = null;

        // Face frame source
        FaceFrameSource _faceSource = null;

        // Face frame reader
        FaceFrameReader _faceReader = null;

        private bool framel1 = false, framel2 = false, framel3 = false;

        private bool framer1 = false, framer2 = false, framer3 = false;

        private bool frameh1 = false, frameh2 = false, frameh3 = false;

        private bool doOpenCloseHand = false, doSwipeRight = false, doSwipeLeft = false;


        public GestureDetector(KinectSensor kinectSensor)
        {
            if (kinectSensor == null)
            {
                throw new ArgumentNullException("kinectSensor NO VALIDO");
            }

            this.bodies = new Body[kinectSensor.BodyFrameSource.BodyCount];
            bodyReader = kinectSensor.BodyFrameSource.OpenReader();

            if (bodyReader != null)
            {
                bodyReader.FrameArrived += BodyOnFrameArrived;
            }

            // Initialize the face source with the desired features
            _faceSource = new FaceFrameSource(kinectSensor, 0, FaceFrameFeatures.BoundingBoxInColorSpace |
                                                  FaceFrameFeatures.FaceEngagement |
                                                  FaceFrameFeatures.Glasses |
                                                  FaceFrameFeatures.Happy |
                                                  FaceFrameFeatures.LeftEyeClosed |
                                                  FaceFrameFeatures.MouthOpen |
                                                  FaceFrameFeatures.PointsInColorSpace |
                                                  FaceFrameFeatures.RightEyeClosed);
            _faceReader = _faceSource.OpenReader();
            _faceReader.FrameArrived += FaceOnFrameArrived;
        }

        public GestureDetector()
        {
            _kinectSensor = KinectSensor.GetDefault();
            if (_kinectSensor == null)
            {
                throw new ArgumentNullException("kinectSensor NO VALIDO");
            }
            this._kinectSensor.Open();

            this.bodies = new Body[_kinectSensor.BodyFrameSource.BodyCount];
            bodyReader = _kinectSensor.BodyFrameSource.OpenReader();

            if (bodyReader != null)
            {
                bodyReader.FrameArrived += BodyOnFrameArrived;
            }

            // Inicializamos el face source con las caracteristicas que queramos
            _faceSource = new FaceFrameSource(_kinectSensor, 0, FaceFrameFeatures.BoundingBoxInColorSpace |
                                                  FaceFrameFeatures.FaceEngagement |
                                                  FaceFrameFeatures.Glasses |
                                                  FaceFrameFeatures.Happy |
                                                  FaceFrameFeatures.LeftEyeClosed |
                                                  FaceFrameFeatures.MouthOpen |
                                                  FaceFrameFeatures.PointsInColorSpace |
                                                  FaceFrameFeatures.RightEyeClosed);
            _faceReader = _faceSource.OpenReader();
            _faceReader.FrameArrived += FaceOnFrameArrived;
        }

        public void Dispose()
        {

            bodyReader.Dispose();
            _faceReader.Dispose();
            _faceSource.Dispose();
            _kinectSensor.Close();
            bodies = null;
        }

        private void BodyOnFrameArrived(object sender, BodyFrameArrivedEventArgs args)
        {
            if (args.FrameReference != null)
            {
                using (var frame = args.FrameReference.AcquireFrame())
                {
                    if (frame != null && bodies != null)
                    {
                        frame.GetAndRefreshBodyData(this.bodies);

                        // buscamos el primer body que tenga tanto la mano derecha como la el hombro izquierdo trackeado,
                        // con sus pertinentes comprobaciones para el gesto SWIPE_LEFT
                        var bodyLeft =
                          this.bodies.FirstOrDefault(
                            b => b.IsTracked
                              && AreTracked(b, JointType.HandRight, JointType.ShoulderLeft, JointType.Neck, JointType.SpineMid));

                        if (bodyLeft != null)
                        {
                            checkSwipeLeft(bodyLeft);
                        }
                        else
                        {
                            framel1 = framel2 = framel3 = false;
                        }

                        var bodyRight =
                          this.bodies.FirstOrDefault(
                            b => b.IsTracked
                              && AreTracked(b, JointType.HandLeft, JointType.ShoulderRight, JointType.Neck, JointType.SpineMid));

                        if (bodyRight != null)
                        {
                            checkSwipeRight(bodyRight);
                        }
                        else
                        {
                            framer1 = framer2 = framer3 = false;
                        }

                        var bodyFace =
                          this.bodies.FirstOrDefault(
                            b => b.IsTracked);

                        if (!_faceSource.IsTrackingIdValid)
                        {
                            if (bodyFace != null)
                            {
                                _faceSource.TrackingId = bodyFace.TrackingId;
                            }
                        }

                        var bodyHand =
                         this.bodies.FirstOrDefault(
                           b => b.IsTracked
                           && AreTracked(b, JointType.HandRight, JointType.Neck));

                        if (bodyHand != null)
                        {
                            checkOpenCloseHand(bodyHand);
                        }
                        else
                        {
                            frameh1 = frameh2 = frameh3 = false;
                        }
                    }


                    if (this.GestoDetectado != null && (doSwipeLeft || doSwipeRight || doOpenCloseHand))
                    {
                        SwipedArgs TypeSwipe = new SwipedArgs();

                        if (doSwipeLeft)
                        {
                            TypeSwipe.GestureType = "left";
                            doSwipeLeft = false;
                            this.GestoDetectado(this, TypeSwipe);
                        }
                        else if (doSwipeRight)
                        {
                            TypeSwipe.GestureType = "right";
                            doSwipeRight = false;
                            this.GestoDetectado(this, TypeSwipe);
                        }
                        else if (doOpenCloseHand)
                        {
                            TypeSwipe.GestureType = "hand";
                            doOpenCloseHand = false;
                            this.GestoDetectado(this, TypeSwipe);
                        }
                    }
                    //else if (this.GestoNoDetectado != null) {
                    //    this.GestoNoDetectado(this, EventArgs.Empty);
                    //}
                }
            }
        }

        private void FaceOnFrameArrived(object sender, FaceFrameArrivedEventArgs e)
        {
            using (var frame = e.FrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    // Obtenemos el frame de la cara
                    FaceFrameResult result = frame.FaceFrameResult;

                    if (result != null)
                    {
                        SwipedArgs TypeSwipe = new SwipedArgs();

                        // Obtenemos las caracteristicas de la cara (en nuestro caso, si es feliz o no)
                        if (result.FaceProperties[FaceProperty.Happy].Equals(DetectionResult.Yes))
                        {
                            TypeSwipe.GestureType = "happy";
                            if (GestoDetectado != null)
                            {
                                this.GestoDetectado(this, TypeSwipe);
                            }
                        }else if (result.FaceProperties[FaceProperty.Happy].Equals(DetectionResult.No))
                        {
                            TypeSwipe.GestureType = "sad";
                            if (GestoDetectado != null)
                            {
                                this.GestoDetectado(this, TypeSwipe);
                            }
                        }
                        else
                        {
                            if (GestoNoDetectado != null)
                            {
                                this.GestoNoDetectado(this, EventArgs.Empty);
                            }
                        }
                    }
                }
            }
        }


        private void checkOpenCloseHand(Body bodyHand)
        {
            if (!frameh1 && !frameh2 && !frameh3)
            {
                if (VerticalDistance(bodyHand, JointType.HandRight, JointType.Neck) >= 0.08
                    && (bodyHand.HandRightState == HandState.Closed))
                {
                    frameh1 = true;
                }
            }
            if (frameh1)
            {
                if (bodyHand.HandRightState == HandState.Open)
                {
                    frameh2 = true;
                    frameh1 = false;
                }
            }
            if (frameh2)
            {
                if (bodyHand.HandRightState == HandState.Closed)
                {
                    frameh3 = true;
                    frameh2 = false;
                }
            }
            if (frameh3)
            {
                if (bodyHand.HandRightState == HandState.Open)
                {
                    doOpenCloseHand = true;
                    frameh3 = false;
                }
            }
            System.Diagnostics.Debug.WriteLine(frameh1 + " " + frameh2 + " " + frameh3);
        }

        private void checkSwipeLeft(Body bodyLeft)
        {

            if (!framel1 && !framel2 && !framel3)
            {
                if (HorizontalDistance(bodyLeft, JointType.HandRight, JointType.ShoulderRight) >= -0.05d
                    && HorizontalDistance(bodyLeft, JointType.HandRight, JointType.ShoulderRight) <= 0.05d
                    && VerticalDistance(bodyLeft, JointType.HandLeft, JointType.SpineMid) <= 0.0d)

                {
                    framel1 = true;
                }
            }

            if (framel1)
            {
                if (HorizontalDistance(bodyLeft, JointType.HandRight, JointType.Neck) <= 0.0d)
                {
                    framel2 = true;
                    framel1 = false;
                }
            }
            else if (framel2)
            {
                if (HorizontalDistance(bodyLeft, JointType.HandRight, JointType.ShoulderLeft) <= 0.0d)
                {
                    framel3 = true;
                    framel2 = false;
                }
            }
            else if (framel3)
            {
                if (HorizontalDistance(bodyLeft, JointType.HandRight, JointType.ShoulderLeft) <= 0.0d)
                {
                    doSwipeLeft = true;
                    framel3 = false;
                }
            }

            //System.Diagnostics.Debug.WriteLine(framel1 + " " + framel2 + " " + framel3);

        }

        private void checkSwipeRight(Body bodyRight)
        {

            if (!framer1 && !framer2 && !framer3)
            {
                if (HorizontalDistance(bodyRight, JointType.HandLeft, JointType.ShoulderLeft) >= -0.05d
                    && HorizontalDistance(bodyRight, JointType.HandLeft, JointType.ShoulderLeft) <= 0.05d
                    && VerticalDistance(bodyRight, JointType.HandLeft, JointType.SpineMid) >= 0.0d)
                {
                    framer1 = true;
                }
            }

            if (framer1)
            {
                if (HorizontalDistance(bodyRight, JointType.HandLeft, JointType.Neck) >= 0.0d)
                {
                    framer2 = true;
                    framer1 = false;
                }
                else if (HorizontalDistance(bodyRight, JointType.HandLeft, JointType.ShoulderLeft) < 0.0d)
                {
                    //framer1 = false;
                }
            }
            else if (framer2)
            {
                if (HorizontalDistance(bodyRight, JointType.HandLeft, JointType.ShoulderRight) >= 0.0d)
                {
                    framer3 = true;
                    framer2 = false;
                }
                else if (HorizontalDistance(bodyRight, JointType.HandLeft, JointType.Neck) > 0.0d)
                {
                    //framer2 = false;
                }
            }
            else if (framer3)
            {
                if (HorizontalDistance(bodyRight, JointType.HandLeft, JointType.ShoulderLeft) >= 0.0d)
                {
                    doSwipeRight = true;
                    framer3 = false;
                }
            }

            // System.Diagnostics.Debug.WriteLine(framer1 + " " + framer2 + " " + framer3);

        }

        static bool AreTracked(Body body, params JointType[] joints)
        {// esta/estan tracked el joint/o joints pasados por parametro del body pasado ??
            return (joints.All(j => body.Joints[j].TrackingState == TrackingState.Tracked));
        }

        static double VerticalDistance(Body body, JointType jointOne, JointType jointTwo)
        {
            return (body.Joints[jointOne].Position.Y - body.Joints[jointTwo].Position.Y);
        }

        static double HorizontalDistance(Body body, JointType jointOne, JointType jointTwo)
        {
            return (body.Joints[jointOne].Position.X - body.Joints[jointTwo].Position.X);
        }


    }
}

