-- --------------------------------------------------------
-- Host:                         localhost\sqlexpress
-- Versión del servidor:         Microsoft SQL Server 2008 R2 (RTM) - 10.50.1600.1
-- SO del servidor:              Windows NT 6.1 <X64> (Build 7601: Service Pack 1) (WOW64)
-- HeidiSQL Versión:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura de base de datos para Cristina2
CREATE DATABASE IF NOT EXISTS "Cristina2";
USE "Cristina2";


-- Volcando estructura para tabla Cristina2.Articulos
CREATE TABLE IF NOT EXISTS "Articulos" (
	"Id" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(100) NOT NULL,
	"IVA" DECIMAL(4,2) NOT NULL,
	"PrecioCompra" DECIMAL(12,4) NOT NULL,
	"Porcentaje" DECIMAL(5,2) NULL DEFAULT NULL,
	"CodigoBarra" VARCHAR(20) NULL DEFAULT NULL,
	"PrecioSugerido" DECIMAL(12,4) NULL DEFAULT NULL,
	"IdCuenta" INT(10,0) NULL DEFAULT NULL,
	"LlevaStock" BIT NULL DEFAULT NULL,
	"Cantidad" INT(10,0) NULL DEFAULT NULL,
	"BloquearPrecio" BIT NULL DEFAULT NULL,
	"IdCategoria" INT(10,0) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.Articulos: -1 rows
/*!40000 ALTER TABLE "Articulos" DISABLE KEYS */;
INSERT INTO "Articulos" ("Id", "Nombre", "IVA", "PrecioCompra", "Porcentaje", "CodigoBarra", "PrecioSugerido", "IdCuenta", "LlevaStock", "Cantidad", "BloquearPrecio", "IdCategoria") VALUES
	(1, 'REPELENTE DE INSECTOS VAIS SPRAY', 21, 17.68, 30, '7791274195952', 22.98, 14, 'True', 10, 'True', 1),
	(2, 'SPRAY BRILLO CAPILAR SYSTEN 3', 21, 98.02, 30, '7794260007000', 127.42, 14, 'True', 2, 'True', 1),
	(3, 'VALIJA DIVA SALLY', 21, 63.114, 30, '7791274193804', 82.04, 14, 'True', 2, 'True', 1),
	(4, 'AMPOLLA NUTRIOPCION VITAL ', 21, 32.825, 30, '7436', 42.67, 14, 'True', 41, 'True', 1),
	(5, 'CREMA PULIDORA BODY-PRO', 21, 70.936, 30, '1577', 92.209, 14, 'True', 3, 'True', 1),
	(6, 'MALETIN M 02208', 21, 435.6, 30, '4821', 566.28, 14, 'True', 1, 'True', 17),
	(7, 'MALETIN C/SEPARADOR M 02308', 21, 454.96, 30, '4823', 591.448, 14, 'True', 1, 'True', 17),
	(8, 'AMPOLLAS BIFERDIL 055', 21, 26.649, 30, '7791001001860', 34.643, 14, 'True', 12, 'True', 1),
	(9, 'AMPOLLA BIFERDIL 011', 21, 21.906, 30, '7791001001402', 28.4778, 14, 'True', 12, 'True', 1),
	(10, 'AMPOLLA OLIO SEMI DE LINO 6612', 21, 20.293, 30, '7795471411600', 26.3809, 14, 'True', 24, 'True', 1),
	(11, 'AMPOLLA BIFERDIL SUPER ESPECIAL ', 21, 20.9814, 30, '7791001000658', 27.2758, 14, 'True', 12, 'True', 1),
	(12, 'ARQUEADOR DE PESTAÑAS  A263', 21, 23.293, 30, '0041250522638', 30.2809, 14, 'True', 6, 'True', 17),
	(13, 'SET CIBER NUT PERFUME + COLONIA  1979', 21, 64.856, 30, '7791274001901', 84.3128, 14, 'True', 2, 'True', 1),
	(14, 'SET ESTUCHE BABY ALGABO X 4  9498', 21, 90.992, 30, '7791274193514', 118.2896, 14, 'True', 2, 'True', 1),
	(15, 'SET BABY ALGABO FECULA+COLONIA  7078', 21, 47.432, 30, '', 61.6616, 14, 'True', 2, 'True', 1),
	(16, 'COLONIA DELICADA CARICIA BABY', 21, 19.821, 30, '7791274192227', 25.7673, 14, 'True', 2, 'True', 1),
	(17, 'COLONIA BABY DULCES MIMOS', 21, 19.821, 30, '7791274192234', 25.7673, 14, 'True', 2, 'True', 1),
	(18, 'COLONIA BABY SUAVE BRISA', 21, 19.821, 30, '7791274192241', 25.7673, 14, 'True', 2, 'True', 1),
	(19, 'INVISIBLES CHICOS ART. 214 NEGRO Y RUBIO', 21, 5.746, 30, '7798087370019', 7.4698, 14, 'True', 24, 'True', 6),
	(20, 'ARTICULO PRUEBA', 21, 0, 0, '0000000', 0, 2, 'False', 0, 'False', 17),
	(21, 'remera', 21, 110, 50, '11111111', 110, 2, 'True', 1, 'False', 12),
	(22, 'ORDEN DE PAGO', 21, 0, 0, '0000000000', 0, 2, 'False', 0, 'False', 18),
	(23, 'MEDIAS COCOT ART. 3510', 21, 13, 35, '7793617081472', 17.55, 15, 'True', 3, 'True', 12);
/*!40000 ALTER TABLE "Articulos" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.Categoria
CREATE TABLE IF NOT EXISTS "Categoria" (
	"Id" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.Categoria: -1 rows
/*!40000 ALTER TABLE "Categoria" DISABLE KEYS */;
INSERT INTO "Categoria" ("Id", "Nombre") VALUES
	(1, 'PERFUMERIA'),
	(2, 'ROPA NIÑOS'),
	(3, 'REMERAS TALLES ESPECIALES'),
	(4, 'MARROQUINERIA'),
	(5, 'HERMETICOS'),
	(6, 'ACCESORIO PARA CABELLO'),
	(7, 'ELECTRONICA'),
	(8, 'ARTESANIA DE MADERA'),
	(9, 'ADORNOS '),
	(10, 'LIQUIDACION ROPA INTERIOR'),
	(11, 'ACERO QUIRURGICO'),
	(12, 'MEDIAS'),
	(13, 'MAQUILLAJE'),
	(14, 'BOXER / SLIP'),
	(15, 'BOMBACHAS / VEDETINA'),
	(16, 'EMPAQUE'),
	(17, 'ACCESORIOS VARIOS '),
	(18, 'TRANSACCIONES'),
	(19, 'MEDIAS NIÑOS');
/*!40000 ALTER TABLE "Categoria" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.CategoriaAFIP
CREATE TABLE IF NOT EXISTS "CategoriaAFIP" (
	"Id" INT(10,0) NOT NULL,
	"IdCategoriaAFIP" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(50) NULL DEFAULT NULL,
	UNIQUE KEY ("IdCategoriaAFIP"),
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.CategoriaAFIP: -1 rows
/*!40000 ALTER TABLE "CategoriaAFIP" DISABLE KEYS */;
INSERT INTO "CategoriaAFIP" ("Id", "IdCategoriaAFIP", "Nombre") VALUES
	(1, 1, 'RESPONSABLE INSCRIPTO'),
	(2, 2, 'RESPONSABLE NO INSCRIPTO'),
	(3, 3, 'MONOTRIBUTISTA'),
	(4, 4, 'EXENTO'),
	(5, 5, 'SIN SITUACION ANTE EL IVA');
/*!40000 ALTER TABLE "CategoriaAFIP" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.CondicionPago
CREATE TABLE IF NOT EXISTS "CondicionPago" (
	"Id" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.CondicionPago: -1 rows
/*!40000 ALTER TABLE "CondicionPago" DISABLE KEYS */;
INSERT INTO "CondicionPago" ("Id", "Nombre") VALUES
	(1, 'Contado'),
	(2, 'Cuenta Corriente'),
	(3, 'Cheque'),
	(4, 'Tarjeta');
/*!40000 ALTER TABLE "CondicionPago" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.Cuenta
CREATE TABLE IF NOT EXISTS "Cuenta" (
	"IdCuenta" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(200) NOT NULL,
	"NombreFantasia" VARCHAR(200) NULL DEFAULT NULL,
	"IdCategoriaAFIP" INT(10,0) NOT NULL,
	"IdTipoDocumento" INT(10,0) NOT NULL,
	"NroDocumento" VARCHAR(13) NULL DEFAULT NULL,
	"NroIngresosBrutos" VARCHAR(14) NULL DEFAULT NULL,
	"IdLocalidad" INT(10,0) NULL DEFAULT NULL,
	"Domicilio" VARCHAR(200) NULL DEFAULT NULL,
	"NroDomicilio" INT(10,0) NULL DEFAULT NULL,
	"Piso" INT(10,0) NULL DEFAULT NULL,
	"Departamento" VARCHAR(5) NULL DEFAULT NULL,
	"Proveedor" BIT NULL DEFAULT NULL,
	"Mail" VARCHAR(100) NULL DEFAULT NULL,
	"Telefono" VARCHAR(20) NULL DEFAULT NULL,
	PRIMARY KEY ("IdCuenta")
);

-- Volcando datos para la tabla Cristina2.Cuenta: -1 rows
/*!40000 ALTER TABLE "Cuenta" DISABLE KEYS */;
INSERT INTO "Cuenta" ("IdCuenta", "Nombre", "NombreFantasia", "IdCategoriaAFIP", "IdTipoDocumento", "NroDocumento", "NroIngresosBrutos", "IdLocalidad", "Domicilio", "NroDomicilio", "Piso", "Departamento", "Proveedor", "Mail", "Telefono") VALUES
	(2, 'prueba', 'prueba', 5, 96, '31807935', '000000', 2410, 'sdfsdf', 2234324, 1, '1', 'True', 'asdgajhsgd', '093283802183'),
	(3, 'CEBALLOS ANIBAL JOSE', 'A & M TEXTIL', 1, 80, '20120925408', '9042420652', 2550, 'RIVERA INDARTE Y COLOMBIA', 0, 0, '0', 'True', 'aymtextil@fibertel.com.ar', '03537412400'),
	(9, 'VENECIA  ADOLFO ', 'ADIDAS', 4, 96, '11133356', '000', 3061, 'ITUZAINGO', 700, 0, '0', 'True', 'NO TIENE', '03537-15442274'),
	(12, 'prueba', 'prueba', 5, 96, '31807935', '111111', 2889, 'iadasd', 987, 0, '0', 'False', 'dfghj', '984375987345'),
	(13, 'Oscar Becerra', 'NUBECITA', 1, 80, '23050776484', '96801709', 2680, 'Jose Enrique Rodo', 5185, 0, '0', 'True', 'www.nubecita.com.arr', '01146827667'),
	(14, 'MARENGO MARIA LAURA', 'ALGABO DAYLOPLAS', 1, 80, '27245851419', '281463781', 3279, 'PASAJESANTA LUCIA', 685, 0, '0', 'True', 'santaluciadeposito@gmail.com', '0353-4535746'),
	(15, 'CERROLAZA  JORGE L', 'DISTRIBUIDOR TEXTIL', 1, 80, '23208044729', '215384098', 3279, 'LEOPOLDO LUGONES ', 200, 0, '0', 'True', '0', '035345323130');
/*!40000 ALTER TABLE "Cuenta" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.DetalleMovimientoCV
CREATE TABLE IF NOT EXISTS "DetalleMovimientoCV" (
	"Id" INT(10,0) NOT NULL,
	"claveMov" INT(10,0) NOT NULL,
	"IdArticulo" INT(10,0) NOT NULL,
	"Cantidad" INT(10,0) NOT NULL,
	"PrecioUnitario" DECIMAL(12,4) NOT NULL,
	"ImporteSubTotal" DECIMAL(12,4) NOT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.DetalleMovimientoCV: -1 rows
/*!40000 ALTER TABLE "DetalleMovimientoCV" DISABLE KEYS */;
INSERT INTO "DetalleMovimientoCV" ("Id", "claveMov", "IdArticulo", "Cantidad", "PrecioUnitario", "ImporteSubTotal") VALUES
	(1, 1, 20, 1, 0, 0),
	(2, 2, 21, 1, 110, 110);
/*!40000 ALTER TABLE "DetalleMovimientoCV" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.Empresas
CREATE TABLE IF NOT EXISTS "Empresas" (
	"Id" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(200) NOT NULL,
	"NombreFantasia" VARCHAR(200) NULL DEFAULT NULL,
	"CUIT" VARCHAR(13) NULL DEFAULT NULL,
	"IngresosBrutos" VARCHAR(14) NULL DEFAULT NULL,
	"InicioActividad" DATE(0) NULL DEFAULT NULL,
	"IdCategoriaAFIP" INT(10,0) NOT NULL,
	"Logo" IMAGE(2147483647) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.Empresas: -1 rows
/*!40000 ALTER TABLE "Empresas" DISABLE KEYS */;
INSERT INTO "Empresas" ("Id", "Nombre", "NombreFantasia", "CUIT", "IngresosBrutos", "InicioActividad", "IdCategoriaAFIP", "Logo") VALUES
	(1, 'Peralta Cristina Maribel', 'Crisma', '27-29922194-1', '281491838', '2015-08-01', 3, NULL),
	(2, 'Peralta Cristina Maribel', 'Crisma  de Todo un Poco...', '27-29922194-1', '281491838', '2015-08-01', 3, NULL),
	(3, 'Peralta Cristina Maribel', 'Crisma De Todo Un Poco...', '27-29922194-1', '281491838', '2015-08-01', 3, NULL);
/*!40000 ALTER TABLE "Empresas" ENABLE KEYS */;


-- Volcando estructura para función Cristina2.fATabla
DELIMITER //
CREATE FUNCTION [dbo].[fATabla](@Parametro varchar(8000))

RETURNS @Temp1 TABLE  (Valor Int)
AS
BEGIN 

	declare @StrValor Varchar(1000)
	declare @TA TABLE  (Valor Int)
	declare @X int
	declare @Y int
	declare @Z int
	declare @T int

	set @StrValor = @Parametro
 
	--print  @StrValor 

	set @X=0
	set @Y=0
	set @Z=0

	--drop table Temp1

	--CREATE TABLE Temp1 (Valor Int)

	while @X <=len(@StrValor) 
	begin
		set @X=@X+1
		if (Right(left(@StrValor,@X),1) =',')
		begin
			set 	@Y=@X
			insert into  @TA Values (CONVERT(INT ,Right(left(@StrValor,@Y-1),(@Y-@Z))))
			--print Right(left(@StrValor,@Y-1),(@Y-@Z))
			set 	@Z=@Y+1
		end
	end
	--print Right(left(@StrValor,@X),(@X-@Z))
	insert into  @TA Values (CONVERT(INT ,Right(left(@StrValor,@X),(@X-@Z))))

	INSERT @Temp1
	SELECT Valor
	FROM @TA
	return
END
//
DELIMITER ;


-- Volcando estructura para tabla Cristina2.Impresoras
CREATE TABLE IF NOT EXISTS "Impresoras" (
	"Id" INT(10,0) NOT NULL,
	"Estacion" VARCHAR(50) NULL DEFAULT NULL,
	"IdTipoComprobante" INT(10,0) NULL DEFAULT NULL,
	"Impresora" VARCHAR(150) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.Impresoras: -1 rows
/*!40000 ALTER TABLE "Impresoras" DISABLE KEYS */;
/*!40000 ALTER TABLE "Impresoras" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.Localidad
CREATE TABLE IF NOT EXISTS "Localidad" (
	"Id" INT(10,0) NOT NULL,
	"IdProvincia" INT(10,0) NULL DEFAULT NULL,
	"Nombre" VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.Localidad: -1 rows
/*!40000 ALTER TABLE "Localidad" DISABLE KEYS */;
INSERT INTO "Localidad" ("Id", "IdProvincia", "Nombre") VALUES
	(2383, 1, '25 de Mayo'),
	(2384, 1, '3 de febrero'),
	(2385, 1, 'A. Alsina'),
	(2386, 1, 'A. Gonzßles Chßves'),
	(2387, 1, 'Aguas Verdes'),
	(2388, 1, 'Alberti'),
	(2389, 1, 'Arrecifes'),
	(2390, 1, 'Ayacucho'),
	(2391, 1, 'Azul'),
	(2392, 1, 'BahÝa Blanca'),
	(2393, 1, 'Balcarce'),
	(2394, 1, 'Baradero'),
	(2395, 1, 'Benito Jußrez'),
	(2396, 1, 'Berisso'),
	(2397, 1, 'BolÝvar'),
	(2398, 1, 'Bragado'),
	(2399, 1, 'Brandsen'),
	(2400, 1, 'Campana'),
	(2401, 1, 'Ca±uelas'),
	(2402, 1, 'Capilla del Se±or'),
	(2403, 1, 'Capitßn Sarmiento'),
	(2404, 1, 'Carapachay'),
	(2405, 1, 'Carhue'),
	(2406, 1, 'Caril¾'),
	(2407, 1, 'Carlos Casares'),
	(2408, 1, 'Carlos Tejedor'),
	(2409, 1, 'Carmen de Areco'),
	(2410, 1, 'Carmen de Patagones'),
	(2411, 1, 'Castelli'),
	(2412, 1, 'Chacabuco'),
	(2413, 1, 'Chascom·s'),
	(2414, 1, 'Chivilcoy'),
	(2415, 1, 'Col¾n'),
	(2416, 1, 'Coronel Dorrego'),
	(2417, 1, 'Coronel Pringles'),
	(2418, 1, 'Coronel Rosales'),
	(2419, 1, 'Coronel Suarez'),
	(2420, 1, 'Costa Azul'),
	(2421, 1, 'Costa Chica'),
	(2422, 1, 'Costa del Este'),
	(2423, 1, 'Costa Esmeralda'),
	(2424, 1, 'Daireaux'),
	(2425, 1, 'Darregueira'),
	(2426, 1, 'Del Viso'),
	(2427, 1, 'Dolores'),
	(2428, 1, 'Don Torcuato'),
	(2429, 1, 'Ensenada'),
	(2430, 1, 'Escobar'),
	(2431, 1, 'Exaltaci¾n de la Cruz'),
	(2432, 1, 'Florentino Ameghino'),
	(2433, 1, 'GarÝn'),
	(2434, 1, 'Gral. Alvarado'),
	(2435, 1, 'Gral. Alvear'),
	(2436, 1, 'Gral. Arenales'),
	(2437, 1, 'Gral. Belgrano'),
	(2438, 1, 'Gral. Guido'),
	(2439, 1, 'Gral. Lamadrid'),
	(2440, 1, 'Gral. Las Heras'),
	(2441, 1, 'Gral. Lavalle'),
	(2442, 1, 'Gral. Madariaga'),
	(2443, 1, 'Gral. Pacheco'),
	(2444, 1, 'Gral. Paz'),
	(2445, 1, 'Gral. Pinto'),
	(2446, 1, 'Gral. Pueyrred¾n'),
	(2447, 1, 'Gral. RodrÝguez'),
	(2448, 1, 'Gral. Viamonte'),
	(2449, 1, 'Gral. Villegas'),
	(2450, 1, 'GuaminÝ'),
	(2451, 1, 'Guernica'),
	(2452, 1, 'Hip¾lito Yrigoyen'),
	(2453, 1, 'Ing. Maschwitz'),
	(2454, 1, 'JunÝn'),
	(2455, 1, 'La Plata'),
	(2456, 1, 'Laprida'),
	(2457, 1, 'Las Flores'),
	(2458, 1, 'Las Toninas'),
	(2459, 1, 'Leandro N. Alem'),
	(2460, 1, 'Lincoln'),
	(2461, 1, 'Loberia'),
	(2462, 1, 'Lobos'),
	(2463, 1, 'Los Cardales'),
	(2464, 1, 'Los Toldos'),
	(2465, 1, 'Lucila del Mar'),
	(2466, 1, 'Lujßn'),
	(2467, 1, 'Magdalena'),
	(2468, 1, 'Maip·'),
	(2469, 1, 'Mar Chiquita'),
	(2470, 1, 'Mar de Aj¾'),
	(2471, 1, 'Mar de las Pampas'),
	(2472, 1, 'Mar del Plata'),
	(2473, 1, 'Mar del Tuy·'),
	(2474, 1, 'Marcos Paz'),
	(2475, 1, 'Mercedes'),
	(2476, 1, 'Miramar'),
	(2477, 1, 'Monte'),
	(2478, 1, 'Monte Hermoso'),
	(2479, 1, 'Munro'),
	(2480, 1, 'Navarro'),
	(2481, 1, 'Necochea'),
	(2482, 1, 'OlavarrÝa'),
	(2483, 1, 'Partido de la Costa'),
	(2484, 1, 'Pehuaj¾'),
	(2485, 1, 'Pellegrini'),
	(2486, 1, 'Pergamino'),
	(2487, 1, 'Pig³Ú'),
	(2488, 1, 'Pila'),
	(2489, 1, 'Pilar'),
	(2490, 1, 'Pinamar'),
	(2491, 1, 'Pinar del Sol'),
	(2492, 1, 'Polvorines'),
	(2493, 1, 'Pte. Per¾n'),
	(2494, 1, 'Pußn'),
	(2495, 1, 'Punta Indio'),
	(2496, 1, 'Ramallo'),
	(2497, 1, 'Rauch'),
	(2498, 1, 'Rivadavia'),
	(2499, 1, 'Rojas'),
	(2500, 1, 'Roque PÚrez'),
	(2501, 1, 'Saavedra'),
	(2502, 1, 'Saladillo'),
	(2503, 1, 'Salliquel¾'),
	(2504, 1, 'Salto'),
	(2505, 1, 'San AndrÚs de Giles'),
	(2506, 1, 'San Antonio de Areco'),
	(2507, 1, 'San Antonio de Padua'),
	(2508, 1, 'San Bernardo'),
	(2509, 1, 'San Cayetano'),
	(2510, 1, 'San Clemente del Tuy·'),
	(2511, 1, 'San Nicolßs'),
	(2512, 1, 'San Pedro'),
	(2513, 1, 'San Vicente'),
	(2514, 1, 'Santa Teresita'),
	(2515, 1, 'Suipacha'),
	(2516, 1, 'Tandil'),
	(2517, 1, 'TapalquÚ'),
	(2518, 1, 'Tordillo'),
	(2519, 1, 'Tornquist'),
	(2520, 1, 'Trenque Lauquen'),
	(2521, 1, 'Tres Lomas'),
	(2522, 1, 'Villa Gesell'),
	(2523, 1, 'Villarino'),
	(2524, 1, 'Zßrate'),
	(2525, 2, '11 de Septiembre'),
	(2526, 2, '20 de Junio'),
	(2527, 2, '25 de Mayo'),
	(2528, 2, 'Acassuso'),
	(2529, 2, 'AdroguÚ'),
	(2530, 2, 'Aldo Bonzi'),
	(2531, 2, '-rea Reserva Cintur¾n Ecol¾gico'),
	(2532, 2, 'Avellaneda'),
	(2533, 2, 'Banfield'),
	(2534, 2, 'Barrio Parque'),
	(2535, 2, 'Barrio Santa Teresita'),
	(2536, 2, 'Beccar'),
	(2537, 2, 'Bella Vista'),
	(2538, 2, 'Berazategui'),
	(2539, 2, 'Bernal Este'),
	(2540, 2, 'Bernal Oeste'),
	(2541, 2, 'Billinghurst'),
	(2542, 2, 'Boulogne'),
	(2543, 2, 'Burzaco'),
	(2544, 2, 'Carapachay'),
	(2545, 2, 'Caseros'),
	(2546, 2, 'Castelar'),
	(2547, 2, 'Churruca'),
	(2548, 2, 'Ciudad Evita'),
	(2549, 2, 'Ciudad Madero'),
	(2550, 2, 'Ciudadela'),
	(2551, 2, 'Claypole'),
	(2552, 2, 'Crucecita'),
	(2553, 2, 'Dock Sud'),
	(2554, 2, 'Don Bosco'),
	(2555, 2, 'Don Orione'),
	(2556, 2, 'El Jag³el'),
	(2557, 2, 'El Libertador'),
	(2558, 2, 'El Palomar'),
	(2559, 2, 'El Tala'),
	(2560, 2, 'El TrÚbol'),
	(2561, 2, 'Ezeiza'),
	(2562, 2, 'Ezpeleta'),
	(2563, 2, 'Florencio Varela'),
	(2564, 2, 'Florida'),
	(2565, 2, 'Francisco -lvarez'),
	(2566, 2, 'Gerli'),
	(2567, 2, 'Glew'),
	(2568, 2, 'Gonzßlez Catßn'),
	(2569, 2, 'Gral. Lamadrid'),
	(2570, 2, 'Grand Bourg'),
	(2571, 2, 'Gregorio de Laferrere'),
	(2572, 2, 'Guillermo Enrique Hudson'),
	(2573, 2, 'Haedo'),
	(2574, 2, 'Hurlingham'),
	(2575, 2, 'Ing. Sourdeaux'),
	(2576, 2, 'Isidro Casanova'),
	(2577, 2, 'Ituzaing¾'),
	(2578, 2, 'JosÚ C. Paz'),
	(2579, 2, 'JosÚ Ingenieros'),
	(2580, 2, 'JosÚ Marmol'),
	(2581, 2, 'La Lucila'),
	(2582, 2, 'La Reja'),
	(2583, 2, 'La Tablada'),
	(2584, 2, 'Lan·s'),
	(2585, 2, 'Llavallol'),
	(2586, 2, 'Loma Hermosa'),
	(2587, 2, 'Lomas de Zamora'),
	(2588, 2, 'Lomas del Mill¾n'),
	(2589, 2, 'Lomas del Mirador'),
	(2590, 2, 'Longchamps'),
	(2591, 2, 'Los Polvorines'),
	(2592, 2, 'Luis Guill¾n'),
	(2593, 2, 'Malvinas Argentinas'),
	(2594, 2, 'MartÝn Coronado'),
	(2595, 2, 'MartÝnez'),
	(2596, 2, 'Merlo'),
	(2597, 2, 'Ministro Rivadavia'),
	(2598, 2, 'Monte Chingolo'),
	(2599, 2, 'Monte Grande'),
	(2600, 2, 'Moreno'),
	(2601, 2, 'Mor¾n'),
	(2602, 2, 'Mu±iz'),
	(2603, 2, 'Olivos'),
	(2604, 2, 'Pablo NoguÚs'),
	(2605, 2, 'Pablo Podestß'),
	(2606, 2, 'Paso del Rey'),
	(2607, 2, 'Pereyra'),
	(2608, 2, 'Pi±eiro'),
	(2609, 2, 'Plßtanos'),
	(2610, 2, 'Pontevedra'),
	(2611, 2, 'Quilmes'),
	(2612, 2, 'Rafael Calzada'),
	(2613, 2, 'Rafael Castillo'),
	(2614, 2, 'Ramos MejÝa'),
	(2615, 2, 'Ranelagh'),
	(2616, 2, 'Remedios de Escalada'),
	(2617, 2, 'Sßenz Pe±a'),
	(2618, 2, 'San Antonio de Padua'),
	(2619, 2, 'San Fernando'),
	(2620, 2, 'San Francisco Solano'),
	(2621, 2, 'San Isidro'),
	(2622, 2, 'San JosÚ'),
	(2623, 2, 'San Justo'),
	(2624, 2, 'San MartÝn'),
	(2625, 2, 'San Miguel'),
	(2626, 2, 'Santos Lugares'),
	(2627, 2, 'SarandÝ'),
	(2628, 2, 'Sourigues'),
	(2629, 2, 'Tapiales'),
	(2630, 2, 'Temperley'),
	(2631, 2, 'Tigre'),
	(2632, 2, 'Tortuguitas'),
	(2633, 2, 'Tristßn Sußrez'),
	(2634, 2, 'Trujui'),
	(2635, 2, 'Turdera'),
	(2636, 2, 'ValentÝn Alsina'),
	(2637, 2, 'Vicente L¾pez'),
	(2638, 2, 'Villa Adelina'),
	(2639, 2, 'Villa Ballester'),
	(2640, 2, 'Villa Bosch'),
	(2641, 2, 'Villa Caraza'),
	(2642, 2, 'Villa Celina'),
	(2643, 2, 'Villa Centenario'),
	(2644, 2, 'Villa de Mayo'),
	(2645, 2, 'Villa Diamante'),
	(2646, 2, 'Villa DomÝnico'),
	(2647, 2, 'Villa Espa±a'),
	(2648, 2, 'Villa Fiorito'),
	(2649, 2, 'Villa Guillermina'),
	(2650, 2, 'Villa Insuperable'),
	(2651, 2, 'Villa JosÚ Le¾n Sußrez'),
	(2652, 2, 'Villa La Florida'),
	(2653, 2, 'Villa Luzuriaga'),
	(2654, 2, 'Villa Martelli'),
	(2655, 2, 'Villa Obrera'),
	(2656, 2, 'Villa Progreso'),
	(2657, 2, 'Villa Raffo'),
	(2658, 2, 'Villa Sarmiento'),
	(2659, 2, 'Villa Tesei'),
	(2660, 2, 'Villa Udaondo'),
	(2661, 2, 'Virrey del Pino'),
	(2662, 2, 'Wilde'),
	(2663, 2, 'William Morris'),
	(2664, 3, 'AgronomÝa'),
	(2665, 3, 'Almagro'),
	(2666, 3, 'Balvanera'),
	(2667, 3, 'Barracas'),
	(2668, 3, 'Belgrano'),
	(2669, 3, 'Boca'),
	(2670, 3, 'Boedo'),
	(2671, 3, 'Caballito'),
	(2672, 3, 'Chacarita'),
	(2673, 3, 'Coghlan'),
	(2674, 3, 'Colegiales'),
	(2675, 3, 'Constituci¾n'),
	(2676, 3, 'Flores'),
	(2677, 3, 'Floresta'),
	(2678, 3, 'La Paternal'),
	(2679, 3, 'Liniers'),
	(2680, 3, 'Mataderos'),
	(2681, 3, 'Monserrat'),
	(2682, 3, 'Monte Castro'),
	(2683, 3, 'Nueva Pompeya'),
	(2684, 3, 'N·±ez'),
	(2685, 3, 'Palermo'),
	(2686, 3, 'Parque Avellaneda'),
	(2687, 3, 'Parque Chacabuco'),
	(2688, 3, 'Parque Chas'),
	(2689, 3, 'Parque Patricios'),
	(2690, 3, 'Puerto Madero'),
	(2691, 3, 'Recoleta'),
	(2692, 3, 'Retiro'),
	(2693, 3, 'Saavedra'),
	(2694, 3, 'San Crist¾bal'),
	(2695, 3, 'San Nicolßs'),
	(2696, 3, 'San Telmo'),
	(2697, 3, 'VÚlez Sßrsfield'),
	(2698, 3, 'Versalles'),
	(2699, 3, 'Villa Crespo'),
	(2700, 3, 'Villa del Parque'),
	(2701, 3, 'Villa Devoto'),
	(2702, 3, 'Villa Gral. Mitre'),
	(2703, 3, 'Villa Lugano'),
	(2704, 3, 'Villa Luro'),
	(2705, 3, 'Villa Ort·zar'),
	(2706, 3, 'Villa Pueyrred¾n'),
	(2707, 3, 'Villa Real'),
	(2708, 3, 'Villa Riachuelo'),
	(2709, 3, 'Villa Santa Rita'),
	(2710, 3, 'Villa Soldati'),
	(2711, 3, 'Villa Urquiza'),
	(2712, 4, 'Aconquija'),
	(2713, 4, 'Ancasti'),
	(2714, 4, 'Andalgalß'),
	(2715, 4, 'Antofagasta'),
	(2716, 4, 'BelÚn'),
	(2717, 4, 'Capayßn'),
	(2718, 4, 'Capital'),
	(2719, 4, '4'),
	(2720, 4, 'Corral Quemado'),
	(2721, 4, 'El Alto'),
	(2722, 4, 'El Rodeo'),
	(2723, 4, 'F.Mamerto Esqui·'),
	(2724, 4, 'Fiambalß'),
	(2725, 4, 'HualfÝn'),
	(2726, 4, 'Huillapima'),
	(2727, 4, 'Ica±o'),
	(2728, 4, 'La Puerta'),
	(2729, 4, 'Las Juntas'),
	(2730, 4, 'Londres'),
	(2731, 4, 'Los Altos'),
	(2732, 4, 'Los Varela'),
	(2733, 4, 'MutquÝn'),
	(2734, 4, 'PaclÝn'),
	(2735, 4, 'Poman'),
	(2736, 4, 'Pozo de La Piedra'),
	(2737, 4, 'Puerta de Corral'),
	(2738, 4, 'Puerta San JosÚ'),
	(2739, 4, 'Recreo'),
	(2740, 4, 'S.F.V de 4'),
	(2741, 4, 'San Fernando'),
	(2742, 4, 'San Fernando del Valle'),
	(2743, 4, 'San JosÚ'),
	(2744, 4, 'Santa MarÝa'),
	(2745, 4, 'Santa Rosa'),
	(2746, 4, 'Saujil'),
	(2747, 4, 'Tapso'),
	(2748, 4, 'Tinogasta'),
	(2749, 4, 'Valle Viejo'),
	(2750, 4, 'Villa Vil'),
	(2751, 5, 'Aviß TeraÝ'),
	(2752, 5, 'Barranqueras'),
	(2753, 5, 'Basail'),
	(2754, 5, 'Campo Largo'),
	(2755, 5, 'Capital'),
	(2756, 5, 'Capitßn Solari'),
	(2757, 5, 'Charadai'),
	(2758, 5, 'Charata'),
	(2759, 5, 'Chorotis'),
	(2760, 5, 'Ciervo Petiso'),
	(2761, 5, 'Cnel. Du Graty'),
	(2762, 5, 'Col. BenÝtez'),
	(2763, 5, 'Col. Elisa'),
	(2764, 5, 'Col. Popular'),
	(2765, 5, 'Colonias Unidas'),
	(2766, 5, 'Concepci¾n'),
	(2767, 5, 'Corzuela'),
	(2768, 5, 'Cote Lai'),
	(2769, 5, 'El Sauzalito'),
	(2770, 5, 'Enrique Urien'),
	(2771, 5, 'Fontana'),
	(2772, 5, 'Fte. Esperanza'),
	(2773, 5, 'Gancedo'),
	(2774, 5, 'Gral. Capdevila'),
	(2775, 5, 'Gral. Pinero'),
	(2776, 5, 'Gral. San MartÝn'),
	(2777, 5, 'Gral. Vedia'),
	(2778, 5, 'Hermoso Campo'),
	(2779, 5, 'I. del Cerrito'),
	(2780, 5, 'J.J. Castelli'),
	(2781, 5, 'La Clotilde'),
	(2782, 5, 'La Eduvigis'),
	(2783, 5, 'La Escondida'),
	(2784, 5, 'La Leonesa'),
	(2785, 5, 'La Tigra'),
	(2786, 5, 'La Verde'),
	(2787, 5, 'Laguna Blanca'),
	(2788, 5, 'Laguna Limpia'),
	(2789, 5, 'Lapachito'),
	(2790, 5, 'Las Bre±as'),
	(2791, 5, 'Las Garcitas'),
	(2792, 5, 'Las Palmas'),
	(2793, 5, 'Los Frentones'),
	(2794, 5, 'Machagai'),
	(2795, 5, 'MakallÚ'),
	(2796, 5, 'Margarita BelÚn'),
	(2797, 5, 'Miraflores'),
	(2798, 5, 'Misi¾n N. Pompeya'),
	(2799, 5, 'Napenay'),
	(2800, 5, 'Pampa Almir¾n'),
	(2801, 5, 'Pampa del Indio'),
	(2802, 5, 'Pampa del Infierno'),
	(2803, 5, 'Pdcia. de La Plaza'),
	(2804, 5, 'Pdcia. Roca'),
	(2805, 5, 'Pdcia. Roque Sßenz Pe±a'),
	(2806, 5, 'Pto. Bermejo'),
	(2807, 5, 'Pto. Eva Per¾n'),
	(2808, 5, 'Puero Tirol'),
	(2809, 5, 'Puerto Vilelas'),
	(2810, 5, 'Quitilipi'),
	(2811, 5, 'Resistencia'),
	(2812, 5, 'Sßenz Pe±a'),
	(2813, 5, 'Samuh·'),
	(2814, 5, 'San Bernardo'),
	(2815, 5, 'Santa Sylvina'),
	(2816, 5, 'Taco Pozo'),
	(2817, 5, 'Tres Isletas'),
	(2818, 5, 'Villa -ngela'),
	(2819, 5, 'Villa Berthet'),
	(2820, 5, 'Villa R. Bermejito'),
	(2821, 6, 'Aldea Apeleg'),
	(2822, 6, 'Aldea Beleiro'),
	(2823, 6, 'Aldea Epulef'),
	(2824, 6, 'Alto RÝo Sengerr'),
	(2825, 6, 'Buen Pasto'),
	(2826, 6, 'Camarones'),
	(2827, 6, 'Carrenleuf·'),
	(2828, 6, 'Cholila'),
	(2829, 6, 'Co. Centinela'),
	(2830, 6, 'Colan ConhuÚ'),
	(2831, 6, 'Comodoro Rivadavia'),
	(2832, 6, 'Corcovado'),
	(2833, 6, 'Cushamen'),
	(2834, 6, 'Dique F. Ameghino'),
	(2835, 6, 'Dolav¾n'),
	(2836, 6, 'Dr. R. Rojas'),
	(2837, 6, 'El Hoyo'),
	(2838, 6, 'El MaitÚn'),
	(2839, 6, 'EpuyÚn'),
	(2840, 6, 'Esquel'),
	(2841, 6, 'Facundo'),
	(2842, 6, 'Gaimßn'),
	(2843, 6, 'Gan Gan'),
	(2844, 6, 'Gastre'),
	(2845, 6, 'Gdor. Costa'),
	(2846, 6, 'Gualjaina'),
	(2847, 6, 'J. de San MartÝn'),
	(2848, 6, 'Lago Blanco'),
	(2849, 6, 'Lago Puelo'),
	(2850, 6, 'Lagunita Salada'),
	(2851, 6, 'Las Plumas'),
	(2852, 6, 'Los Altares'),
	(2853, 6, 'Paso de los Indios'),
	(2854, 6, 'Paso del Sapo'),
	(2855, 6, 'Pto. Madryn'),
	(2856, 6, 'Pto. Pirßmides'),
	(2857, 6, 'Rada Tilly'),
	(2858, 6, 'Rawson'),
	(2859, 6, 'RÝo Mayo'),
	(2860, 6, 'RÝo Pico'),
	(2861, 6, 'Sarmiento'),
	(2862, 6, 'Tecka'),
	(2863, 6, 'Telsen'),
	(2864, 6, 'Trelew'),
	(2865, 6, 'Trevelin'),
	(2866, 6, 'Veintiocho de Julio'),
	(2867, 7, 'Achiras'),
	(2868, 7, 'Adelia Maria'),
	(2869, 7, 'Agua de Oro'),
	(2870, 7, 'Alcira Gigena'),
	(2871, 7, 'Aldea Santa Maria'),
	(2872, 7, 'Alejandro Roca'),
	(2873, 7, 'Alejo Ledesma'),
	(2874, 7, 'Alicia'),
	(2875, 7, 'Almafuerte'),
	(2876, 7, 'Alpa Corral'),
	(2877, 7, 'Alta Gracia'),
	(2878, 7, 'Alto Alegre'),
	(2879, 7, 'Alto de Los Quebrachos'),
	(2880, 7, 'Altos de Chipion'),
	(2881, 7, 'Amboy'),
	(2882, 7, 'Ambul'),
	(2883, 7, 'Ana Zumaran'),
	(2884, 7, 'Anisacate'),
	(2885, 7, 'Arguello'),
	(2886, 7, 'Arias'),
	(2887, 7, 'Arroyito'),
	(2888, 7, 'Arroyo Algodon'),
	(2889, 7, 'Arroyo Cabral'),
	(2890, 7, 'Arroyo Los Patos'),
	(2891, 7, 'Assunta'),
	(2892, 7, 'Atahona'),
	(2893, 7, 'Ausonia'),
	(2894, 7, 'Avellaneda'),
	(2895, 7, 'Ballesteros'),
	(2896, 7, 'Ballesteros Sud'),
	(2897, 7, 'Balnearia'),
	(2898, 7, 'Ba±ado de Soto'),
	(2899, 7, 'Bell Ville'),
	(2900, 7, 'Bengolea'),
	(2901, 7, 'Benjamin Gould'),
	(2902, 7, 'Berrotaran'),
	(2903, 7, 'Bialet Masse'),
	(2904, 7, 'Bouwer'),
	(2905, 7, 'Brinkmann'),
	(2906, 7, 'Buchardo'),
	(2907, 7, 'Bulnes'),
	(2908, 7, 'Cabalango'),
	(2909, 7, 'Calamuchita'),
	(2910, 7, 'Calchin'),
	(2911, 7, 'Calchin Oeste'),
	(2912, 7, 'Calmayo'),
	(2913, 7, 'Camilo Aldao'),
	(2914, 7, 'Caminiaga'),
	(2915, 7, 'Ca±ada de Luque'),
	(2916, 7, 'Ca±ada de Machado'),
	(2917, 7, 'Ca±ada de Rio Pinto'),
	(2918, 7, 'Ca±ada del Sauce'),
	(2919, 7, 'Canals'),
	(2920, 7, 'Candelaria Sud'),
	(2921, 7, 'Capilla de Remedios'),
	(2922, 7, 'Capilla de Siton'),
	(2923, 7, 'Capilla del Carmen'),
	(2924, 7, 'Capilla del Monte'),
	(2925, 7, 'Cordoba'),
	(2926, 7, 'Capitan Gral B. O¦Higgins'),
	(2927, 7, 'Carnerillo'),
	(2928, 7, 'Carrilobo'),
	(2929, 7, 'Casa Grande'),
	(2930, 7, 'Cavanagh'),
	(2931, 7, 'Cerro Colorado'),
	(2932, 7, 'Chajßn'),
	(2933, 7, 'Chalacea'),
	(2934, 7, 'Cha±ar Viejo'),
	(2935, 7, 'ChancanÝ'),
	(2936, 7, 'Charbonier'),
	(2937, 7, 'Charras'),
	(2938, 7, 'Chaz¾n'),
	(2939, 7, 'Chilibroste'),
	(2940, 7, 'Chucul'),
	(2941, 7, 'Chu±a'),
	(2942, 7, 'Chu±a Huasi'),
	(2943, 7, 'Churqui Ca±ada'),
	(2944, 7, 'Cienaga Del Coro'),
	(2945, 7, 'Cintra'),
	(2946, 7, 'Col. Almada'),
	(2947, 7, 'Col. Anita'),
	(2948, 7, 'Col. Barge'),
	(2949, 7, 'Col. Bismark'),
	(2950, 7, 'Col. Bremen'),
	(2951, 7, 'Col. Caroya'),
	(2952, 7, 'Col. Italiana'),
	(2953, 7, 'Col. Iturraspe'),
	(2954, 7, 'Col. Las Cuatro Esquinas'),
	(2955, 7, 'Col. Las Pichanas'),
	(2956, 7, 'Col. Marina'),
	(2957, 7, 'Col. Prosperidad'),
	(2958, 7, 'Col. San Bartolome'),
	(2959, 7, 'Col. San Pedro'),
	(2960, 7, 'Col. Tirolesa'),
	(2961, 7, 'Col. Vicente Aguero'),
	(2962, 7, 'Col. Videla'),
	(2963, 7, 'Col. Vignaud'),
	(2964, 7, 'Col. Waltelina'),
	(2965, 7, 'Colazo'),
	(2966, 7, 'Comechingones'),
	(2967, 7, 'Conlara'),
	(2968, 7, 'Copacabana'),
	(2969, 7, '7'),
	(2970, 7, 'Coronel Baigorria'),
	(2971, 7, 'Coronel Moldes'),
	(2972, 7, 'Corral de Bustos'),
	(2973, 7, 'Corralito'),
	(2974, 7, 'CosquÝn'),
	(2975, 7, 'Costa Sacate'),
	(2976, 7, 'Cruz Alta'),
	(2977, 7, 'Cruz de Ca±a'),
	(2978, 7, 'Cruz del Eje'),
	(2979, 7, 'Cuesta Blanca'),
	(2980, 7, 'Dean Funes'),
	(2981, 7, 'Del Campillo'),
	(2982, 7, 'Despe±aderos'),
	(2983, 7, 'Devoto'),
	(2984, 7, 'Diego de Rojas'),
	(2985, 7, 'Dique Chico'),
	(2986, 7, 'El Ara±ado'),
	(2987, 7, 'El Brete'),
	(2988, 7, 'El Chacho'),
	(2989, 7, 'El CrispÝn'),
	(2990, 7, 'El FortÝn'),
	(2991, 7, 'El Manzano'),
	(2992, 7, 'El Rastreador'),
	(2993, 7, 'El Rodeo'),
	(2994, 7, 'El TÝo'),
	(2995, 7, 'Elena'),
	(2996, 7, 'Embalse'),
	(2997, 7, 'Esquina'),
	(2998, 7, 'Estaci¾n Gral. Paz'),
	(2999, 7, 'Estaci¾n Jußrez Celman'),
	(3000, 7, 'Estancia de Guadalupe'),
	(3001, 7, 'Estancia Vieja'),
	(3002, 7, 'Etruria'),
	(3003, 7, 'Eufrasio Loza'),
	(3004, 7, 'Falda del Carmen'),
	(3005, 7, 'Freyre'),
	(3006, 7, 'Gral. Baldissera'),
	(3007, 7, 'Gral. Cabrera'),
	(3008, 7, 'Gral. Deheza'),
	(3009, 7, 'Gral. Fotheringham'),
	(3010, 7, 'Gral. Levalle'),
	(3011, 7, 'Gral. Roca'),
	(3012, 7, 'Guanaco Muerto'),
	(3013, 7, 'Guasapampa'),
	(3014, 7, 'Guatimozin'),
	(3015, 7, 'Gutenberg'),
	(3016, 7, 'Hernando'),
	(3017, 7, 'Huanchillas'),
	(3018, 7, 'Huerta Grande'),
	(3019, 7, 'Huinca Renanco'),
	(3020, 7, 'Idiazabal'),
	(3021, 7, 'Impira'),
	(3022, 7, 'Inriville'),
	(3023, 7, 'Isla Verde'),
	(3024, 7, 'Ital¾'),
	(3025, 7, 'James Craik'),
	(3026, 7, 'Jes·s MarÝa'),
	(3027, 7, 'Jovita'),
	(3028, 7, 'Justiniano Posse'),
	(3029, 7, 'Km 658'),
	(3030, 7, 'L. V. Mansilla'),
	(3031, 7, 'La Batea'),
	(3032, 7, 'La Calera'),
	(3033, 7, 'La Carlota'),
	(3034, 7, 'La Carolina'),
	(3035, 7, 'La Cautiva'),
	(3036, 7, 'La Cesira'),
	(3037, 7, 'La Cruz'),
	(3038, 7, 'La Cumbre'),
	(3039, 7, 'La Cumbrecita'),
	(3040, 7, 'La Falda'),
	(3041, 7, 'La Francia'),
	(3042, 7, 'La Granja'),
	(3043, 7, 'La Higuera'),
	(3044, 7, 'La Laguna'),
	(3045, 7, 'La Paisanita'),
	(3046, 7, 'La Palestina'),
	(3047, 7, '12'),
	(3048, 7, 'La Paquita'),
	(3049, 7, 'La Para'),
	(3050, 7, 'La Paz'),
	(3051, 7, 'La Playa'),
	(3052, 7, 'La Playosa'),
	(3053, 7, 'La Poblaci¾n'),
	(3054, 7, 'La Posta'),
	(3055, 7, 'La Puerta'),
	(3056, 7, 'La Quinta'),
	(3057, 7, 'La Rancherita'),
	(3058, 7, 'La Rinconada'),
	(3059, 7, 'La Serranita'),
	(3060, 7, 'La Tordilla'),
	(3061, 7, 'Laborde'),
	(3062, 7, 'Laboulaye'),
	(3063, 7, 'Laguna Larga'),
	(3064, 7, 'Las Acequias'),
	(3065, 7, 'Las Albahacas'),
	(3066, 7, 'Las Arrias'),
	(3067, 7, 'Las Bajadas'),
	(3068, 7, 'Las Caleras'),
	(3069, 7, 'Las Calles'),
	(3070, 7, 'Las Ca±adas'),
	(3071, 7, 'Las Gramillas'),
	(3072, 7, 'Las Higueras'),
	(3073, 7, 'Las Isletillas'),
	(3074, 7, 'Las Junturas'),
	(3075, 7, 'Las Palmas'),
	(3076, 7, 'Las Pe±as'),
	(3077, 7, 'Las Pe±as Sud'),
	(3078, 7, 'Las Perdices'),
	(3079, 7, 'Las Playas'),
	(3080, 7, 'Las Rabonas'),
	(3081, 7, 'Las Saladas'),
	(3082, 7, 'Las Tapias'),
	(3083, 7, 'Las Varas'),
	(3084, 7, 'Las Varillas'),
	(3085, 7, 'Las Vertientes'),
	(3086, 7, 'Leguizam¾n'),
	(3087, 7, 'Leones'),
	(3088, 7, 'Los Cedros'),
	(3089, 7, 'Los Cerrillos'),
	(3090, 7, 'Los Cha±aritos (C.E)'),
	(3091, 7, 'Los Chanaritos (R.S)'),
	(3092, 7, 'Los Cisnes'),
	(3093, 7, 'Los Cocos'),
	(3094, 7, 'Los C¾ndores'),
	(3095, 7, 'Los Hornillos'),
	(3096, 7, 'Los Hoyos'),
	(3097, 7, 'Los Mistoles'),
	(3098, 7, 'Los Molinos'),
	(3099, 7, 'Los Pozos'),
	(3100, 7, 'Los Reartes'),
	(3101, 7, 'Los Surgentes'),
	(3102, 7, 'Los Talares'),
	(3103, 7, 'Los Zorros'),
	(3104, 7, 'Lozada'),
	(3105, 7, 'Luca'),
	(3106, 7, 'Luque'),
	(3107, 7, 'Luyaba'),
	(3108, 7, 'Malague±o'),
	(3109, 7, 'Malena'),
	(3110, 7, 'Malvinas Argentinas'),
	(3111, 7, 'Manfredi'),
	(3112, 7, 'Maquinista Gallini'),
	(3113, 7, 'Marcos Jußrez'),
	(3114, 7, 'Marull'),
	(3115, 7, 'Matorrales'),
	(3116, 7, 'Mattaldi'),
	(3117, 7, 'Mayu Sumaj'),
	(3118, 7, 'Media Naranja'),
	(3119, 7, 'Melo'),
	(3120, 7, 'Mendiolaza'),
	(3121, 7, 'Mi Granja'),
	(3122, 7, 'Mina Clavero'),
	(3123, 7, 'Miramar'),
	(3124, 7, 'Morrison'),
	(3125, 7, 'Morteros'),
	(3126, 7, 'Mte. Buey'),
	(3127, 7, 'Mte. Cristo'),
	(3128, 7, 'Mte. De Los Gauchos'),
	(3129, 7, 'Mte. Le±a'),
	(3130, 7, 'Mte. MaÝz'),
	(3131, 7, 'Mte. Ralo'),
	(3132, 7, 'Nicolßs Bruzone'),
	(3133, 7, 'Noetinger'),
	(3134, 7, 'Nono'),
	(3135, 7, 'Nueva 7'),
	(3136, 7, 'Obispo Trejo'),
	(3137, 7, 'Olaeta'),
	(3138, 7, 'Oliva'),
	(3139, 7, 'Olivares San Nicolßs'),
	(3140, 7, 'Onagolty'),
	(3141, 7, 'Oncativo'),
	(3142, 7, 'Ordo±ez'),
	(3143, 7, 'Pacheco De Melo'),
	(3144, 7, 'Pampayasta N.'),
	(3145, 7, 'Pampayasta S.'),
	(3146, 7, 'Panaholma'),
	(3147, 7, 'Pascanas'),
	(3148, 7, 'Pasco'),
	(3149, 7, 'Paso del Durazno'),
	(3150, 7, 'Paso Viejo'),
	(3151, 7, 'Pilar'),
	(3152, 7, 'PincÚn'),
	(3153, 7, 'PiquillÝn'),
	(3154, 7, 'Plaza de Mercedes'),
	(3155, 7, 'Plaza Luxardo'),
	(3156, 7, 'Porte±a'),
	(3157, 7, 'Potrero de Garay'),
	(3158, 7, 'Pozo del Molle'),
	(3159, 7, 'Pozo Nuevo'),
	(3160, 7, 'Pueblo Italiano'),
	(3161, 7, 'Puesto de Castro'),
	(3162, 7, 'Punta del Agua'),
	(3163, 7, 'Quebracho Herrado'),
	(3164, 7, 'Quilino'),
	(3165, 7, 'Rafael GarcÝa'),
	(3166, 7, 'Ranqueles'),
	(3167, 7, 'Rayo Cortado'),
	(3168, 7, 'Reducci¾n'),
	(3169, 7, 'Rinc¾n'),
	(3170, 7, 'RÝo Bamba'),
	(3171, 7, 'RÝo Ceballos'),
	(3172, 7, 'RÝo Cuarto'),
	(3173, 7, 'RÝo de Los Sauces'),
	(3174, 7, 'RÝo Primero'),
	(3175, 7, 'RÝo Segundo'),
	(3176, 7, 'RÝo Tercero'),
	(3177, 7, 'Rosales'),
	(3178, 7, 'Rosario del Saladillo'),
	(3179, 7, 'Sacanta'),
	(3180, 7, 'Sagrada Familia'),
	(3181, 7, 'Saira'),
	(3182, 7, 'Saladillo'),
	(3183, 7, 'Saldßn'),
	(3184, 7, 'Salsacate'),
	(3185, 7, 'Salsipuedes'),
	(3186, 7, 'Sampacho'),
	(3187, 7, 'San AgustÝn'),
	(3188, 7, 'San Antonio de Arredondo'),
	(3189, 7, 'San Antonio de LitÝn'),
	(3190, 7, 'San Basilio'),
	(3191, 7, 'San Carlos Minas'),
	(3192, 7, 'San Clemente'),
	(3193, 7, 'San Esteban'),
	(3194, 7, 'San Francisco'),
	(3195, 7, 'San Ignacio'),
	(3196, 7, 'San Javier'),
	(3197, 7, 'San Jer¾nimo'),
	(3198, 7, 'San JoaquÝn'),
	(3199, 7, 'San JosÚ de La Dormida'),
	(3200, 7, 'San JosÚ de Las Salinas'),
	(3201, 7, 'San Lorenzo'),
	(3202, 7, 'San Marcos Sierras'),
	(3203, 7, 'San Marcos Sud'),
	(3204, 7, 'San Pedro'),
	(3205, 7, 'San Pedro N.'),
	(3206, 7, 'San Roque'),
	(3207, 7, 'San Vicente'),
	(3208, 7, 'Santa Catalina'),
	(3209, 7, 'Santa Elena'),
	(3210, 7, 'Santa Eufemia'),
	(3211, 7, 'Santa Maria'),
	(3212, 7, 'Sarmiento'),
	(3213, 7, 'Saturnino M.Laspiur'),
	(3214, 7, 'Sauce Arriba'),
	(3215, 7, 'Sebastißn Elcano'),
	(3216, 7, 'Seeber'),
	(3217, 7, 'Segunda Usina'),
	(3218, 7, 'Serrano'),
	(3219, 7, 'Serrezuela'),
	(3220, 7, 'Sgo. Temple'),
	(3221, 7, 'Silvio Pellico'),
	(3222, 7, 'Simbolar'),
	(3223, 7, 'Sinsacate'),
	(3224, 7, 'Sta. Rosa de Calamuchita'),
	(3225, 7, 'Sta. Rosa de RÝo Primero'),
	(3226, 7, 'Suco'),
	(3227, 7, 'Tala Ca±ada'),
	(3228, 7, 'Tala Huasi'),
	(3229, 7, 'Talaini'),
	(3230, 7, 'Tancacha'),
	(3231, 7, 'Tanti'),
	(3232, 7, 'Ticino'),
	(3233, 7, 'Tinoco'),
	(3234, 7, 'TÝo Pujio'),
	(3235, 7, 'Toledo'),
	(3236, 7, 'Toro Pujio'),
	(3237, 7, 'Tosno'),
	(3238, 7, 'Tosquita'),
	(3239, 7, 'Trßnsito'),
	(3240, 7, 'Tuclame'),
	(3241, 7, 'Tutti'),
	(3242, 7, 'Ucacha'),
	(3243, 7, 'Unquillo'),
	(3244, 7, 'Valle de Anisacate'),
	(3245, 7, 'Valle Hermoso'),
	(3246, 7, 'VÚlez Sarfield'),
	(3247, 7, 'Viamonte'),
	(3248, 7, 'Vicu±a Mackenna'),
	(3249, 7, 'Villa Allende'),
	(3250, 7, 'Villa Amancay'),
	(3251, 7, 'Villa Ascasubi'),
	(3252, 7, 'Villa Candelaria N.'),
	(3253, 7, 'Villa Carlos Paz'),
	(3254, 7, 'Villa Cerro Azul'),
	(3255, 7, 'Villa Ciudad de AmÚrica'),
	(3256, 7, 'Villa Ciudad Pque Los Reartes'),
	(3257, 7, 'Villa Concepci¾n del TÝo'),
	(3258, 7, 'Villa Cura Brochero'),
	(3259, 7, 'Villa de Las Rosas'),
	(3260, 7, 'Villa de MarÝa'),
	(3261, 7, 'Villa de Pocho'),
	(3262, 7, 'Villa de Soto'),
	(3263, 7, 'Villa del Dique'),
	(3264, 7, 'Villa del Prado'),
	(3265, 7, 'Villa del Rosario'),
	(3266, 7, 'Villa del Totoral'),
	(3267, 7, 'Villa Dolores'),
	(3268, 7, 'Villa El Chancay'),
	(3269, 7, 'Villa Elisa'),
	(3270, 7, 'Villa Flor Serrana'),
	(3271, 7, 'Villa Fontana'),
	(3272, 7, 'Villa Giardino'),
	(3273, 7, 'Villa Gral. Belgrano'),
	(3274, 7, 'Villa Gutierrez'),
	(3275, 7, 'Villa Huidobro'),
	(3276, 7, 'Villa La Bolsa'),
	(3277, 7, 'Villa Los Aromos'),
	(3278, 7, 'Villa Los Patos'),
	(3279, 7, 'Villa MarÝa'),
	(3280, 7, 'Villa Nueva'),
	(3281, 7, 'Villa Pque. Santa Ana'),
	(3282, 7, 'Villa Pque. Siquiman'),
	(3283, 7, 'Villa Quillinzo'),
	(3284, 7, 'Villa Rossi'),
	(3285, 7, 'Villa Rumipal'),
	(3286, 7, 'Villa San Esteban'),
	(3287, 7, 'Villa San Isidro'),
	(3288, 7, 'Villa 21'),
	(3289, 7, 'Villa Sarmiento (G.R)'),
	(3290, 7, 'Villa Sarmiento (S.A)'),
	(3291, 7, 'Villa Tulumba'),
	(3292, 7, 'Villa Valeria'),
	(3293, 7, 'Villa Yacanto'),
	(3294, 7, 'Washington'),
	(3295, 7, 'Wenceslao Escalante'),
	(3296, 7, 'Ycho Cruz Sierras'),
	(3297, 8, 'Alvear'),
	(3298, 8, 'Bella Vista'),
	(3299, 8, 'Ber¾n de Astrada'),
	(3300, 8, 'Bonpland'),
	(3301, 8, 'Caß Cati'),
	(3302, 8, 'Capital'),
	(3303, 8, 'ChavarrÝa'),
	(3304, 8, 'Col. C. Pellegrini'),
	(3305, 8, 'Col. Libertad'),
	(3306, 8, 'Col. Liebig'),
	(3307, 8, 'Col. Sta Rosa'),
	(3308, 8, 'Concepci¾n'),
	(3309, 8, 'Cruz de Los Milagros'),
	(3310, 8, 'Curuz·-Cuatiß'),
	(3311, 8, 'Empedrado'),
	(3312, 8, 'Esquina'),
	(3313, 8, 'Estaci¾n Torrent'),
	(3314, 8, 'Felipe YofrÚ'),
	(3315, 8, 'Garruchos'),
	(3316, 8, 'Gdor. Agr¾nomo'),
	(3317, 8, 'Gdor. MartÝnez'),
	(3318, 8, 'Goya'),
	(3319, 8, 'Guaviravi'),
	(3320, 8, 'Herlitzka'),
	(3321, 8, 'Ita-Ibate'),
	(3322, 8, 'ItatÝ'),
	(3323, 8, 'Ituzaing¾'),
	(3324, 8, 'JosÚ Rafael G¾mez'),
	(3325, 8, 'Juan Pujol'),
	(3326, 8, 'La Cruz'),
	(3327, 8, 'Lavalle'),
	(3328, 8, 'Lomas de Vallejos'),
	(3329, 8, 'Loreto'),
	(3330, 8, 'Mariano I. Loza'),
	(3331, 8, 'Mburucuyß'),
	(3332, 8, 'Mercedes'),
	(3333, 8, 'Mocoretß'),
	(3334, 8, 'Mte. Caseros'),
	(3335, 8, 'Nueve de Julio'),
	(3336, 8, 'Palmar Grande'),
	(3337, 8, 'Parada Pucheta'),
	(3338, 8, 'Paso de La Patria'),
	(3339, 8, 'Paso de Los Libres'),
	(3340, 8, 'Pedro R. Fernandez'),
	(3341, 8, 'PerugorrÝa'),
	(3342, 8, 'Pueblo Libertador'),
	(3343, 8, 'Ramada Paso'),
	(3344, 8, 'Riachuelo'),
	(3345, 8, 'Saladas'),
	(3346, 8, 'San Antonio'),
	(3347, 8, 'San Carlos'),
	(3348, 8, 'San Cosme'),
	(3349, 8, 'San Lorenzo'),
	(3350, 8, '20 del Palmar'),
	(3351, 8, 'San Miguel'),
	(3352, 8, 'San Roque'),
	(3353, 8, 'Santa Ana'),
	(3354, 8, 'Santa LucÝa'),
	(3355, 8, 'Santo TomÚ'),
	(3356, 8, 'Sauce'),
	(3357, 8, 'Tabay'),
	(3358, 8, 'Tapebicuß'),
	(3359, 8, 'Tatacua'),
	(3360, 8, 'Virasoro'),
	(3361, 8, 'Yapey·'),
	(3362, 8, 'YataitÝ Calle'),
	(3363, 9, 'Alarc¾n'),
	(3364, 9, 'Alcaraz'),
	(3365, 9, 'Alcaraz N.'),
	(3366, 9, 'Alcaraz S.'),
	(3367, 9, 'Aldea Asunci¾n'),
	(3368, 9, 'Aldea Brasilera'),
	(3369, 9, 'Aldea Elgenfeld'),
	(3370, 9, 'Aldea Grapschental'),
	(3371, 9, 'Aldea Ma. Luisa'),
	(3372, 9, 'Aldea Protestante'),
	(3373, 9, 'Aldea Salto'),
	(3374, 9, 'Aldea San Antonio (G)'),
	(3375, 9, 'Aldea San Antonio (P)'),
	(3376, 9, 'Aldea 19'),
	(3377, 9, 'Aldea San Miguel'),
	(3378, 9, 'Aldea San Rafael'),
	(3379, 9, 'Aldea Spatzenkutter'),
	(3380, 9, 'Aldea Sta. MarÝa'),
	(3381, 9, 'Aldea Sta. Rosa'),
	(3382, 9, 'Aldea Valle MarÝa'),
	(3383, 9, 'Altamirano Sur'),
	(3384, 9, 'Antelo'),
	(3385, 9, 'Antonio Tomßs'),
	(3386, 9, 'Aranguren'),
	(3387, 9, 'Arroyo Bar·'),
	(3388, 9, 'Arroyo Burgos'),
	(3389, 9, 'Arroyo ClÚ'),
	(3390, 9, 'Arroyo Corralito'),
	(3391, 9, 'Arroyo del Medio'),
	(3392, 9, 'Arroyo Maturrango'),
	(3393, 9, 'Arroyo Palo Seco'),
	(3394, 9, 'Banderas'),
	(3395, 9, 'Basavilbaso'),
	(3396, 9, 'Betbeder'),
	(3397, 9, 'Bovril'),
	(3398, 9, 'Caseros'),
	(3399, 9, 'Ceibas'),
	(3400, 9, 'Cerrito'),
	(3401, 9, 'ChajarÝ'),
	(3402, 9, 'Chilcas'),
	(3403, 9, 'Clodomiro Ledesma'),
	(3404, 9, 'Col. Alemana'),
	(3405, 9, 'Col. Avellaneda'),
	(3406, 9, 'Col. Avigdor'),
	(3407, 9, 'Col. AyuÝ'),
	(3408, 9, 'Col. Baylina'),
	(3409, 9, 'Col. Carrasco'),
	(3410, 9, 'Col. Celina'),
	(3411, 9, 'Col. Cerrito'),
	(3412, 9, 'Col. Crespo'),
	(3413, 9, 'Col. Elia'),
	(3414, 9, 'Col. Ensayo'),
	(3415, 9, 'Col. Gral. Roca'),
	(3416, 9, 'Col. La Argentina'),
	(3417, 9, 'Col. Merou'),
	(3418, 9, 'Col. Oficial N¬3'),
	(3419, 9, 'Col. Oficial N¦13'),
	(3420, 9, 'Col. Oficial N¦14'),
	(3421, 9, 'Col. Oficial N¦5'),
	(3422, 9, 'Col. Reffino'),
	(3423, 9, 'Col. Tunas'),
	(3424, 9, 'Col. Virar¾'),
	(3425, 9, 'Col¾n'),
	(3426, 9, 'Concepci¾n del Uruguay'),
	(3427, 9, 'Concordia'),
	(3428, 9, 'Conscripto Bernardi'),
	(3429, 9, 'Costa Grande'),
	(3430, 9, 'Costa San Antonio'),
	(3431, 9, 'Costa Uruguay N.'),
	(3432, 9, 'Costa Uruguay S.'),
	(3433, 9, 'Crespo'),
	(3434, 9, 'Crucecitas 3¬'),
	(3435, 9, 'Crucecitas 7¬'),
	(3436, 9, 'Crucecitas 8¬'),
	(3437, 9, 'Cuchilla Redonda'),
	(3438, 9, 'Curtiembre'),
	(3439, 9, 'Diamante'),
	(3440, 9, 'Distrito 6¦'),
	(3441, 9, 'Distrito Cha±ar'),
	(3442, 9, 'Distrito Chiqueros'),
	(3443, 9, 'Distrito Cuarto'),
	(3444, 9, 'Distrito Diego L¾pez'),
	(3445, 9, 'Distrito Pajonal'),
	(3446, 9, 'Distrito Sauce'),
	(3447, 9, 'Distrito Tala'),
	(3448, 9, 'Distrito Talitas'),
	(3449, 9, 'Don Crist¾bal 1¬ Secci¾n'),
	(3450, 9, 'Don Crist¾bal 2¬ Secci¾n'),
	(3451, 9, 'Durazno'),
	(3452, 9, 'El Cimarr¾n'),
	(3453, 9, 'El Gramillal'),
	(3454, 9, 'El Palenque'),
	(3455, 9, 'El Pingo'),
	(3456, 9, 'El Quebracho'),
	(3457, 9, 'El Redom¾n'),
	(3458, 9, 'El Solar'),
	(3459, 9, 'Enrique Carbo'),
	(3460, 9, '9'),
	(3461, 9, 'Espinillo N.'),
	(3462, 9, 'Estaci¾n Campos'),
	(3463, 9, 'Estaci¾n Escri±a'),
	(3464, 9, 'Estaci¾n Lazo'),
	(3465, 9, 'Estaci¾n RaÝces'),
	(3466, 9, 'Estaci¾n Yer·a'),
	(3467, 9, 'Estancia Grande'),
	(3468, 9, 'Estancia LÝbaros'),
	(3469, 9, 'Estancia Racedo'),
	(3470, 9, 'Estancia Solß'),
	(3471, 9, 'Estancia YuquerÝ'),
	(3472, 9, 'Estaquitas'),
	(3473, 9, 'Faustino M. Parera'),
	(3474, 9, 'Febre'),
	(3475, 9, 'Federaci¾n'),
	(3476, 9, 'Federal'),
	(3477, 9, 'Gdor. Echag³e'),
	(3478, 9, 'Gdor. Mansilla'),
	(3479, 9, 'Gilbert'),
	(3480, 9, 'Gonzßlez Calder¾n'),
	(3481, 9, 'Gral. Almada'),
	(3482, 9, 'Gral. Alvear'),
	(3483, 9, 'Gral. Campos'),
	(3484, 9, 'Gral. Galarza'),
	(3485, 9, 'Gral. RamÝrez'),
	(3486, 9, 'Gualeguay'),
	(3487, 9, 'Gualeguaych·'),
	(3488, 9, 'Gualeguaycito'),
	(3489, 9, 'Guardamonte'),
	(3490, 9, 'Hambis'),
	(3491, 9, 'Hasenkamp'),
	(3492, 9, 'Hernandarias'),
	(3493, 9, 'Hernßndez'),
	(3494, 9, 'Herrera'),
	(3495, 9, 'Hinojal'),
	(3496, 9, 'Hocker'),
	(3497, 9, 'Ing. Sajaroff'),
	(3498, 9, 'Irazusta'),
	(3499, 9, 'Isletas'),
	(3500, 9, 'J.J De Urquiza'),
	(3501, 9, 'Jubileo'),
	(3502, 9, 'La Clarita'),
	(3503, 9, 'La Criolla'),
	(3504, 9, 'La Esmeralda'),
	(3505, 9, 'La Florida'),
	(3506, 9, 'La Fraternidad'),
	(3507, 9, 'La Hierra'),
	(3508, 9, 'La Ollita'),
	(3509, 9, 'La Paz'),
	(3510, 9, 'La Picada'),
	(3511, 9, 'La Providencia'),
	(3512, 9, 'La Verbena'),
	(3513, 9, 'Laguna BenÝtez'),
	(3514, 9, 'Larroque'),
	(3515, 9, 'Las Cuevas'),
	(3516, 9, 'Las Garzas'),
	(3517, 9, 'Las Guachas'),
	(3518, 9, 'Las Mercedes'),
	(3519, 9, 'Las Moscas'),
	(3520, 9, 'Las Mulitas'),
	(3521, 9, 'Las Toscas'),
	(3522, 9, 'Laurencena'),
	(3523, 9, 'Libertador San MartÝn'),
	(3524, 9, 'Loma Limpia'),
	(3525, 9, 'Los Ceibos'),
	(3526, 9, 'Los Charruas'),
	(3527, 9, 'Los Conquistadores'),
	(3528, 9, 'Lucas Gonzßlez'),
	(3529, 9, 'Lucas N.'),
	(3530, 9, 'Lucas S. 1¬'),
	(3531, 9, 'Lucas S. 2¬'),
	(3532, 9, 'Maciß'),
	(3533, 9, 'MarÝa Grande'),
	(3534, 9, 'MarÝa Grande 2¬'),
	(3535, 9, 'MÚdanos'),
	(3536, 9, 'Mojones N.'),
	(3537, 9, 'Mojones S.'),
	(3538, 9, 'Molino Doll'),
	(3539, 9, 'Monte Redondo'),
	(3540, 9, 'Montoya'),
	(3541, 9, 'Mulas Grandes'),
	(3542, 9, 'Ðancay'),
	(3543, 9, 'Nogoyß'),
	(3544, 9, 'Nueva Escocia'),
	(3545, 9, 'Nueva Vizcaya'),
	(3546, 9, 'Omb·'),
	(3547, 9, 'Oro Verde'),
	(3548, 9, 'Paranß'),
	(3549, 9, 'Pasaje Guayaquil'),
	(3550, 9, 'Pasaje Las Tunas'),
	(3551, 9, 'Paso de La Arena'),
	(3552, 9, 'Paso de La Laguna'),
	(3553, 9, 'Paso de Las Piedras'),
	(3554, 9, 'Paso Duarte'),
	(3555, 9, 'Pastor Britos'),
	(3556, 9, 'Pedernal'),
	(3557, 9, 'Perdices'),
	(3558, 9, 'Picada Ber¾n'),
	(3559, 9, 'Piedras Blancas'),
	(3560, 9, 'Primer Distrito Cuchilla'),
	(3561, 9, 'Primero de Mayo'),
	(3562, 9, 'Pronunciamiento'),
	(3563, 9, 'Pto. Algarrobo'),
	(3564, 9, 'Pto. Ibicuy'),
	(3565, 9, 'Pueblo Brugo'),
	(3566, 9, 'Pueblo Cazes'),
	(3567, 9, 'Pueblo Gral. Belgrano'),
	(3568, 9, 'Pueblo Liebig'),
	(3569, 9, 'Puerto Yeruß'),
	(3570, 9, 'Punta del Monte'),
	(3571, 9, 'Quebracho'),
	(3572, 9, 'Quinto Distrito'),
	(3573, 9, 'Raices Oeste'),
	(3574, 9, 'Rinc¾n de Nogoyß'),
	(3575, 9, 'Rinc¾n del Cinto'),
	(3576, 9, 'Rinc¾n del Doll'),
	(3577, 9, 'Rinc¾n del Gato'),
	(3578, 9, 'Rocamora'),
	(3579, 9, 'Rosario del Tala'),
	(3580, 9, 'San Benito'),
	(3581, 9, 'San Cipriano'),
	(3582, 9, 'San Ernesto'),
	(3583, 9, 'San Gustavo'),
	(3584, 9, 'San Jaime'),
	(3585, 9, 'San JosÚ'),
	(3586, 9, 'San JosÚ de Feliciano'),
	(3587, 9, 'San Justo'),
	(3588, 9, 'San Marcial'),
	(3589, 9, 'San Pedro'),
	(3590, 9, 'San RamÝrez'),
	(3591, 9, 'San Ram¾n'),
	(3592, 9, 'San Roque'),
	(3593, 9, 'San Salvador'),
	(3594, 9, 'San VÝctor'),
	(3595, 9, 'Santa Ana'),
	(3596, 9, 'Santa Anita'),
	(3597, 9, 'Santa Elena'),
	(3598, 9, 'Santa LucÝa'),
	(3599, 9, 'Santa Luisa'),
	(3600, 9, 'Sauce de Luna'),
	(3601, 9, 'Sauce Montrull'),
	(3602, 9, 'Sauce Pinto'),
	(3603, 9, 'Sauce Sur'),
	(3604, 9, 'SeguÝ'),
	(3605, 9, 'Sir Leonard'),
	(3606, 9, 'Sosa'),
	(3607, 9, 'Tabossi'),
	(3608, 9, 'Tezanos Pinto'),
	(3609, 9, 'Ubajay'),
	(3610, 9, 'Urdinarrain'),
	(3611, 9, 'Veinte de Septiembre'),
	(3612, 9, 'Viale'),
	(3613, 9, 'Victoria'),
	(3614, 9, 'Villa Clara'),
	(3615, 9, 'Villa del Rosario'),
	(3616, 9, 'Villa DomÝnguez'),
	(3617, 9, 'Villa Elisa'),
	(3618, 9, 'Villa Fontana'),
	(3619, 9, 'Villa Gdor. Etchevehere'),
	(3620, 9, 'Villa Mantero'),
	(3621, 9, 'Villa Paranacito'),
	(3622, 9, 'Villa Urquiza'),
	(3623, 9, 'Villaguay'),
	(3624, 9, 'Walter Moss'),
	(3625, 9, 'YacarÚ'),
	(3626, 9, 'Yeso Oeste'),
	(3627, 10, 'Buena Vista'),
	(3628, 10, 'Clorinda'),
	(3629, 10, 'Col. Pastoril'),
	(3630, 10, 'Cte. Fontana'),
	(3631, 10, 'El Colorado'),
	(3632, 10, 'El Espinillo'),
	(3633, 10, 'Estanislao Del Campo'),
	(3634, 10, '10'),
	(3635, 10, 'FortÝn Lugones'),
	(3636, 10, 'Gral. Lucio V. Mansilla'),
	(3637, 10, 'Gral. Manuel Belgrano'),
	(3638, 10, 'Gral. Mosconi'),
	(3639, 10, 'Gran Guardia'),
	(3640, 10, 'Herradura'),
	(3641, 10, 'Ibarreta'),
	(3642, 10, 'Ing. Jußrez'),
	(3643, 10, 'Laguna Blanca'),
	(3644, 10, 'Laguna Naick Neck'),
	(3645, 10, 'Laguna Yema'),
	(3646, 10, 'Las Lomitas'),
	(3647, 10, 'Los Chiriguanos'),
	(3648, 10, 'Mayor V. Villafa±e'),
	(3649, 10, 'Misi¾n San Fco.'),
	(3650, 10, 'Palo Santo'),
	(3651, 10, 'PiranÚ'),
	(3652, 10, 'Pozo del Maza'),
	(3653, 10, 'Riacho He-He'),
	(3654, 10, 'San Hilario'),
	(3655, 10, 'San MartÝn II'),
	(3656, 10, 'Siete Palmas'),
	(3657, 10, 'Subteniente PerÝn'),
	(3658, 10, 'Tres Lagunas'),
	(3659, 10, 'Villa Dos Trece'),
	(3660, 10, 'Villa Escolar'),
	(3661, 10, 'Villa Gral. G³emes'),
	(3662, 11, 'Abdon Castro Tolay'),
	(3663, 11, 'Abra Pampa'),
	(3664, 11, 'Abralaite'),
	(3665, 11, 'Aguas Calientes'),
	(3666, 11, 'Arrayanal'),
	(3667, 11, 'Barrios'),
	(3668, 11, 'Caimancito'),
	(3669, 11, 'Calilegua'),
	(3670, 11, 'Cangrejillos'),
	(3671, 11, 'Caspala'),
	(3672, 11, 'Catuß'),
	(3673, 11, 'Cieneguillas'),
	(3674, 11, 'Coranzulli'),
	(3675, 11, 'Cusi-Cusi'),
	(3676, 11, 'El Aguilar'),
	(3677, 11, 'El Carmen'),
	(3678, 11, 'El C¾ndor'),
	(3679, 11, 'El Fuerte'),
	(3680, 11, 'El Piquete'),
	(3681, 11, 'El Talar'),
	(3682, 11, 'Fraile Pintado'),
	(3683, 11, 'Hip¾lito Yrigoyen'),
	(3684, 11, 'Huacalera'),
	(3685, 11, 'Humahuaca'),
	(3686, 11, 'La Esperanza'),
	(3687, 11, 'La Mendieta'),
	(3688, 11, 'La Quiaca'),
	(3689, 11, 'Ledesma'),
	(3690, 11, 'Libertador Gral. San Martin'),
	(3691, 11, 'Maimara'),
	(3692, 11, 'Mina Pirquitas'),
	(3693, 11, 'Monterrico'),
	(3694, 11, 'Palma Sola'),
	(3695, 11, 'Palpalß'),
	(3696, 11, 'Pampa Blanca'),
	(3697, 11, 'Pampichuela'),
	(3698, 11, 'Perico'),
	(3699, 11, 'Puesto del MarquÚs'),
	(3700, 11, 'Puesto Viejo'),
	(3701, 11, 'Pumahuasi'),
	(3702, 11, 'Purmamarca'),
	(3703, 11, 'Rinconada'),
	(3704, 11, 'Rodeitos'),
	(3705, 11, 'Rosario de RÝo Grande'),
	(3706, 11, 'San Antonio'),
	(3707, 11, 'San Francisco'),
	(3708, 11, 'San Pedro'),
	(3709, 11, 'San Rafael'),
	(3710, 11, 'San Salvador'),
	(3711, 11, 'Santa Ana'),
	(3712, 11, 'Santa Catalina'),
	(3713, 11, 'Santa Clara'),
	(3714, 11, 'Susques'),
	(3715, 11, 'Tilcara'),
	(3716, 11, 'Tres Cruces'),
	(3717, 11, 'Tumbaya'),
	(3718, 11, 'Valle Grande'),
	(3719, 11, 'Vinalito'),
	(3720, 11, 'Volcßn'),
	(3721, 11, 'Yala'),
	(3722, 11, 'YavÝ'),
	(3723, 11, 'Yuto'),
	(3724, 12, 'Abramo'),
	(3725, 12, 'Adolfo Van Praet'),
	(3726, 12, 'Agustoni'),
	(3727, 12, 'Algarrobo del Aguila'),
	(3728, 12, 'Alpachiri'),
	(3729, 12, 'Alta Italia'),
	(3730, 12, 'Anguil'),
	(3731, 12, 'Arata'),
	(3732, 12, 'Ataliva Roca'),
	(3733, 12, 'Bernardo Larroude'),
	(3734, 12, 'Bernasconi'),
	(3735, 12, 'Caleuf·'),
	(3736, 12, 'Carro Quemado'),
	(3737, 12, 'Catril¾'),
	(3738, 12, 'Ceballos'),
	(3739, 12, 'Chacharramendi'),
	(3740, 12, 'Col. Bar¾n'),
	(3741, 12, 'Col. Santa MarÝa'),
	(3742, 12, 'Conhelo'),
	(3743, 12, 'Coronel Hilario Lagos'),
	(3744, 12, 'Cuchillo-C¾'),
	(3745, 12, 'Doblas'),
	(3746, 12, 'Dorila'),
	(3747, 12, 'Eduardo Castex'),
	(3748, 12, 'Embajador Martini'),
	(3749, 12, 'Falucho'),
	(3750, 12, 'Gral. Acha'),
	(3751, 12, 'Gral. Manuel Campos'),
	(3752, 12, 'Gral. Pico'),
	(3753, 12, 'GuatrachÚ'),
	(3754, 12, 'Ing. Luiggi'),
	(3755, 12, 'Intendente Alvear'),
	(3756, 12, 'Jacinto Arauz'),
	(3757, 12, 'La Adela'),
	(3758, 12, 'La Humada'),
	(3759, 12, 'La Maruja'),
	(3760, 12, '12'),
	(3761, 12, 'La Reforma'),
	(3762, 12, 'Limay Mahuida'),
	(3763, 12, 'Lonquimay'),
	(3764, 12, 'Loventuel'),
	(3765, 12, 'Luan Toro'),
	(3766, 12, 'MacachÝn'),
	(3767, 12, 'Maisonnave'),
	(3768, 12, 'Mauricio Mayer'),
	(3769, 12, 'Metileo'),
	(3770, 12, 'Miguel CanÚ'),
	(3771, 12, 'Miguel Riglos'),
	(3772, 12, 'Monte Nievas'),
	(3773, 12, 'Parera'),
	(3774, 12, 'Per·'),
	(3775, 12, 'Pichi-Huinca'),
	(3776, 12, 'Puelches'),
	(3777, 12, 'PuelÚn'),
	(3778, 12, 'Quehue'),
	(3779, 12, 'Quem· Quem·'),
	(3780, 12, 'QuetrequÚn'),
	(3781, 12, 'Rancul'),
	(3782, 12, 'Realic¾'),
	(3783, 12, 'Relmo'),
	(3784, 12, 'Rol¾n'),
	(3785, 12, 'Rucanelo'),
	(3786, 12, 'Sarah'),
	(3787, 12, 'Speluzzi'),
	(3788, 12, 'Sta. Isabel'),
	(3789, 12, 'Sta. Rosa'),
	(3790, 12, 'Sta. Teresa'),
	(3791, 12, 'TelÚn'),
	(3792, 12, 'Toay'),
	(3793, 12, 'Tomas M. de Anchorena'),
	(3794, 12, 'Trenel'),
	(3795, 12, 'Unanue'),
	(3796, 12, 'Uriburu'),
	(3797, 12, 'Veinticinco de Mayo'),
	(3798, 12, 'Vertiz'),
	(3799, 12, 'Victorica'),
	(3800, 12, 'Villa Mirasol'),
	(3801, 12, 'Winifreda'),
	(3802, 13, 'Arauco'),
	(3803, 13, 'Capital'),
	(3804, 13, 'Castro Barros'),
	(3805, 13, 'Chamical'),
	(3806, 13, 'Chilecito'),
	(3807, 13, 'Coronel F. Varela'),
	(3808, 13, 'Famatina'),
	(3809, 13, 'Gral. A.V.Pe±aloza'),
	(3810, 13, 'Gral. Belgrano'),
	(3811, 13, 'Gral. J.F. Quiroga'),
	(3812, 13, 'Gral. Lamadrid'),
	(3813, 13, 'Gral. Ocampo'),
	(3814, 13, 'Gral. San MartÝn'),
	(3815, 13, 'Independencia'),
	(3816, 13, 'Rosario Penaloza'),
	(3817, 13, 'San Blas de Los Sauces'),
	(3818, 13, 'Sanagasta'),
	(3819, 13, 'Vinchina'),
	(3820, 14, 'Capital'),
	(3821, 14, 'Chacras de Coria'),
	(3822, 14, 'Dorrego'),
	(3823, 14, 'Gllen'),
	(3824, 14, 'Godoy Cruz'),
	(3825, 14, 'Gral. Alvear'),
	(3826, 14, 'GuaymallÚn'),
	(3827, 14, 'JunÝn'),
	(3828, 14, 'La Paz'),
	(3829, 14, 'Las Heras'),
	(3830, 14, 'Lavalle'),
	(3831, 14, 'Lujßn'),
	(3832, 14, 'Lujßn De Cuyo'),
	(3833, 14, 'Maip·'),
	(3834, 14, 'Malarg³e'),
	(3835, 14, 'Rivadavia'),
	(3836, 14, 'San Carlos'),
	(3837, 14, 'San MartÝn'),
	(3838, 14, 'San Rafael'),
	(3839, 14, 'Sta. Rosa'),
	(3840, 14, 'Tunuyßn'),
	(3841, 14, 'Tupungato'),
	(3842, 14, 'Villa Nueva'),
	(3843, 15, 'Alba Posse'),
	(3844, 15, 'Almafuerte'),
	(3845, 15, 'Ap¾stoles'),
	(3846, 15, 'Arist¾bulo Del Valle'),
	(3847, 15, 'Arroyo Del Medio'),
	(3848, 15, 'Azara'),
	(3849, 15, 'Bdo. De Irigoyen'),
	(3850, 15, 'Bonpland'),
	(3851, 15, 'Caß Yari'),
	(3852, 15, 'Campo Grande'),
	(3853, 15, 'Campo Ram¾n'),
	(3854, 15, 'Campo Viera'),
	(3855, 15, 'Candelaria'),
	(3856, 15, 'CapiovÝ'),
	(3857, 15, 'Caraguatay'),
	(3858, 15, 'Cdte. GuacurarÝ'),
	(3859, 15, 'Cerro Azul'),
	(3860, 15, 'Cerro Corß'),
	(3861, 15, 'Col. Alberdi'),
	(3862, 15, 'Col. Aurora'),
	(3863, 15, 'Col. Delicia'),
	(3864, 15, 'Col. Polana'),
	(3865, 15, 'Col. Victoria'),
	(3866, 15, 'Col. Wanda'),
	(3867, 15, 'Concepci¾n De La Sierra'),
	(3868, 15, 'Corpus'),
	(3869, 15, 'Dos Arroyos'),
	(3870, 15, 'Dos de Mayo'),
	(3871, 15, 'El Alcßzar'),
	(3872, 15, 'El Dorado'),
	(3873, 15, 'El Soberbio'),
	(3874, 15, 'Esperanza'),
	(3875, 15, 'F. Ameghino'),
	(3876, 15, 'Fachinal'),
	(3877, 15, 'GaruhapÚ'),
	(3878, 15, 'Garupß'),
	(3879, 15, 'Gdor. L¾pez'),
	(3880, 15, 'Gdor. Roca'),
	(3881, 15, 'Gral. Alvear'),
	(3882, 15, 'Gral. Urquiza'),
	(3883, 15, 'GuaranÝ'),
	(3884, 15, 'H. Yrigoyen'),
	(3885, 15, 'Iguaz·'),
	(3886, 15, 'ItacaruarÚ'),
	(3887, 15, 'JardÝn AmÚrica'),
	(3888, 15, 'Leandro N. Alem'),
	(3889, 15, 'Libertad'),
	(3890, 15, 'Loreto'),
	(3891, 15, 'Los Helechos'),
	(3892, 15, 'Mßrtires'),
	(3893, 15, '15'),
	(3894, 15, 'Moj¾n Grande'),
	(3895, 15, 'Montecarlo'),
	(3896, 15, 'Nueve de Julio'),
	(3897, 15, 'Oberß'),
	(3898, 15, 'Olegario V. Andrade'),
	(3899, 15, 'PanambÝ'),
	(3900, 15, 'Posadas'),
	(3901, 15, 'Profundidad'),
	(3902, 15, 'Pto. Iguaz·'),
	(3903, 15, 'Pto. Leoni'),
	(3904, 15, 'Pto. Piray'),
	(3905, 15, 'Pto. Rico'),
	(3906, 15, 'Ruiz de Montoya'),
	(3907, 15, 'San Antonio'),
	(3908, 15, 'San Ignacio'),
	(3909, 15, 'San Javier'),
	(3910, 15, 'San JosÚ'),
	(3911, 15, 'San MartÝn'),
	(3912, 15, 'San Pedro'),
	(3913, 15, 'San Vicente'),
	(3914, 15, 'Santiago De Liniers'),
	(3915, 15, 'Santo Pipo'),
	(3916, 15, 'Sta. Ana'),
	(3917, 15, 'Sta. MarÝa'),
	(3918, 15, 'Tres Capones'),
	(3919, 15, 'Veinticinco de Mayo'),
	(3920, 15, 'Wanda'),
	(3921, 16, 'Aguada San Roque'),
	(3922, 16, 'AluminÚ'),
	(3923, 16, 'Andacollo'),
	(3924, 16, 'A±elo'),
	(3925, 16, 'Bajada del Agrio'),
	(3926, 16, 'Barrancas'),
	(3927, 16, 'Buta Ranquil'),
	(3928, 16, 'Capital'),
	(3929, 16, 'CaviahuÚ'),
	(3930, 16, 'Centenario'),
	(3931, 16, 'Chorriaca'),
	(3932, 16, 'Chos Malal'),
	(3933, 16, 'Cipolletti'),
	(3934, 16, 'Covunco Abajo'),
	(3935, 16, 'Coyuco Cochico'),
	(3936, 16, 'Cutral C¾'),
	(3937, 16, 'El Cholar'),
	(3938, 16, 'El Huec·'),
	(3939, 16, 'El Sauce'),
	(3940, 16, 'Gua±acos'),
	(3941, 16, 'Huinganco'),
	(3942, 16, 'Las Coloradas'),
	(3943, 16, 'Las Lajas'),
	(3944, 16, 'Las Ovejas'),
	(3945, 16, 'LoncopuÚ'),
	(3946, 16, 'Los Catutos'),
	(3947, 16, 'Los Chihuidos'),
	(3948, 16, 'Los Miches'),
	(3949, 16, 'Manzano Amargo'),
	(3950, 16, '16'),
	(3951, 16, 'Octavio Pico'),
	(3952, 16, 'Paso Aguerre'),
	(3953, 16, 'Pic·n Leuf·'),
	(3954, 16, 'Piedra del Aguila'),
	(3955, 16, 'Pilo Lil'),
	(3956, 16, 'Plaza Huincul'),
	(3957, 16, 'Plottier'),
	(3958, 16, 'Quili Malal'),
	(3959, 16, 'Ram¾n Castro'),
	(3960, 16, 'Rinc¾n de Los Sauces'),
	(3961, 16, 'San MartÝn de Los Andes'),
	(3962, 16, 'San Patricio del Cha±ar'),
	(3963, 16, 'Santo Tomßs'),
	(3964, 16, 'Sauzal Bonito'),
	(3965, 16, 'Senillosa'),
	(3966, 16, 'Taquimilßn'),
	(3967, 16, 'Tricao Malal'),
	(3968, 16, 'Varvarco'),
	(3969, 16, 'Villa CurÝ Leuvu'),
	(3970, 16, 'Villa del Nahueve'),
	(3971, 16, 'Villa del Puente Pic·n Leuv·'),
	(3972, 16, 'Villa El Choc¾n'),
	(3973, 16, 'Villa La Angostura'),
	(3974, 16, 'Villa Pehuenia'),
	(3975, 16, 'Villa Traful'),
	(3976, 16, 'Vista Alegre'),
	(3977, 16, 'Zapala'),
	(3978, 17, 'Aguada Cecilio'),
	(3979, 17, 'Aguada de Guerra'),
	(3980, 17, 'AllÚn'),
	(3981, 17, 'Arroyo de La Ventana'),
	(3982, 17, 'Arroyo Los Berros'),
	(3983, 17, 'Bariloche'),
	(3984, 17, 'Calte. Cordero'),
	(3985, 17, 'Campo Grande'),
	(3986, 17, 'Catriel'),
	(3987, 17, 'Cerro PolicÝa'),
	(3988, 17, 'Cervantes'),
	(3989, 17, 'Chelforo'),
	(3990, 17, 'Chimpay'),
	(3991, 17, 'Chinchinales'),
	(3992, 17, 'Chipauquil'),
	(3993, 17, 'Choele Choel'),
	(3994, 17, 'Cinco Saltos'),
	(3995, 17, 'Cipolletti'),
	(3996, 17, 'Clemente Onelli'),
	(3997, 17, 'Colßn Conhue'),
	(3998, 17, 'Comallo'),
	(3999, 17, 'Comic¾'),
	(4000, 17, 'Cona Niyeu'),
	(4001, 17, 'Coronel Belisle'),
	(4002, 17, 'Cubanea'),
	(4003, 17, 'Darwin'),
	(4004, 17, 'Dina Huapi'),
	(4005, 17, 'El Bols¾n'),
	(4006, 17, 'El CaÝn'),
	(4007, 17, 'El Manso'),
	(4008, 17, 'Gral. Conesa'),
	(4009, 17, 'Gral. Enrique Godoy'),
	(4010, 17, 'Gral. Fernandez Oro'),
	(4011, 17, 'Gral. Roca'),
	(4012, 17, 'Guardia Mitre'),
	(4013, 17, 'Ing. Huergo'),
	(4014, 17, 'Ing. Jacobacci'),
	(4015, 17, 'Laguna Blanca'),
	(4016, 17, 'Lamarque'),
	(4017, 17, 'Las Grutas'),
	(4018, 17, 'Los Menucos'),
	(4019, 17, 'Luis Beltrßn'),
	(4020, 17, 'MainquÚ'),
	(4021, 17, 'Mamuel Choique'),
	(4022, 17, 'Maquinchao'),
	(4023, 17, 'MencuÚ'),
	(4024, 17, 'Mtro. Ramos Mexia'),
	(4025, 17, 'Nahuel Niyeu'),
	(4026, 17, 'Naupa Huen'),
	(4027, 17, 'Ðorquinco'),
	(4028, 17, 'Ojos de Agua'),
	(4029, 17, 'Paso de Agua'),
	(4030, 17, 'Paso Flores'),
	(4031, 17, 'Pe±as Blancas'),
	(4032, 17, 'Pichi Mahuida'),
	(4033, 17, 'Pilcaniyeu'),
	(4034, 17, 'Pomona'),
	(4035, 17, 'Prahuaniyeu'),
	(4036, 17, 'Rinc¾n Treneta'),
	(4037, 17, 'RÝo Chico'),
	(4038, 17, 'RÝo Colorado'),
	(4039, 17, 'Roca'),
	(4040, 17, 'San Antonio Oeste'),
	(4041, 17, 'San Javier'),
	(4042, 17, 'Sierra Colorada'),
	(4043, 17, 'Sierra Grande'),
	(4044, 17, 'Sierra Pailemßn'),
	(4045, 17, 'Valcheta'),
	(4046, 17, 'Valle Azul'),
	(4047, 17, 'Viedma'),
	(4048, 17, 'Villa LlanquÝn'),
	(4049, 17, 'Villa Mascardi'),
	(4050, 17, 'Villa Regina'),
	(4051, 17, 'YaminuÚ'),
	(4052, 18, 'A. Saravia'),
	(4053, 18, 'Aguaray'),
	(4054, 18, 'Angastaco'),
	(4055, 18, 'Animanß'),
	(4056, 18, 'Cachi'),
	(4057, 18, 'Cafayate'),
	(4058, 18, 'Campo Quijano'),
	(4059, 18, 'Campo Santo'),
	(4060, 18, 'Capital'),
	(4061, 18, 'Cerrillos'),
	(4062, 18, 'Chicoana'),
	(4063, 18, 'Col. Sta. Rosa'),
	(4064, 18, 'Coronel Moldes'),
	(4065, 18, 'El Bordo'),
	(4066, 18, 'El Carril'),
	(4067, 18, 'El Galp¾n'),
	(4068, 18, 'El JardÝn'),
	(4069, 18, 'El Potrero'),
	(4070, 18, 'El Quebrachal'),
	(4071, 18, 'El Tala'),
	(4072, 18, 'Embarcaci¾n'),
	(4073, 18, 'Gral. Ballivian'),
	(4074, 18, 'Gral. G³emes'),
	(4075, 18, 'Gral. Mosconi'),
	(4076, 18, 'Gral. Pizarro'),
	(4077, 18, 'Guachipas'),
	(4078, 18, 'Hip¾lito Yrigoyen'),
	(4079, 18, 'Iruyß'),
	(4080, 18, 'Isla De Ca±as'),
	(4081, 18, 'J. V. Gonzalez'),
	(4082, 18, 'La Caldera'),
	(4083, 18, 'La Candelaria'),
	(4084, 18, 'La Merced'),
	(4085, 18, 'La Poma'),
	(4086, 18, 'La Vi±a'),
	(4087, 18, 'Las Lajitas'),
	(4088, 18, 'Los Toldos'),
	(4089, 18, 'Metßn'),
	(4090, 18, 'Molinos'),
	(4091, 18, 'Nazareno'),
	(4092, 18, 'Orßn'),
	(4093, 18, 'Payogasta'),
	(4094, 18, 'Pichanal'),
	(4095, 18, 'Prof. S. Mazza'),
	(4096, 18, 'RÝo Piedras'),
	(4097, 18, 'Rivadavia Banda Norte'),
	(4098, 18, 'Rivadavia Banda Sur'),
	(4099, 18, 'Rosario de La Frontera'),
	(4100, 18, 'Rosario de Lerma'),
	(4101, 18, 'Saclantßs'),
	(4102, 18, '18'),
	(4103, 18, 'San Antonio'),
	(4104, 18, 'San Carlos'),
	(4105, 18, 'San JosÚ De Metßn'),
	(4106, 18, 'San Ram¾n'),
	(4107, 18, 'Santa Victoria E.'),
	(4108, 18, 'Santa Victoria O.'),
	(4109, 18, 'Tartagal'),
	(4110, 18, 'Tolar Grande'),
	(4111, 18, 'Urundel'),
	(4112, 18, 'Vaqueros'),
	(4113, 18, 'Villa San Lorenzo'),
	(4114, 19, 'Albard¾n'),
	(4115, 19, 'Angaco'),
	(4116, 19, 'Calingasta'),
	(4117, 19, 'Capital'),
	(4118, 19, 'Caucete'),
	(4119, 19, 'Chimbas'),
	(4120, 19, 'Iglesia'),
	(4121, 19, 'Jachal'),
	(4122, 19, 'Nueve de Julio'),
	(4123, 19, 'Pocito'),
	(4124, 19, 'Rawson'),
	(4125, 19, 'Rivadavia'),
	(4126, 19, '19'),
	(4127, 19, 'San MartÝn'),
	(4128, 19, 'Santa LucÝa'),
	(4129, 19, 'Sarmiento'),
	(4130, 19, 'Ullum'),
	(4131, 19, 'Valle FÚrtil'),
	(4132, 19, 'Veinticinco de Mayo'),
	(4133, 19, 'Zonda'),
	(4134, 20, 'Alto Pelado'),
	(4135, 20, 'Alto Pencoso'),
	(4136, 20, 'Anchorena'),
	(4137, 20, 'Arizona'),
	(4138, 20, 'Bagual'),
	(4139, 20, 'Balde'),
	(4140, 20, 'Batavia'),
	(4141, 20, 'Beazley'),
	(4142, 20, 'Buena Esperanza'),
	(4143, 20, 'Candelaria'),
	(4144, 20, 'Capital'),
	(4145, 20, 'Carolina'),
	(4146, 20, 'CarpinterÝa'),
	(4147, 20, 'Concarßn'),
	(4148, 20, 'Cortaderas'),
	(4149, 20, 'El Morro'),
	(4150, 20, 'El Trapiche'),
	(4151, 20, 'El Volcßn'),
	(4152, 20, 'FortÝn El Patria'),
	(4153, 20, 'Fortuna'),
	(4154, 20, 'Fraga'),
	(4155, 20, 'Juan Jorba'),
	(4156, 20, 'Juan Llerena'),
	(4157, 20, 'Juana Koslay'),
	(4158, 20, 'Justo Daract'),
	(4159, 20, 'La Calera'),
	(4160, 20, 'La Florida'),
	(4161, 20, 'La Punilla'),
	(4162, 20, 'La Toma'),
	(4163, 20, 'Lafinur'),
	(4164, 20, 'Las Aguadas'),
	(4165, 20, 'Las Chacras'),
	(4166, 20, 'Las Lagunas'),
	(4167, 20, 'Las Vertientes'),
	(4168, 20, 'Lavaisse'),
	(4169, 20, 'Leandro N. Alem'),
	(4170, 20, 'Los Molles'),
	(4171, 20, 'Lujßn'),
	(4172, 20, 'Mercedes'),
	(4173, 20, 'Merlo'),
	(4174, 20, 'Naschel'),
	(4175, 20, 'Navia'),
	(4176, 20, 'NogolÝ'),
	(4177, 20, 'Nueva Galia'),
	(4178, 20, 'Papagayos'),
	(4179, 20, 'Paso Grande'),
	(4180, 20, 'Potrero de Los Funes'),
	(4181, 20, 'Quines'),
	(4182, 20, 'Renca'),
	(4183, 20, 'Saladillo'),
	(4184, 20, 'San Francisco'),
	(4185, 20, 'San Ger¾nimo'),
	(4186, 20, 'San MartÝn'),
	(4187, 20, 'San Pablo'),
	(4188, 20, 'Santa Rosa de Conlara'),
	(4189, 20, 'Talita'),
	(4190, 20, 'Tilisarao'),
	(4191, 20, 'Uni¾n'),
	(4192, 20, 'Villa de La Quebrada'),
	(4193, 20, 'Villa de Praga'),
	(4194, 20, 'Villa del Carmen'),
	(4195, 20, 'Villa Gral. Roca'),
	(4196, 20, 'Villa Larca'),
	(4197, 20, 'Villa Mercedes'),
	(4198, 20, 'Zanjitas'),
	(4199, 21, 'Calafate'),
	(4200, 21, 'Caleta Olivia'),
	(4201, 21, 'Ca±ad¾n Seco'),
	(4202, 21, 'Comandante Piedrabuena'),
	(4203, 21, 'El Calafate'),
	(4204, 21, 'El ChaltÚn'),
	(4205, 21, 'Gdor. Gregores'),
	(4206, 21, 'Hip¾lito Yrigoyen'),
	(4207, 21, 'Jaramillo'),
	(4208, 21, 'Koluel Kaike'),
	(4209, 21, 'Las Heras'),
	(4210, 21, 'Los Antiguos'),
	(4211, 21, 'Perito Moreno'),
	(4212, 21, 'Pico Truncado'),
	(4213, 21, 'Pto. Deseado'),
	(4214, 21, 'Pto. San Julißn'),
	(4215, 21, 'Pto. 21'),
	(4216, 21, 'RÝo Cuarto'),
	(4217, 21, 'RÝo Gallegos'),
	(4218, 21, 'RÝo Turbio'),
	(4219, 21, 'Tres Lagos'),
	(4220, 21, 'Veintiocho De Noviembre'),
	(4221, 22, 'Aar¾n Castellanos'),
	(4222, 22, 'Acebal'),
	(4223, 22, 'Aguarß Grande'),
	(4224, 22, 'Albarellos'),
	(4225, 22, 'Alcorta'),
	(4226, 22, 'Aldao'),
	(4227, 22, 'Alejandra'),
	(4228, 22, '-lvarez'),
	(4229, 22, 'Ambrosetti'),
	(4230, 22, 'Amenßbar'),
	(4231, 22, 'AngÚlica'),
	(4232, 22, 'Angeloni'),
	(4233, 22, 'Arequito'),
	(4234, 22, 'Arminda'),
	(4235, 22, 'Armstrong'),
	(4236, 22, 'Arocena'),
	(4237, 22, 'Arroyo Aguiar'),
	(4238, 22, 'Arroyo Ceibal'),
	(4239, 22, 'Arroyo Leyes'),
	(4240, 22, 'Arroyo Seco'),
	(4241, 22, 'Arruf¾'),
	(4242, 22, 'Arteaga'),
	(4243, 22, 'Ataliva'),
	(4244, 22, 'Aurelia'),
	(4245, 22, 'Avellaneda'),
	(4246, 22, 'Barrancas'),
	(4247, 22, 'Bauer Y Sigel'),
	(4248, 22, 'Bella Italia'),
	(4249, 22, 'Berabev·'),
	(4250, 22, 'Berna'),
	(4251, 22, 'Bernardo de Irigoyen'),
	(4252, 22, 'Bigand'),
	(4253, 22, 'Bombal'),
	(4254, 22, 'Bouquet'),
	(4255, 22, 'Bustinza'),
	(4256, 22, 'Cabal'),
	(4257, 22, 'Cacique Ariacaiquin'),
	(4258, 22, 'Cafferata'),
	(4259, 22, 'CalchaquÝ'),
	(4260, 22, 'Campo Andino'),
	(4261, 22, 'Campo Piaggio'),
	(4262, 22, 'Ca±ada de G¾mez'),
	(4263, 22, 'Ca±ada del Ucle'),
	(4264, 22, 'Ca±ada Rica'),
	(4265, 22, 'Ca±ada RosquÝn'),
	(4266, 22, 'Candioti'),
	(4267, 22, 'Capital'),
	(4268, 22, 'Capitßn Berm·dez'),
	(4269, 22, 'Capivara'),
	(4270, 22, 'Carcara±ß'),
	(4271, 22, 'Carlos Pellegrini'),
	(4272, 22, 'Carmen'),
	(4273, 22, 'Carmen Del Sauce'),
	(4274, 22, 'Carreras'),
	(4275, 22, 'Carrizales'),
	(4276, 22, 'Casalegno'),
	(4277, 22, 'Casas'),
	(4278, 22, 'Casilda'),
	(4279, 22, 'Castelar'),
	(4280, 22, 'Castellanos'),
	(4281, 22, 'Cayastß'),
	(4282, 22, 'Cayastacito'),
	(4283, 22, 'Centeno'),
	(4284, 22, 'Cepeda'),
	(4285, 22, 'Ceres'),
	(4286, 22, 'Chabßs'),
	(4287, 22, 'Cha±ar Ladeado'),
	(4288, 22, 'Chapuy'),
	(4289, 22, 'Chovet'),
	(4290, 22, 'Christophersen'),
	(4291, 22, 'Classon'),
	(4292, 22, 'Cnel. Arnold'),
	(4293, 22, 'Cnel. Bogado'),
	(4294, 22, 'Cnel. Dominguez'),
	(4295, 22, 'Cnel. Fraga'),
	(4296, 22, 'Col. Aldao'),
	(4297, 22, 'Col. Ana'),
	(4298, 22, 'Col. Belgrano'),
	(4299, 22, 'Col. Bicha'),
	(4300, 22, 'Col. Bigand'),
	(4301, 22, 'Col. Bossi'),
	(4302, 22, 'Col. Cavour'),
	(4303, 22, 'Col. Cello'),
	(4304, 22, 'Col. Dolores'),
	(4305, 22, 'Col. Dos Rosas'),
	(4306, 22, 'Col. Durßn'),
	(4307, 22, 'Col. Iturraspe'),
	(4308, 22, 'Col. Margarita'),
	(4309, 22, 'Col. Mascias'),
	(4310, 22, 'Col. Raquel'),
	(4311, 22, 'Col. Rosa'),
	(4312, 22, 'Col. San JosÚ'),
	(4313, 22, 'Constanza'),
	(4314, 22, 'Coronda'),
	(4315, 22, 'Correa'),
	(4316, 22, 'Crispi'),
	(4317, 22, 'Culul·'),
	(4318, 22, 'Curupayti'),
	(4319, 22, 'Desvio Arij¾n'),
	(4320, 22, 'Diaz'),
	(4321, 22, 'Diego de Alvear'),
	(4322, 22, 'Egusquiza'),
	(4323, 22, 'El Arazß'),
	(4324, 22, 'El Rab¾n'),
	(4325, 22, 'El Sombrerito'),
	(4326, 22, 'El TrÚbol'),
	(4327, 22, 'Elisa'),
	(4328, 22, 'Elortondo'),
	(4329, 22, 'Emilia'),
	(4330, 22, 'Empalme San Carlos'),
	(4331, 22, 'Empalme Villa Constitucion'),
	(4332, 22, 'Esmeralda'),
	(4333, 22, 'Esperanza'),
	(4334, 22, 'Estaci¾n Alvear'),
	(4335, 22, 'Estacion Clucellas'),
	(4336, 22, 'Esteban Rams'),
	(4337, 22, 'Esther'),
	(4338, 22, 'Esustolia'),
	(4339, 22, 'Eusebia'),
	(4340, 22, 'Felicia'),
	(4341, 22, 'Fidela'),
	(4342, 22, 'Fighiera'),
	(4343, 22, 'Firmat'),
	(4344, 22, 'Florencia'),
	(4345, 22, 'FortÝn Olmos'),
	(4346, 22, 'Franck'),
	(4347, 22, 'Fray Luis Beltrßn'),
	(4348, 22, 'Frontera'),
	(4349, 22, 'Fuentes'),
	(4350, 22, 'Funes'),
	(4351, 22, 'Gaboto'),
	(4352, 22, 'Galisteo'),
	(4353, 22, 'Gßlvez'),
	(4354, 22, 'Garabalto'),
	(4355, 22, 'Garibaldi'),
	(4356, 22, 'Gato Colorado'),
	(4357, 22, 'Gdor. Crespo'),
	(4358, 22, 'Gessler'),
	(4359, 22, 'Godoy'),
	(4360, 22, 'Golondrina'),
	(4361, 22, 'Gral. Gelly'),
	(4362, 22, 'Gral. Lagos'),
	(4363, 22, 'Granadero Baigorria'),
	(4364, 22, 'Gregoria Perez De Denis'),
	(4365, 22, 'Grutly'),
	(4366, 22, 'Guadalupe N.'),
	(4367, 22, 'G÷deken'),
	(4368, 22, 'Helvecia'),
	(4369, 22, 'Hersilia'),
	(4370, 22, 'HipatÝa'),
	(4371, 22, 'Huanqueros'),
	(4372, 22, 'Hugentobler'),
	(4373, 22, 'Hughes'),
	(4374, 22, 'Humberto 1¦'),
	(4375, 22, 'Humboldt'),
	(4376, 22, 'Ibarlucea'),
	(4377, 22, 'Ing. Chanourdie'),
	(4378, 22, 'Intiyaco'),
	(4379, 22, 'Ituzaing¾'),
	(4380, 22, 'Jacinto L. Arßuz'),
	(4381, 22, 'Josefina'),
	(4382, 22, 'Juan B. Molina'),
	(4383, 22, 'Juan de Garay'),
	(4384, 22, 'Juncal'),
	(4385, 22, 'La Brava'),
	(4386, 22, 'La Cabral'),
	(4387, 22, 'La Camila'),
	(4388, 22, 'La Chispa'),
	(4389, 22, 'La Clara'),
	(4390, 22, 'La Criolla'),
	(4391, 22, 'La Gallareta'),
	(4392, 22, 'La Lucila'),
	(4393, 22, 'La Pelada'),
	(4394, 22, 'La Penca'),
	(4395, 22, 'La Rubia'),
	(4396, 22, 'La Sarita'),
	(4397, 22, 'La Vanguardia'),
	(4398, 22, 'Labordeboy'),
	(4399, 22, 'Laguna Paiva'),
	(4400, 22, 'Landeta'),
	(4401, 22, 'Lanteri'),
	(4402, 22, 'Larrechea'),
	(4403, 22, 'Las Avispas'),
	(4404, 22, 'Las Bandurrias'),
	(4405, 22, 'Las Garzas'),
	(4406, 22, 'Las Palmeras'),
	(4407, 22, 'Las Parejas'),
	(4408, 22, 'Las Petacas'),
	(4409, 22, 'Las Rosas'),
	(4410, 22, 'Las Toscas'),
	(4411, 22, 'Las Tunas'),
	(4412, 22, 'Lazzarino'),
	(4413, 22, 'Lehmann'),
	(4414, 22, 'Llambi Campbell'),
	(4415, 22, 'Logro±o'),
	(4416, 22, 'Loma Alta'),
	(4417, 22, 'L¾pez'),
	(4418, 22, 'Los Amores'),
	(4419, 22, 'Los Cardos'),
	(4420, 22, 'Los Laureles'),
	(4421, 22, 'Los Molinos'),
	(4422, 22, 'Los Quirquinchos'),
	(4423, 22, 'Lucio V. Lopez'),
	(4424, 22, 'Luis Palacios'),
	(4425, 22, 'Ma. Juana'),
	(4426, 22, 'Ma. Luisa'),
	(4427, 22, 'Ma. Susana'),
	(4428, 22, 'Ma. Teresa'),
	(4429, 22, 'Maciel'),
	(4430, 22, 'Maggiolo'),
	(4431, 22, 'Malabrigo'),
	(4432, 22, 'Marcelino Escalada'),
	(4433, 22, 'Margarita'),
	(4434, 22, 'Matilde'),
	(4435, 22, 'Mauß'),
	(4436, 22, 'Mßximo Paz'),
	(4437, 22, 'MelincuÚ'),
	(4438, 22, 'Miguel Torres'),
	(4439, 22, 'MoisÚs Ville'),
	(4440, 22, 'Monigotes'),
	(4441, 22, 'Monje'),
	(4442, 22, 'Monte Obscuridad'),
	(4443, 22, 'Monte Vera'),
	(4444, 22, 'Montefiore'),
	(4445, 22, 'Montes de Oca'),
	(4446, 22, 'Murphy'),
	(4447, 22, 'Ðanducita'),
	(4448, 22, 'NarÚ'),
	(4449, 22, 'Nelson'),
	(4450, 22, 'Nicanor E. Molinas'),
	(4451, 22, 'Nuevo Torino'),
	(4452, 22, 'Oliveros'),
	(4453, 22, 'Palacios'),
	(4454, 22, 'Pav¾n'),
	(4455, 22, 'Pav¾n Arriba'),
	(4456, 22, 'Pedro G¾mez Cello'),
	(4457, 22, 'PÚrez'),
	(4458, 22, 'Peyrano'),
	(4459, 22, 'Piamonte'),
	(4460, 22, 'Pilar'),
	(4461, 22, 'Pi±ero'),
	(4462, 22, 'Plaza Clucellas'),
	(4463, 22, 'Portugalete'),
	(4464, 22, 'Pozo Borrado'),
	(4465, 22, 'Progreso'),
	(4466, 22, 'Providencia'),
	(4467, 22, 'Pte. Roca'),
	(4468, 22, 'Pueblo Andino'),
	(4469, 22, 'Pueblo Esther'),
	(4470, 22, 'Pueblo Gral. San MartÝn'),
	(4471, 22, 'Pueblo Irigoyen'),
	(4472, 22, 'Pueblo Marini'),
	(4473, 22, 'Pueblo Mu±oz'),
	(4474, 22, 'Pueblo Uranga'),
	(4475, 22, 'Pujato'),
	(4476, 22, 'Pujato N.'),
	(4477, 22, 'Rafaela'),
	(4478, 22, 'Ramay¾n'),
	(4479, 22, 'Ramona'),
	(4480, 22, 'Reconquista'),
	(4481, 22, 'Recreo'),
	(4482, 22, 'Ricardone'),
	(4483, 22, 'Rivadavia'),
	(4484, 22, 'Roldßn'),
	(4485, 22, 'Romang'),
	(4486, 22, 'Rosario'),
	(4487, 22, 'Rueda'),
	(4488, 22, 'Rufino'),
	(4489, 22, 'Sa Pereira'),
	(4490, 22, 'Saguier'),
	(4491, 22, 'Saladero M. Cabal'),
	(4492, 22, 'Salto Grande'),
	(4493, 22, 'San AgustÝn'),
	(4494, 22, 'San Antonio de Obligado'),
	(4495, 22, 'San Bernardo (N.J.)'),
	(4496, 22, 'San Bernardo (S.J.)'),
	(4497, 22, 'San Carlos Centro'),
	(4498, 22, 'San Carlos N.'),
	(4499, 22, 'San Carlos S.'),
	(4500, 22, 'San Crist¾bal'),
	(4501, 22, 'San Eduardo'),
	(4502, 22, 'San Eugenio'),
	(4503, 22, 'San Fabißn'),
	(4504, 22, 'San Fco. de Santa FÚ'),
	(4505, 22, 'San Genaro'),
	(4506, 22, 'San Genaro N.'),
	(4507, 22, 'San Gregorio'),
	(4508, 22, 'San Guillermo'),
	(4509, 22, 'San Javier'),
	(4510, 22, 'San Jer¾nimo del Sauce'),
	(4511, 22, 'San Jer¾nimo N.'),
	(4512, 22, 'San Jer¾nimo S.'),
	(4513, 22, 'San Jorge'),
	(4514, 22, 'San JosÚ de La Esquina'),
	(4515, 22, 'San JosÚ del Rinc¾n'),
	(4516, 22, 'San Justo'),
	(4517, 22, 'San Lorenzo'),
	(4518, 22, 'San Mariano'),
	(4519, 22, 'San MartÝn de Las Escobas'),
	(4520, 22, 'San MartÝn N.'),
	(4521, 22, 'San Vicente'),
	(4522, 22, 'Sancti Spititu'),
	(4523, 22, 'Sanford'),
	(4524, 22, 'Santo Domingo'),
	(4525, 22, 'Santo TomÚ'),
	(4526, 22, 'Santurce'),
	(4527, 22, 'Sargento Cabral'),
	(4528, 22, 'Sarmiento'),
	(4529, 22, 'Sastre'),
	(4530, 22, 'Sauce Viejo'),
	(4531, 22, 'Serodino'),
	(4532, 22, 'Silva'),
	(4533, 22, 'Soldini'),
	(4534, 22, 'Soledad'),
	(4535, 22, 'Soutomayor'),
	(4536, 22, 'Sta. Clara de Buena Vista'),
	(4537, 22, 'Sta. Clara de Saguier'),
	(4538, 22, 'Sta. Isabel'),
	(4539, 22, 'Sta. Margarita'),
	(4540, 22, 'Sta. Maria Centro'),
	(4541, 22, 'Sta. MarÝa N.'),
	(4542, 22, 'Sta. Rosa'),
	(4543, 22, 'Sta. Teresa'),
	(4544, 22, 'Suardi'),
	(4545, 22, 'Sunchales'),
	(4546, 22, 'Susana'),
	(4547, 22, 'TacuarendÝ'),
	(4548, 22, 'Tacural'),
	(4549, 22, 'Tartagal'),
	(4550, 22, 'Teodelina'),
	(4551, 22, 'Theobald'),
	(4552, 22, 'Timb·es'),
	(4553, 22, 'Toba'),
	(4554, 22, 'Tortugas'),
	(4555, 22, 'Tostado'),
	(4556, 22, 'Totoras'),
	(4557, 22, 'Traill'),
	(4558, 22, 'Venado Tuerto'),
	(4559, 22, 'Vera'),
	(4560, 22, 'Vera y Pintado'),
	(4561, 22, 'Videla'),
	(4562, 22, 'Vila'),
	(4563, 22, 'Villa Amelia'),
	(4564, 22, 'Villa Ana'),
	(4565, 22, 'Villa Ca±as'),
	(4566, 22, 'Villa Constituci¾n'),
	(4567, 22, 'Villa EloÝsa'),
	(4568, 22, 'Villa Gdor. Gßlvez'),
	(4569, 22, 'Villa Guillermina'),
	(4570, 22, 'Villa Minetti'),
	(4571, 22, 'Villa Mugueta'),
	(4572, 22, 'Villa Ocampo'),
	(4573, 22, 'Villa San JosÚ'),
	(4574, 22, 'Villa Saralegui'),
	(4575, 22, 'Villa Trinidad'),
	(4576, 22, 'Villada'),
	(4577, 22, 'Virginia'),
	(4578, 22, 'Wheelwright'),
	(4579, 22, 'Zavalla'),
	(4580, 22, 'Zen¾n Pereira'),
	(4581, 23, 'A±atuya'),
	(4582, 23, '-rraga'),
	(4583, 23, 'Bandera'),
	(4584, 23, 'Bandera Bajada'),
	(4585, 23, 'Beltrßn'),
	(4586, 23, 'Brea Pozo'),
	(4587, 23, 'Campo Gallo'),
	(4588, 23, 'Capital'),
	(4589, 23, 'Chilca Juliana'),
	(4590, 23, 'Choya'),
	(4591, 23, 'Clodomira'),
	(4592, 23, 'Col. Alpina'),
	(4593, 23, 'Col. Dora'),
	(4594, 23, 'Col. El Simbolar Robles'),
	(4595, 23, 'El Bobadal'),
	(4596, 23, 'El Charco'),
	(4597, 23, 'El Moj¾n'),
	(4598, 23, 'Estaci¾n Atamisqui'),
	(4599, 23, 'Estaci¾n Simbolar'),
	(4600, 23, 'Fernßndez'),
	(4601, 23, 'FortÝn Inca'),
	(4602, 23, 'FrÝas'),
	(4603, 23, 'Garza'),
	(4604, 23, 'Gramilla'),
	(4605, 23, 'Guardia Escolta'),
	(4606, 23, 'Herrera'),
	(4607, 23, 'Ica±o'),
	(4608, 23, 'Ing. Forres'),
	(4609, 23, 'La Banda'),
	(4610, 23, 'La Ca±ada'),
	(4611, 23, 'Laprida'),
	(4612, 23, 'Lavalle'),
	(4613, 23, 'Loreto'),
	(4614, 23, 'Los JurÝes'),
	(4615, 23, 'Los N·±ez'),
	(4616, 23, 'Los Pirpintos'),
	(4617, 23, 'Los Quiroga'),
	(4618, 23, 'Los Telares'),
	(4619, 23, 'Lugones'),
	(4620, 23, 'Malbrßn'),
	(4621, 23, 'Matara'),
	(4622, 23, 'MedellÝn'),
	(4623, 23, 'Monte Quemado'),
	(4624, 23, 'Nueva Esperanza'),
	(4625, 23, 'Nueva Francia'),
	(4626, 23, 'Palo Negro'),
	(4627, 23, 'Pampa de Los Guanacos'),
	(4628, 23, 'Pinto'),
	(4629, 23, 'Pozo Hondo'),
	(4630, 23, 'QuimilÝ'),
	(4631, 23, 'Real Sayana'),
	(4632, 23, 'Sachayoj'),
	(4633, 23, 'San Pedro de Guasayßn'),
	(4634, 23, 'Selva'),
	(4635, 23, 'Sol de Julio'),
	(4636, 23, 'Sumampa'),
	(4637, 23, 'Suncho Corral'),
	(4638, 23, 'Taboada'),
	(4639, 23, 'Tapso'),
	(4640, 23, 'Termas de Rio Hondo'),
	(4641, 23, 'Tintina'),
	(4642, 23, 'Tomas Young'),
	(4643, 23, 'Vilelas'),
	(4644, 23, 'Villa Atamisqui'),
	(4645, 23, 'Villa La Punta'),
	(4646, 23, 'Villa Ojo de Agua'),
	(4647, 23, 'Villa RÝo Hondo'),
	(4648, 23, 'Villa Salavina'),
	(4649, 23, 'Villa Uni¾n'),
	(4650, 23, 'Vilmer'),
	(4651, 23, 'Weisburd'),
	(4652, 24, 'RÝo Grande'),
	(4653, 24, 'Tolhuin'),
	(4654, 24, 'Ushuaia'),
	(4655, 25, 'Acheral'),
	(4656, 25, 'Agua Dulce'),
	(4657, 25, 'Aguilares'),
	(4658, 25, 'Alderetes'),
	(4659, 25, 'Alpachiri'),
	(4660, 25, 'Alto Verde'),
	(4661, 25, 'Amaicha del Valle'),
	(4662, 25, 'Amberes'),
	(4663, 25, 'Ancajuli'),
	(4664, 25, 'Arcadia'),
	(4665, 25, 'Atahona'),
	(4666, 25, 'Banda del RÝo Sali'),
	(4667, 25, 'Bella Vista'),
	(4668, 25, 'Buena Vista'),
	(4669, 25, 'Burruyac·'),
	(4670, 25, 'Capitßn Cßceres'),
	(4671, 25, 'Cevil Redondo'),
	(4672, 25, 'Choromoro'),
	(4673, 25, 'Ciudacita'),
	(4674, 25, 'Colalao del Valle'),
	(4675, 25, 'Colombres'),
	(4676, 25, 'Concepci¾n'),
	(4677, 25, 'DelfÝn Gallo'),
	(4678, 25, 'El Bracho'),
	(4679, 25, 'El Cadillal'),
	(4680, 25, 'El Cercado'),
	(4681, 25, 'El Cha±ar'),
	(4682, 25, 'El Manantial'),
	(4683, 25, 'El Moj¾n'),
	(4684, 25, 'El Mollar'),
	(4685, 25, 'El Naranjito'),
	(4686, 25, 'El Naranjo'),
	(4687, 25, 'El Polear'),
	(4688, 25, 'El Puestito'),
	(4689, 25, 'El Sacrificio'),
	(4690, 25, 'El Timb¾'),
	(4691, 25, 'Escaba'),
	(4692, 25, 'Esquina'),
	(4693, 25, 'Estaci¾n Arßoz'),
	(4694, 25, 'Famaillß'),
	(4695, 25, 'Gastone'),
	(4696, 25, 'Gdor. Garmendia'),
	(4697, 25, 'Gdor. Piedrabuena'),
	(4698, 25, 'Graneros'),
	(4699, 25, 'Huasa Pampa'),
	(4700, 25, 'J. B. Alberdi'),
	(4701, 25, 'La Cocha'),
	(4702, 25, 'La Esperanza'),
	(4703, 25, 'La Florida'),
	(4704, 25, 'La Ramada'),
	(4705, 25, 'La Trinidad'),
	(4706, 25, 'Lamadrid'),
	(4707, 25, 'Las Cejas'),
	(4708, 25, 'Las Talas'),
	(4709, 25, 'Las Talitas'),
	(4710, 25, 'Los Bulacio'),
	(4711, 25, 'Los G¾mez'),
	(4712, 25, 'Los Nogales'),
	(4713, 25, 'Los Pereyra'),
	(4714, 25, 'Los PÚrez'),
	(4715, 25, 'Los Puestos'),
	(4716, 25, 'Los Ralos'),
	(4717, 25, 'Los Sarmientos'),
	(4718, 25, 'Los Sosa'),
	(4719, 25, 'Lules'),
	(4720, 25, 'M. GarcÝa Fernßndez'),
	(4721, 25, 'Manuela Pedraza'),
	(4722, 25, 'Medinas'),
	(4723, 25, 'Monte Bello'),
	(4724, 25, 'Monteagudo'),
	(4725, 25, 'Monteros'),
	(4726, 25, 'Padre Monti'),
	(4727, 25, 'Pampa Mayo'),
	(4728, 25, 'Quilmes'),
	(4729, 25, 'Raco'),
	(4730, 25, 'Ranchillos'),
	(4731, 25, 'RÝo Chico'),
	(4732, 25, 'RÝo Colorado'),
	(4733, 25, 'RÝo Seco'),
	(4734, 25, 'Rumi Punco'),
	(4735, 25, 'San AndrÚs'),
	(4736, 25, 'San Felipe'),
	(4737, 25, 'San Ignacio'),
	(4738, 25, 'San Javier'),
	(4739, 25, 'San JosÚ'),
	(4740, 25, 'San Miguel de 25'),
	(4741, 25, 'San Pedro'),
	(4742, 25, 'San Pedro de Colalao'),
	(4743, 25, 'Santa Rosa de Leales'),
	(4744, 25, 'Sgto. Moya'),
	(4745, 25, 'Siete de Abril'),
	(4746, 25, 'Simoca'),
	(4747, 25, 'Soldado Maldonado'),
	(4748, 25, 'Sta. Ana'),
	(4749, 25, 'Sta. Cruz'),
	(4750, 25, 'Sta. LucÝa'),
	(4751, 25, 'Taco Ralo'),
	(4752, 25, 'TafÝ del Valle'),
	(4753, 25, 'TafÝ Viejo'),
	(4754, 25, 'Tapia'),
	(4755, 25, 'Teniente Berdina'),
	(4756, 25, 'Trancas'),
	(4757, 25, 'Villa Belgrano'),
	(4758, 25, 'Villa BenjamÝn Araoz'),
	(4759, 25, 'Villa Chiligasta'),
	(4760, 25, 'Villa de Leales'),
	(4761, 25, 'Villa Quinteros'),
	(4762, 25, 'Yßnima'),
	(4763, 25, 'Yerba Buena'),
	(4764, 25, 'Yerba Buena (S)');
/*!40000 ALTER TABLE "Localidad" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.MovimientoCV
CREATE TABLE IF NOT EXISTS "MovimientoCV" (
	"claveMov" INT(10,0) NOT NULL,
	"IdTipoMov" INT(10,0) NOT NULL,
	"PuntoVenta" INT(10,0) NOT NULL,
	"NroMov" INT(10,0) NOT NULL,
	"Fecha" DATE(0) NOT NULL,
	"ImporteNeto" DECIMAL(12,4) NOT NULL,
	"ImporteIVA" DECIMAL(12,4) NOT NULL,
	"IdCuenta" INT(10,0) NOT NULL,
	"Observacion" VARCHAR(300) NOT NULL,
	"CAE" VARCHAR(14) NULL DEFAULT NULL,
	"VencimientoCAE" DATE(0) NULL DEFAULT NULL,
	"FechaContabilizacion" DATE(0) NULL DEFAULT NULL,
	"IdCondicionPago" INT(10,0) NULL DEFAULT NULL,
	PRIMARY KEY ("claveMov")
);

-- Volcando datos para la tabla Cristina2.MovimientoCV: -1 rows
/*!40000 ALTER TABLE "MovimientoCV" DISABLE KEYS */;
INSERT INTO "MovimientoCV" ("claveMov", "IdTipoMov", "PuntoVenta", "NroMov", "Fecha", "ImporteNeto", "ImporteIVA", "IdCuenta", "Observacion", "CAE", "VencimientoCAE", "FechaContabilizacion", "IdCondicionPago") VALUES
	(1, 1, 1, 1, '2015-12-16', 0, 0, 2, '', 'nulaso', '2015-12-16', '2015-12-16', 1),
	(2, 2, 1, 1, '2015-12-16', 90.91, 19.09, 2, '', 'nulaso', '2015-12-16', '2015-12-16', 3);
/*!40000 ALTER TABLE "MovimientoCV" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.Pais
CREATE TABLE IF NOT EXISTS "Pais" (
	"Id" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.Pais: -1 rows
/*!40000 ALTER TABLE "Pais" DISABLE KEYS */;
INSERT INTO "Pais" ("Id", "Nombre") VALUES
	(1, 'Argentina');
/*!40000 ALTER TABLE "Pais" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.Parametros
CREATE TABLE IF NOT EXISTS "Parametros" (
	"Id" INT(10,0) NOT NULL,
	"NombreParametro" VARCHAR(50) NULL DEFAULT NULL,
	"ValorParametro" VARCHAR(50) NULL DEFAULT NULL,
	"Descripcion" VARCHAR(200) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.Parametros: -1 rows
/*!40000 ALTER TABLE "Parametros" DISABLE KEYS */;
INSERT INTO "Parametros" ("Id", "NombreParametro", "ValorParametro", "Descripcion") VALUES
	(1, 'PuntoVenta', '1', '');
/*!40000 ALTER TABLE "Parametros" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.Provincia
CREATE TABLE IF NOT EXISTS "Provincia" (
	"Id" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(50) NULL DEFAULT NULL,
	"IdPais" INT(10,0) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.Provincia: -1 rows
/*!40000 ALTER TABLE "Provincia" DISABLE KEYS */;
INSERT INTO "Provincia" ("Id", "Nombre", "IdPais") VALUES
	(1, 'Buenos Aires', 1),
	(2, 'Buenos Aires-GBA', 1),
	(3, 'Capital Federal', 1),
	(4, 'Catamarca', 1),
	(5, 'Chaco', 1),
	(6, 'Chubut', 1),
	(7, 'Córdoba', 1),
	(8, 'Corrientes', 1),
	(9, 'Entre Ríos', 1),
	(10, 'Formosa', 1),
	(11, 'Jujuy', 1),
	(12, 'La Pampa', 1),
	(13, 'La Rioja', 1),
	(14, 'Mendoza', 1),
	(15, 'Misiones', 1),
	(16, 'Neuquén', 1),
	(17, 'Río Negro', 1),
	(18, 'Salta', 1),
	(19, 'San Juan', 1),
	(20, 'San Luis', 1),
	(21, 'Santa Cruz', 1),
	(22, 'Santa Fe', 1),
	(23, 'Santiago del Estero', 1),
	(24, 'Tierra del Fuego', 1),
	(25, 'Tucumán', 1);
/*!40000 ALTER TABLE "Provincia" ENABLE KEYS */;


-- Volcando estructura para procedimiento Cristina2.SPActualizarPrecioPorProveedor
DELIMITER //
CREATE PROCEDURE [dbo].[SPActualizarPrecioPorProveedor] @Cuenta INT, @IdCategoria INT, @Porcentaje DECIMAL(5,2)

AS


UPDATE Articulos 
SET Porcentaje = @Porcentaje, 
	PrecioSugerido = PrecioCompra + (PrecioCompra * @Porcentaje / 100)
WHERE (IdCuenta = @Cuenta OR @Cuenta = 0) AND BloquearPrecio = 0 AND (IdCategoria = @IdCategoria OR @IdCategoria = 0)
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPBuscarCuenta
DELIMITER //
CREATE PROCEDURE [dbo].[SPBuscarCuenta] @Texto VARCHAR(200), @Columna BIT 

AS

DECLARE @strNombre VARCHAR(200) = ''
DECLARE @strNombreFantasia VARCHAR(200) = ''

IF @Columna = 0
	BEGIN
		SET @strNombre = @Texto
	END
ELSE
	BEGIN
		SET @strNombreFantasia = @Texto
	END

SELECT * 
FROM Cuenta
WHERE Nombre LIKE '%' + @strNombre + '%' AND NombreFantasia LIKE '%' + @strNombreFantasia + '%'
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarArticulo
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarArticulo] @Id INT
AS
DELETE Articulos WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarCategoria
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarCategoria] @Id INT
AS
DELETE Categoria WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarCategoriaAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarCategoriaAFIP] @Id INT
AS
DELETE CategoriaAFIP WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarCuenta
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarCuenta] @IdCuenta INT
AS
DELETE Cuenta WHERE IdCuenta = @IdCuenta
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarDetalleMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarDetalleMovimiento] @ClaveMov INT
AS

