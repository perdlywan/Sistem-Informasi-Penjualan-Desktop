-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 05, 2022 at 05:48 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kelontong`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` char(10) NOT NULL,
  `password` varchar(20) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(50) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`, `nama`, `jenis_kelamin`, `no_telp`, `alamat`, `email`) VALUES
('Calvin12', '123', 'Calvin', 'Laki-Laki', '081991546789', 'Jln Pasar berdikari no.90', 'Calvin_12@gmail.com'),
('perdly_wan', '12345', 'Perdly Setiawan', 'Laki-Laki', '081378717655', 'Serang', 'perdly@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `id_barang` char(10) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `stok` varchar(100) NOT NULL,
  `harga` int(100) NOT NULL,
  `satuan` enum('Pcs','Box','Slop') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`id_barang`, `nama_barang`, `stok`, `harga`, `satuan`) VALUES
('BD01', 'Beras Gajah 10KG', '28', 135000, 'Pcs'),
('BD02', 'Indomie Ayam Bawang', '42', 94500, 'Box'),
('BD03', 'Indomie Goreng', '28', 97200, 'Box'),
('BD04', 'Kecap ABC 150ml', '31', 20500, 'Pcs'),
('BD05', 'Beras Nanas 25KG', '19', 300000, 'Pcs'),
('BD06', 'Indomie Soto Medan', '14', 94500, 'Box'),
('BD07', 'Minyak Goreng ABC 1 Liter', '25', 14000, 'Pcs'),
('BD08', 'Bawang Putih 5Kg', '16', 98000, 'Pcs'),
('BD09', 'Beras Mawar 10Kg', '10', 135000, 'Pcs'),
('RK01', 'Surya 16', '46', 221000, 'Slop'),
('RK02', 'Sampoerna Mild', '22', 230000, 'Slop'),
('RK03', 'Umild', '17', 200000, 'Slop');

-- --------------------------------------------------------

--
-- Table structure for table `pasok`
--

CREATE TABLE `pasok` (
  `id_pasok` char(10) NOT NULL,
  `tanggal` date NOT NULL,
  `admin` varchar(100) NOT NULL,
  `nama_pemasok` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pasok`
--

INSERT INTO `pasok` (`id_pasok`, `tanggal`, `admin`, `nama_pemasok`) VALUES
('P001', '2021-02-05', 'perdly_wan', 'CV Close The Door'),
('P002', '2021-02-08', 'perdly_wan', 'PT Rimba Jaya'),
('P003', '2021-02-08', 'perdly_wan', 'CV Close The Door'),
('P004', '2021-02-08', 'perdly_wan', 'PT CPD'),
('P005', '2021-02-09', 'perdly_wan', 'PT Jaya Abadi'),
('P006', '2021-02-18', 'perdly_wan', 'PT Rimba Jaya'),
('P007', '2021-02-22', 'perdly_wan', 'PT CPD'),
('P008', '2021-02-25', 'perdly_wan', 'PT Rimba Jaya'),
('P009', '2021-02-25', 'perdly_wan', 'PT Jaya Abadi');

-- --------------------------------------------------------

--
-- Table structure for table `pasok_detail`
--

