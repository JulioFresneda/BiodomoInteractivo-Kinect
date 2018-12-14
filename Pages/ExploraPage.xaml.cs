//------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Resources;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Wpf.Controls;
    using Microsoft.Samples.Kinect.ControlsBasics.DataModel;
    using Microsoft.Samples.Kinect.ControlsBasics.Pages;
  



    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class ExploraPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExploraPage"/> class. 
        /// </summary>
        /// 
        private string currentZone;

        private List<Uri> uriAmazonia;
        private List<String> titlesAmazonia;
        private List<String> descAmazonia;

        private List<Uri> uriIndopacifico;
        private List<String> titlesIndopacifico;
        private List<String> descIndopacifico;

        private List<Uri> uriMadagascar;
        private List<String> titlesMadagascar;
        private List<String> descMadagascar;

        private ZonePage amazoniaZone;
        private ZonePage indopacificoZone;
        private ZonePage madagascarZone;


        public ExploraPage()
        {
            this.InitializeComponent();
            LoadSpecies();
            LoadTitles();
            LoadDesc();

            amazoniaZone = new ZonePage(uriAmazonia, titlesAmazonia, descAmazonia);
            indopacificoZone = new ZonePage(uriIndopacifico, titlesIndopacifico, descIndopacifico);
            madagascarZone = new ZonePage(uriMadagascar, titlesMadagascar, descMadagascar);






            ExploraFrame.Content = amazoniaZone;
            currentZone = "amazonia";








        }

        private void ZoneClick(object sender, RoutedEventArgs e)
        {
            if( (sender as Button).Name == "amazoniaButton")
            {
                if (currentZone != "amazonia") ExploraFrame.Content = amazoniaZone;
                currentZone = "amazonia";
            }
            else if ((sender as Button).Name == "indopacificoButton")
            {
                if (currentZone != "indopacifico") ExploraFrame.Content = indopacificoZone;
                currentZone = "indopacifico";
            }
            else if ((sender as Button).Name == "madagascarButton")
            {
                if (currentZone != "madagascar") ExploraFrame.Content = madagascarZone;
                currentZone = "madagascar";
            }

        }

































        private void LoadSpecies()
        {
            uriAmazonia = new List<Uri>();
            uriIndopacifico = new List<Uri>();
            uriMadagascar = new List<Uri>();


            // imagenes amazonia
            uriAmazonia.Add(new Uri("Images/ama_a_0.png", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_1.jpeg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_2.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_3.jpeg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_4.jpeg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_5.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_6.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_7.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_8.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_9.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_10.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_11.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_12.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_13.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_14.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_15.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_16.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_a_17.jpg", UriKind.Relative));


            uriAmazonia.Add(new Uri("Images/ama_v_0.png", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_1.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_2.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_3.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_4.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_5.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_6.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_7.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_8.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_9.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_10.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_11.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_12.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_13.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_14.jpg", UriKind.Relative));
            uriAmazonia.Add(new Uri("Images/ama_v_15.jpg", UriKind.Relative));




            // imagenes madagascar
            uriMadagascar.Add(new Uri("Images/mad_a_0.png", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_a_1.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_a_2.jpg", UriKind.Relative));

            uriMadagascar.Add(new Uri("Images/mad_v_0.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_1.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_2.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_3.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_4.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_5.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_6.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_7.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_8.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_9.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_10.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_11.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_12.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_13.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_14.jpg", UriKind.Relative));
            uriMadagascar.Add(new Uri("Images/mad_v_15.jpg", UriKind.Relative));





            uriIndopacifico.Add(new Uri("Images/ip_a_0.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_1.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_2.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_3.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_4.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_5.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_6.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_7.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_8.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_9.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_10.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_11.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_12.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_13.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_14.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_a_15.jpg", UriKind.Relative));


            uriIndopacifico.Add(new Uri("Images/ip_v_0.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_1.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_2.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_3.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_4.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_5.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_6.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_7.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_8.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_9.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_10.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_11.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_12.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_13.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_14.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Images/ip_v_15.jpg", UriKind.Relative));


        }











        private void LoadTitles()
        {
            titlesAmazonia = new List<string>();
            titlesMadagascar = new List<string>();
            titlesIndopacifico = new List<string>();



            titlesAmazonia.Add("Perezoso de dos dedos");
            titlesAmazonia.Add("Tucán de pecho blanco");
            titlesAmazonia.Add("Trompetero");
            titlesAmazonia.Add("Tortuga matamata");
            titlesAmazonia.Add("Rana de ojos rojos");
            titlesAmazonia.Add("Culebra verde nariguda");
            titlesAmazonia.Add("Cotinga");
            titlesAmazonia.Add("Armadillo de seis bandas");
            titlesAmazonia.Add("Boa arco iris");
            titlesAmazonia.Add("Ajolote");
            titlesAmazonia.Add("Rascón de cuello rojo");
            titlesAmazonia.Add("Ibis escarlata");
            titlesAmazonia.Add("Iguana verde");
            titlesAmazonia.Add("Rana punta de ﬂecha rayada");
            titlesAmazonia.Add("Rana punta de ﬂecha de franjas amarillas");
            titlesAmazonia.Add("Rana punta de ﬂecha teñida");
            titlesAmazonia.Add("Arasarí verde");
            titlesAmazonia.Add("Tití de cara blanca");



            titlesAmazonia.Add("Árbol del coral");
            titlesAmazonia.Add("Buganvilla");
            titlesAmazonia.Add("Butia lanosa");
            titlesAmazonia.Add("Clavel del aire");
            titlesAmazonia.Add("Coco plumoso");
            titlesAmazonia.Add("Filodendro");
            titlesAmazonia.Add("Galán de noche");
            titlesAmazonia.Add("Guayaba del Brasil");
            titlesAmazonia.Add("Heliconia");
            titlesAmazonia.Add("Jacaranda");
            titlesAmazonia.Add("Lágrimas de amor");
            titlesAmazonia.Add("Lantana");
            titlesAmazonia.Add("Lapacho rosado");
            titlesAmazonia.Add("Madero amarillo");
            titlesAmazonia.Add("Nuez de la India");
            titlesAmazonia.Add("Palmera de los pantanos");



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


            titlesIndopacifico.Add("Raya nido de abeja");
            titlesIndopacifico.Add("Pez ballesta azul");
            titlesIndopacifico.Add("Pez unicornio de espina naranja");
            titlesIndopacifico.Add("Pez cirujano convicto");
            titlesIndopacifico.Add("Bagre rayado");
            titlesIndopacifico.Add("Carpa de bambú");
            titlesIndopacifico.Add("Danio de rayas verdes");
            titlesIndopacifico.Add("Pez aleta roja del pacífico");
            titlesIndopacifico.Add("Escatófago plateado");
            titlesIndopacifico.Add("Pez ángel malayo");
            titlesIndopacifico.Add("Labrido limpiador azul");
            titlesIndopacifico.Add("Lábrido con mancha en la axila");
            titlesIndopacifico.Add("Muntjac");
            titlesIndopacifico.Add("Escorpión asiático");
            titlesIndopacifico.Add("Rana cornuda");
            titlesIndopacifico.Add("Sapo malayo de bosque");

            titlesIndopacifico.Add("Árbol del caucho");
            titlesIndopacifico.Add("Cyca");
            titlesIndopacifico.Add("Cyca de Ceilán");
            titlesIndopacifico.Add("Bastón de bambú");
            titlesIndopacifico.Add("Bignonia blanca");
            titlesIndopacifico.Add("Caryota obtusa");
            titlesIndopacifico.Add("Cerezo magenta");
            titlesIndopacifico.Add("Cheﬂera");
            titlesIndopacifico.Add("Falsa aralia");
            titlesIndopacifico.Add("Ficus australiano");
            titlesIndopacifico.Add("Ficus benjamina");
            titlesIndopacifico.Add("Ficus trepador");
            titlesIndopacifico.Add("Helecho arborescente australiano");
            titlesIndopacifico.Add("Helecho arborescente de Tasmania");
            titlesIndopacifico.Add("Helecho nido");
            titlesIndopacifico.Add("Higuera loca");
        }


        private void LoadDesc()
        {
            descAmazonia = new List<string>();
            descIndopacifico = new List<string>();
            descMadagascar = new List<string>();


            descAmazonia.Add("Choloepus didactylus. Las extremidades terminan en dos dedos con garras curvas que le sirven para trepar y permanecer colgado. Su pelo es largo y se orienta desde el vientre hacia el dorso, al contrario que la mayoría de los mamíferos. Es de hábitos nocturnos y duerme hasta quince horas durante el día. Nocturno. Come hojas y frutas.");
            descAmazonia.Add("Ramphastos tucanus. El macho y la hembra son iguales, a excepción del pico que es más largo en el macho. Son principalmente frugívoras. Usan su pico para alcanzar los frutos que engullen enteros con una rápida sacudida de su cuello. También comen insectos, orugas y pequeños reptiles. Hace el nido en huecos de árboles. Vive solo, en pareja o en pequeñas bandadas. Emite un gruñido profundo que puede oírse a gran distancia.");
            descAmazonia.Add("Psophia crepitans. Es sociable. Vive en pequeños grupos en el suelo del bosque donde descansan, se bañan y buscan frutos caídos de los árboles para alimentarse mientras que por la noche prefieren posarse en las ramas de los árboles. Emite una variedad de sonidos, algunos intensos como una trompeta, para advertir del peligro, marcar su territorio, solicitar alimento o amenazar a los intrusos. Es muy dócil y las poblaciones nativas la utilizan como centinela para cuidar de sus gallinas ya que avisan de la presencia de cualquier animal extraño.");
            descAmazonia.Add("Chelus fimbriatus. Pasa la mayor parte del tiempo bajo el agua en el fondo de ríos, lagunas y ciénagas de poca profundidad y escaso caudal. Utiliza su camuflaje y su comportamiento estático para pasar inadvertida y cazar al acecho. Sus mandíbulas son débiles y no son adecuadas para agarrar a las presas. Por eso cuando un pez o un invertebrado está a su alcance abre la boca y lo engulle. Sus ojos son pequeños pero posee grandes tímpanos externos que le ayudan a detectar a las presas en movimiento. La nariz en forma de tubo le permite respirar sin salir a la superficie.");
            descAmazonia.Add("Agalychnis callidryas. Es arborícola y vive entre la vegetación de las selvas húmedas cerca de los ríos. Tiene ventosas en los dedos de las patas que le ayudan a adherirse al envés de las hojas donde descansa durante el día. Deposita los huevos en la vegetación que cuelga por encima del agua. Come insectos. Es tóxica.");
            descAmazonia.Add("Philodryas baroni. Serpiente estrictamente arborícola que en raras ocasiones desciende al suelo. Su aspecto y color verde le confieren un excelente camuflaje. Suele pasar gran parte del día inmóvil colgada entre las hojas de los árboles, circunstancia que aprovecha para capturar al acecho a lagartos, anfibios, murciélagos o aves. Posee veneno que inocula con colmillos situados en la parte posterior de la mandíbula con el que inmoviliza a las presas una vez capturadas.");
            descAmazonia.Add("Cotinga cayana. Es un ave con acentuado dimorfismo sexual. Mientras que el macho es de color azul turquesa brillante con la garganta rojiza la hembra tiene un tono marrón grisáceo. Vive en el dosel de la selva, tanto en tierra firme como en las áreas inundables. Es muy silenciosa, excepto cuando se alarma por la presencia de depredadores. Construye un nido plano que luego destruye para evitar que los depredadores encuentren el sitio que normalmente vuelve a utilizar. El nombre de cotinga proviene del guaraní para referirse a las aves con colores que brillan en el bosque.");
            descAmazonia.Add("Euphractus sexcinctus. Es un mamífero acorazado con el cuerpo cubierto de anillos duros de los que salen pelos sensibles. Es tímido y de costumbres diurnas. Posee fuertes garras con las que excava en la tierra sus madrigueras donde se refugia y reproduce. Tiene glándulas odoríferas en la base de la cola para marcar el territorio. Son buenos nadadores. Su alimentación es variada y va desde raíces a tubérculos, lombrices, insectos, carroña y pequeños vertebrados.");
            descAmazonia.Add("Epicrates cenchria. Tiene escamas suaves y brillantes. Vive en los bosques tropicales a nivel de suelo en lugares próximos al agua, aunque también es semiarborícola. Descansa durante el día y por la noche se alimenta de aves y pequeños mamíferos que localizan gracias unos receptores situados al lado de los ojos que detectan el calor que emiten. Asfixia a la presa y la engulle entera.");
            descAmazonia.Add("Ambystoma mexicanum. Salamandra endémica de algunas lagunas mejicanas. Su desarrollo es muy peculiar ya que alcanza el estado adulto sin terminar la metamorfosis, es decir, mantiene la forma larvaria durante toda su vida. Tiene hábitos nocturnos. Se alimenta de invertebrados.");
            descAmazonia.Add("Aramides ypecaha. Vive en riberas de ríos y lagunas. Al alba y al atardecer se reúne en grupos y produce un canto característico que le ha dado nombre a la especie. Se alimenta de semillas, frutos, insectos e invertebrados acuáticos. Construye un nido plano en los árboles con hierba seca y ramas. Es monógama.");
            descAmazonia.Add("Eudocimos ruber. Es sociable y forma grandes colonias en época de cría. Los jóvenes son pardo oscuro y los adultos rojo vivo que se hace más intenso a medida que envejece. Este color proviene del pigmento de unos crustáceos que forman parte de su dieta. Tiene un pico largo y curvo que utiliza para buscar alimento removiendo el fango en zonas someras de estuarios y manglares. Su dieta es variada a base de insectos, semillas, ranas y peces.");
            descAmazonia.Add("Iguana iguana. Vive en manglares, selvas y riberas de ríos. Es arborícola y buena nadadora. Tiene la piel cubierta de escamas y una cresta dorsal de espinas dérmicas. La cola la utiliza como látigo para defenderse. Come hojas , flores y frutas.");
            descAmazonia.Add("Phyllobates vittatus. Algunas tribus amazónicas utilizan el veneno que estas ranitas almacenan en su piel para untar los dardos con los que cazan animales, mayormente pequeños primates. Cuando se clavan en el cuerpo los tóxicos se distribuyen rápidamente por los tejidos del animal que muere de manera fulminante. Estas neurotoxinas paralizantes no las produce la rana, sino que provienen de los insectos venenosos de su dieta.");
            descAmazonia.Add("Dendrobates leucomelas. Las Dendrobates, pese a su pequeño tamaño, son animales de gran carácter y los machos defenderán vivamente su territorio de otros machos. Sus dominios suelen ser troncos caídos que ofrecen a la rana numerosos escondites y puestos elevados desde donde actúan de vigías a la vez que sirven para propagar más lejos los cantos que atraerán a hembras para la reproducción.");
            descAmazonia.Add("Dendrobates tinctorius. Este anfibio pertenece a una familia de pequeñas ranas de vivos colores que viven en el suelo de las selvas húmedas del centro y del sur de América. Sus brillantes colores aposemáticos indican su elevada toxicidad. No en vano, son los anfibios más venenosos del mundo. Se alimentan de pequeños invertebrados. Ponen los huevos en la hojarasca y el macho transporta los renacuajos a charcas.");
            descAmazonia.Add("Pteroglossus viridis. Es un pequeño tucán que vive en la espesura del bosque en grupos reducidos. Se alimenta de frutos, flores, insectos y huevos de aves. Construye los nidos en huecos de árboles o aprovecha los nidos abandonados de pájaros carpinteros donde pone de 2 a 4 huevos. El macho y la hembra comparten la incubación y el cuidado de las crías.");
            descAmazonia.Add("Callithrix geoffroyi. Es un pequeño primate endémico de los bosques atlánticos de Brasil. Es diurno y arbóreo. Vive en grupos familiares con una hambre dominante que es la única que se reproduce. Es monógamo. Se alimenta de frutas e invertebrados y emite muchos sonidos que representan emociones y estados de ánimo.");








            descAmazonia.Add("Erythrina crista–galli. Es un pequeño árbol caduco de 5–10 m de altura nativo de la región del Paraná (Norte de Argentina, Paraguay y Sur de Brasil). Crece en bosques galería a lo largo de los ríos y en zonas inundables. El tallo es irregular y contiene alcaloides cuya ingestión puede producir toxicidad. Las ramas tienen espinas. Las flores, de color rojo brillante,  son melíferas y el néctar atrae a insectos y aves. Las raíces presentan nódulos con bacterias fijadoras de nitrógeno. Se usa como planta medicinal y ornamental.");
            descAmazonia.Add("Bougainvillea glabra. Arbusto sarmentoso originario de Brasil. Perenne, trepador y leñoso con espinas en sus ramas que le permiten agarrarse a un soporte. Tiene hojas verdes brillantes. Las ﬂores son pequeñas y blancas y están rodeadas de unas brácteas caducas de color rojo intenso. Tiene propiedades medicinales contra las afecciones gastrointestinales y respiratorias.");
            descAmazonia.Add("Butia eriospatha. Palmera endémica del sur de Brasil. Vive en zonas de media altura entre 700 y 1.200 m. Las hojas son péndulas de 2 m de longitud y el peciolo largo y espinoso. La base de las hojas está cubierta de un denso tomento marrón. Las ﬂores se agrupan en inﬂorescencias macho y hembra que dan frutos globosos, suculentos y comestibles.");
            descAmazonia.Add("Tillandsia usneoides. Herbácea originaria de América, desde el sudeste de EE.UU. hasta Argentina. Crece en climas cálidos y húmedos. Vive en ramas de árboles formando estructuras colgantes y lanudas de 1 m de longitud.  No tiene raíces. El tallo es ﬂexible y las hojas pequeñas, delgadas y curvas. Las ﬂores son diminutas y aromáticas. Se propaga por fragmentos de tallo que arrastra el viento o las aves. Es muy sensible a la polución del aire.");
            descAmazonia.Add("Syagrus romanzoffiana. Palmera de mediana altura nativa de Paraguay y el área de influencia del río Paraná. Tiene el tallo desnudo y las hojas son palmas alternas que dan un aspecto elegante. Las flores masculinas y femeninas están separadas en plantas diferentes. Los frutos son anaranjados, parecidos a aceitunas, de sabor dulce, muy atractivos para pájaros y animales trepadores. Se planta como ornamental. Se ha introducido en otras regiones tropicales del mundo donde se ha naturalizado. A veces es invasiva.");
            descAmazonia.Add("Philodendron xanadu. Herbácea trepadora nativa de la selva de Brasil. Tiene hojas perennes, grandes y brillantes, coriáceas y con dimorﬁsmo foliar, es decir, las hojas varían de aspecto a medida que crecen. Tiene raíces aéreas que utiliza para ﬁjarse a un soporte. Son epiﬁtas. La ﬂor es una inﬂorescencia que está rodeada por una bráctea blanca protectora. El fruto es una baya de sabor parecido a la piña.");
            descAmazonia.Add("Cestrum nocturnum. Arbusto nativo de Sudamérica. Es perenne, aunque a veces pierde la hoja. Las ﬂores son pequeñas y tubulares de color blanco o amarillo verdoso y desprenden una fragancia intensa durante la noche. Se agrupan en racimos. El fruto es una baya globosa blanca. Todas las partes de la planta son altamente tóxicas, aunque tiene aplicaciones medicinales.");
            descAmazonia.Add("Acca selloviana. Arbusto originario del  centro de Sudamérica. Perenne. Las hojas son simples, coriáceas, verdes brillantes por el haz y tomentosas por el envés. Las ﬂores son solitarias y tienen gran número de estambres de color rojo vivo. El fruto es carnoso, pequeño y  muy aromático, de color verde y con numerosas semillas. Tiene aplicaciones medicinales y se utiliza en la elaboración de bebidas y mermeladas.");
            descAmazonia.Add("Heliconia latispatha. Herbácea grande y vigorosa de 2–3 m de altura de crecimiento parecido a los bananeros. Está extendida por toda América tropical. Tiene hojas grandes, simples, de margen entero y color verde brillante. Las ﬂores se sitúan en espiral alrededor de un largo pedúnculo protegidas por brácteas de color amarillo o rojo. Producen néctar y son polinizadas por colibríes.");
            descAmazonia.Add("Jacaranda mimosifolia. Árbol semipersistente originario de los bosques caducifolios tropicales  de Sudamérica aunque se ha introducido por otras zonas.  Las hojas son grandes, compuestas  bipinnadas y opuestas. Alcanza 10 m. Las ﬂores están agrupadas en panículas azul violáceo. Fruto leñoso en cápsula con semillas aladas. Toda la planta es venenosa pero se utiliza para dolencias gastrointestinales y en carpintería.");
            descAmazonia.Add("Russelia equisetiformis. Es un arbusto perenne de 1,2–1,5 m originario de México y Guatemala.  Sus ramas son delgadas y colgantes con hojas muy pequeñas de color verde brillante reducidas a escamas. Tiene copiosas ﬂores tubulares de color rojo brillante agrupadas en racimos que se suceden a lo largo de todo el año en los climas tropicales y subtropicales atrayendo con su néctar a mariposas y colibríes. Se utiliza como planta ornamental.");
            descAmazonia.Add("Lantana camara. Arbusto perenne nativo de las áreas tropicales y subtropicales de Sudamérica y América Central. Alcanza 1,5 m de altura y es muy ramiﬁcado y oloroso. El tallo es cuadrangular y las hojas simples, de bordes dentados, ásperas, rugosas y pubescentes. Las ﬂores son amarillas y se tornan rojizas cuando maduran. El fruto es una drupa negra brillante. Se ha naturalizado en zonas cálidas de todo el mundo.");
            descAmazonia.Add("Tabebuia impetiginosa. Árbol nativo de la zona intertropical de América, México, el Caribe, Argentina y Paraguay. La corteza es lisa y las hojas palmaticompuestas. Es semipersistente. Tiene inﬂorescencias en panícula al ﬁnal de las ramas y las ﬂores son largas trompetas rosadas que abren antes que las hojas. Fruto en cápsula alargado y cilíndrico con semillas aladas. Es resistente al fuego. Su madera se utiliza en construcción. Muy apreciado medicinalmente.");
            descAmazonia.Add("Handroanthus ochraeus. Árbol originario de regiones cálidas de América, desde México a Argentina. Alcanza 20 m de altura. Tiene forma irregular y ﬂorece masivamente después de las primeras lluvias. Es semipersistente ya que pierde las hojas después de la ﬂoración. Las ﬂores son de color amarillo intenso y tienen el cáliz alargado en forma de trompeta. El fruto es una legumbre. Su madera es muy resistente y se utiliza en construcción.");
            descAmazonia.Add("Thevetia peruviana. Arbusto originario de América tropical que alcanza 5 m. Perenne. Tiene la corteza grisácea y las hojas duras, lanceoladas, de color verde oscuro vivo. Las ﬂores son amarillas y perfumadas en forma de embudo. El fruto es una drupa carnosa  roja redondeada. Desde hace cientos de años se utiliza en medicina tradicional para reducir grasa. Es ornamental.");
            descAmazonia.Add("Acoelorraphe wrightii. Pequeña palmera natural de Florida y áreas tropicales húmedas de América Central y el Caribe, donde se encuentra silvestre en muchos ambientes, incluidas áreas salinas, pantanos y bosques periódicamente inundados. El tronco está cubierto de ﬁbras y las hojas son grandes en forma de abanico con espinas aserradas en los márgenes. Flores diminutas blancas y hermafroditas.");






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










            descIndopacifico.Add("Himantura uarnak. Vive en bahías de arena y lagunas salobres asociadas a arrecifes coralinos hasta 50 m de profundidad. Tolera bajos niveles de salinidad por lo que a veces se adentra en zonas de manglar. Alcanza 2 m. Es nocturna y durante el día se esconde en la arena. Come peces, cangrejos y medusas.");
            descIndopacifico.Add("Odonus niger. Vive en zonas de corriente próximas a los arrecifes y fondos coralinos. Alcanza 50 cm. Tiene la piel dura y resistente que lo hace inmune a enfermedades parasitarias. Dispone de espinas dorsales para defenderse. Sus dientes, de color rojo, son capaces de romper el arrecife. Se alimenta de invertebrados.");
            descIndopacifico.Add("Naso lituratus. Vive en lagunas interiores y en arrecifes de coral. Alcanza 45 cm. Tiene el cuerpo comprimido lateralmente y posee un agudo aguijón extensible en la aleta caudal para defensa. Es gris con líneas amarillas y azules en los contornos, pero oscurece rápidamente si se encuentra estresado. Se alimenta de algas. Tiene dimorfismo sexual. Es solitario pero a veces forma cardúmenes.");
            descIndopacifico.Add("Acanthurus triostegus. Vive en aguas cercanas a arrecifes costeros. Es gregario y le agrada la convivencia con otros peces. Los juveniles pueden encontrarse en las pozas de marea cercanas a la playa. Se alimenta de plancton y algas filamentosas. Es monógamo y se reproduce por fertilización externa formando cardúmenes.");
            descIndopacifico.Add("Pangasianodon hypophthalmus. Pez de gran tamaño, migratorio que en la temporada de lluvias nada hasta el curso alto del río para desovar y vuelve aguas abajo cuando desciende el nivel del agua. Se alimenta de crustáceos, algas, plancton y peces. Es pacífico y de hábitos nocturnos. Vive en la cuenca del Mekong.");
            descIndopacifico.Add("Spinibarbus denticulatus. Se encuentra en zonas profundas de los grandes ríos del sudeste asiático. Es omnívoro oportunista que se alimenta de algas, plantas acuáticas, insectos, crustáceos y pequeños peces. Se cultiva para consumo humano en ríos, embalses y estanques por su rápido crecimiento y su exquisita carne.");
            descIndopacifico.Add("Opsarius pulchellus. Pez pequeño que vive en el curso alto de los ríos del sudeste asiático donde el agua está bien oxigenada, la corriente es rápida y el lecho arenoso. Se alimenta de larvas de insectos. Es muy sensible a la degradación de su hábitat por contaminación agrícola y el aumento de la sedimentación.");
            descIndopacifico.Add("Tribolodon brandtii. Puede crecer hasta 50 cm de longitud. Se encuentra en ríos, zonas costeras y salobres de Corea, Japón y otros lugares del este de Asia. Es migratorio. La hembra nada contracorriente en los ríos para enterrar los huevos en la arena de mayo a septiembre.");
            descIndopacifico.Add("Selenotoca mutifasciata. Pez de manglar y delta de río y estuario. Los jóvenes se adentran hasta lugares donde la salinidad es casi nula. Los adultos prefieren aguas saladas y desovan en zonas costeras próximas a los ríos. No existe dimorfismo sexual. Se alimenta de invertebrados y vegetales.");
            descIndopacifico.Add("Monodactylus argenteus. Vive en agua dulce, manglares y arrecifes costeros. Tiene el cuerpo comprimido lateralmente y a medida que envejece se hace más redondeado. Devora larvas de insectos, plancton y detritos. Gregario. Los adultos se adentran en los ríos para desovar. Allí viven los juveniles antes de bajar al manglar y al litoral.");
            descIndopacifico.Add("Labroides dimidiatus. Vive asociado a arrecifes de coral poco profundos. Se ha especializado en limpiar de parásitos y tejidos muertos a los peces. Vive en colonias formadas por un macho y varias hembras. Cuando el macho dominante muere es reemplazado por una hembra que se convierte en macho.");
            descIndopacifico.Add("Bodianus axillaris. Pez de vida solitaria y hábitos diurnos que vive en el arrecife entre 2 y 40 m. Puede formar pequeños cardúmenes. Proyecta un chorro de agua sobre el fondo arenoso para descubrir y capturar moluscos, crustáceos y gusanos.");
            descIndopacifico.Add("Muntiacus muntjak. Pequeño ciervo de bosque que se mueve con agilidad entre la espesura de la jungla. El macho posee una pequeña cornamenta y colmillos que sobresalen del maxilar superior y la hembra una protuberancia con un mechón de pelo. Es de hábitos solitarios. Come hojas, frutas y pequeños animales.");
            descIndopacifico.Add("Heterometrus sp. Posee grandes pinzas con las que captura a sus presas. En el extremo del abdomen tiene un aguijón con veneno defensivo pero a veces lo utiliza para paralizar a las presas. Es solitario. Vive en la maleza de los bosques, debajo de troncos o en madrigueras abandonadas.");
            descIndopacifico.Add("Megophrys nasuta. Rana robusta que se oculta entre las hojas muertas del suelo de los bosques húmedos utilizando su coloración críptica y apariencia de hoja. Sus ataques son explosivos. Salta sobre la presa y de inmediato la captura y engulle. Es muy voraz. Captura insectos y arácnidos.");
            descIndopacifico.Add("Bufo asper. Sapo de vida terrestre pero ligada a ríos y arroyos. Segrega un tóxico a través de la piel para persuadir a sus depredadores que puede producir dificultades de locomoción, postración o convulsiones. Se alimenta de Invertebrados y pequeños vertebrados.");

            descIndopacifico.Add("Ficus elástica. Árbol grande nativo de la India y el Sudeste asiático. Desarrolla raíces aéreas y contrafuertes que lo anclan al suelo y soportan las pesadas ramas. Es perenne con hojas anchas, brillantes y ovales. El fruto es un higo. Se cultiva en todo el mundo como ornamental. Su corteza produce un látex tóxico muy irritante para los ojos y la piel que se utiliza para la fabricación de caucho.");
            descIndopacifico.Add("Cycas revoluta. Es un pequeño árbol caduco de 5–10 m de altura nativo de la región del Paraná (Norte de Argentina, Paraguay y Sur de Brasil). Crece en bosques galería a lo largo de los ríos y en zonas inundables. El tallo es irregular y contiene alcaloides cuya ingestión puede producir toxicidad. Las ramas tienen espinas. Las flores, de color rojo brillante, son melíferas y el néctar atrae a insectos y aves. Las raíces presentan nódulos con bacterias fijadoras de nitrógeno. Se usa como planta medicinal y ornamental.");
            descIndopacifico.Add("Cycas circinalis. Se localiza en los bosques nativos de Sri Lanka. Tiene crecimiento lento y alcanza 3 m de altura. No es una palmera pero las hojas pinnadas que crecen en forma de roseta en la parte superior le dan este aspecto. Son reminiscencias vivas de los últimos bosques del periodo carbonífero. Las semillas son venenosas pero las toxinas se eliminan remojándolas en agua. La harina de éstas se usa para hacer tortas y gachas. Se encuentra en peligro crítico.");
            descIndopacifico.Add("Chimonobambusa tumidissinoda. Bambú endémico de los valles de Sichuan y Yunnan en China. Alcanza 6 m de altura y tiene tallos ﬁnos de 1,3 cm de diámetro. El porte es colgante con las hoja verdes y ﬁnas. El tallo presenta grandes discos aplanados en los nudos como si fueran nudillos. Ha sido muy utilizado en China para confeccionar bastones desde hace más de 2.000 años.");
            descIndopacifico.Add("Pandorea jasminoides. Planta trepadora nativa de Malasia y Australia. Es perenne de tallos leñosos. Las hojas son coriáceas y brillantes. Las ﬂores crecen en racimos y son grandes  y atrompetadas de color que va del blanco al rosado, según la variedad. No dispone de sistemas de agarre pero las largas ramas se comportan como lianas en presencia de árboles o arbustos, utilizándolos de soporte para acercarse a la luz.");
            descIndopacifico.Add("Caryota obtusa. Palmera originaria de la India que en la actualidad se extiende por las montañas de todo el sudeste asiático. Es de crecimiento muy rápido y alcanzan más de 30 m. El tronco es alto, grueso, sin ramiﬁcaciones que llega a 90 cm de diámetro. Las  hojas son bipinnadas con los foliolos en forma de triángulo.");
            descIndopacifico.Add("Syzygium paniculatum. Árbol de áreas costeras arenosas de los bosques templados húmedos de Australia. Alcanza 15 m.  Es denso y ancho con la corteza escamosa. Las hojas son opuestas, simples, elípticas, acabadas en punta, oscuras brillantes por el haz y más pálidas en el envés. Las ﬂores son blancas en racimos y dan una baya esférica carnosa de color magenta. Es comestible y ligeramente ácida. Se utiliza como ornamental.");
            descIndopacifico.Add("Schefﬂera arboricola. Arbusto nativo de Taiwan y la isla china de Hainan. Alcanza 8 m de altura. Es perenne. Emite raíces aéreas que cuando llegan al suelo se convierten en raíces funcionales. Tiene hojas digitadas de 7–9 foliolos de color verde brillante por el haz y mate por el envés de textura coriácea. Las ﬂores son hermafroditas y se agrupan en panículas. Producen frutos esféricos en drupas que son muy apreciados por las aves.");
            descIndopacifico.Add("Fatsia japonica. Arbusto perenne de hasta 3 m  de altura originario de Japón. Crece en lugares sombríos y húmedos por debajo de los 200 m de altitud. Las hojas son simples y palmatilobadas, grandes, coriáceas, con peciolos largos de color verde oscuro. Las inﬂorescencias son panículas de forma triangular con ﬂores blancas que producen un fruto en drupa globoso, verde al principio y negro en la madurez.");
            descIndopacifico.Add("Ficus rubiginosa. Ficus endémico de la costa este de Australia. Alcanza los 20 m y tiene una copa aparasolada que proporciona una sombra densa. Es perenne con hojas elípticas. Para la polinización requiere la presencia de una avispa y los frutos (higos) son de color rojo cuando maduran. En climas tropicales las ramas inferiores funcionan como raíces aéreas y cuando alcanzan el suelo forman raíces secundarias.");
            descIndopacifico.Add("Ficus benjamina. Es una higuera nativa del sudeste asiático muy utilizada en decoración de casas y patios. Crece hasta los 15 m y tiene hojas grandes y lanceoloadas de un color verde brillante que crecen sobre ramas arqueadas. Los frutos son un alimento muy apreciado por algunas aves. En estado juvenil trepa sobre otros árboles y desarrolla raíces aéreas que, en contacto con el suelo, se engruesan y endurecen para mantener erguido al árbol.");
            descIndopacifico.Add("Ficus pumila. Es un arbusto trepador perenne originario de Japón. Tiene densas ramas ﬁnas que se agarran con facilidad al suelo o a los muros cubriéndolos con un ﬁno tapiz verde. Las hojas son pequeñas, coriáceas, de color verde oscuro. Tiene crecimiento rápido. Alcanza los 10 m de altura. Las ﬂores son muy pequeñas y los frutos tienen color anaranjado y púrpura con sabor desagradable.");
            descIndopacifico.Add("Cyathea cooperi. Helecho arborescente originario de Australia. Alcanza 15 m. El tronco está cubierto de una pilosidad parduzca y en la parte superior se encuentran los frondes de color verde claro. Se reproduce por esporas y crece lentamente. Está naturalizado en muchos lugares. Es descendiente de los grandes helechos que formaron bosques inmensos hace millones de años.");
            descIndopacifico.Add("Balantium antarcticum. Helecho arborescente originario de Australia.  Vive en colinas abrigadas y en barrancos húmedos. Alcanza 15 m. Tiene un rizoma subterráneo del que sale un tronco fibroso vertical. En su copa, de 2 a 6 m de diámetro, se expanden las hojas o frondes. Algunas de ellas contienen en el envés esporangios, los órganos productores de esporas. La médula de la planta es comestible y contiene alto contenido de almidón.");
            descIndopacifico.Add("Asplenium nidus. Helecho nativo de las selvas húmedas del sudeste asiático. Tiene hábitos epíﬁtos ya que crece sobre troncos de árboles en los pisos bajos de la selva donde hay poca luz natural. No es parásita porque no perfora la corteza ni se alimenta de la savia del árbol. Se reproduce por esporas que se originan en unas estructuras en el envés de las hojas o frondes fértiles. Las hojas son lustrosas.");
            descIndopacifico.Add("Ficus macrophylla. Árbol nativo de la costa Este de Australia aunque está muy extendido por Sudamérica. Es perenne y sus hojas recuerdan a las del magnolio. Las semillas germinan en la copa de un árbol huésped. Vive como epíﬁta hasta que las raíces llegan al suelo. Entonces se alarga y estrangula al huésped convirtiéndose en un árbol independiente. Sus raíces aéreas le permiten extender ampliamente su copa.");

        }
    }
}