SELECT
    RowNum = ROW_NUMBER() OVER(ORDER BY Id)
    ,*
INTO #DetalleMovimientoCV
FROM DetalleMovimientoCV 
WHERE claveMov = @ClaveMov

DECLARE @MaxRownum INT
SET @MaxRownum = (SELECT MAX(RowNum) FROM #DetalleMovimientoCV)

DECLARE @Iter INT
SET @Iter = (SELECT MIN(RowNum) FROM #DetalleMovimientoCV)

WHILE @Iter <= @MaxRownum
BEGIN
	DELETE DetalleMovimientoCV WHERE Id = (SELECT Id
    FROM #DetalleMovimientoCV
    WHERE RowNum = @Iter)
    SET @Iter = @Iter + 1
END


DROP TABLE #DetalleMovimientoCV
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarEmpresa
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarEmpresa] @Id INT

AS

DELETE Empresas WHERE Id =  @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarImpresoras
DELIMITER //
CREATE PROC [dbo].[SPEliminarImpresoras] 
    @Estacion VARCHAR(50),
    @IdTipoComprobante int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Impresoras]
	WHERE  [Estacion] = @Estacion AND [IdTipoComprobante] = @IdTipoComprobante

	COMMIT
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarTipoComprobante
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarTipoComprobante] @Id INT

