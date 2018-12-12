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
    /// Interaction logic for Indopacifico.xaml
    /// </summary>
    public partial class Indopacifico : Page
    {
        private List<Uri> uriIndopacifico;
        private List<String> titlesIndopacifico;
        private List<String> descIndopacifico;

        int puntero;

        public Indopacifico()
        {
            InitializeComponent();
            uriIndopacifico = new List<Uri>();
            titlesIndopacifico = new List<string>();
            descIndopacifico = new List<string>();


            puntero = 0;


            LoadSpecies(uriIndopacifico);
            Uri resourceUri = new Uri("Images/ip_a_0.jpg", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            this.Especie.Source = temp;



            Uri leftButtonUri = new Uri("Assets/explora_button_left_ip.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(leftButtonUri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            this.Left.Background = brush;




            Uri rightButtonUri = new Uri("Assets/explora_button_right_ip.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(rightButtonUri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            brush = new ImageBrush();
            brush.ImageSource = temp;
            this.Right.Background = brush;


            LoadTitles(titlesIndopacifico);
            this.Titulo.Text = titlesIndopacifico[0];

            LoadDesc(descIndopacifico);
            this.Descripcion.Text = descIndopacifico[0];


        }


        private void RightClick(object sender, RoutedEventArgs e)
        {
            if (puntero < uriIndopacifico.Count - 1)
            {
                puntero++;
                Uri resourceUri = uriIndopacifico[puntero];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;

                this.Titulo.Text = titlesIndopacifico[puntero];
                this.Descripcion.Text = descIndopacifico[puntero];
            }

        }

        private void LeftClick(object sender, RoutedEventArgs e)
        {
            if (puntero > 0)
            {
                puntero--;
                Uri resourceUri = uriIndopacifico[puntero];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;

                this.Titulo.Text = titlesIndopacifico[puntero];
                this.Descripcion.Text = descIndopacifico[puntero];
            }

        }








        public void LoadSpecies(List<Uri> uriIndopacifico)
        {

            // imagenes amazonas
            uriIndopacifico.Add( new Uri("Images/ip_a_0.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_1.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_2.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_3.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_4.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_5.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_6.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_7.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_8.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_9.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_10.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_11.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_12.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_13.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_14.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_a_15.jpg", UriKind.Relative ));


            uriIndopacifico.Add( new Uri("Images/ip_v_0.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_1.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_2.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_3.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_4.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_5.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_6.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_7.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_8.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_9.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_10.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_11.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_12.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_13.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_14.jpg", UriKind.Relative ));
            uriIndopacifico.Add( new Uri("Images/ip_v_15.jpg", UriKind.Relative ));


        }



        public void LoadTitles( List<String> titlesIndopacifico )
        {
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




        private void LoadDesc( List<String> descIndopacifico)
        {
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
