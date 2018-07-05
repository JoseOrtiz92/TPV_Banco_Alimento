-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-02-2018 a las 12:23:39
-- Versión del servidor: 10.1.28-MariaDB
-- Versión de PHP: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tpv`
--
CREATE DATABASE IF NOT EXISTS `tpv` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `tpv`;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `albaran`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `albaran` (
`Nombre_Asociacion` varchar(50)
,`direccion_Asociacion` varchar(50)
,`Telefono_Asociacion` varchar(9)
,`Nombre_Almacen` varchar(50)
,`Direccion_Almacen` varchar(140)
,`Telefono_Almacen` varchar(9)
,`Nombre_Producto` varchar(50)
,`Cantidad` float
,`fecha` varchar(30)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `almacenes`
--

CREATE TABLE `almacenes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `direccion` varchar(140) NOT NULL,
  `telefono` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `almacenes`
--

INSERT INTO `almacenes` (`id`, `nombre`, `direccion`, `telefono`) VALUES
(1, 'Salesianos', 'Calle de María Auxiliadora, 7, 11009 Cádiz', '956261553');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asociaciones`
--

CREATE TABLE `asociaciones` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `telefono` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `carrito`
--

CREATE TABLE `carrito` (
  `id` int(11) NOT NULL,
  `producto` varchar(50) NOT NULL,
  `cantidad` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`nombre`) VALUES
('Cereales'),
('Conservas'),
('Lacteos'),
('Legumbres'),
('Otros'),
('Pasta');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entradaproducto`
--

