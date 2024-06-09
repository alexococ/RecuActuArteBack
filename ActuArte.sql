-- Reemplaza 'NombreDeTuBaseDeDatos' con el nombre real de tu base de datos
CREATE DATABASE ActuArteDB;
GO

USE ActuArteDB;
GO




-- Creación de la tabla 'Obras'
CREATE TABLE Obras (
    idObra INT PRIMARY KEY IDENTITY,
    nombreObra NVARCHAR(255),
    descObra NVARCHAR(MAX),
    valoracionObra FLOAT,
    imagen NVARCHAR(MAX), -- campo para almacenar la ruta de la imagen o su URL
    autorObra NVARCHAR(255),
    directorObra NVARCHAR(255),
    duracionObra INT -- Duración en minutos
);
GO



-- Creación de la tabla 'Asientos'
CREATE TABLE Asientos (
    idAsiento INT PRIMARY KEY IDENTITY,
    idObra INT,
    isOccupied BIT,
    FOREIGN KEY (idObra) REFERENCES Obras(idObra)
);
GO

-- Creación de la tabla 'Usuarios'
CREATE TABLE Usuarios (
    idUsuario INT PRIMARY KEY IDENTITY,
    nombreUsuario NVARCHAR(255) NOT NULL,
    passwordUsuario NVARCHAR(255) NOT NULL,
);
GO

INSERT INTO Usuarios(idUsuario, nombreUsuario, passwordUsuario)
VALUES
(
    1,
    'admin',
    'admin'
),
(
    2,
    'admin2',
    'admin'
),
(
    3,
    'admin3',
    'admin'
),
(
    4,
    'admin4',
    'admin'
),



-- Inserciones de prueba en la tabla 'Obras'
INSERT INTO Obras (idObra, nombreObra, descObra, valoracionObra, imagen, autorObra, directorObra, duracionObra)
VALUES

(
    1,
    'Romeo y Julieta', 
    'La excelente y lamentable tragedia de Romeo y Julieta cuenta la historia de dos jóvenes enamorados, Romeo y Julieta, quienes pertenecen a dos familias poderosas y enemigas de la ciudad renacentista de Verona, Italia: los Montesco y los Capuleto. Los protagonistas se conocen en un baile familiar de los Capuleto, en el que Romeo y sus amigos se cuelan, a pesar del peligro que corren y de que el rey de la ciudad ha decretado una frágil tregua entre las familias. Y tan pronto como bailan, Romeo y Julieta quedan perdidamente enamorados el uno del otro.', 
    5, 'https://almeriaciudad.es/cultura/wp-content/archivos/sites/21/2022/02/IMG_2391-1.jpeg', 
    'Nayra Calvo y Miguel A.Luengo', 
    'Franco Zeffirelli', 90
),

(
    2,
    'La Casa de Bernarda Alba', 
    'Tras la muerte de su segundo esposo, Bernarda Alba se recluye e impone un luto riguroso y asfixiante por ocho años, prohibiendo a sus cinco hijas a que vayan a la fiesta. Cuando Angustias, la primogénita y la única hija del primer marido, hereda una fortuna, atrae a un pretendiente, Pepe el Romano.', 
    4.3, 'https://chglenguayliteratura.files.wordpress.com/2020/01/aaaa.jpg', 
    'Nancy Fabiola Herrera y Carmen Romeu', 
    'Alfredo Sanzol', 60
),

(
    3,
    'La Celestina', 
    'La loca pasión por Melibea, hija de un rico mercader, lleva al joven Calisto a romper todas las barreras y a aliarse con una vieja alcahueta. Desde el momento en que entra en escena, Celestina avasalla toda la obra hasta convertirse en un personaje literario de fama universal.', 
    4.7, 'https://www.cervantesvirtual.com/s3/BVMC_OBRAS/ffa/c66/288/2b1/11d/fac/c70/021/85c/e60/64/mimes/imagenes/ffac6628-82b1-11df-acc7-002185ce6064_2.jpg', 
    'Cobadonga Calderon y Javier Mañon', 
    'Antonio Castro Guijosa', 60
),

