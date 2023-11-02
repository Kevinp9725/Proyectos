-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-08-2023 a las 02:29:32
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tienda`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id_producto` int(11) NOT NULL,
  `nombre` text NOT NULL,
  `precio` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id_producto`, `nombre`, `precio`) VALUES
(1, 'Cafe', 12.5),
(2, 'Semita', 5),
(3, 'Huevos', 10),
(5, 'Pan', 24),
(6, 'Dorito', 6),
(7, 'Rica Sula', 6),
(8, 'Leche', 25);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `contrasena` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `correo`, `contrasena`) VALUES
(1, 'ovasquezo@unah.hn', '$2y$10$wP8yV5NdJQgQkLJ5JH8NL.eUrGGbcaJtce7mTkAug.NbJoGI6x13K'),
(5, 'oscar@ejemplo.com', '$2y$10$f0zG.F/fgTam2z0NdgdW8OyzGyNTm9PZYligyR2UsF.t8RZUklpBC'),
(7, 'kevin@ejemplo.com', 'abcd1234'),
(8, 'angel@ejemplo.com', 'abc123'),
(9, 'roger@ejemplo.com', '$2y$10$Gxn4BwWdfEk9dxiZKZAVd.kPMrQGXddLEbdRgBZaaeYLSJERQZ9cW');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id_producto`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `correo` (`correo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