CREATE TABLE `entradaproducto` (
  `idEntrada` int(11) NOT NULL,
  `idAlmacen` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL,
  `Cantidad` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entradas`
--

CREATE TABLE `entradas` (
  `id` int(11) NOT NULL,
  `fecha` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `graficoentrada`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `graficoentrada` (
`CANTIDAD` float
,`Fecha_Entrada` varchar(30)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `graficosalida`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `graficosalida` (
`CANTIDAD` float
,`Fecha_Salida` varchar(30)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `informe_entrada_por_fecha`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `informe_entrada_por_fecha` (
`Nombre_Almacen` varchar(50)
,`Nombre_Producto` varchar(50)
,`Cantidad` float
,`Fecha_Entrada` varchar(30)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `informe_stock`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `informe_stock` (
`Nombre_Almacen` varchar(50)
,`Nombre_Producto` varchar(50)
,`Cantidad` float
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `categoria` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salidaproducto`
--

CREATE TABLE `salidaproducto` (
  `idSalida` int(11) NOT NULL,
  `idAlmacen` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL,
  `cantidad` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salidas`
--

CREATE TABLE `salidas` (
  `id` int(11) NOT NULL,
  `idAsociacion` int(11) NOT NULL,
  `fecha` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stockalmacenes`
--

CREATE TABLE `stockalmacenes` (
  `idAlmacen` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL,
  `cantidad` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura para la vista `albaran`
--
DROP TABLE IF EXISTS `albaran`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `albaran`  AS  select `asoc`.`nombre` AS `Nombre_Asociacion`,`asoc`.`direccion` AS `direccion_Asociacion`,`asoc`.`telefono` AS `Telefono_Asociacion`,`a`.`nombre` AS `Nombre_Almacen`,`a`.`direccion` AS `Direccion_Almacen`,`a`.`telefono` AS `Telefono_Almacen`,`p`.`nombre` AS `Nombre_Producto`,`sp`.`cantidad` AS `Cantidad`,`s`.`fecha` AS `fecha` from ((((`asociaciones` `asoc` join `almacenes` `a`) join `productos` `p`) join `salidas` `s`) join `salidaproducto` `sp`) where ((`asoc`.`id` = `s`.`idAsociacion`) and (`a`.`id` = `sp`.`idAlmacen`) and (`p`.`id` = `sp`.`idProducto`) and (`sp`.`cantidad` = (select `salidaproducto`.`cantidad` from `salidaproducto` where ((`salidaproducto`.`idProducto` = `p`.`id`) and (`salidaproducto`.`idSalida` = `s`.`id`)))) and (`s`.`id` = (select max(`salidas`.`id`) from `salidas`)) and (`sp`.`idSalida` = `s`.`id`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `graficoentrada`
--
DROP TABLE IF EXISTS `graficoentrada`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `graficoentrada`  AS  select `ep`.`Cantidad` AS `CANTIDAD`,`s`.`fecha` AS `Fecha_Entrada` from (`entradas` `s` join `entradaproducto` `ep`) where ((`s`.`id` = `ep`.`idEntrada`) and (`ep`.`Cantidad` = (select sum(`entradaproducto`.`Cantidad`) from `entradaproducto` where (`entradaproducto`.`idEntrada` = `s`.`id`)))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `graficosalida`
--
DROP TABLE IF EXISTS `graficosalida`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `graficosalida`  AS  select `sp`.`cantidad` AS `CANTIDAD`,`s`.`fecha` AS `Fecha_Salida` from (`salidas` `s` join `salidaproducto` `sp`) where ((`s`.`id` = `sp`.`idSalida`) and (`sp`.`cantidad` = (select sum(`salidaproducto`.`cantidad`) from `salidaproducto` where (`salidaproducto`.`idSalida` = `s`.`id`)))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `informe_entrada_por_fecha`
--
DROP TABLE IF EXISTS `informe_entrada_por_fecha`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `informe_entrada_por_fecha`  AS  select `a`.`nombre` AS `Nombre_Almacen`,`p`.`nombre` AS `Nombre_Producto`,`ep`.`Cantidad` AS `Cantidad`,`e`.`fecha` AS `Fecha_Entrada` from (((`productos` `p` join `entradas` `e`) join `entradaproducto` `ep`) join `almacenes` `a`) where ((`a`.`id` = `ep`.`idAlmacen`) and (`p`.`id` = `ep`.`idProducto`) and (`ep`.`idEntrada` = `e`.`id`) and (`ep`.`Cantidad` = (select sum(`entradaproducto`.`Cantidad`) from `entradaproducto` where ((`entradaproducto`.`idEntrada` = `e`.`id`) and (`entradaproducto`.`idProducto` = `p`.`id`))))) order by `e`.`fecha` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `informe_stock`
--
DROP TABLE IF EXISTS `informe_stock`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `informe_stock`  AS  select `a`.`nombre` AS `Nombre_Almacen`,`p`.`nombre` AS `Nombre_Producto`,`sta`.`cantidad` AS `Cantidad` from ((`almacenes` `a` join `productos` `p`) join `stockalmacenes` `sta`) where ((`a`.`id` = `sta`.`idAlmacen`) and (`p`.`id` = `sta`.`idProducto`)) order by `sta`.`idAlmacen` ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `almacenes`
--
ALTER TABLE `almacenes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `asociaciones`
--
ALTER TABLE `asociaciones`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `carrito`
--
ALTER TABLE `carrito`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`nombre`);

--
-- Indices de la tabla `entradaproducto`
--
ALTER TABLE `entradaproducto`
  ADD PRIMARY KEY (`idEntrada`,`idAlmacen`,`idProducto`),
  ADD KEY `entprod_fk_idAlm` (`idAlmacen`),
  ADD KEY `entprod_fk_idProd` (`idProducto`);

--
-- Indices de la tabla `entradas`
--
ALTER TABLE `entradas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_nombre` (`nombre`),
  ADD KEY `catPROD_CATNOM_FK` (`categoria`);

--
-- Indices de la tabla `salidaproducto`
--
ALTER TABLE `salidaproducto`
  ADD PRIMARY KEY (`idSalida`,`idAlmacen`,`idProducto`),
  ADD KEY `salidProd_fk_idAlm` (`idAlmacen`),
  ADD KEY `salidProd_fk_idProd` (`idProducto`);

--
-- Indices de la tabla `salidas`
--
ALTER TABLE `salidas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `salidas_fk_idAsoc` (`idAsociacion`);

--
-- Indices de la tabla `stockalmacenes`
--
ALTER TABLE `stockalmacenes`
  ADD PRIMARY KEY (`idAlmacen`,`idProducto`),
  ADD KEY `stkal_fk_idProd` (`idProducto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `almacenes`
--
ALTER TABLE `almacenes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `asociaciones`
--
ALTER TABLE `asociaciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `carrito`
--
ALTER TABLE `carrito`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `entradas`
--
ALTER TABLE `entradas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `salidas`
--
ALTER TABLE `salidas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `entradaproducto`
--
ALTER TABLE `entradaproducto`
  ADD CONSTRAINT `entprod_fk_idAlm` FOREIGN KEY (`idAlmacen`) REFERENCES `almacenes` (`id`),
  ADD CONSTRAINT `entprod_fk_idEn` FOREIGN KEY (`idEntrada`) REFERENCES `entradas` (`id`),
  ADD CONSTRAINT `entprod_fk_idProd` FOREIGN KEY (`idProducto`) REFERENCES `productos` (`id`);

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `catPROD_CATNOM_FK` FOREIGN KEY (`categoria`) REFERENCES `categorias` (`nombre`) ON DELETE CASCADE;

--
-- Filtros para la tabla `salidaproducto`
--
ALTER TABLE `salidaproducto`
  ADD CONSTRAINT `salidProd_fk_idAlm` FOREIGN KEY (`idAlmacen`) REFERENCES `almacenes` (`id`),
  ADD CONSTRAINT `salidProd_fk_idProd` FOREIGN KEY (`idProducto`) REFERENCES `productos` (`id`),
  ADD CONSTRAINT `salidProd_fk_idSal` FOREIGN KEY (`idSalida`) REFERENCES `salidas` (`id`);

--
-- Filtros para la tabla `salidas`
--
ALTER TABLE `salidas`
  ADD CONSTRAINT `salidas_fk_idAsoc` FOREIGN KEY (`idAsociacion`) REFERENCES `asociaciones` (`id`);

--
-- Filtros para la tabla `stockalmacenes`
--
ALTER TABLE `stockalmacenes`
  ADD CONSTRAINT `stkal_fk_idAlm` FOREIGN KEY (`idAlmacen`) REFERENCES `almacenes` (`id`),
  ADD CONSTRAINT `stkal_fk_idProd` FOREIGN KEY (`idProducto`) REFERENCES `productos` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