CREATE TABLE `pasok_detail` (
  `id_pasok` char(10) NOT NULL,
  `id_barang` char(10) NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `satuan` varchar(100) NOT NULL,
  `stok` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pasok_detail`
--

INSERT INTO `pasok_detail` (`id_pasok`, `id_barang`, `nama_barang`, `satuan`, `stok`) VALUES
('P001', 'BD01', 'Beras Gajah 10KG', 'Pcs', '2'),
('P002', 'RK04', 'Malboro Merah', 'Slop', '5'),
('P002', 'RK03', 'Umild', 'Slop', '5'),
('P003', 'BD01', 'Beras Gajah 10KG', 'Pcs', '3'),
('P003', 'BD02', 'Indomie Ayam Bawang', 'Box', '5'),
('P004', 'RK04', 'Malboro Merah', 'Slop', '2'),
('P005', 'BD07', 'Minyak Goreng ABC 1 Liter', 'Pcs', '12'),
('P005', 'RK01', 'Surya 16', 'Slop', '12'),
('P006', 'BD08', 'Bawang Putih 5Kg', 'Pcs', '5'),
('P006', 'BD01', 'Beras Gajah 10KG', 'Pcs', '5'),
('P007', 'RK03', 'Umild', 'Slop', '2'),
('P007', 'RK04', 'Malboro Merah', 'Slop', '2'),
('P008', 'RK02', 'Sampoerna Mild', 'Slop', '10'),
('P009', 'BD02', 'Indomie Ayam Bawang', 'Box', '10'),
('P009', 'BD01', 'Beras Gajah 10KG', 'Pcs', '10');

-- --------------------------------------------------------

--
-- Table structure for table `pemasok`
--

CREATE TABLE `pemasok` (
  `nama_pemasok` varchar(50) NOT NULL,
  `no_telepon` varchar(13) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `kota` varchar(100) NOT NULL,
  `kode_pos` varchar(5) NOT NULL,
  `email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pemasok`
--

INSERT INTO `pemasok` (`nama_pemasok`, `no_telepon`, `alamat`, `kota`, `kode_pos`, `email`) VALUES
('CV Close The Door', '0771613033', 'Jln Cindera', 'Batam', '31314', 'Customer@cth2.com'),
('CV Makmur Abadi', '0771315678', 'Jln Rawasari', 'Tg pinang', '21122', 'MakmurAbadi@yahoo.com'),
('PT CPD', '077112121', 'Jln Dompak Baru', 'Dompak', '12789', 'CPD@gmail.com'),
('PT Gunung Wijaya', '077190909', 'Jln.Pasar Lama', 'Tg pinang', '13456', 'Customer@gwijaya.com'),
('PT Jaya Abadi', '0771678099', 'Jln Kampung Pisang', 'Kijang', '12322', 'Jaya.Abadi12@gmail.com'),
('PT Mawar Jaya', '077161256', 'Jln kampung baru no.6', 'Batam', '54521', 'Mawar_jaya@gmail.com'),
('PT Rimba Jaya', '0771101020', 'Jln Rimba Baru', 'Kijang', '15678', 'Jaya12Rimba@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `no_transaksi` char(10) NOT NULL,
  `admin` varchar(10) NOT NULL,
  `tanggal` date NOT NULL,
  `total` varchar(100) NOT NULL,
  `jumlah_pembayaran` varchar(100) NOT NULL,
  `kembalian` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`no_transaksi`, `admin`, `tanggal`, `total`, `jumlah_pembayaran`, `kembalian`) VALUES
('001', 'perdly_wan', '2021-02-05', '270.000', '300000', '30.000'),
('002', 'perdly_wan', '2021-02-08', '1.431.000', '1500000', '69.000'),
('003', 'perdly_wan', '2021-02-08', '205.000', '220000', '15.000'),
('004', 'perdly_wan', '2021-02-09', '2.820.000', '3000000', '180.000'),
('005', 'perdly_wan', '2021-02-18', '1.350.000', '1400000', '50.000'),
('006', 'perdly_wan', '2021-02-22', '242.500', '250000', '7.500'),
('007', 'perdly_wan', '2021-02-25', '270.000', '300000', '30.000'),
('008', 'perdly_wan', '2021-02-25', '340.000', '350000', '10.000');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_detail`
--

CREATE TABLE `transaksi_detail` (
  `no_transaksi` char(10) NOT NULL,
  `id_barang` char(10) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga` int(50) NOT NULL,
  `qty` int(50) NOT NULL,
  `jumlah` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi_detail`
--

INSERT INTO `transaksi_detail` (`no_transaksi`, `id_barang`, `nama_barang`, `harga`, `qty`, `jumlah`) VALUES
('001', 'BD01', 'Beras Gajah 10KG', 135000, 2, 270000),
('002', 'BD02', 'Indomie Ayam Bawang', 94500, 10, 945000),
('002', 'BD03', 'Indomie Goreng', 97200, 5, 486000),
('003', 'BD04', 'Kecap ABC 150ml', 20500, 10, 205000),
('004', 'BD07', 'Minyak Goreng ABC 1 Liter', 14000, 12, 168000),
('004', 'RK01', 'Surya 16', 221000, 12, 2652000),
('005', 'BD01', 'Beras Gajah 10KG', 135000, 10, 1350000),
('006', 'BD07', 'Minyak Goreng ABC 1 Liter', 14000, 10, 140000),
('006', 'BD04', 'Kecap ABC 150ml', 20500, 5, 102500),
('007', 'BD01', 'Beras Gajah 10KG', 135000, 2, 270000),
('008', 'BD01', 'Beras Gajah 10KG', 135000, 2, 270000),
('008', 'BD07', 'Minyak Goreng ABC 1 Liter', 14000, 5, 70000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indexes for table `pasok`
--
ALTER TABLE `pasok`
  ADD PRIMARY KEY (`id_pasok`);

--
-- Indexes for table `pasok_detail`
--
ALTER TABLE `pasok_detail`
  ADD KEY `id_pasok` (`id_pasok`);

--
-- Indexes for table `pemasok`
--
ALTER TABLE `pemasok`
  ADD PRIMARY KEY (`nama_pemasok`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`no_transaksi`),
  ADD KEY `admin` (`admin`);

--
-- Indexes for table `transaksi_detail`
--
ALTER TABLE `transaksi_detail`
  ADD KEY `no_transaksi` (`no_transaksi`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pasok_detail`
--
ALTER TABLE `pasok_detail`
  ADD CONSTRAINT `pasok_detail_ibfk_1` FOREIGN KEY (`id_pasok`) REFERENCES `pasok` (`id_pasok`);

--
-- Constraints for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`admin`) REFERENCES `admin` (`username`);

--
-- Constraints for table `transaksi_detail`
--
ALTER TABLE `transaksi_detail`
  ADD CONSTRAINT `transaksi_detail_ibfk_1` FOREIGN KEY (`no_transaksi`) REFERENCES `transaksi` (`no_transaksi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