AS

DELETE TipoComprobante WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarTipoDocumentoAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarTipoDocumentoAFIP] @Id INT
AS
DELETE TipoDocumento WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPEliminarTipoMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPEliminarTipoMovimiento] @Id INT
AS
DELETE TipoMovimiento WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPImprimirMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPImprimirMovimiento] @Id INT, @CodigoBarra VARCHAR(40)

AS

SELECT DM.Id, M.claveMov, M.IdTipoMov, M.PuntoVenta, M.NroMov,	M.Fecha, M.ImporteNeto, 
	   M.ImporteIVA, M.IdCuenta, M.Observacion,  M.CAE, M.VencimientoCAE,
	   DM.IdArticulo, DM.Cantidad, DM.PrecioUnitario, 
	   DM.ImporteSubTotal, C.Nombre AS NombreCuenta, C.NombreFantasia AS NombreFantasiaCuenta, C.IdTipoDocumento, 
	   C.NroDocumento, C.NroIngresosBrutos, C.IdLocalidad, C.Domicilio, C.NroDomicilio, C.Piso, C.Departamento, 
	   C.Proveedor, A.Nombre AS NombreArticulo, A.IVA, 
	   E.Nombre, E.NombreFantasia NombreFantasiaEmpresa, E.CUIT, E.IngresosBrutos, E.InicioActividad, 
	   E.Logo, CAFIP.Nombre AS CategoriaAFIPEmpresa,
	   CAFIPC.Nombre AS CategoriaAFIPCuenta, TM.IdTipoComprobante, TM.Nombre AS NombreMovimiento,
	   TC.Letra, @CodigoBarra AS CodBar
