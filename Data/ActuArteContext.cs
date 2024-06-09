using Microsoft.EntityFrameworkCore;
using ActuArte.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ActuArte.Data
{
    public class ActuArteContext : DbContext
    {

        public ActuArteContext(DbContextOptions<ActuArteContext> options)
            : base(options)
        {

        }

        public DbSet<Obras> Obras { get; set; }
        public DbSet<Asientos> Asientos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<AsientosGuardados> AsientosObrasDatos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Obras>().HasData(
                new Obras
                {
                    idObra = 1,
                    nombreObra = "Romeo y Julieta",
                    descObra = "La excelente y lamentable tragedia de Romeo y Julieta cuenta la historia de dos jóvenes enamorados, Romeo y Julieta, quienes pertenecen a dos familias poderosas y enemigas de la ciudad renacentista de Verona, Italia: los Montesco y los Capuleto. Los protagonistas se conocen en un baile familiar de los Capuleto, en el que Romeo y sus amigos se cuelan, a pesar del peligro que corren y de que el rey de la ciudad ha decretado una frágil tregua entre las familias. Y tan pronto como bailan, Romeo y Julieta quedan perdidamente enamorados el uno del otro.",
                    valoracionObra = 5,
                    imagen = "https://almeriaciudad.es/cultura/wp-content/archivos/sites/21/2022/02/IMG_2391-1.jpeg",
                    autorObra = "Nayra Calvo y Miguel A.Luengo",
                    directorObra = "Franco Zeffirelli",
                    duracionObra = 90,
                    aclamadas = true,
                    recientes = false,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 2,
                    nombreObra = "La Casa de Bernarda Alba",
                    descObra = "Tras la muerte de su segundo esposo, Bernarda Alba se recluye e impone un luto riguroso y asfixiante por ocho años, prohibiendo a sus cinco hijas a que vayan a la fiesta. Cuando Angustias, la primogénita y la única hija del primer marido, hereda una fortuna, atrae a un pretendiente, Pepe el Romano.",
                    valoracionObra = 4.3,
                    imagen = "https://chglenguayliteratura.files.wordpress.com/2020/01/aaaa.jpg",
                    autorObra = "Nancy Fabiola Herrera y Carmen Romeu",
                    directorObra = "Alfredo Sanzol",
                    duracionObra = 60,
                    aclamadas = false,
                    recientes = false,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 3,
                    nombreObra = "La Celestina",
                    descObra = "La loca pasión por Melibea, hija de un rico mercader, lleva al joven Calisto a romper todas las barreras y a aliarse con una vieja alcahueta. Desde el momento en que entra en escena, Celestina avasalla toda la obra hasta convertirse en un personaje literario de fama universal.",
                    valoracionObra = 4.7,
                    imagen = "https://www.cervantesvirtual.com/s3/BVMC_OBRAS/ffa/c66/288/2b1/11d/fac/c70/021/85c/e60/64/mimes/imagenes/ffac6628-82b1-11df-acc7-002185ce6064_2.jpg",
                    autorObra = "Cobadonga Calderon y Javier Mañon",
                    directorObra = "Antonio Castro Guijosa",
                    duracionObra = 60,
                    aclamadas = true,
                    recientes = true,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 4,
                    nombreObra = "La Vida es Sueño",
                    descObra = "El rey Basilio va a tener un hijo. Pero un adivino le dice que ese nacimiento traerá el desastre al reino. En efecto, nada más nacer la madre muere, y el rey, asustado encierra a su hijo en una torre escondida entre montañas de forma que nadie sepa donde está. Solo Clotaldo, su ayo, conoce su paradero.",
                    valoracionObra = 4.4,
                    imagen = "https://www.elejandria.com/covers/La_vida_es_sueno-Calderon_de_la_Barca_Pedro-md.png",
                    autorObra = "David Luque y Rebeca Matellan",
                    directorObra = "Declan Deonnellan",
                    duracionObra = 100,
                    aclamadas = false,
                    recientes = false,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 5,
                    nombreObra = "Hamlet",
                    descObra = "La tragedia de Hamlet, Príncipe de Dinamarca cuenta la historia del joven heredero al trono danés, cuyo padre muerto se le aparece como un fantasma en las murallas del castillo, para invocar su venganza, pues su muerte no fue natural sino que fue envenenado por su propia esposa Gertrudis, madre de Hamlet, y su hermano y actual rey, Claudio.",
                    valoracionObra = 4.5,
                    imagen = "https://cdn.kobo.com/book-images/5fc4252b-1c4f-40ef-9975-22982c94f12c/1200/1200/False/hamlet-prince-of-denmark-23.jpg",
                    autorObra = "Juan Motilla y Antonio Campos",
                    directorObra = "Miguel del Arco",
                    duracionObra = 95,
                    aclamadas = true,
                    recientes = true,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 6,
                    nombreObra = "El Fantasma de la Ópera",
                    descObra = "Misterio y amor en las catacumbas de París. En los sótanos de la Ópera de París se esconde un misterioso personaje que oculta su rostro desfigurado. Este ser acecha por los camerinos y vigila a Christine, una inocente muchacha con gran talento de la que se ha enamorado. A través de un tenebroso y cruel personaje, Erik, atormentado por la deformidad de su rostro y su pasión por la belleza, y de los recovecos de un edificio, la Ópera de París, Leroux nos introduce en el mundo del otro lado del telón.",
                    valoracionObra = 4.8,
                    imagen = "https://teatroaranjuez.es/wp-content/uploads/2023/10/el-fantasma-de-la-opera-330x467-1.jpg",
                    autorObra = "Manu Pilas y Gerónimo Raouch",
                    directorObra = "Federico Bellone",
                    duracionObra = 150,
                    aclamadas = false,
                    recientes = true,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 7,
                    nombreObra = "Sueño de una Noche de Verano",
                    descObra = "Narra los hechos que suceden durante el casamiento de Teseo, duque de Atenas, con Hipólita, reina de las amazonas. Incluye las aventuras de cuatro amantes atenienses y un grupo de seis actores aficionados que son controlados por las hadas que habitan en el bosque donde la mayor parte de la obra tiene lugar.",
                    valoracionObra = 4.2,
                    imagen = "https://image.isu.pub/190709204809-9c82f7fce8bb840f1ff3b5631eef637f/jpg/page_1.jpg",
                    autorObra = "Rafa Ramos y Jordi Millan",
                    directorObra = "Marco Carniti",
                    duracionObra = 90,
                    aclamadas = true,
                    recientes = false,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 8,
                    nombreObra = "Don Juan Tenorio",
                    descObra = "Don Juan Tenorio es el personaje más célebre del teatro español. La historia de este burlador de mujeres comienza en los días de Carnaval y acaba en el Día de Difuntos. Don Juan es un seductor que se mofa de todos los valores sociales establecidos. Pero su vida cambiará al conocer a doña Inés. Gracias a su amor, el alma de don Juan se salvará de las llamas del infierno.",
                    valoracionObra = 4.3,
                    imagen = "https://m.media-amazon.com/images/I/61Er0I3cJaL._AC_UF1000,1000_QL80_.jpg",
                    autorObra = "Francisco Fraguas y Amanda Recacha",
                    directorObra = "Pedro Amalio Lopez",
                    duracionObra = 100,
                    aclamadas = false,
                    recientes = false,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 9,
                    nombreObra = "Fuenteovejuna",
                    descObra = "El pueblo de Fuente Ovejuna, ya está harto de la crueldad de su señor, que no hace más que fastidiarlos, ya sea reclutando jóvenes para sus guerras, o deshonrando a sus mujeres, y esta es la gota que colma el vaso de su paciencia, así que deciden intervenir y matar al Comendador.",
                    valoracionObra = 4.5,
                    imagen = "https://m.media-amazon.com/images/I/418RabpIZVS.jpg",
                    autorObra = "Blanca Apilanez y Juan José Otegui",
                    directorObra = "Adolfo Marsillat",
                    duracionObra = 90,
                    aclamadas = true,
                    recientes = false,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 10,
                    nombreObra = "La Divina Comedia",
                    descObra = "Es una obra humana que refleja el peregrinaje del ser humano en busca de “la Luz”, es el descubrimiento del hombre hacia Dios, con la ayuda de la razón (Virgilio) y de la fe (Beatriz). El poema es una epopeya religiosa que narra con realismo un viaje, es un canto a la humanidad.",
                    valoracionObra = 5,
                    imagen = "https://m.media-amazon.com/images/I/71WJbXGxPdL._AC_UF1000,1000_QL80_.jpg",
                    autorObra = "Alejandro Centro y Daniel Valdovinos",
                    directorObra = "Dante",
                    duracionObra = 110,
                    aclamadas = true,
                    recientes = true,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 11,
                    nombreObra = "El enfermo imaginario",
                    descObra = "Argán se cree muy enfermo y no puede vivir sin estar rodeado de médicos. Para conseguir tener uno en su familia que le haga ahorrar la ingente cantidad de dinero que destina a sus curas, medicamentos y potingues, no duda en concertar un matrimonio de conveniencia entre su hija Angélica con el hijo del doctor Diafoirus.",
                    valoracionObra = 4.7,
                    imagen = "https://www.tarambana.net/upload/espectaculos/foto_poster-1296.jpg?id=117364",
                    autorObra = "Eduardo Tovar y Virginia Sanchez",
                    directorObra = "Eva del Palacio",
                    duracionObra = 70,
                    aclamadas = false,
                    recientes = false,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 12,
                    nombreObra = "Cats",
                    descObra = "Esta obra musical es una de las más célebres de Broadway. Fue creada por el legendario Andrew Lloyd Weber, quien a su vez se basó en los poemas de T. S. Eliot, «El libro de los gatos habilidosos del viejo Possum». Relata la historia de los Jellicle Cats, un grupo de gatos callejeros que poco a poco se va presentando ante el público, en medio de impresionantes números musicales.",
                    valoracionObra = 4.3,
                    imagen = "https://upload.wikimedia.org/wikipedia/en/3/30/Cats_1998_DVD_Cover.jpg",
                    autorObra = "Tailor Swoft y Jason Derulo",
                    directorObra = "Trevor Nunn",
                    duracionObra = 120,
                    aclamadas = true,
                    recientes = true,
                    ultimasSesiones = false
                },
                new Obras
                {
                    idObra = 13,
                    nombreObra = "Wicked",
                    descObra = "Narra la historia de Elphaba, una niña nacida de color verde y cómo se convierte en la Malvada Bruja del Oeste, pasando por los sucesos que experimenta desde su nacimiento, infancia y juventud en la Universidad de Shiz hasta llegar a la edad adulta, momento de la llegada de Dorothy a la tierra de Oz.",
                    valoracionObra = 4.7,
                    imagen = "https://m.media-amazon.com/images/M/MV5BNjczYjBhMTctYTA3Yy00NTgyLWFkZWQtZjQwYTRkMDc1YTc1XkEyXkFqcGdeQXVyNTk5NTQzNDI@._V1_.jpg",
                    autorObra = "Arianna Grande y Adam James",
                    directorObra = "Joe Mantello",
                    duracionObra = 165,
                    aclamadas = false,
                    recientes = false,
                    ultimasSesiones = true
                },
                new Obras
                {
                    idObra = 14,
                    nombreObra = "Los Miserables",
                    descObra = "Es la historia de Jean Valjean, un convicto que estuvo injustamente encarcelado por 19 años por haberse robado una rebanada de pan. Al ser liberado de su injusta condena, Valjean trata de escapar de su pasado, lleno de maldad y depravación, para vivir una vida digna y honesta.",
                    valoracionObra = 4.8,
                    imagen = "https://m.media-amazon.com/images/I/517Cb2FS4qL.jpg",
                    autorObra = "Miguel del Arco y Gemma Castaño",
                    directorObra = "David White",
                    duracionObra = 210,
                    aclamadas = true,
                    recientes = false,
                    ultimasSesiones = true
                },
                new Obras
                {
                    idObra = 15,
                    nombreObra = "Casa de Muñecas",
                    descObra = "En Casa de muñecas Ibsen aborda el problema de la situación de la mujer de la pequeña burguesía en la sociedad de su tiempo. Nora, la protagonista, es el retrato de las mujeres de su clase y puede ofrecer un retrato con mucha actualidad para las mujeres inmersas en la vorágine del mundo contemporáneo.",
                    valoracionObra = 4.6,
                    imagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/ef/99/ef9995dc7f336bc670c2775b7316b143.jpg",
                    autorObra = " Nayra Calvo y Miguel A.Luengo",
                    directorObra = "Franco Zeffirelli",
                    duracionObra = 100,
                    aclamadas = false,
                    recientes = false,
                    ultimasSesiones = true
                },
                new Obras
                {
                    idObra = 16,
                    nombreObra = "El alcalde de Zalamea",
                    descObra = "En el alcalde de Zalamea, se cuenta la venganza del Alcalde Pedro Crespo, que da muerte a don Álvaro, el arrogante capitán que ha secuestrado a su hija. Esta reacción no se percibe como el resultado de aplicar un código rígido y bárbaro, sino como una reacción justa que será aprobada por el rey.",
                    valoracionObra = 4.1,
                    imagen = "https://m.media-amazon.com/images/I/51fM26seM-L.jpg",
                    autorObra = " Carmelo Gomez y Joaquin Notario",
                    directorObra = "Miguel Nieto",
                    duracionObra = 90,
                    aclamadas = true,
                    recientes = false,
                    ultimasSesiones = true
                }

            );

            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios
                {
                    idUsuario = 1,
                    nombreUsuario = "admin",
                    passwordUsuario = "admin",
                    isAdmin = true
                },
                new Usuarios
                {
                    idUsuario = 2,
                    nombreUsuario = "admin2",
                    passwordUsuario = "admin",
                    isAdmin = true
                },
                new Usuarios
                {
                    idUsuario = 3,
                    nombreUsuario = "admin3",
                    passwordUsuario = "admin",
                    isAdmin = true
                },
                new Usuarios
                {
                    idUsuario = 4,
                    nombreUsuario = "admin4",
                    passwordUsuario = "admin",
                    isAdmin = true
                }
            );


            modelBuilder.Entity<Asientos>().HasData(
                new Asientos
                {
                    idAsiento = 1,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 2,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 3,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 4,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 5,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 6,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 7,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 8,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 9,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 10,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 11,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 12,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 13,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 14,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 15,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 16,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 17,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 18,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 19,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 20,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 21,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 22,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 23,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 24,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 25,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 26,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 27,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 28,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 29,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 30,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 31,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 32,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 33,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 34,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 35,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 36,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 37,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 38,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 39,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 40,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 41,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 42,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 43,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 44,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 45,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 46,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 47,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 48,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 49,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 50,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 51,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 52,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 53,
                    estaOcupado = false
                },
                new Asientos
                {
                    idAsiento = 54,
                    estaOcupado = false
                }
            );

        

        }
    }
}