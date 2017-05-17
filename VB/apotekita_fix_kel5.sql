-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 10 Mei 2017 pada 18.06
-- Versi Server: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `apotekita`
--
CREATE DATABASE IF NOT EXISTS `apotekita` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `apotekita`;

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_penjualan`
--

DROP TABLE IF EXISTS `detail_penjualan`;
CREATE TABLE `detail_penjualan` (
  `id_dtl_penj` int(11) NOT NULL,
  `id_penjualan` int(11) NOT NULL,
  `id_obat` char(5) NOT NULL,
  `jml_out` int(4) NOT NULL,
  `jumlah_harga_item` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detail_penjualan`
--

INSERT INTO `detail_penjualan` (`id_dtl_penj`, `id_penjualan`, `id_obat`, `jml_out`, `jumlah_harga_item`) VALUES
(1, 1, 'OB1', 5, ''),
(2, 2, 'OB1', 3, ''),
(3, 1, 'OB2', 2, ''),
(4, 1, 'OB3', 7, ''),
(5, 1, 'OB4', 7, ''),
(6, 1, 'OB5', 5, ''),
(7, 2, 'OB1', 4, ''),
(8, 2, 'OB3', 5, ''),
(9, 3, 'OB4', 3, ''),
(10, 3, 'OB1', 7, ''),
(11, 3, 'OB2', 7, ''),
(12, 4, 'OB5', 4, ''),
(13, 5, 'OB5', 5, ''),
(22, 2, 'OB2', 5, '10'),
(37, 89, 'OB1', 2, '160000'),
(38, 89, 'OB4', 1, '34000'),
(39, 77, 'OB1', 2, '160000'),
(40, 77, 'OB4', 2, '68000'),
(41, 79, 'OB4', 2, '68000'),
(42, 79, 'OB2', 1, '30000'),
(43, 19, 'OB1', 2, '160000'),
(44, 19, 'OB4', 2, '68000'),
(45, 123, 'OB1', 1, '80000'),
(46, 123, 'OB1', 12, '960000'),
(47, 122, 'OB1', 1, '80000'),
(48, 989, 'OB1', 3, '240000'),
(49, 989, 'OB5', 2, '50000'),
(50, 789, 'OB1', 1, '90000'),
(51, 170511117, 'OB3', 1, '52000'),
(53, 170511118, 'OB3', 1, '52000'),
(54, 170511119, 'OB4', 1, '34000'),
(55, 170511119, 'OB1', 9, '72000000'),
(56, 170511120, 'OB3', 1, '52000'),
(57, 170511120, 'OB4', 1, '34000'),
(58, 170511120, 'OB1', 5, '40000000'),
(59, 170511121, 'OB3', 1, '52000'),
(60, 170511122, 'OB1', 1, '80000'),
(61, 170511122, 'OB4', 1, '34000'),
(62, 170511122, 'OB3', 1, '52000'),
(63, 170511123, 'OB1', 1, '80000'),
(64, 170511123, 'OB1', 1, '80000'),
(65, 170511123, 'OB4', 1, '34000'),
(66, 170511124, 'OB1', 1, '80000'),
(67, 170511124, 'OB3', 1, '52000'),
(68, 170511124, 'OB4', 1, '34000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jabatan`
--

DROP TABLE IF EXISTS `jabatan`;
CREATE TABLE `jabatan` (
  `id_jabatan` char(5) NOT NULL,
  `nama_jabatan` varchar(30) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jabatan`
--

INSERT INTO `jabatan` (`id_jabatan`, `nama_jabatan`, `keterangan`) VALUES
('ADM', 'Administrator', 'Adminitrator IT'),
('AP', 'Apoteker', 'Menerima obat dan menyimpan'),
('HR', 'Human Resource', 'Mengurus kepegawaian'),
('KSR', 'Kasir', 'Mengurus transaksi penjualan obat'),
('MAN', 'Manager', 'Penanggungjawab');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jabatan_pegawai`
--

DROP TABLE IF EXISTS `jabatan_pegawai`;
CREATE TABLE `jabatan_pegawai` (
  `id` int(11) NOT NULL,
  `id_jabatan` char(5) NOT NULL,
  `id_pegawai` char(5) NOT NULL,
  `jabatan_mulai` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `jataban_berakhir` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jabatan_pegawai`
--

INSERT INTO `jabatan_pegawai` (`id`, `id_jabatan`, `id_pegawai`, `jabatan_mulai`, `jataban_berakhir`) VALUES
(1, 'AP', 'PEG01', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(2, 'AP', 'PEG02', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(3, 'AP', 'PEG03', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(4, 'AP', 'PEG04', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(5, 'AP', 'PEG05', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(6, 'KSR', 'PEG06', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(7, 'KSR', 'PEG07', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(8, 'KSR', 'PEG08', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(9, 'KSR', 'PEG09', '2017-03-17 09:57:18', '0000-00-00 00:00:00'),
(10, 'KSR', 'PEG10', '2017-03-17 09:57:18', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Struktur dari tabel `obat`
--

DROP TABLE IF EXISTS `obat`;
CREATE TABLE `obat` (
  `id_obat` char(5) NOT NULL,
  `nama_obat` varchar(25) NOT NULL,
  `harga` varchar(15) NOT NULL,
  `expired_date` date NOT NULL,
  `no_bpom` varchar(25) NOT NULL,
  `no_barcode` char(13) NOT NULL,
  `keterangan` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `obat`
--

INSERT INTO `obat` (`id_obat`, `nama_obat`, `harga`, `expired_date`, `no_bpom`, `no_barcode`, `keterangan`) VALUES
('OB1', 'Paracetamol', '80000', '2019-10-18', '866611005112', '8729110764922', 'Obat penurun panas'),
('oB112', '', '', '2017-05-04', '', '', ''),
('OB2', 'Daivonex', '30000', '2019-09-09', '866423105112', '8129310704922', 'Vitamin D'),
('OB3', 'Evista', '52000', '2020-03-21', '869422125112', '8128311409002', 'Obat Osteophorosis'),
('OB4', 'Betadine', '34000', '2019-08-11', '809472125202', '8127311205012', 'Obat Luka'),
('OB5', 'Antasid', '25000', '2020-09-12', '801272729002', '8127311205012', 'Obat perut'),
('OB54', 'asdyftuy', '1723717', '2017-05-04', '173163876', '162378163781', 'hhjjh'),
('ob7', 'aadshf', '2000', '2017-05-04', '32678678', '28838828428', 'djjfsjg'),
('OB74', 'asdfhj', '999', '2017-05-04', '23667', '26375', 'jsdfh'),
('OB88', 'Promag Baru', '5000', '2017-05-04', '3198207389', '281182739', 'Obat');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pegawai`
--

DROP TABLE IF EXISTS `pegawai`;
CREATE TABLE `pegawai` (
  `id_pegawai` char(5) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `jk` enum('Laki-Laki','Perempuan') NOT NULL DEFAULT 'Laki-Laki',
  `tempat_lahir` varchar(15) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `alamat` text NOT NULL,
  `passwd` varchar(30) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `updated_at` timestamp NULL DEFAULT NULL,
  `hak_akses` enum('kasir','hrd') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pegawai`
--

INSERT INTO `pegawai` (`id_pegawai`, `nama`, `jk`, `tempat_lahir`, `tanggal_lahir`, `alamat`, `passwd`, `created_at`, `updated_at`, `hak_akses`) VALUES
('AA01', 'a', 'Laki-Laki', 'a', '2017-05-03', 'a', 'a', '0000-00-00 00:00:00', NULL, 'kasir'),
('BB01', 'b', 'Laki-Laki', 'b', '2017-05-02', 'b', 'b', '0000-00-00 00:00:00', NULL, 'hrd'),
('PEG01', 'Johan jauhari', 'Laki-Laki', 'Yogyakarta', '1973-11-14', 'Jln. Megatruh no5 Depok Sleman Yogyakarta', 'johan123', '0000-00-00 00:00:00', NULL, 'kasir'),
('PEG02', 'Rudi Rahmawan', 'Laki-Laki', 'Bojonegoro', '1965-12-07', 'Jln. Giri Jaya no 12 Cangkriman Sleman Yogyakarta', 'rudi123', '0000-00-00 00:00:00', NULL, 'kasir'),
('PEG03', 'Reddi Setiawan', 'Laki-Laki', 'Bima', '1988-03-29', 'JLn. Singoturunan no 4/5 Depok Sleman YOgyakarta', 'reddi123', '0000-00-00 00:00:00', NULL, 'kasir'),
('PEG04', 'Havil Wintas E', 'Laki-Laki', 'Yogyakarta', '1989-03-26', 'Jln. Kranjilan no 45 Wirobrajan Yogyakarta', 'havil123', '0000-00-00 00:00:00', NULL, 'kasir'),
('PEG05', 'Sasmito Adi Wena', 'Laki-Laki', 'Yogyakarta', '1979-10-03', 'Jln. Samirono no 45 Selatan Indomaret Point, Sleman Yogyakarta', 'sasimi123', '0000-00-00 00:00:00', '2017-04-13 05:19:09', 'kasir'),
('PEG06', 'Muhammad Dandy Huwaida', 'Laki-Laki', 'Tegal', '1998-05-10', 'Kalongsari, Tegal, Jawa Tengah', 'password', '0000-00-00 00:00:00', NULL, 'kasir'),
('PEG07', 'Rini Sugiono', 'Laki-Laki', 'Bantul', '1998-03-28', 'Parangtritis, Bantul, Sleman, Yogyakarta', 'password', '0000-00-00 00:00:00', NULL, 'kasir'),
('PEG08', 'Havil Lintas Negara', 'Laki-Laki', 'Sleman', '1998-03-09', 'Sendangadi, Mlati, Sleman, Yogyakarta', 'password', '0000-00-00 00:00:00', NULL, 'kasir'),
('PEG09', 'Izul Faprintyas', 'Laki-Laki', 'Solo', '1998-07-06', 'Karangsari, Solo Utara, Jawa Tengah', 'password', '0000-00-00 00:00:00', NULL, 'kasir'),
('PEG10', 'Rhenita Haryonoo', 'Laki-Laki', 'Kulon Progo', '1997-03-30', 'Purwosari, Purworejo, Kulon progo, Yogyakarta', 'password', '0000-00-00 00:00:00', '2017-05-04 03:51:18', 'kasir'),
('PEG11', 'Dandy', 'Laki-Laki', 'Banyuwangi', '2010-09-07', 'banyuwangi	', 'c', '0000-00-00 00:00:00', NULL, 'hrd');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penerimaan`
--

DROP TABLE IF EXISTS `penerimaan`;
CREATE TABLE `penerimaan` (
  `id_pnrm` varchar(15) NOT NULL,
  `id_pegawai` char(5) NOT NULL,
  `id_obat` char(5) NOT NULL,
  `jml_in` int(100) NOT NULL,
  `waktu` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penerimaan`
--

INSERT INTO `penerimaan` (`id_pnrm`, `id_pegawai`, `id_obat`, `jml_in`, `waktu`) VALUES
('pen1', 'PEG01', 'OB3', 100, '2017-03-09 03:29:04'),
('pen2', 'PEG05', 'OB2', 500, '2017-03-09 03:29:04'),
('pen3', 'PEG04', 'OB1', 250, '2017-03-09 03:29:04'),
('pen4', 'PEG03', 'OB4', 175, '2017-03-09 03:29:04'),
('pen5', 'PEG02', 'OB4', 50, '2017-03-09 03:29:04');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan`
--

DROP TABLE IF EXISTS `penjualan`;
CREATE TABLE `penjualan` (
  `id_penjualan` int(11) NOT NULL,
  `id_pegawai` char(5) NOT NULL,
  `waktu_transaksi` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `total_harga_terjual` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penjualan`
--

INSERT INTO `penjualan` (`id_penjualan`, `id_pegawai`, `waktu_transaksi`, `total_harga_terjual`) VALUES
(1, 'PEG06', '2017-03-09 03:07:24', '0'),
(2, 'PEG07', '2017-03-09 03:07:24', '0'),
(3, 'PEG06', '2017-03-09 03:07:44', '0'),
(4, 'PEG08', '2017-03-09 03:07:44', '0'),
(5, 'PEG10', '2017-03-07 07:19:10', '0'),
(19, 'AA01', '2017-05-04 02:08:09', '228000'),
(77, 'AA01', '2017-05-03 16:51:56', '228000'),
(79, 'AA01', '2017-05-03 16:54:21', '98000'),
(89, 'AA01', '2017-05-03 16:34:53', '194000'),
(122, 'AA01', '2017-05-04 02:59:35', '80000'),
(123, 'AA01', '2017-05-04 02:58:14', '1040000'),
(789, 'PEG01', '2017-05-04 03:27:14', '90000'),
(989, 'PEG01', '2017-05-04 03:19:09', '290000'),
(170511117, 'AA01', '2017-05-10 15:46:00', '52000'),
(170511118, 'AA01', '2017-05-10 15:48:06', '52000'),
(170511119, 'AA01', '2017-05-10 15:49:24', '72034000'),
(170511120, 'AA01', '2017-05-10 15:50:46', '40086000'),
(170511121, 'AA01', '2017-05-10 15:51:12', '52000'),
(170511122, 'AA01', '2017-05-10 15:51:33', '166000'),
(170511123, 'AA01', '2017-05-10 15:53:02', '194000'),
(170511124, 'AA01', '2017-05-10 15:54:34', '166000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detail_penjualan`
--
ALTER TABLE `detail_penjualan`
  ADD PRIMARY KEY (`id_dtl_penj`),
  ADD KEY `id_penjualan` (`id_penjualan`),
  ADD KEY `id_obat` (`id_obat`);

--
-- Indexes for table `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`id_jabatan`);

--
-- Indexes for table `jabatan_pegawai`
--
ALTER TABLE `jabatan_pegawai`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_jabatan` (`id_jabatan`,`id_pegawai`),
  ADD KEY `fk_jbpg_pegawai` (`id_pegawai`);

--
-- Indexes for table `obat`
--
ALTER TABLE `obat`
  ADD PRIMARY KEY (`id_obat`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indexes for table `penerimaan`
--
ALTER TABLE `penerimaan`
  ADD PRIMARY KEY (`id_pnrm`),
  ADD KEY `id_apoteker` (`id_pegawai`,`id_obat`),
  ADD KEY `fk_penerimaan_obat` (`id_obat`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id_penjualan`),
  ADD KEY `id_kasir` (`id_pegawai`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detail_penjualan`
--
ALTER TABLE `detail_penjualan`
  MODIFY `id_dtl_penj` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;
--
-- AUTO_INCREMENT for table `jabatan_pegawai`
--
ALTER TABLE `jabatan_pegawai`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `id_penjualan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=170511125;
--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `detail_penjualan`
--
ALTER TABLE `detail_penjualan`
  ADD CONSTRAINT `fk_det_obat` FOREIGN KEY (`id_obat`) REFERENCES `obat` (`id_obat`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_det_penjualan` FOREIGN KEY (`id_penjualan`) REFERENCES `penjualan` (`id_penjualan`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `jabatan_pegawai`
--
ALTER TABLE `jabatan_pegawai`
  ADD CONSTRAINT `fk_jbpg_jabatan` FOREIGN KEY (`id_jabatan`) REFERENCES `jabatan` (`id_jabatan`),
  ADD CONSTRAINT `fk_jbpg_pegawai` FOREIGN KEY (`id_pegawai`) REFERENCES `pegawai` (`id_pegawai`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `penerimaan`
--
ALTER TABLE `penerimaan`
  ADD CONSTRAINT `fk_penerimaan_apoteker` FOREIGN KEY (`id_pegawai`) REFERENCES `pegawai` (`id_pegawai`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_penerimaan_obat` FOREIGN KEY (`id_obat`) REFERENCES `obat` (`id_obat`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  ADD CONSTRAINT `fk_penjualan_pegawai01` FOREIGN KEY (`id_pegawai`) REFERENCES `pegawai` (`id_pegawai`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