FROM MovimientoCV M 
	LEFT JOIN TipoMovimiento TM ON M.IdTipoMov = TM.Id
	LEFT JOIN TipoComprobante TC ON TM.IdTipoComprobante = TC.Id
	LEFT JOIN DetalleMovimientoCV DM ON M.claveMov = DM.claveMov
	LEFT JOIN Articulos A ON DM.IdArticulo = A.Id
	LEFT JOIN Cuenta C ON M.IdCuenta = C.IdCuenta
	LEFT JOIN CategoriaAFIP CAFIPC ON C.IdCategoriaAFIP = CAFIPC.IdCategoriaAFIP
	LEFT JOIN Empresas E ON E.Id = 1
	LEFT JOIN CategoriaAFIP CAFIP ON E.IdCategoriaAFIP = CAFIP.IdCategoriaAFIP
WHERE M.claveMov = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarArticulo
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarArticulo]  @Nombre VARCHAR(100), @IVA DECIMAL(4,2), @PrecioCompra DECIMAL(12,4), 
									  @Porcentaje DECIMAL(5,2), @CodigoBarra VARCHAR(20), @PrecioSugerido DECIMAL(12,4),
									  @IdCuenta INT, @LlevaStock BIT, @Cantidad INT, @BloquearPrecio BIT, @IdCategoria INT

