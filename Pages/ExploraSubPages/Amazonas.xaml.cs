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
    public partial class Amazonas : Page
    {

        private List<Uri> uriAmazonas;
        private List<String> titlesAmazonas;
        private List<String> descAmazonas;


        int puntero;
        List<int> indices;

        public Amazonas()
        {
            InitializeComponent();
            uriAmazonas = new List<Uri>();
            titlesAmazonas = new List<String>();
            descAmazonas = new List<string>();
            indices = new List<int>();

            

            
            puntero = 0;

            LoadSpecies(uriAmazonas);
            Random r = new Random();
            List<int> indicestemp = new List<int>();

            for (int i = 0; i < uriAmazonas.Count; i++)
            {
                indicestemp.Add(i);
            }

            while( indicestemp.Count > 0 )
            {
                int rand = r.Next(0, indicestemp.Count);
                indices.Add(indicestemp[rand]);
                indicestemp.RemoveAt(rand);
            }




           
            StreamResourceInfo streamInfo = Application.GetResourceStream(uriAmazonas[indices[0]]);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            this.Especie.Source = temp;




            Uri leftButtonUri = new Uri("Assets/explora_button_left_ama.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(leftButtonUri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            this.Left.Background = brush;




            Uri rightButtonUri = new Uri("Assets/explora_button_right_ama.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(rightButtonUri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            brush = new ImageBrush();
            brush.ImageSource = temp;
            this.Right.Background = brush;


            LoadTitles(titlesAmazonas);
            this.Titulo.Text = titlesAmazonas[indices[0]];

            LoadDesc(descAmazonas);
            this.Descripcion.Text = descAmazonas[indices[0]];

        }

     




        private void RightClick(object sender, RoutedEventArgs e)
        {
            if (puntero < uriAmazonas.Count - 1)
            {
                puntero++;
                Uri resourceUri = uriAmazonas[indices[puntero]];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;

                this.Titulo.Text = titlesAmazonas[indices[puntero]];
                this.Descripcion.Text = descAmazonas[indices[puntero]];
            }

        }

        private void LeftClick(object sender, RoutedEventArgs e)
        {
            if (puntero > 0)
            {
                puntero--;
                Uri resourceUri = uriAmazonas[indices[puntero]];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;

                this.Titulo.Text = titlesAmazonas[indices[puntero]];
                this.Descripcion.Text = descAmazonas[indices[puntero]];
            }

        }














        private void LoadSpecies( List<Uri> uriAmazonas )
        {
            
            // imagenes amazonas
            uriAmazonas.Add(new Uri("Images/ama_a_0.png", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_1.jpeg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_2.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_3.jpeg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_4.jpeg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_5.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_6.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_7.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_8.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_9.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_10.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_11.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_12.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_13.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_14.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_15.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_16.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_a_17.jpg", UriKind.Relative));


            uriAmazonas.Add(new Uri("Images/ama_v_0.png", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_1.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_2.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_3.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_4.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_5.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_6.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_7.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_8.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_9.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_10.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_11.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_12.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_13.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_14.jpg", UriKind.Relative));
            uriAmazonas.Add(new Uri("Images/ama_v_15.jpg", UriKind.Relative));

            
        }


        private void LoadTitles( List<String> titlesAmazonas )
        {
            titlesAmazonas.Add("Perezoso de dos dedos");
            titlesAmazonas.Add("Tucán de pecho blanco");
            titlesAmazonas.Add("Trompetero");
            titlesAmazonas.Add("Tortuga matamata");
            titlesAmazonas.Add("Rana de ojos rojos");
            titlesAmazonas.Add("Culebra verde nariguda");
            titlesAmazonas.Add("Cotinga");
            titlesAmazonas.Add("Armadillo de seis bandas");
            titlesAmazonas.Add("Boa arco iris");
            titlesAmazonas.Add("Ajolote");
            titlesAmazonas.Add("Rascón de cuello rojo");
            titlesAmazonas.Add("Ibis escarlata");
            titlesAmazonas.Add("Iguana verde");
            titlesAmazonas.Add("Rana punta de ﬂecha rayada");
            titlesAmazonas.Add("Rana punta de ﬂecha de franjas amarillas");
            titlesAmazonas.Add("Rana punta de ﬂecha teñida");
            titlesAmazonas.Add("Arasarí verde");
            titlesAmazonas.Add("Tití de cara blanca");



            titlesAmazonas.Add("Árbol del coral");
            titlesAmazonas.Add("Buganvilla");
            titlesAmazonas.Add("Butia lanosa");
            titlesAmazonas.Add("Clavel del aire");
            titlesAmazonas.Add("Coco plumoso");
            titlesAmazonas.Add("Filodendro");
            titlesAmazonas.Add("Galán de noche");
            titlesAmazonas.Add("Guayaba del Brasil");
            titlesAmazonas.Add("Heliconia");
            titlesAmazonas.Add("Jacaranda");
            titlesAmazonas.Add("Lágrimas de amor");
            titlesAmazonas.Add("Lantana");
            titlesAmazonas.Add("Lapacho rosado");
            titlesAmazonas.Add("Madero amarillo");
            titlesAmazonas.Add("Nuez de la India");
            titlesAmazonas.Add("Palmera de los pantanos");
        }


        private void LoadDesc( List<String> descAmazonas )
        {
            descAmazonas.Add("Choloepus didactylus. Las extremidades terminan en dos dedos con garras curvas que le sirven para trepar y permanecer colgado. Su pelo es largo y se orienta desde el vientre hacia el dorso, al contrario que la mayoría de los mamíferos. Es de hábitos nocturnos y duerme hasta quince horas durante el día. Nocturno. Come hojas y frutas.");
            descAmazonas.Add("Ramphastos tucanus. El macho y la hembra son iguales, a excepción del pico que es más largo en el macho. Son principalmente frugívoras. Usan su pico para alcanzar los frutos que engullen enteros con una rápida sacudida de su cuello. También comen insectos, orugas y pequeños reptiles. Hace el nido en huecos de árboles. Vive solo, en pareja o en pequeñas bandadas. Emite un gruñido profundo que puede oírse a gran distancia.");
            descAmazonas.Add("Psophia crepitans. Es sociable. Vive en pequeños grupos en el suelo del bosque donde descansan, se bañan y buscan frutos caídos de los árboles para alimentarse mientras que por la noche prefieren posarse en las ramas de los árboles. Emite una variedad de sonidos, algunos intensos como una trompeta, para advertir del peligro, marcar su territorio, solicitar alimento o amenazar a los intrusos. Es muy dócil y las poblaciones nativas la utilizan como centinela para cuidar de sus gallinas ya que avisan de la presencia de cualquier animal extraño.");
            descAmazonas.Add("Chelus fimbriatus. Pasa la mayor parte del tiempo bajo el agua en el fondo de ríos, lagunas y ciénagas de poca profundidad y escaso caudal. Utiliza su camuflaje y su comportamiento estático para pasar inadvertida y cazar al acecho. Sus mandíbulas son débiles y no son adecuadas para agarrar a las presas. Por eso cuando un pez o un invertebrado está a su alcance abre la boca y lo engulle. Sus ojos son pequeños pero posee grandes tímpanos externos que le ayudan a detectar a las presas en movimiento. La nariz en forma de tubo le permite respirar sin salir a la superficie.");
            descAmazonas.Add("Agalychnis callidryas. Es arborícola y vive entre la vegetación de las selvas húmedas cerca de los ríos. Tiene ventosas en los dedos de las patas que le ayudan a adherirse al envés de las hojas donde descansa durante el día. Deposita los huevos en la vegetación que cuelga por encima del agua. Come insectos. Es tóxica.");
            descAmazonas.Add("Philodryas baroni. Serpiente estrictamente arborícola que en raras ocasiones desciende al suelo. Su aspecto y color verde le confieren un excelente camuflaje. Suele pasar gran parte del día inmóvil colgada entre las hojas de los árboles, circunstancia que aprovecha para capturar al acecho a lagartos, anfibios, murciélagos o aves. Posee veneno que inocula con colmillos situados en la parte posterior de la mandíbula con el que inmoviliza a las presas una vez capturadas.");
            descAmazonas.Add("Cotinga cayana. Es un ave con acentuado dimorfismo sexual. Mientras que el macho es de color azul turquesa brillante con la garganta rojiza la hembra tiene un tono marrón grisáceo. Vive en el dosel de la selva, tanto en tierra firme como en las áreas inundables. Es muy silenciosa, excepto cuando se alarma por la presencia de depredadores. Construye un nido plano que luego destruye para evitar que los depredadores encuentren el sitio que normalmente vuelve a utilizar. El nombre de cotinga proviene del guaraní para referirse a las aves con colores que brillan en el bosque.");
            descAmazonas.Add("Euphractus sexcinctus. Es un mamífero acorazado con el cuerpo cubierto de anillos duros de los que salen pelos sensibles. Es tímido y de costumbres diurnas. Posee fuertes garras con las que excava en la tierra sus madrigueras donde se refugia y reproduce. Tiene glándulas odoríferas en la base de la cola para marcar el territorio. Son buenos nadadores. Su alimentación es variada y va desde raíces a tubérculos, lombrices, insectos, carroña y pequeños vertebrados.");
            descAmazonas.Add("Epicrates cenchria. Tiene escamas suaves y brillantes. Vive en los bosques tropicales a nivel de suelo en lugares próximos al agua, aunque también es semiarborícola. Descansa durante el día y por la noche se alimenta de aves y pequeños mamíferos que localizan gracias unos receptores situados al lado de los ojos que detectan el calor que emiten. Asfixia a la presa y la engulle entera.");
            descAmazonas.Add("Ambystoma mexicanum. Salamandra endémica de algunas lagunas mejicanas. Su desarrollo es muy peculiar ya que alcanza el estado adulto sin terminar la metamorfosis, es decir, mantiene la forma larvaria durante toda su vida. Tiene hábitos nocturnos. Se alimenta de invertebrados.");
            descAmazonas.Add("Aramides ypecaha. Vive en riberas de ríos y lagunas. Al alba y al atardecer se reúne en grupos y produce un canto característico que le ha dado nombre a la especie. Se alimenta de semillas, frutos, insectos e invertebrados acuáticos. Construye un nido plano en los árboles con hierba seca y ramas. Es monógama.");
            descAmazonas.Add("Eudocimos ruber. Es sociable y forma grandes colonias en época de cría. Los jóvenes son pardo oscuro y los adultos rojo vivo que se hace más intenso a medida que envejece. Este color proviene del pigmento de unos crustáceos que forman parte de su dieta. Tiene un pico largo y curvo que utiliza para buscar alimento removiendo el fango en zonas someras de estuarios y manglares. Su dieta es variada a base de insectos, semillas, ranas y peces.");
            descAmazonas.Add("Iguana iguana. Vive en manglares, selvas y riberas de ríos. Es arborícola y buena nadadora. Tiene la piel cubierta de escamas y una cresta dorsal de espinas dérmicas. La cola la utiliza como látigo para defenderse. Come hojas , flores y frutas.");
            descAmazonas.Add("Phyllobates vittatus. Algunas tribus amazónicas utilizan el veneno que estas ranitas almacenan en su piel para untar los dardos con los que cazan animales, mayormente pequeños primates. Cuando se clavan en el cuerpo los tóxicos se distribuyen rápidamente por los tejidos del animal que muere de manera fulminante. Estas neurotoxinas paralizantes no las produce la rana, sino que provienen de los insectos venenosos de su dieta.");
            descAmazonas.Add("Dendrobates leucomelas. Las Dendrobates, pese a su pequeño tamaño, son animales de gran carácter y los machos defenderán vivamente su territorio de otros machos. Sus dominios suelen ser troncos caídos que ofrecen a la rana numerosos escondites y puestos elevados desde donde actúan de vigías a la vez que sirven para propagar más lejos los cantos que atraerán a hembras para la reproducción.");
            descAmazonas.Add("Dendrobates tinctorius. Este anfibio pertenece a una familia de pequeñas ranas de vivos colores que viven en el suelo de las selvas húmedas del centro y del sur de América. Sus brillantes colores aposemáticos indican su elevada toxicidad. No en vano, son los anfibios más venenosos del mundo. Se alimentan de pequeños invertebrados. Ponen los huevos en la hojarasca y el macho transporta los renacuajos a charcas.");
            descAmazonas.Add("Pteroglossus viridis. Es un pequeño tucán que vive en la espesura del bosque en grupos reducidos. Se alimenta de frutos, flores, insectos y huevos de aves. Construye los nidos en huecos de árboles o aprovecha los nidos abandonados de pájaros carpinteros donde pone de 2 a 4 huevos. El macho y la hembra comparten la incubación y el cuidado de las crías.");
            descAmazonas.Add("Callithrix geoffroyi. Es un pequeño primate endémico de los bosques atlánticos de Brasil. Es diurno y arbóreo. Vive en grupos familiares con una hambre dominante que es la única que se reproduce. Es monógamo. Se alimenta de frutas e invertebrados y emite muchos sonidos que representan emociones y estados de ánimo.");








            descAmazonas.Add("Erythrina crista–galli. Es un pequeño árbol caduco de 5–10 m de altura nativo de la región del Paraná (Norte de Argentina, Paraguay y Sur de Brasil). Crece en bosques galería a lo largo de los ríos y en zonas inundables. El tallo es irregular y contiene alcaloides cuya ingestión puede producir toxicidad. Las ramas tienen espinas. Las flores, de color rojo brillante,  son melíferas y el néctar atrae a insectos y aves. Las raíces presentan nódulos con bacterias fijadoras de nitrógeno. Se usa como planta medicinal y ornamental.");
            descAmazonas.Add("Bougainvillea glabra. Arbusto sarmentoso originario de Brasil. Perenne, trepador y leñoso con espinas en sus ramas que le permiten agarrarse a un soporte. Tiene hojas verdes brillantes. Las ﬂores son pequeñas y blancas y están rodeadas de unas brácteas caducas de color rojo intenso. Tiene propiedades medicinales contra las afecciones gastrointestinales y respiratorias.");
            descAmazonas.Add("Butia eriospatha. Palmera endémica del sur de Brasil. Vive en zonas de media altura entre 700 y 1.200 m. Las hojas son péndulas de 2 m de longitud y el peciolo largo y espinoso. La base de las hojas está cubierta de un denso tomento marrón. Las ﬂores se agrupan en inﬂorescencias macho y hembra que dan frutos globosos, suculentos y comestibles.");
            descAmazonas.Add("Tillandsia usneoides. Herbácea originaria de América, desde el sudeste de EE.UU. hasta Argentina. Crece en climas cálidos y húmedos. Vive en ramas de árboles formando estructuras colgantes y lanudas de 1 m de longitud.  No tiene raíces. El tallo es ﬂexible y las hojas pequeñas, delgadas y curvas. Las ﬂores son diminutas y aromáticas. Se propaga por fragmentos de tallo que arrastra el viento o las aves. Es muy sensible a la polución del aire.");
            descAmazonas.Add("Syagrus romanzoffiana. Palmera de mediana altura nativa de Paraguay y el área de influencia del río Paraná. Tiene el tallo desnudo y las hojas son palmas alternas que dan un aspecto elegante. Las flores masculinas y femeninas están separadas en plantas diferentes. Los frutos son anaranjados, parecidos a aceitunas, de sabor dulce, muy atractivos para pájaros y animales trepadores. Se planta como ornamental. Se ha introducido en otras regiones tropicales del mundo donde se ha naturalizado. A veces es invasiva.");
            descAmazonas.Add("Philodendron xanadu. Herbácea trepadora nativa de la selva de Brasil. Tiene hojas perennes, grandes y brillantes, coriáceas y con dimorﬁsmo foliar, es decir, las hojas varían de aspecto a medida que crecen. Tiene raíces aéreas que utiliza para ﬁjarse a un soporte. Son epiﬁtas. La ﬂor es una inﬂorescencia que está rodeada por una bráctea blanca protectora. El fruto es una baya de sabor parecido a la piña.");
            descAmazonas.Add("Cestrum nocturnum. Arbusto nativo de Sudamérica. Es perenne, aunque a veces pierde la hoja. Las ﬂores son pequeñas y tubulares de color blanco o amarillo verdoso y desprenden una fragancia intensa durante la noche. Se agrupan en racimos. El fruto es una baya globosa blanca. Todas las partes de la planta son altamente tóxicas, aunque tiene aplicaciones medicinales.");
            descAmazonas.Add("Acca selloviana. Arbusto originario del  centro de Sudamérica. Perenne. Las hojas son simples, coriáceas, verdes brillantes por el haz y tomentosas por el envés. Las ﬂores son solitarias y tienen gran número de estambres de color rojo vivo. El fruto es carnoso, pequeño y  muy aromático, de color verde y con numerosas semillas. Tiene aplicaciones medicinales y se utiliza en la elaboración de bebidas y mermeladas.");
            descAmazonas.Add("Heliconia latispatha. Herbácea grande y vigorosa de 2–3 m de altura de crecimiento parecido a los bananeros. Está extendida por toda América tropical. Tiene hojas grandes, simples, de margen entero y color verde brillante. Las ﬂores se sitúan en espiral alrededor de un largo pedúnculo protegidas por brácteas de color amarillo o rojo. Producen néctar y son polinizadas por colibríes.");
            descAmazonas.Add("Jacaranda mimosifolia. Árbol semipersistente originario de los bosques caducifolios tropicales  de Sudamérica aunque se ha introducido por otras zonas.  Las hojas son grandes, compuestas  bipinnadas y opuestas. Alcanza 10 m. Las ﬂores están agrupadas en panículas azul violáceo. Fruto leñoso en cápsula con semillas aladas. Toda la planta es venenosa pero se utiliza para dolencias gastrointestinales y en carpintería.");
            descAmazonas.Add("Russelia equisetiformis. Es un arbusto perenne de 1,2–1,5 m originario de México y Guatemala.  Sus ramas son delgadas y colgantes con hojas muy pequeñas de color verde brillante reducidas a escamas. Tiene copiosas ﬂores tubulares de color rojo brillante agrupadas en racimos que se suceden a lo largo de todo el año en los climas tropicales y subtropicales atrayendo con su néctar a mariposas y colibríes. Se utiliza como planta ornamental.");
            descAmazonas.Add("Lantana camara. Arbusto perenne nativo de las áreas tropicales y subtropicales de Sudamérica y América Central. Alcanza 1,5 m de altura y es muy ramiﬁcado y oloroso. El tallo es cuadrangular y las hojas simples, de bordes dentados, ásperas, rugosas y pubescentes. Las ﬂores son amarillas y se tornan rojizas cuando maduran. El fruto es una drupa negra brillante. Se ha naturalizado en zonas cálidas de todo el mundo.");
            descAmazonas.Add("Tabebuia impetiginosa. Árbol nativo de la zona intertropical de América, México, el Caribe, Argentina y Paraguay. La corteza es lisa y las hojas palmaticompuestas. Es semipersistente. Tiene inﬂorescencias en panícula al ﬁnal de las ramas y las ﬂores son largas trompetas rosadas que abren antes que las hojas. Fruto en cápsula alargado y cilíndrico con semillas aladas. Es resistente al fuego. Su madera se utiliza en construcción. Muy apreciado medicinalmente.");
            descAmazonas.Add("Handroanthus ochraeus. Árbol originario de regiones cálidas de América, desde México a Argentina. Alcanza 20 m de altura. Tiene forma irregular y ﬂorece masivamente después de las primeras lluvias. Es semipersistente ya que pierde las hojas después de la ﬂoración. Las ﬂores son de color amarillo intenso y tienen el cáliz alargado en forma de trompeta. El fruto es una legumbre. Su madera es muy resistente y se utiliza en construcción.");
            descAmazonas.Add("Thevetia peruviana. Arbusto originario de América tropical que alcanza 5 m. Perenne. Tiene la corteza grisácea y las hojas duras, lanceoladas, de color verde oscuro vivo. Las ﬂores son amarillas y perfumadas en forma de embudo. El fruto es una drupa carnosa  roja redondeada. Desde hace cientos de años se utiliza en medicina tradicional para reducir grasa. Es ornamental.");
            descAmazonas.Add("Acoelorraphe wrightii. Pequeña palmera natural de Florida y áreas tropicales húmedas de América Central y el Caribe, donde se encuentra silvestre en muchos ambientes, incluidas áreas salinas, pantanos y bosques periódicamente inundados. El tronco está cubierto de ﬁbras y las hojas son grandes en forma de abanico con espinas aserradas en los márgenes. Flores diminutas blancas y hermafroditas.");

        }





        
    }
}
