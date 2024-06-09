using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ActuArte.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asientos",
                columns: table => new
                {
                    idAsiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estaOcupado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asientos", x => x.idAsiento);
                });

            migrationBuilder.CreateTable(
                name: "AsientosObrasDatos",
                columns: table => new
                {
                    idObjeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idObra = table.Column<int>(type: "int", nullable: false),
                    idSesion = table.Column<int>(type: "int", nullable: false),
                    idAsiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsientosObrasDatos", x => x.idObjeto);
                });

            migrationBuilder.CreateTable(
                name: "Obras",
                columns: table => new
                {
                    idObra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descObra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valoracionObra = table.Column<double>(type: "float", nullable: false),
                    autorObra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    directorObra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duracionObra = table.Column<int>(type: "int", nullable: false),
                    aclamadas = table.Column<bool>(type: "bit", nullable: false),
                    recientes = table.Column<bool>(type: "bit", nullable: false),
                    ultimasSesiones = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obras", x => x.idObra);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false),
                    nombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passwordUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });

            migrationBuilder.InsertData(
                table: "Asientos",
                columns: new[] { "idAsiento", "estaOcupado" },
                values: new object[,]
                {
                    { 1, false },
                    { 2, false },
                    { 3, false },
                    { 4, false },
                    { 5, false },
                    { 6, false },
                    { 7, false },
                    { 8, false },
                    { 9, false },
                    { 10, false },
                    { 11, false },
                    { 12, false },
                    { 13, false },
                    { 14, false },
                    { 15, false },
                    { 16, false },
                    { 17, false },
                    { 18, false },
                    { 19, false },
                    { 20, false },
                    { 21, false },
                    { 22, false },
                    { 23, false },
                    { 24, false },
                    { 25, false },
                    { 26, false },
                    { 27, false },
                    { 28, false },
                    { 29, false },
                    { 30, false },
                    { 31, false },
                    { 32, false },
                    { 33, false },
                    { 34, false },
                    { 35, false },
                    { 36, false },
                    { 37, false },
                    { 38, false },
                    { 39, false },
                    { 40, false },
                    { 41, false },
                    { 42, false },
                    { 43, false },
                    { 44, false },
                    { 45, false },
                    { 46, false },
                    { 47, false },
                    { 48, false },
                    { 49, false },
                    { 50, false },
                    { 51, false },
                    { 52, false },
                    { 53, false },
                    { 54, false }
                });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "idObra", "aclamadas", "autorObra", "descObra", "directorObra", "duracionObra", "imagen", "nombreObra", "recientes", "ultimasSesiones", "valoracionObra" },
                values: new object[,]
                {
                    { 1, true, "Nayra Calvo y Miguel A.Luengo", "La excelente y lamentable tragedia de Romeo y Julieta cuenta la historia de dos jóvenes enamorados, Romeo y Julieta, quienes pertenecen a dos familias poderosas y enemigas de la ciudad renacentista de Verona, Italia: los Montesco y los Capuleto. Los protagonistas se conocen en un baile familiar de los Capuleto, en el que Romeo y sus amigos se cuelan, a pesar del peligro que corren y de que el rey de la ciudad ha decretado una frágil tregua entre las familias. Y tan pronto como bailan, Romeo y Julieta quedan perdidamente enamorados el uno del otro.", "Franco Zeffirelli", 90, "https://almeriaciudad.es/cultura/wp-content/archivos/sites/21/2022/02/IMG_2391-1.jpeg", "Romeo y Julieta", false, false, 5.0 },
                    { 2, false, "Nancy Fabiola Herrera y Carmen Romeu", "Tras la muerte de su segundo esposo, Bernarda Alba se recluye e impone un luto riguroso y asfixiante por ocho años, prohibiendo a sus cinco hijas a que vayan a la fiesta. Cuando Angustias, la primogénita y la única hija del primer marido, hereda una fortuna, atrae a un pretendiente, Pepe el Romano.", "Alfredo Sanzol", 60, "https://chglenguayliteratura.files.wordpress.com/2020/01/aaaa.jpg", "La Casa de Bernarda Alba", false, false, 4.2999999999999998 },
                    { 3, true, "Cobadonga Calderon y Javier Mañon", "La loca pasión por Melibea, hija de un rico mercader, lleva al joven Calisto a romper todas las barreras y a aliarse con una vieja alcahueta. Desde el momento en que entra en escena, Celestina avasalla toda la obra hasta convertirse en un personaje literario de fama universal.", "Antonio Castro Guijosa", 60, "https://www.cervantesvirtual.com/s3/BVMC_OBRAS/ffa/c66/288/2b1/11d/fac/c70/021/85c/e60/64/mimes/imagenes/ffac6628-82b1-11df-acc7-002185ce6064_2.jpg", "La Celestina", true, false, 4.7000000000000002 },
                    { 4, false, "David Luque y Rebeca Matellan", "El rey Basilio va a tener un hijo. Pero un adivino le dice que ese nacimiento traerá el desastre al reino. En efecto, nada más nacer la madre muere, y el rey, asustado encierra a su hijo en una torre escondida entre montañas de forma que nadie sepa donde está. Solo Clotaldo, su ayo, conoce su paradero.", "Declan Deonnellan", 100, "https://www.elejandria.com/covers/La_vida_es_sueno-Calderon_de_la_Barca_Pedro-md.png", "La Vida es Sueño", false, false, 4.4000000000000004 },
                    { 5, true, "Juan Motilla y Antonio Campos", "La tragedia de Hamlet, Príncipe de Dinamarca cuenta la historia del joven heredero al trono danés, cuyo padre muerto se le aparece como un fantasma en las murallas del castillo, para invocar su venganza, pues su muerte no fue natural sino que fue envenenado por su propia esposa Gertrudis, madre de Hamlet, y su hermano y actual rey, Claudio.", "Miguel del Arco", 95, "https://cdn.kobo.com/book-images/5fc4252b-1c4f-40ef-9975-22982c94f12c/1200/1200/False/hamlet-prince-of-denmark-23.jpg", "Hamlet", true, false, 4.5 },
                    { 6, false, "Manu Pilas y Gerónimo Raouch", "Misterio y amor en las catacumbas de París. En los sótanos de la Ópera de París se esconde un misterioso personaje que oculta su rostro desfigurado. Este ser acecha por los camerinos y vigila a Christine, una inocente muchacha con gran talento de la que se ha enamorado. A través de un tenebroso y cruel personaje, Erik, atormentado por la deformidad de su rostro y su pasión por la belleza, y de los recovecos de un edificio, la Ópera de París, Leroux nos introduce en el mundo del otro lado del telón.", "Federico Bellone", 150, "https://teatroaranjuez.es/wp-content/uploads/2023/10/el-fantasma-de-la-opera-330x467-1.jpg", "El Fantasma de la Ópera", true, false, 4.7999999999999998 },
                    { 7, true, "Rafa Ramos y Jordi Millan", "Narra los hechos que suceden durante el casamiento de Teseo, duque de Atenas, con Hipólita, reina de las amazonas. Incluye las aventuras de cuatro amantes atenienses y un grupo de seis actores aficionados que son controlados por las hadas que habitan en el bosque donde la mayor parte de la obra tiene lugar.", "Marco Carniti", 90, "https://image.isu.pub/190709204809-9c82f7fce8bb840f1ff3b5631eef637f/jpg/page_1.jpg", "Sueño de una Noche de Verano", false, false, 4.2000000000000002 },
                    { 8, false, "Francisco Fraguas y Amanda Recacha", "Don Juan Tenorio es el personaje más célebre del teatro español. La historia de este burlador de mujeres comienza en los días de Carnaval y acaba en el Día de Difuntos. Don Juan es un seductor que se mofa de todos los valores sociales establecidos. Pero su vida cambiará al conocer a doña Inés. Gracias a su amor, el alma de don Juan se salvará de las llamas del infierno.", "Pedro Amalio Lopez", 100, "https://m.media-amazon.com/images/I/61Er0I3cJaL._AC_UF1000,1000_QL80_.jpg", "Don Juan Tenorio", false, false, 4.2999999999999998 },
                    { 9, true, "Blanca Apilanez y Juan José Otegui", "El pueblo de Fuente Ovejuna, ya está harto de la crueldad de su señor, que no hace más que fastidiarlos, ya sea reclutando jóvenes para sus guerras, o deshonrando a sus mujeres, y esta es la gota que colma el vaso de su paciencia, así que deciden intervenir y matar al Comendador.", "Adolfo Marsillat", 90, "https://m.media-amazon.com/images/I/418RabpIZVS.jpg", "Fuenteovejuna", false, false, 4.5 },
                    { 10, true, "Alejandro Centro y Daniel Valdovinos", "Es una obra humana que refleja el peregrinaje del ser humano en busca de “la Luz”, es el descubrimiento del hombre hacia Dios, con la ayuda de la razón (Virgilio) y de la fe (Beatriz). El poema es una epopeya religiosa que narra con realismo un viaje, es un canto a la humanidad.", "Dante", 110, "https://m.media-amazon.com/images/I/71WJbXGxPdL._AC_UF1000,1000_QL80_.jpg", "La Divina Comedia", true, false, 5.0 },
                    { 11, false, "Eduardo Tovar y Virginia Sanchez", "Argán se cree muy enfermo y no puede vivir sin estar rodeado de médicos. Para conseguir tener uno en su familia que le haga ahorrar la ingente cantidad de dinero que destina a sus curas, medicamentos y potingues, no duda en concertar un matrimonio de conveniencia entre su hija Angélica con el hijo del doctor Diafoirus.", "Eva del Palacio", 70, "https://www.tarambana.net/upload/espectaculos/foto_poster-1296.jpg?id=117364", "El enfermo imaginario", false, false, 4.7000000000000002 },
                    { 12, true, "Tailor Swoft y Jason Derulo", "Esta obra musical es una de las más célebres de Broadway. Fue creada por el legendario Andrew Lloyd Weber, quien a su vez se basó en los poemas de T. S. Eliot, «El libro de los gatos habilidosos del viejo Possum». Relata la historia de los Jellicle Cats, un grupo de gatos callejeros que poco a poco se va presentando ante el público, en medio de impresionantes números musicales.", "Trevor Nunn", 120, "https://upload.wikimedia.org/wikipedia/en/3/30/Cats_1998_DVD_Cover.jpg", "Cats", true, false, 4.2999999999999998 },
                    { 13, false, "Arianna Grande y Adam James", "Narra la historia de Elphaba, una niña nacida de color verde y cómo se convierte en la Malvada Bruja del Oeste, pasando por los sucesos que experimenta desde su nacimiento, infancia y juventud en la Universidad de Shiz hasta llegar a la edad adulta, momento de la llegada de Dorothy a la tierra de Oz.", "Joe Mantello", 165, "https://m.media-amazon.com/images/M/MV5BNjczYjBhMTctYTA3Yy00NTgyLWFkZWQtZjQwYTRkMDc1YTc1XkEyXkFqcGdeQXVyNTk5NTQzNDI@._V1_.jpg", "Wicked", false, true, 4.7000000000000002 },
                    { 14, true, "Miguel del Arco y Gemma Castaño", "Es la historia de Jean Valjean, un convicto que estuvo injustamente encarcelado por 19 años por haberse robado una rebanada de pan. Al ser liberado de su injusta condena, Valjean trata de escapar de su pasado, lleno de maldad y depravación, para vivir una vida digna y honesta.", "David White", 210, "https://m.media-amazon.com/images/I/517Cb2FS4qL.jpg", "Los Miserables", false, true, 4.7999999999999998 },
                    { 15, false, " Nayra Calvo y Miguel A.Luengo", "En Casa de muñecas Ibsen aborda el problema de la situación de la mujer de la pequeña burguesía en la sociedad de su tiempo. Nora, la protagonista, es el retrato de las mujeres de su clase y puede ofrecer un retrato con mucha actualidad para las mujeres inmersas en la vorágine del mundo contemporáneo.", "Franco Zeffirelli", 100, "https://images.cdn3.buscalibre.com/fit-in/360x360/ef/99/ef9995dc7f336bc670c2775b7316b143.jpg", "Casa de Muñecas", false, true, 4.5999999999999996 },
                    { 16, true, " Carmelo Gomez y Joaquin Notario", "En el alcalde de Zalamea, se cuenta la venganza del Alcalde Pedro Crespo, que da muerte a don Álvaro, el arrogante capitán que ha secuestrado a su hija. Esta reacción no se percibe como el resultado de aplicar un código rígido y bárbaro, sino como una reacción justa que será aprobada por el rey.", "Miguel Nieto", 90, "https://m.media-amazon.com/images/I/51fM26seM-L.jpg", "El alcalde de Zalamea", false, true, 4.0999999999999996 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "idUsuario", "isAdmin", "nombreUsuario", "passwordUsuario" },
                values: new object[,]
                {
                    { 1, true, "admin", "admin" },
                    { 2, true, "admin2", "admin" },
                    { 3, true, "admin3", "admin" },
                    { 4, true, "admin4", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asientos");

            migrationBuilder.DropTable(
                name: "AsientosObrasDatos");

            migrationBuilder.DropTable(
                name: "Obras");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