AS

INSERT INTO Articulos (Nombre, IVA, PrecioCompra, Porcentaje, CodigoBarra, PrecioSugerido, IdCuenta, LlevaStock, Cantidad, BloquearPrecio, IdCategoria)
VALUES (@Nombre, @IVA, @PrecioCompra, @Porcentaje, @CodigoBarra, @PrecioSugerido, @IdCuenta, @LlevaStock, @Cantidad, @BloquearPrecio, @IdCategoria)

SELECT MAX(Id) AS Id FROM Articulos
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarCategoria
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarCategoria] @Nombre VARCHAR(50)
AS
INSERT INTO Categoria (Nombre) VALUES (@Nombre)


SELECT MAX(Id) AS Id FROM Categoria
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarCategoriaAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarCategoriaAFIP] @Nombre VARCHAR(50), @IdCategoriaAFIP INT
AS
INSERT INTO CategoriaAFIP (Nombre, IdCategoriaAFIP) VALUES (@Nombre, @IdCategoriaAFIP)

SELECT MAX(Id) AS Id FROM CategoriaAFIP
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarCuenta
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarCuenta] @Nombre VARCHAR(200), @NombreFantasia VARCHAR(200) = NULL, @IdCategoriaAFIP INT,
								  @IdTipoDocumento INT, @NroDocumento VARCHAR(13) = null, @NroIngresosBrutos VARCHAR(14) = NULL,
								  @IdLocalidad INT, @Domicilio VARCHAR(200) = NULL, @NroDomicilio INT = NULL, @Piso INT = NULL,
								  @Departamento VARCHAR(5) = NULL, @Proveedor BIT = NULL, @Mail VARCHAR(100) = NULL,
								  @Telefono VARCHAR(20) = NULL