(
    4,
    'La Vida es Sueño', 
    'El rey Basilio va a tener un hijo. Pero un adivino le dice que ese nacimiento traerá el desastre al reino. En efecto, nada más nacer la madre muere, y el rey, asustado encierra a su hijo en una torre escondida entre montañas de forma que nadie sepa donde está. Solo Clotaldo, su ayo, conoce su paradero.', 
    4.4, 'https://www.elejandria.com/covers/La_vida_es_sueno-Calderon_de_la_Barca_Pedro-md.png', 
    'David Luque y Rebeca Matellan', 
    'Declan Deonnellan', 100
),

(
    5,
    'Hamlet', 
    'La tragedia de Hamlet, Príncipe de Dinamarca cuenta la historia del joven heredero al trono danés, cuyo padre muerto se le aparece como un fantasma en las murallas del castillo, para invocar su venganza, pues su muerte no fue natural sino que fue envenenado por su propia esposa Gertrudis, madre de Hamlet, y su hermano y actual rey, Claudio.', 
    4.5, 'https://cdn.kobo.com/book-images/5fc4252b-1c4f-40ef-9975-22982c94f12c/1200/1200/False/hamlet-prince-of-denmark-23.jpg', 
    'Juan Motilla y Antonio Campos', 
    'Miguel del Arco', 95
),

(
    6,
    'El Fantasma de la Ópera', 
    'Misterio y amor en las catacumbas de París. En los sótanos de la Ópera de París se esconde un misterioso personaje que oculta su rostro desfigurado. Este ser acecha por los camerinos y vigila a Christine, una inocente muchacha con gran talento de la que se ha enamorado. A través de un tenebroso y cruel personaje, Erik, atormentado por la deformidad de su rostro y su pasión por la belleza, y de los recovecos de un edificio, la Ópera de París, Leroux nos introduce en el mundo del otro lado del telón.', 
    4.8, 'https://teatroaranjuez.es/wp-content/uploads/2023/10/el-fantasma-de-la-opera-330x467-1.jpg', 
    'Manu Pilas y Gerónimo Raouch', 
    'Federico Bellone', 150
),

(
    7,
    'Sueño de una Noche de Verano', 
    'Narra los hechos que suceden durante el casamiento de Teseo, duque de Atenas, con Hipólita, reina de las amazonas. Incluye las aventuras de cuatro amantes atenienses y un grupo de seis actores aficionados que son controlados por las hadas que habitan en el bosque donde la mayor parte de la obra tiene lugar.', 
    4.2, 'https://image.isu.pub/190709204809-9c82f7fce8bb840f1ff3b5631eef637f/jpg/page_1.jpg', 
    'Rafa Ramos y Jordi Millan', 
    'Marco Carniti', 90
),

(
    8,
    'Don Juan Tenorio', 
    'Don Juan Tenorio es el personaje más célebre del teatro español. La historia de este burlador de mujeres comienza en los días de Carnaval y acaba en el Día de Difuntos. Don Juan es un seductor que se mofa de todos los valores sociales establecidos. Pero su vida cambiará al conocer a doña Inés. Gracias a su amor, el alma de don Juan se salvará de las llamas del infierno.', 
    4.3, 'https://m.media-amazon.com/images/I/61Er0I3cJaL._AC_UF1000,1000_QL80_.jpg', 
    'Francisco Fraguas y Amanda Recacha', 
    'Pedro Amalio Lopez', 100
),

(
    9,
    'Fuenteovejuna', 
    'El pueblo de Fuente Ovejuna, ya está harto de la crueldad de su señor, que no hace más que fastidiarlos, ya sea reclutando jóvenes para sus guerras, o deshonrando a sus mujeres, y esta es la gota que colma el vaso de su paciencia, así que deciden intervenir y matar al Comendador.', 
    4.5, 'https://m.media-amazon.com/images/I/418RabpIZVS.jpg', 
    'Blanca Apilanez y Juan José Otegui', 
    'Adolfo Marsillat', 90
),

(
    10,
    'La Divina Comedia', 
    'Es una obra humana que refleja el peregrinaje del ser humano en busca de “la Luz”, es el descubrimiento del hombre hacia Dios, con la ayuda de la razón (Virgilio) y de la fe (Beatriz). El poema es una epopeya religiosa que narra con realismo un viaje, es un canto a la humanidad.', 
    5, 'https://m.media-amazon.com/images/I/71WJbXGxPdL._AC_UF1000,1000_QL80_.jpg', 
    'Alejandro Centro y Daniel Valdovinos', 
    'Dante', 110
),

