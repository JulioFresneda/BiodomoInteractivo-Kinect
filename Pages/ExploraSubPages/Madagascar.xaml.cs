using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Microsoft.Samples.Kinect.ControlsBasics.Pages.ExploraSubPages
{
    /// <summary>
    /// Interaction logic for Amazonas.xaml
    /// </summary>
    public partial class Madagascar : Page
    {
        private List<Uri> uriMadagascar;
        private List<String> titlesMadagascar;
        private List<String> descMadagascar;
        private List<int> indices;

        int puntero;

        public Madagascar()
        {
            InitializeComponent();
            uriMadagascar = new List<Uri>();
            titlesMadagascar = new List<string>();
            descMadagascar = new List<string>();
            indices = new List<int>();
            LoadSpecies(uriMadagascar);

            Random r = new Random();
            List<int> indicestemp = new List<int>();

            for (int i = 0; i < uriMadagascar.Count; i++)
            {
                indicestemp.Add(i);
            }

            while (indicestemp.Count > 0)
            {
                int rand = r.Next(0, indicestemp.Count);
                indices.Add(indicestemp[rand]);
                indicestemp.RemoveAt(rand);
            }



            puntero = 0;

            
            StreamResourceInfo streamInfo = Application.GetResourceStream(uriMadagascar[indices[0]]);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            this.Especie.Source = temp;



            Uri leftButtonUri = new Uri("Assets/explora_button_left_mad.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(leftButtonUri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            this.Left.Background = brush;




            Uri rightButtonUri = new Uri("Assets/explora_button_right_mad.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(rightButtonUri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            brush = new ImageBrush();
            brush.ImageSource = temp;
            this.Right.Background = brush;



            LoadTitles(titlesMadagascar);
            this.Titulo.Text = titlesMadagascar[0];

            LoadDesc(descMadagascar);
            this.Descripcion.Text = descMadagascar[0];
            

        }


        private void RightClick(object sender, RoutedEventArgs e)
        {
            if (puntero < uriMadagascar.Count - 1)
            {
                puntero++;
                Uri resourceUri = uriMadagascar[indices[puntero]];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;

                this.Titulo.Text = titlesMadagascar[indices[puntero]];
                this.Descripcion.Text = descMadagascar[indices[puntero]];
            }

        }

        private void LeftClick(object sender, RoutedEventArgs e)
        {
            if (puntero > 0)
            {
                puntero--;
                Uri resourceUri = uriMadagascar[indices[puntero]];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;

                this.Titulo.Text = titlesMadagascar[indices[puntero]];
                this.Descripcion.Text = descMadagascar[indices[puntero]];
            }

        }





        public void LoadSpecies(List<Uri> uriMadagascar)
        {

            // imagenes madagascar
            uriMadagascar.Add(new Uri("Images/mad_a_0.png", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_a_1.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_a_2.jpg", UriKind.Relative ));

            uriMadagascar.Add(new Uri("Images/mad_v_0.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_1.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_2.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_3.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_4.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_5.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_6.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_7.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_8.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_9.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_10.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_11.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_12.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_13.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_14.jpg", UriKind.Relative ));
            uriMadagascar.Add(new Uri("Images/mad_v_15.jpg", UriKind.Relative ));


        }

        private void LoadTitles( List<String> titlesMadagascar )
        {
            titlesMadagascar.Add("Lémur de cola anillada");
            titlesMadagascar.Add("Cucaracha de Madagascar");
            titlesMadagascar.Add("Turaco cariblanco");



            titlesMadagascar.Add("Tulipero de Gabon");
            titlesMadagascar.Add("Palma del viajero");
            titlesMadagascar.Add("Pandano");
            titlesMadagascar.Add("Flamboyán");
            titlesMadagascar.Add("Ciruelo de los cafres");
            titlesMadagascar.Add("Baobab");
            titlesMadagascar.Add("Árbol del coral africano");
            titlesMadagascar.Add("Ajo lavanda");
            titlesMadagascar.Add("Ave del paraíso");
            titlesMadagascar.Add("Bignonia del Cabo");
            titlesMadagascar.Add("Drago");
            titlesMadagascar.Add("Lirio del Nilo");
            titlesMadagascar.Add("Palmera del Senegal");
            titlesMadagascar.Add("Palmera triangular");
            titlesMadagascar.Add("Schotia");
            titlesMadagascar.Add("Ave del paraíso blanca");
        }

        private void LoadDesc( List<String> descMadagascar )
        {
            descMadagascar.Add("Lemur catta. Es un primate de hábitos estrictamente diurnos que pasa la mayor parte del tiempo en los árboles, aunque también frecuenta el suelo. Es sociable y vive en grupos de 5 a 25 individuos. Es polígamo y usa su característica cola para hacer señales visuales y odoríferas. Cuando camina por el suelo mantiene erguida la cola para señalar su presencia al resto de sus congéneres. También se comunica por vocalizaciones, por actitudes corporales y por expresiones del rostro. Se alimenta de frutos, hojas, flores, cortezas y pequeños insectos.");
            descMadagascar.Add("Gromphadorhina portentosa. Es una de las mayores cucarachas que existen. Carece de alas y es una excelente escaladora. Progenitores y crías permanecen juntos largos periodos de tiempo. Pueden expulsar aire por los poros respiratorios del abdomen produciendo un sonido característico. Vive en la madera muerta y come restos vegetales.");
            descMadagascar.Add("Tauraco leucotis. Ave de vivos colores y una cresta sobre la cabeza que pueden levantar a voluntad. Sus colores rojo y verde se deben a pigmentos producidos por esta a ve. Es ruidosa y emite una penetrante llamada de alarma. Construye nidos grandes y sencillos con ramas y pone dos huevos. Come frutas y pequeños artrópodos. Es endémica del este africano.");

            descMadagascar.Add("Spathodea campanulata. Árbol nativo de las selvas tropicales secas de la Costa Este de África que alcanza los 25 m de altura, pero está muy extendido en todas las zonas tropicales del mundo. Las flores son rojo anaranjadas y se comportan como una copa reteniendo agua de lluvia que atrae numerosas aves. El fruto es una cápsula ligeramente leñoso que se abre en dos valvas. Está encuadrada entre las 100 plantas más invasoras del mundo.");
            descMadagascar.Add("Ravenala madagascariensis. Planta herbácea perenne que alcanza 10 m. Es endémica de Madagascar donde vive en llanuras y pastizales con agua abundante por debajo de 800 m. Se ha introducido en otras islas como Mauricio o Reunión comportándose como invasora. Las hojas crecen en un solo plano con forma de abanico. Las flores son hermafroditas de color blanco crema y crecen desde las axilas de las hojas. Son polinizadas por el lémur negro.");
            descMadagascar.Add("Pandanus utilis. Arbusto endémico de Madagascar y naturalizado en áreas de clima subtropical. El tronco es recto, liso y redondeado. Tiene raíces que surgen del tallo por encima del suelo que ayudan a soportar la planta. La ramificación dicotómica forma una copa piramidal. Es perenne con hojas insertadas en espiral a lo largo del tronco. Son grandes, lineares y de bordes aserrados. Las flores masculinas y femeninas están en plantas diferentes. El fruto es una piña colgante comestible.");
            descMadagascar.Add("Delonix regia. Árbol originario de la selva seca de Madagascar donde está en peligro de extinción, aunque se ha naturalizado en muchos lugares del mundo de clima tropical. Es caduco o semiperenne de follaje denso y hojas doblemente divididas. Tiene bonitas flores anaranjadas y el fruto es una legumbre leñosa larga y plana que contiene semillas pequeñas. Se utiliza como instrumento de percusión. La corteza y las flores se usan en remedios contra el reuma y el asma bronquial.");
            descMadagascar.Add("Harpephyllum caffrum. Árbol de bosques costeros del sudeste de África, desde El Cabo a Mozambique. Perenne. Copa compacta y redondeada. Tronco recto liso que se vuelve rugoso con el tiempo. Hojas compuestas, verde oscuras por el haz y más claras por el envés. A los dos años enrojecen y caen. Las flores masculinas y femeninas se encuentran en árboles separados. Fruto en drupa rojo, carnoso, en racimos. Se usa para fabricar muebles o para tallar.");
            descMadagascar.Add("Adansonia grandidieri. Es un árbol caduco de los bosques secos de Madagascar que alcanza 25 m. Su tronco puede tener 11 m de diámetro y sus ramas sin hojas recuerdan las raíces de un árbol. Su madera, sin cercos anuales, es semejante a una esponja, ya que puede almacenar 90.000 l de agua para poder sobrevivir durante los periodos de sequía. A la corteza le salen nudos e irregularidades en la superficie. Contiene una fibra muy resistente que la protege de los incendios. El fruto es parecido a un melón con múltiples semillas grandes y aplanadas.");
            descMadagascar.Add("Erythrina caffra. Es un pequeño árbol caduco de 3 a 7 m nativo del sureste de África. Tiene las ramas cubiertas de espinas. Crece en los bosques costeros sudafricanos hasta los 200 m de altitud. Es frecuentemente en parques por sus brillantes flores anaranjadas y la sombra que proporciona. Las flores son ricas en néctar que atrae aves favoreciendo la polinización. El fruto es una legumbre cilíndrica leñosa que contienen semillas de color rojo vivo. Se utiliza para fabricar juguetes, vallas y medicinas.");
            descMadagascar.Add("Tulbaghia violácea. Planta herbácea del Sur de África. Es perenne y soporta bien los ambientes marinos. Tiene una base bulbosa y las hojas son largas y acintadas de color verde vivo. Las flores tubulares con pétalos abiertos en estrella de color malva. El fruto es una cápsula. Emana un fuerte olor a ajo. Se utiliza localmente como medicinal.");
            descMadagascar.Add("Strelitzia reginae. Herbácea tropical originaria de Sudáfrica. Perenne que alcanza redondeadas, 1,5 m de altura. Tiene tallos subterráneos que acumulan sustancias de reserva. Las hojas son persistentes, grandes, verde grisáceas y ovaladas. Los tallos tienen forma de pico de ave y mantienen de 5 a 8 ﬂores anaranjadas. El fruto es una cápsula trilocular en la que se forman semillas negras, redondeadas, con arilo naranja y plumoso.");
            descMadagascar.Add("Cape honeysuckle. Arbusto originario de Sudáfrica. Semitrepador, perenne, de porte erecto con largas y ﬂexibles ramas que se apoyan sobre otros arbustos para alcanzar la luz. Puede llegar a 3 m de altura. Las ﬂores son tubulares y se agrupan en largos racimos al ﬁnal de las ramas. Su color va del naranja al rojo. Son muy apreciadas por los insectos y las aves por su gran cantidad de néctar. Fruto en cápsula con numerosas semillas.");
            descMadagascar.Add("Dracaena draco. Herbácea que se comporta como un árbol pero carece de crecimiento en grosor. El tallo es único y suculento, ramiﬁcado en altura, que forma una copa abovedada. El follaje es persistente, carnoso, de hojas lineares. Las ﬂores son pequeñas de color blanco y desprenden una agradable fragancia. Se encuentran en racimos terminales. La savia se torna roja en contacto con el aire. Tiene propiedades medicinales y se usa en la fabricación de tintes y barnices.");
            descMadagascar.Add("Agapanthus africanus. Planta herbácea originaria de Sudáfrica que puede alcanzar los 60 cm de altura. Perenne. El tallo es corto pero del que salen largas hojas acintadas de color verde intenso. Las ﬂores se agrupan en la parte superior en inﬂorescencias de color blanco, azul o violeta. Tiene raíces carnosas gruesas y compactas. Es una planta resistente al fuego.");
            descMadagascar.Add("Phoenix reclinata. Palmera originaria de Madagascar y de los trópicos de África. Vive en bosques húmedos y laderas de montañas hasta los 3.000 m. Las hojas son pinnadas de 4 m de longitud. Las ﬂores masculinas y femeninas están separadas en palmeras diferentes. Las masculinas forman grandes ramilletes amarillos y las femeninas son globosas. Produce frutos comestibles en racimos colgantes que contienen una semilla dura en el interior. Se usa en cestería y de la savia se extrae el vino de palma.");
            descMadagascar.Add("Dypsis decaryi. Palmera endémica de la selva húmeda de Madagascar. Las hojas son pinnadas de 3 m de longitud y crecen en tres lados distintos de la planta formando un tallo triangular. Las ﬂores son amarillas o verdosas y producen un fruto comestible de color negro. Sus principales amenazas son el fuego y la recolección de sus semillas para el comercio.");
            descMadagascar.Add("Schotia afra. Árbol oriundo de Sudáfrica. Se encuentra en las orillas de arroyos secos, bancos de arena y pequeños ríos. Alcanza 5 m. Es perenne, de ramas rígidas y tronco nudoso. Las ﬂores son numerosas de color rosado a rojo brillante y están distribuidas por todo el árbol. Tienen mucho de néctar que atrae a aves y mariposas. El fruto es una legumbre que explota cuando está seca dispersando las semillas. Son comestibles.");
            descMadagascar.Add("Strelitzia alba. Herbácea nativa de Sudáfrica y Madagascar. Es la más alta de las Sterlitzias con una altura de 10 m y una de las tres arborescentes junto a S. nicolai. y S. caudata. Las hojas son alternas con nervadura central marcada, ovales y de peciolo largo. Están dispuestas en dos ﬁlas a lo largo de un eje y crecen helicoidalmente. Las ﬂores son hermafroditas, blancas, encerradas en una espata de color púrpura. El fruto es una cápsula con arilo lanoso de color rojo brillante.");

        }



        
    }
}