AS
INSERT INTO Cuenta (Nombre, NombreFantasia, IdCategoriaAFIP, IdTipoDocumento, NroDocumento, NroIngresosBrutos,
					IdLocalidad, Domicilio, NroDomicilio, Piso, Departamento, Proveedor, Mail, Telefono)
VALUES
(@Nombre, @NombreFantasia, @IdCategoriaAFIP, @IdTipoDocumento, @NroDocumento, @NroIngresosBrutos, @IdLocalidad,
@Domicilio, @NroDomicilio, @Piso, @Departamento, @Proveedor, @Mail, @Telefono)

SELECT MAX(IdCuenta) AS IdCuenta FROM Cuenta
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarDetalleMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarDetalleMovimiento] @claveMov INT, @IdTipoMovimiento INT, @IdArticulo INT, 
													  @Cantidad INT, @PrecioUnitario DECIMAL(12,4), 
													  @ImporteSubTotal DECIMAL(12,4)
											   

AS

INSERT INTO DetalleMovimientoCV (claveMov, IdArticulo, Cantidad, PrecioUnitario, ImporteSubTotal)
VALUES (@claveMov, @IdArticulo, @Cantidad, @PrecioUnitario, @ImporteSubTotal)

DECLARE @TM_MueveStock BIT
DECLARE @TM_Signo CHAR(1)
DECLARE @Art_LlevaStock BIT