(
    11,
    'El enfermo imaginario', 
    'Argán se cree muy enfermo y no puede vivir sin estar rodeado de médicos. Para conseguir tener uno en su familia que le haga ahorrar la ingente cantidad de dinero que destina a sus curas, medicamentos y potingues, no duda en concertar un matrimonio de conveniencia entre su hija Angélica con el hijo del doctor Diafoirus.', 
    4.7, 'https://www.tarambana.net/upload/espectaculos/foto_poster-1296.jpg?id=117364', 
    'Eduardo Tovar y Virginia Sanchez', 
    'Eva del Palacio', 70
),

(
    12,
    'Cats', 
    'Esta obra musical es una de las más célebres de Broadway. Fue creada por el legendario Andrew Lloyd Weber, quien a su vez se basó en los poemas de T. S. Eliot, «El libro de los gatos habilidosos del viejo Possum». Relata la historia de los Jellicle Cats, un grupo de gatos callejeros que poco a poco se va presentando ante el público, en medio de impresionantes números musicales.', 
    4.3, 'https://upload.wikimedia.org/wikipedia/en/3/30/Cats_1998_DVD_Cover.jpg', 
    'Tailor Swoft y Jason Derulo', 
    'Trevor Nunn', 120
),

(
    13,
    'Wicked', 
    'Narra la historia de Elphaba, una niña nacida de color verde y cómo se convierte en la Malvada Bruja del Oeste, pasando por los sucesos que experimenta desde su nacimiento, infancia y juventud en la Universidad de Shiz hasta llegar a la edad adulta, momento de la llegada de Dorothy a la tierra de Oz.', 
    4.7, 'https://m.media-amazon.com/images/M/MV5BNjczYjBhMTctYTA3Yy00NTgyLWFkZWQtZjQwYTRkMDc1YTc1XkEyXkFqcGdeQXVyNTk5NTQzNDI@._V1_.jpg', 
    'Arianna Grande y Adam James', 
    'Joe Mantello', 165
),

(
    14,
    'Los Miserables', 
    'Es la historia de Jean Valjean, un convicto que estuvo injustamente encarcelado por 19 años por haberse robado una rebanada de pan. Al ser liberado de su injusta condena, Valjean trata de escapar de su pasado, lleno de maldad y depravación, para vivir una vida digna y honesta.', 
    4.8, 'https://m.media-amazon.com/images/I/517Cb2FS4qL.jpg', 
    'Miguel del Arco Gemma Castaño', 
    'David White', 210
),

(
    15,
    'Casa de Muñecas', 
    'En Casa de muñecas Ibsen aborda el problema de la situación de la mujer de la pequeña burguesía en la sociedad de su tiempo. Nora, la protagonista, es el retrato de las mujeres de su clase y puede ofrecer un retrato con mucha actualidad para las mujeres inmersas en la vorágine del mundo contemporáneo.', 
    4.6, 'https://images.cdn3.buscalibre.com/fit-in/360x360/ef/99/ef9995dc7f336bc670c2775b7316b143.jpg', 
    'Autores: Nayra Calvo y Miguel A.Luengo', 
    'Director: Franco Zeffirelli', 100
),

(
    16,
    'El alcalde de Zalamea', 
    'En el alcalde de Zalamea, se cuenta la venganza del Alcalde Pedro Crespo, que da muerte a don Álvaro, el arrogante capitán que ha secuestrado a su hija. Esta reacción no se percibe como el resultado de aplicar un código rígido y bárbaro, sino como una reacción justa que será aprobada por el rey.', 
    4.1, 'https://m.media-amazon.com/images/I/51fM26seM-L.jpg', 
    'Carmelo Gomez y Joaquin Notario', 
    'Miguel Nieto', 90
);

GO



-- Inserciones de prueba en la tabla 'Asientos'
-- Asegúrate de ajustar los ID de 'idObra' según los valores reales después de las inserciones en 'Obras'
INSERT INTO Asientos (idObra, isOccupied)
VALUES
(1, 0), -- Asientos para 'La vida es sueño'
(1, 1),
(2, 0); -- Asientos para 'Don Quijote'
GO
