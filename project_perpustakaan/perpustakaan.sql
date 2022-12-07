-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.4.25-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for perpustakaan
CREATE DATABASE IF NOT EXISTS `perpustakaan` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `perpustakaan`;

-- Dumping structure for table perpustakaan.koleksi
CREATE TABLE IF NOT EXISTS `koleksi` (
  `id_koleksi` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nama_koleksi` varchar(255) NOT NULL DEFAULT '0',
  `dir_gambar` text NOT NULL,
  `deskripsi` longtext NOT NULL,
  `penerbit` varchar(255) NOT NULL DEFAULT '0',
  `jenis_koleksi` varchar(255) NOT NULL DEFAULT '0',
  `tahun_terbit` year(4) NOT NULL,
  `lokasi` varchar(255) NOT NULL DEFAULT '0',
  `tanggal_masuk_koleksi` date NOT NULL,
  `stock` int(11) NOT NULL DEFAULT 0,
  `bahasa` varchar(50) NOT NULL DEFAULT '0',
  `kategori` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_koleksi`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table perpustakaan.koleksi: ~2 rows (approximately)
INSERT INTO `koleksi` (`id_koleksi`, `nama_koleksi`, `dir_gambar`, `deskripsi`, `penerbit`, `jenis_koleksi`, `tahun_terbit`, `lokasi`, `tanggal_masuk_koleksi`, `stock`, `bahasa`, `kategori`) VALUES
	(14, 'Sistem Basis Data', 'D:/Document/File Gerry/Matkul/Semester 03/05. Pemrograman Visual/Tugas/Vis_Tugas9_2107411028_Gerry Satria Halim/project_perpustakaan/gambar_buku.jpg', 'Buku mengenai Sistem Basis Data', 'Gramedia', 'Buku', '2002', '23A', '2022-12-01', 10, 'Indonesia', 'Sains | Teknologi | '),
	(15, 'Pemrograman Visual', 'D:/Document/File Gerry/Matkul/Semester 03/05. Pemrograman Visual/Tugas/Vis_Tugas9_2107411028_Gerry Satria Halim/project_perpustakaan/gambar_buku.jpg', 'Buku mengenai Pemrograman Visual', 'Gramindo', 'Buku', '2010', '20S', '2022-12-07', 10, 'Indonesia', 'Sains | Teknologi | Budaya | ');

-- Dumping structure for table perpustakaan.users
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `registered_at` date DEFAULT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table perpustakaan.users: ~1 rows (approximately)
INSERT INTO `users` (`id_user`, `username`, `password`, `registered_at`) VALUES
	(1, 'admin', '21232f297a57a5a743894a0e4a801fc3', '2022-12-07'),
	(4, 'gerry', 'b7b7c4c378e9875e7c42877c800006c5', '2022-12-07');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