SELECT @TM_MueveStock = MueveStock, @TM_Signo = Signo FROM TipoMovimiento WHERE Id = @IdTipoMovimiento
IF	@TM_MueveStock = 1
	BEGIN
		SELECT @Art_LlevaStock = LlevaStock FROM Articulos WHERE Id = @IdArticulo
		IF @Art_LlevaStock = 1
			BEGIN
				UPDATE Articulos SET Cantidad = ISNULL(Cantidad,0) + (@Cantidad * CASE WHEN @TM_Signo = 'D' THEN 1 ELSE -1 END) WHERE Id = @IdArticulo
			END
	END

SELECT MAX(Id) FROM DetalleMovimientoCV
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarEmpresa
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarEmpresa] @Nombre VARCHAR(200), @NombreFantasia VARCHAR(200), @CUIT VARCHAR(13),
								   @IngresosBrutos VARCHAR(14), @InicioActividad VARCHAR(10), @IdCategoriaAFIP INT
								   
AS

INSERT INTO Empresas (Nombre, NombreFantasia, CUIT, IngresosBrutos, InicioActividad, IdCategoriaAFIP)
VALUES (@Nombre, @NombreFantasia, @CUIT, @IngresosBrutos, @InicioActividad, @IdCategoriaAFIP)


SELECT MAX(Id) AS Id FROM Empresas
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarImpresoras
DELIMITER //
CREATE PROC [dbo].[SPInsertarImpresoras] 
    @Estacion varchar(50) = NULL,
    @IdTipoComprobante int = NULL,
    @Impresora varchar(150) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Impresoras] ([Estacion], [IdTipoComprobante], [Impresora])
	SELECT @Estacion, @IdTipoComprobante, @Impresora
	
	-- Begin Return Select <- do not remove
	SELECT [Id]
	FROM   [dbo].[Impresoras]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarMovimientoCV
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarMovimientoCV] @IdTipoMov INT, @PuntoVenta INT, @NroMov INT , @Fecha DATE, 
									    @ImporteNeto DECIMAL(12,4), @ImporteIVA DECIMAL(12,8), @IdCuenta INT, 
									    @Observacion VARCHAR(100), @CAE VARCHAR(14), @VencimientoCAE DATE,
									    @FechaContabilizacion DATE, @IdCondicionPago INT
AS

IF @NroMov = 0 
	BEGIN
		SELECT @NroMov = CASE WHEN COUNT(M.NroMov) = 0 THEN 1 ELSE MAX(M.NroMov) + 1 END 
		FROM MovimientoCV M WHERE IdTipoMov = @IdTipoMov AND PuntoVenta = @PuntoVenta
	END

INSERT INTO MovimientoCV (IdTipoMov, PuntoVenta, NroMov, Fecha, ImporteNeto, 
						  ImporteIVA, IdCuenta, Observacion, CAE, VencimientoCAE, FechaContabilizacion,
						  IdCondicionPago)
VALUES (@IdTipoMov, 
@PuntoVenta, 
@NroMov, 
@Fecha, 
@ImporteNeto, 
@ImporteIVA, 
@IdCuenta, 
@Observacion,
@CAE,
@VencimientoCAE,
@FechaContabilizacion,
@IdCondicionPago)

SELECT MAX(claveMov) AS Id FROM MovimientoCV
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarTipoComprobante
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarTipoComprobante] @Id INT, @Nombre VARCHAR(100), 
										   @Letra CHAR(1), @Descripcion VARCHAR(50),
										   @Copias SMALLINT
AS

INSERT INTO TipoComprobante (Id, Nombre, Letra, Descripcion, Copias) 
VALUES (@Id, @Nombre, @Letra, @Descripcion, @Copias)

SELECT MAX(Id) AS Id FROM TipoComprobante
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarTipoDocumentoAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarTipoDocumentoAFIP] @IdTipoDocumento INT, @Nombre VARCHAR(50)
AS
INSERT INTO TipoDocumento (IdTipoDocumento, Nombre) VALUES (@IdTipoDocumento ,@Nombre)

SELECT MAX(Id) AS Id FROM TipoDocumento
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsertarTipoMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsertarTipoMovimiento] @IdTipoComprobante INT, @Nombre VARCHAR(100), 
												 @Signo CHAR(1), @Numeracion CHAR(1), @MueveStock BIT
AS
INSERT INTO TipoMovimiento (IdTipoComprobante,Nombre,Signo,Numeracion, MueveStock) 
VALUES (@IdTipoComprobante, @Nombre,@Signo,@Numeracion, @MueveStock)

SELECT MAX(Id) AS Id FROM TipoMovimiento
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPInsetarPais
DELIMITER //
CREATE PROCEDURE [dbo].[SPInsetarPais] @Nombre VARCHAR(50)
AS
INSERT INTO Pais (Nombre)
VALUES (@Nombre)


SELECT MAX(Id) As Id FROM Pais
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarArticulos
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarArticulos]
AS
SELECT A.Id, A.Nombre, A.IVA, A.PrecioCompra, A.Porcentaje, A.CodigoBarra, A.PrecioSugerido, 
	   A.IdCuenta, C.Nombre AS NombreCuenta, A.LlevaStock, A.Cantidad, A.BloquearPrecio, A.IdCategoria
FROM Articulos A LEFT JOIN Cuenta C ON A.IdCuenta = C.IdCuenta
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarArticulosPorCuenta
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarArticulosPorCuenta](@IdCUenta bigint)
as
begin
select Id from Articulos where IdCuenta=@IdCUenta
end
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarCategoriaAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarCategoriaAFIP]
AS 
SELECT Id, IdCategoriaAFIP, Nombre FROM CategoriaAFIP
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarCategorias
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarCategorias]
AS

SELECT Id, Nombre 
FROM Categoria
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarCondicionPago
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarCondicionPago]
AS
SELECT Id, Nombre FROM CondicionPago
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarCuentas
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarCuentas] 
AS


SELECT IdCuenta, Nombre, NombreFantasia, IdCategoriaAFIP, IdTipoDocumento, NroDocumento, 
	   NroIngresosBrutos, ISNULL(IdLocalidad,2889) AS IdLocalidad, Domicilio, 
	   ISNULL(NroDomicilio,0) AS NroDomicilio, ISNULL(Piso,0) AS Piso, Departamento, Proveedor,
	   Mail, Telefono
FROM Cuenta
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarCuentaXTipoCuenta
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarCuentaXTipoCuenta] @TipoCuenta BIT

AS

SELECT IdCuenta, Nombre, NombreFantasia, IdCategoriaAFIP, IdTipoDocumento, 
	   NroDocumento, NroIngresosBrutos, ISNULL(IdLocalidad,2889), Domicilio, ISNULL(NroDomicilio,0), 
	   ISNULL(Piso,0), Departamento, Proveedor, Mail, Telefono
FROM Cuenta
WHERE Proveedor = @TipoCuenta
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarLocalidad
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarLocalidad]
AS

SELECT L.Id, L.Nombre, L.IdProvincia, P.Nombre AS NombreProvincia
FROM Localidad L LEFT JOIN Provincia P ON L.IdProvincia = P.Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarMovimientos
DELIMITER //

CREATE PROCEDURE [dbo].[SPListarMovimientos](@IdTipoMovimiento bigint)
as
begin
select IdTipoMov,PuntoVenta,NroMov,IdCuenta from MovimientoCV where IdTipoMov=@IdTipoMovimiento
end
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarTipoComprobantes
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarTipoComprobantes]

AS

SELECt Id, Nombre, Letra, Descripcion, Copias FROM TipoComprobante
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarTipoDocumentoAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarTipoDocumentoAFIP]
AS
SELECT Id, IdTipoDocumento, Nombre FROM TipoDocumento
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarTipoMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPListarTipoMovimiento]
AS
SELECT Id, IdTipoComprobante, Nombre, Signo, Numeracion, MueveStock 
FROM TipoMovimiento
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarArticulo
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarArticulo]  @Id INT, @Nombre VARCHAR(100), @IVA DECIMAL(4,2), @PrecioCompra DECIMAL(12,4), 
									  @Porcentaje DECIMAL(5,2), @CodigoBarra VARCHAR(20), @PrecioSugerido DECIMAL(12,4),
									  @IdCuenta INT, @LlevaStock BIT, @Cantidad INT, @BloquearPrecio BIT, @IdCategoria INT

AS
UPDATE Articulos
SET Nombre = @Nombre, 
	IVA = @IVA, 
	PrecioCompra = @PrecioCompra, 
	Porcentaje = @Porcentaje, 
	CodigoBarra = @CodigoBarra, 
	PrecioSugerido = @PrecioSugerido,
	IdCuenta = @IdCuenta,
	LlevaStock = @LlevaStock,
	Cantidad = @Cantidad,
	BloquearPrecio = @BloquearPrecio,
	IdCategoria = @IdCategoria
WHERE
	Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarCategoria
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarCategoria] @Id INT, @Nombre VARCHAR(50)
AS
UPDATE Categoria SET Nombre = @Nombre WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarCategoriaAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarCategoriaAFIP] @Id INT, @IdCategoriaAFIP INT, @Nombre VARCHAR(50)
AS
UPDATE CategoriaAFIP SET Nombre = @Nombre, IdCategoriaAFIP = @IdCategoriaAFIP WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarCuenta
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarCuenta] @IdCuenta INT , @Nombre VARCHAR(200), @NombreFantasia VARCHAR(200), 
								   @IdCategoriaAFIP INT, @IdTipoDocumento INT, @NroDocumento VARCHAR(13), 
								   @NroIngresosBrutos VARCHAR(14), @IdLocalidad INT, @Domicilio VARCHAR(200), 
								   @NroDomicilio INT, @Piso INT, @Departamento VARCHAR(5), @Proveedor BIT,
								   @Mail VARCHAR(100), @Telefono VARCHAR(20)
AS
UPDATE Cuenta
SET Nombre = @Nombre, 
	NombreFantasia = @NombreFantasia, 
	IdCategoriaAFIP = @IdCategoriaAFIP, 
	IdTipoDocumento = @IdTipoDocumento, 
	NroDocumento = @NroDocumento, 
	NroIngresosBrutos = @NroIngresosBrutos,
	IdLocalidad = IdLocalidad, 
	Domicilio = @Domicilio, 
	NroDomicilio = @NroDomicilio, 
	Piso = @Piso, 
	Departamento = @Departamento,
	Proveedor = @Proveedor,
	Mail = @Mail,
	Telefono = @Telefono
WHERE IdCuenta = @IdCuenta
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarEmpresa
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarEmpresa] @Nombre VARCHAR(200), @NombreFantasia VARCHAR(200), @CUIT VARCHAR(13),
								    @IngresosBrutos VARCHAR(14), @InicioActividad VARCHAR(10), @IdCategoriaAFIP INT,
								    @ID INT


AS


UPDATE Empresas
SET Nombre = @Nombre,
	NombreFantasia = @NombreFantasia,
	CUIT = @CUIT,
	IngresosBrutos = @IngresosBrutos,
	InicioActividad = @InicioActividad,
	IdCategoriaAFIP = @IdCategoriaAFIP
WHERE Id = @ID


SELECT @ID AS Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarImpresoras
DELIMITER //
CREATE PROC [dbo].[SPModificarImpresoras] 
    @Estacion varchar(50) = NULL,
    @IdTipoComprobante int = NULL,
    @Impresora varchar(150) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Impresoras]
	SET    [Impresora] = @Impresora
	WHERE  [Estacion] = @Estacion AND [IdTipoComprobante] = @IdTipoComprobante

	
--	SELECT Id FROM Impresoras WHERE  [Estacion] = @Estacion AND [IdTipoComprobante] = @IdTipoComprobante
	COMMIT
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarPais
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarPais] @Id INT, @Nombre VARCHAR(50)
AS

UPDATE Pais 
SET Nombre = @Nombre
WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarTipoComprobante
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarTipoComprobante] @Id INT, @Nombre VARCHAR(100), @Letra CHAR(1), @Descripcion VARCHAR(50),
												   @Copias SMALLINT	
AS

UPDATE TipoComprobante 
SET Nombre = @Nombre,
	Letra = @Letra,
	Descripcion = @Descripcion,
	Copias = @Copias
WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarTipoDocumentoAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarTipoDocumentoAFIP] @Id INT, @IdTipoDocumento INT, @Nombre VARCHAR(50)
AS
UPDATE TipoDocumento 
SET IdTipoDocumento = @IdTipoDocumento,
	Nombre = @Nombre 
WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPModificarTipoMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPModificarTipoMovimiento] @Id INT, @IdTipoComprobante INT, @Nombre VARCHAR(100), 
													@Signo CHAR(1), @Numeracion CHAR(1), @MueveStock BIT
AS
UPDATE TipoMovimiento 
SET IdTipoComprobante = @IdTipoComprobante,
	Nombre = @Nombre,
	Signo = @Signo,
	Numeracion = @Numeracion,
	MueveStock = @MueveStock
WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerArticulo
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerArticulo] @Id INT
AS
SELECT Id, Nombre, IVA, PrecioCompra, Porcentaje, CodigoBarra, PrecioSugerido, IdCuenta, LlevaStock,
	   Cantidad, BloquearPrecio, IdCategoria
FROM Articulos
WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerCategoria
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerCategoria] @Id INT
AS
SELECT Id, Nombre FROM Categoria WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerCategoriaAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerCategoriaAFIP] @Id INT
AS
SELECT Id, Nombre FROM CategoriaAFIP WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerCuenta
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerCuenta] @Id INT
AS
SELECT IdCuenta, Nombre, NombreFantasia, IdCategoriaAFIP, IdTipoDocumento, NroDocumento, 
	   NroIngresosBrutos, ISNULL(IdLocalidad,2889) AS IdLocalidad, Domicilio, ISNULL(NroDomicilio,0) AS NroDomicilio
	   , ISNULL(Piso,0) AS Piso, Departamento, Proveedor,
	   Mail, Telefono
FROM Cuenta
WHERE IdCuenta = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerDetalleMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerDetalleMovimiento] @ClaveMov INT
AS
SELECT Id, claveMov, IdArticulo, Cantidad, PrecioUnitario, ImporteSubTotal
FROM DetalleMovimientoCV
WHERE claveMov = @ClaveMov
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerEmpresa
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerEmpresa] @ID INT

AS

IF @ID = 0
	BEGIN
		SELECT TOP 1 Id, Nombre, NombreFantasia, CUIT, IngresosBrutos, InicioActividad, IdCategoriaAFIP
		FROM Empresas
	END
ELSE
	BEGIN
		SELECT TOP 1 Id, Nombre, NombreFantasia, CUIT, IngresosBrutos, InicioActividad, IdCategoriaAFIP
		FROM Empresas
		WHERE Id = @ID
	END
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerImpresoras
DELIMITER //
CREATE PROC [dbo].[SPObtenerImpresoras] 
    @Estacion VARCHAR(50),
    @IdTipoComprobante int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Estacion], [IdTipoComprobante], [Impresora] 
	FROM   [dbo].[Impresoras] 
	WHERE  [Estacion] = @Estacion AND [IdTipoComprobante] = @IdTipoComprobante 

	COMMIT
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerLocalidad
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerLocalidad] @Id INT
AS

SELECT  TOP 5 L.Id, L.Nombre AS NombreLocalidad, P.Nombre AS NombreProvincia
FROM Localidad L LEFT JOIN Provincia P ON L.IdProvincia = P.Id
WHERE L.Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerMovimiento] @IdTipoMov INT, @PuntoVenta INT, @NroMov INT, @IdCuenta INT
AS
SELECT claveMov, IdTipoMov, PuntoVenta, NroMov, Fecha, ImporteNeto, 
	   ImporteIVA, IdCuenta, Observacion, CAE, VencimientoCAE, FechaContabilizacion, IdCondicionPago
FROM MovimientoCV
WHERE IdTipoMov = @IdTipoMov AND PuntoVenta = @PuntoVenta AND NroMov = @NroMov AND IdCuenta = @IdCuenta
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerPais
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerPais] @Id INT
AS
SELECT Id, Nombre 
FROM Pais
WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerParametro
DELIMITER //
CREATE PROCEDURE dbo.SPObtenerParametro @NombreParametro VARCHAR(50)
AS

SELECT Id, NombreParametro, ValorParametro, Descripcion 
FROM Parametros WHERE NombreParametro = @NombreParametro
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerTipoComprobante
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerTipoComprobante] @ID INT = 0
AS

DECLARE @Where VARCHAR(100) = ''

BEGIN
	SELECT Id, Nombre, Letra, Descripcion, Copias
	FROM TipoComprobante
	WHERE Id = @ID
END
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerTipoDocumentoAFIP
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerTipoDocumentoAFIP] @Id INT
AS
SELECT Id, IdTipoDocumento, Nombre FROM TipoDocumento WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPObtenerTipoMovimiento
DELIMITER //
CREATE PROCEDURE [dbo].[SPObtenerTipoMovimiento] @Id INT
AS
SELECT Id, IdTipoComprobante, Nombre, Signo, Numeracion , MueveStock
FROM TipoMovimiento
WHERE Id = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPVacioDetalleMovimientoCV
DELIMITER //
CREATE PROCEDURE [dbo].[SPVacioDetalleMovimientoCV]
AS
SELECT  DMCV.IdArticulo, A.Nombre AS NombreArticulo ,DMCV.Cantidad, DMCV.PrecioUnitario, DMCV.ImporteSubTotal 
FROM DetalleMovimientoCV DMCV LEFT JOIN Articulos A ON DMCV.IdArticulo = A.Id
WHERE 1 = 0


 
 
 
 SELECT SUM(ISNULL(NroMov,1)) + 1 AS NroMov 
 FROM MovimientoCV WHERE IdTipoMov = 1 AND PuntoVenta = 1
//
DELIMITER ;


-- Volcando estructura para tabla Cristina2.TipoComprobante
CREATE TABLE IF NOT EXISTS "TipoComprobante" (
	"Id" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(100) NOT NULL,
	"Letra" CHAR(1) NULL DEFAULT NULL,
	"Descripcion" VARCHAR(50) NULL DEFAULT NULL,
	"Copias" SMALLINT(5,0) NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.TipoComprobante: -1 rows
/*!40000 ALTER TABLE "TipoComprobante" DISABLE KEYS */;
INSERT INTO "TipoComprobante" ("Id", "Nombre", "Letra", "Descripcion", "Copias") VALUES
	(1, 'FACTURAS A', 'A', 'FACTURA', 3),
	(2, 'NOTAS DE DEBITO A', 'A', 'NOTAS DE DEBITO ', 2),
	(3, 'NOTAS DE CREDITO A', 'A', 'NOTAS DE CREDITO ', 0),
	(4, 'RECIBOS A', 'A', NULL, 0),
	(5, 'NOTAS DE VENTA AL CONTADO A', 'A', NULL, 0),
	(6, 'FACTURAS B', 'B', NULL, 0),
	(7, 'NOTAS DE DEBITO B', 'B', NULL, 0),
	(8, 'NOTAS DE CREDITO B', 'B', NULL, 0),
	(9, 'RECIBOS B', 'B', NULL, 0),
	(10, 'NOTAS DE VENTA AL CONTADO B', 'B', NULL, 0),
	(11, 'FACTURAS C', 'C', NULL, 0),
	(12, 'NOTAS DE DEBITO C', 'C', NULL, 0),
	(13, 'NOTAS DE CREDITO C', 'C', NULL, 0),
	(15, 'RECIBOS C', 'C', NULL, 0),
	(16, 'NOTAS DE VENTA AL CONTADO C', 'C', NULL, 0),
	(17, 'LIQUIDACION DE SERVICIOS PUBLICOS CLASE A', 'A', NULL, 0),
	(18, 'LIQUIDACION DE SERVICIOS PUBLICOS CLASE B', 'B', NULL, 0),
	(19, 'FACTURAS DE EXPORTACION', NULL, NULL, 0),
	(20, 'NOTAS DE DEBITO POR OPERACIONES CON EL EXTERIOR', NULL, NULL, 0),
	(21, 'NOTAS DE CREDITO POR OPERACIONES CON EL EXTERIOR', NULL, NULL, 0),
	(22, 'FACTURAS - PERMISO EXPORTACION SIMPLIFICADO - DTO. 855/97', NULL, NULL, 0),
	(23, 'CPTES  A  DE COMPRA PRIMARIA PARA EL SECTOR PESQUERO MARITIMO', NULL, NULL, 0),
	(24, 'CPTES  A  DE COSIGNACION PRIMARIA PARA EL SECTOR PESQUERO MARITIMO', NULL, NULL, 0),
	(25, 'CPTES  B  DE COMPRA PRIMARIA PARA EL SECTOR PESQUERO MARITIMO', NULL, NULL, 0),
	(26, 'CPTES  B  DE CONSIGNACION PRIMARIA PARA EL SECTOR PESQUERO MARITIMO', NULL, NULL, 0),
	(27, 'LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE A', 'A', NULL, 0),
	(28, 'LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE B', 'B', NULL, 0),
	(30, 'COMPROBANTES DE COMPRA DE BIENES USADOS', NULL, NULL, 0),
	(32, 'COMPROBANTES PARA RECICLAR MATERIALES', NULL, NULL, 0),
	(33, 'LIQUIDACION PRIMARIA DE GRANOS', NULL, NULL, 0),
	(34, 'COMPROBANTES A DEL APARTADO A  INCISO F  R G  N  1415', 'A', NULL, 0),
	(35, 'COMPROBANTES B DEL ANEXO I  APARTADO A  INC. F   RG N  1415', 'B', NULL, 0),
	(36, 'COMPROBANTES C DEL ANEXO I  APARTADO A  INC.F   R.G. N  1415', 'C', NULL, 0),
	(37, 'NOTAS DE DEBITO O DOCUMENTO EQUIVALENTE QUE CUMPLAN CON LA R.G. N  1415', NULL, NULL, 0),
	(38, 'NOTAS DE CREDITO O DOCUMENTO EQUIVALENTE QUE CUMPLAN CON LA R.G. N  1415', NULL, NULL, 0),
	(39, 'OTROS COMPROBANTES A QUE CUMPLEN CON LA R G  1415', 'A', NULL, 0),
	(40, 'OTROS COMPROBANTES B QUE CUMPLAN CON LA R.G. 1415', 'B', NULL, 0),
	(41, 'OTROS COMPROBANTES C QUE CUMPLAN CON LA R.G. 1415', 'C', NULL, 0),
	(43, 'NOTA DE CREDITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE B', 'B', NULL, 0),
	(45, 'NOTA DE DEBITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE A', 'A', NULL, 0),
	(46, 'NOTA DE DEBITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE B', 'B', NULL, 0),
	(48, 'NOTA DE CREDITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE A', 'A', NULL, 0),
	(49, 'COMPROBANTES DE COMPRA DE BIENES NO REGISTRABLES A CONSUMIDORES FINALES', NULL, NULL, 0),
	(50, 'RECIBO FACTURA A  REGIMEN DE FACTURA DE CREDITO', 'A', NULL, 0),
	(51, 'FACTURAS M', 'M', NULL, 0),
	(52, 'NOTAS DE DEBITO M', 'M', NULL, 0),
	(53, 'NOTAS DE CREDITO M', 'M', NULL, 0),
	(54, 'RECIBOS M', 'M', NULL, 0),
	(55, 'NOTAS DE VENTA AL CONTADO M', 'M', NULL, 0),
	(56, 'COMPROBANTES M DEL ANEXO I  APARTADO A  INC F   R G  N  1415', 'M', NULL, 0),
	(57, 'OTROS COMPROBANTES M QUE CUMPLAN CON LA R G  N  1415', 'M', NULL, 0),
	(58, 'CUENTAS DE VENTA Y LIQUIDO PRODUCTO M', 'M', NULL, 0),
	(59, 'LIQUIDACIONES M', 'M', NULL, 0),
	(60, 'CUENTAS DE VENTA Y LIQUIDO PRODUCTO A', 'A', NULL, 0),
	(61, 'CUENTAS DE VENTA Y LIQUIDO PRODUCTO B', 'B', NULL, 0),
	(63, 'LIQUIDACIONES A', 'A', NULL, 0),
	(64, 'LIQUIDACIONES B', 'B', NULL, 0),
	(66, 'DESPACHO DE IMPORTACION', NULL, NULL, 0),
	(70, 'RECIBOS FACTURA DE CREDITO', NULL, NULL, 0),
	(81, 'TIQUE FACTURA A   CONTROLADORES FISCALES', 'A', NULL, 0),
	(82, 'TIQUE - FACTURA B', 'B', NULL, 0),
	(83, 'TIQUE', NULL, NULL, 0),
	(90, 'NOTA DE CREDITO OTROS COMP  QUE NO CUMPLEN CON LA R G  1415 Y SUS MODIF', NULL, NULL, 0),
	(99, 'OTROS COMP  QUE NO CUMPLEN CON LA R G  1415 Y SUS MODIF', NULL, NULL, 0),
	(110, 'TIQUE NOTA DE CREDITO', NULL, NULL, 0),
	(111, 'TIQUE FACTURA C', 'C', NULL, 0),
	(112, 'TIQUE NOTA DE CREDITO A', 'A', NULL, 0),
	(113, 'TIQUE NOTA DE CREDITO B', 'B', NULL, 0),
	(114, 'TIQUE NOTA DE CREDITO C', 'C', NULL, 0),
	(115, 'TIQUE NOTA DE DEBITO A', 'A', NULL, 0),
	(116, 'TIQUE NOTA DE DEBITO B', 'B', NULL, 0),
	(117, 'TIQUE NOTA DE DEBITO C', 'C', NULL, 0),
	(118, 'TIQUE FACTURA M', 'M', NULL, 0),
	(119, 'TIQUE NOTA DE CREDITO M', 'M', NULL, 0),
	(120, 'TIQUE NOTA DE DEBITO M', 'M', NULL, 0),
	(331, 'LIQUIDACION SECUNDARIA DE GRANOS', NULL, NULL, 0),
	(332, 'CERTIFICADO DE DEPOSITO DE GRANOS EN PLANTA', NULL, NULL, 0);
/*!40000 ALTER TABLE "TipoComprobante" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.TipoDocumento
CREATE TABLE IF NOT EXISTS "TipoDocumento" (
	"Id" INT(10,0) NOT NULL,
	"IdTipoDocumento" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(50) NULL DEFAULT NULL,
	UNIQUE KEY ("IdTipoDocumento"),
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.TipoDocumento: -1 rows
/*!40000 ALTER TABLE "TipoDocumento" DISABLE KEYS */;
INSERT INTO "TipoDocumento" ("Id", "IdTipoDocumento", "Nombre") VALUES
	(1, 80, 'C U I T'),
	(2, 86, 'C U I L'),
	(3, 96, 'DNI '),
	(4, 99, 'SIN IDENTIFICAR / VENTA GLOBAL DIARIA');
/*!40000 ALTER TABLE "TipoDocumento" ENABLE KEYS */;


-- Volcando estructura para tabla Cristina2.TipoMovimiento
CREATE TABLE IF NOT EXISTS "TipoMovimiento" (
	"Id" INT(10,0) NOT NULL,
	"IdTipoComprobante" INT(10,0) NOT NULL,
	"Nombre" VARCHAR(100) NOT NULL,
	"Signo" CHAR(1) NOT NULL,
	"Numeracion" CHAR(1) NULL DEFAULT NULL,
	"MueveStock" BIT NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla Cristina2.TipoMovimiento: -1 rows
/*!40000 ALTER TABLE "TipoMovimiento" DISABLE KEYS */;
INSERT INTO "TipoMovimiento" ("Id", "IdTipoComprobante", "Nombre", "Signo", "Numeracion", "MueveStock") VALUES
	(1, 1, 'FACTURA A', 'A', 'A', 'True'),
	(2, 11, 'Factura C', 'A', 'A', 'True'),
	(3, 9, 'ORDEN DE PAGO', 'D', 'A', 'False'),
	(4, 6, 'Factura B', 'A', 'A', 'True'),
	(5, 10, 'REMITO', 'D', 'M', 'False');
/*!40000 ALTER TABLE "TipoMovimiento" ENABLE KEYS */;


-- Volcando estructura para procedimiento Cristina2.SPFacturaFacturero
DELIMITER //
CREATE PROCEDURE [Reportes].[SPFacturaFacturero] @Id INT

AS

SELECT DM.Id, M.claveMov, M.IdTipoMov, M.PuntoVenta, M.NroMov,	M.Fecha, M.ImporteNeto, 
	   M.ImporteIVA, M.IdCuenta, M.Observacion,  M.CAE, M.VencimientoCAE,
	   DM.IdArticulo, DM.Cantidad, DM.PrecioUnitario, 
	   DM.ImporteSubTotal, C.Nombre AS NombreCuenta, C.NombreFantasia AS NombreFantasiaCuenta, C.IdTipoDocumento, 
	   C.NroDocumento, C.NroIngresosBrutos, C.IdLocalidad, C.Domicilio, C.NroDomicilio, C.Piso, C.Departamento, 
	   C.Proveedor, A.Nombre AS NombreArticulo, A.IVA, 
	   E.Nombre, E.NombreFantasia NombreFantasiaEmpresa, E.CUIT, E.IngresosBrutos, E.InicioActividad, 
	   E.Logo, CAFIP.Nombre AS CategoriaAFIPEmpresa, CAFIPC.IdCategoriaAFIP AS IdCategoriaAFIPCuenta,
	   CAFIPC.Nombre AS CategoriaAFIPCuenta, TM.IdTipoComprobante, TM.Nombre AS NombreMovimiento,
	   TC.Letra, L.Nombre AS NombreLocalidad, CP.Id AS IdCondicionPago
FROM MovimientoCV M 
	LEFT JOIN TipoMovimiento TM ON M.IdTipoMov = TM.Id
	LEFT JOIN TipoComprobante TC ON TM.IdTipoComprobante = TC.Id
	LEFT JOIN DetalleMovimientoCV DM ON M.claveMov = DM.claveMov
	LEFT JOIN Articulos A ON DM.IdArticulo = A.Id
	LEFT JOIN Cuenta C ON M.IdCuenta = C.IdCuenta
	LEFT JOIN CategoriaAFIP CAFIPC ON C.IdCategoriaAFIP = CAFIPC.IdCategoriaAFIP
	LEFT JOIN Empresas E ON E.Id = 1
	LEFT JOIN CategoriaAFIP CAFIP ON E.IdCategoriaAFIP = CAFIP.IdCategoriaAFIP
	LEFT JOIN Localidad L ON C.IdLocalidad = L.Id
	LEFT JOIN CondicionPago CP ON M.IdCondicionPago = CP.Id
WHERE M.claveMov = @Id
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPListarMovimientos
DELIMITER //
CREATE PROCEDURE [Reportes].[SPListarMovimientos] @CuentaDesde INT, @CuentaHasta INT, 
											@FechaDesde DATETIME, @FechaHasta DATETIME,
											@TipoMov VARCHAR(500)
AS



SELECT M.claveMov, M.IdTipoMov, Tm.Nombre AS TipoMovimiento, M.PuntoVenta, M.NroMov, M.Fecha, M.ImporteNeto, 
	   M.ImporteIVA, M.IdCuenta, C.Nombre AS NombreCuenta, M.Observacion, M.CAE, M.VencimientoCAE,
	   DM.Id, DM.IdArticulo, A.Nombre AS NombreArticulo, DM.Cantidad, 
	   DM.PrecioUnitario, DM.ImporteSubTotal
FROM MovimientoCV M 
	 LEFT JOIN TipoMovimiento TM ON M.IdTipoMov = Tm.Id
	 LEFT JOIN DetalleMovimientoCV DM ON M.claveMov = DM.claveMov
	 LEFT JOIN Articulos A On DM.IdArticulo = A.Id
	 LEFT JOIN Cuenta C ON M.IdCuenta = C.IdCuenta
WHERE M.IdCuenta >= @CuentaDesde AND M.IdCuenta <= @CuentaHasta
	  AND M.Fecha BETWEEN CONVERT(VARCHAR,@FechaDesde,103) AND CONVERT(VARCHAR,@FechaHasta,103)
	  AND M.IdTipoMov IN (SELECT Valor FROM fATABLA(@TipoMov))
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPReporteArticulos
DELIMITER //
CREATE PROCEDURE [Reportes].[SPReporteArticulos] @ArticuloDesde INT, @ArticuloHasta INT, 
												@CuentaDesde INT, @CuentaHasta INT,
												@Categoria VARCHAR(500)
AS
SELECT A.Id, A.Nombre, A.IVA, A.PrecioCompra, A.Porcentaje, A.CodigoBarra, 
	   A.PrecioSugerido, A.IdCuenta, C.Nombre NombreCuenta, A.LlevaStock, A.Cantidad,
	   A.IdCategoria, Cat.Nombre AS Nombrecategoria
FROM Articulos A 
	LEFT JOIN Cuenta C ON A.IdCuenta = C.IdCuenta
	LEFT JOIN Categoria Cat ON A.IdCategoria = Cat.Id
WHERE (A.Id BETWEEN @ArticuloDesde AND @ArticuloHasta) 
	AND (A.IdCuenta BETWEEN @CuentaDesde AND @CuentaHasta)
	AND A.IdCategoria IN (SELECT Valor FROM fATabla(@Categoria))
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPReporteCuentas
DELIMITER //
CREATE PROCEDURE [Reportes].[SPReporteCuentas] @CuentaDesde INT, @CuentaHasta INT, @TipoCuenta BIT = NULL
AS

SELECT IdCuenta, Nombre, NombreFantasia, IdCategoriaAFIP, IdTipoDocumento, 
	   NroDocumento, NroIngresosBrutos, IdLocalidad, Domicilio, 
	   NroDomicilio, Piso, Departamento, Proveedor, Mail, Telefono
FROM Cuenta
WHERE IdCuenta >= @CuentaDesde AND IdCuenta <= @CuentaHasta AND (Proveedor = @TipoCuenta OR @TipoCuenta IS NULL)
//
DELIMITER ;


-- Volcando estructura para procedimiento Cristina2.SPResumenCuenta
DELIMITER //
CREATE PROCEDURE [Reportes].[SPResumenCuenta] @CuentaDesde INT, @CuentaHasta INT,
										  @FechaDesde DATE, @FechaHasta DATE
AS
SELECT M.claveMov, M.Fecha, M.FechaContabilizacion, TM.Nombre AS Movimiento, M.PuntoVenta, 
	   M.NroMov, M.Observacion, 
	   CASE WHEN TM.Signo = 'D' THEN M.ImporteNeto + M.ImporteIVA ELSE 0 END AS Debe,
	   CASE WHEN TM.Signo = 'H' THEN M.ImporteNeto + M.ImporteIVA ELSE 0 END AS Haber,
	   C.IdCuenta, C.Nombre AS NombreCuenta, NroDocumento	
FROM MovimientoCV M 
	 LEFT JOIN TipoMovimiento TM ON M.IdTipoMov = TM.Id
	 LEFT JOIN Cuenta C ON M.IdCuenta = C.IdCuenta
WHERE M.IdCuenta BETWEEN @CuentaDesde AND @CuentaHasta
	  AND M.FechaContabilizacion BETWEEN CONVERT(VARCHAR,@FechaDesde,103) AND CONVERT(VARCHAR,@FechaHasta,103)
//
DELIMITER ;


-- Volcando estructura para disparador Cristina2.DetalleMovimiento_DELETE
/* Error de SQL (156): Sintaxis incorrecta cerca de la palabra clave 'FROM'. *//*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
