-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 18 avr. 2018 à 14:58
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `suivia`
--

-- --------------------------------------------------------

--
-- Structure de la table `cabinet`
--

DROP TABLE IF EXISTS `cabinet`;
CREATE TABLE IF NOT EXISTS `cabinet` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `adresse` varchar(100) DEFAULT NULL,
  `code_postal` varchar(11) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `longitude` varchar(50) DEFAULT NULL,
  `latitude` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=293 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `cabinet`
--

INSERT INTO `cabinet` (`id`, `adresse`, `code_postal`, `ville`, `longitude`, `latitude`) VALUES
(281, '20 Rue Maurice Schumann', '62223', ' Anzin-Saint-Aubin', '2,7552761', '50,3161668'),
(282, 'Rue Alfred de Musset', '62300 ', 'Lens', '4,920098', '45,7579394'),
(283, '22 Rue du 4 Septembre', '62880 ', 'Vendin-le-Vieil', '2,3354851', '48,8700094'),
(284, '82 Avenue Marceau', '59130 ', 'Lambersart', '2,2967941', '48,8722638'),
(285, '25 Rue Saint-Sébastien', '59800 ', 'Lille', '2,3698336', '48,8613679'),
(286, '2 Rue Meurein', '59000 ', 'Lille', '3,0521858', '50,6287099'),
(287, '5 Avenue Guynemer', '59140 ', 'Dunkerque', '2,4148241', '48,7589975'),
(288, '1 Coulée verte René-Dumont', '75012 ', 'Paris', '2,371466', '48,8493828'),
(289, '7B Rue Bellot', '75019 ', 'Paris', '2,3675474', '48,8859754'),
(290, '39 Rue Bintot', '03200 ', 'Vichy', '3,4229414', '46,1284782'),
(291, '112 Rue Queue de Renard', '59805', 'leers', '0,3919388', '49,7572345'),
(292, '270 Avenue du Zoo', '49454', 'zoo', '-71,2952292', '46,88927');

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

DROP TABLE IF EXISTS `medecin`;
CREATE TABLE IF NOT EXISTS `medecin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `id_cabinet` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_medecin_id_cabinet` (`id_cabinet`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `medecin`
--

INSERT INTO `medecin` (`id`, `nom`, `prenom`, `id_cabinet`) VALUES
(1, 'Mamene', 'Rico', 282),
(2, 'Meadows', 'Kitra', 281),
(3, 'Schroediner', 'Claud', 283),
(4, 'Rios', 'Arthur', 282),
(5, 'Alact', 'Calid', 285),
(6, 'Padilla', 'Rebekah', 289),
(7, 'Marks', 'Yolanda', 290),
(8, 'Mason', 'Deirdre', 286),
(9, 'Wilkerson', 'Rina', 284),
(10, 'Rivers', 'Alfreda', 284),
(11, 'Verene', 'Alice', 289),
(12, 'Garcia', 'Lolo', 284),
(13, 'Richardson', 'Megan', 289),
(14, 'Yang', 'Britanney', 288),
(15, 'Duhamel', 'Leatitia', 285),
(16, 'Lamb', 'Devin', 283),
(17, 'Valentine', 'Erasmus', 290),
(18, 'London', 'Layla', 282),
(19, 'Grauqul', 'Tokyo', 285),
(20, 'Stephenson', 'Remedios', 281),
(21, 'Ellisa', 'Eli', 285),
(22, 'hamel', 'jocelyn', 292);

-- --------------------------------------------------------

--
-- Structure de la table `role`
--

DROP TABLE IF EXISTS `role`;
CREATE TABLE IF NOT EXISTS `role` (
  `id` int(11) NOT NULL,
  `description` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `role`
--

INSERT INTO `role` (`id`, `description`) VALUES
(1, 'visiteur'),
(2, 'administrateur');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `login` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `id_medecin` int(11) DEFAULT NULL,
  `id_role` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_utilisateur_id_medecin` (`id_medecin`),
  KEY `FK_utilisateur_id_role` (`id_role`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom`, `prenom`, `login`, `password`, `id_medecin`, `id_role`) VALUES
(2, 'Ware', 'Rahim', '1B0519A7-CBEC-2E9B-9F42-05D154051794', 'XYB20WJU1FJ', 11, 1),
(3, 'Page', 'Tanner', '42251F30-115A-FC2D-D5F5-476E455E90AD', 'DMN30FHT6GQ', 13, 1),
(4, 'Macias', 'Orson', '2F27BF16-A2A1-49E4-458D-632BBE31C8DC', 'NIX72RGI7WX', 1, 1),
(5, 'Mccarthy', 'Ulysses', '5F4C02D6-E787-908C-D6D4-207763738AA2', 'GNT01VXB1MJ', 2, 1),
(6, 'Higgins', 'Ocean', 'B928631B-2B6D-70C8-BCD7-1FBDCB9F8FF3', 'NNI56YJL7VU', 1, 1),
(7, 'Lancaster', 'Dominique', '3CB1920F-20EE-6C9C-3E30-B6C14171740B', 'KCV89AHI7ZR', 11, 1),
(8, 'Andrews', 'Zelda', 'DA6F2F63-9FCB-DBCB-9625-738CCCBC16FF', 'PMN70SPZ5FV', 10, 1),
(9, 'Rush', 'Channing', 'CBE17672-13A2-02D1-0F15-5A075845A782', 'HGM49SVK5XI', 13, 1),
(10, 'Weaver', 'Abraham', 'B4EAE87B-89B3-0603-93B4-3296611BC4CA', 'UXR05XKL2OA', 10, 1),
(11, 'Martin', 'Hayden', 'A5214356-7CC8-6BAC-A8EE-D40A8861D884', 'KBO32GJQ2SS', 9, 1),
(12, 'Harrington', 'Kalia', '64FD7ED6-3CEB-78D0-9EC6-D099593DFB56', 'NPY36ISC1UB', 21, 1),
(13, 'Santiago', 'Sophia', '44664C75-B95C-C318-0CE9-BC6400CBADA7', 'XDQ53EPN2EW', 12, 1),
(14, 'Reeves', 'Ezra', '3F7F7027-E5F7-1472-B579-32293254630F', 'ZCU03CVI5PA', 3, 1),
(15, 'David', 'Lamar', 'BBB8A687-B340-8A33-357C-A52284C8E686', 'RAI49UCF4SB', 5, 1),
(16, 'Lyons', 'Kaitlin', '55367995-6F2D-A0A1-9671-62D7B8A66300', 'JSA14FIX3EU', 17, 1),
(17, 'Gamble', 'Ria', 'CEA9DAF5-35FE-787A-4AA4-6AEDF802F318', 'GHT66XFR2FH', 5, 1),
(18, 'Terry', 'Madaline', 'E9D5B558-0F37-B330-0952-C80A65C75F7A', 'TMN51SJR8QU', 20, 1),
(19, 'Atkins', 'Jayme', '5B2A4C0F-8394-0F25-F1AC-131C3A67FEFF', 'JMZ65QET0YQ', 16, 1),
(20, 'Vang', 'Illiana', 'C1D117DF-2261-C89C-0CBF-D3DEBA51635D', 'BLM02ISU4ZJ', 3, 1),
(21, 'Spencer', 'Justine', '2F3599F6-93B4-BC28-B800-9BE1DEC78675', 'EWM09SEF7CQ', 5, 1),
(22, 'Waters', 'Athena', 'CBE9A658-874B-CE38-B9DE-0EE5317972AC', 'GPH68UGG1CG', 5, 1),
(23, 'Reid', 'Juliet', '0051650A-59FF-5487-3499-A87445BE2027', 'DNJ30CQA8NN', 17, 1),
(24, 'Scott', 'Cameron', 'FD85CAF6-7065-834E-2AB9-7210A062C87F', 'GDK16HPU6OV', 10, 1),
(25, 'Rowe', 'Eliana', '9BCA7592-D328-2422-AFDC-A7723316403B', 'VCY01QSF8DU', 1, 1),
(26, 'Nolan', 'Mallory', 'F21CB83E-5BFF-389A-24CB-E2E33B85486E', 'SGT13WAA4BO', 4, 1),
(27, 'Welch', 'Alexis', 'E698F371-6612-AF1A-1AE3-D92C8141C2E9', 'RJS44QUL0KC', 9, 1),
(28, 'Shaw', 'Anika', '5E66F8FD-0358-3DD2-95F4-CB35F7B1F73C', 'LRS99AIU8PR', 8, 1),
(29, 'Mitchell', 'Ferdinand', 'D4375F3C-574F-7700-CFF0-5E697D1D996A', 'SDO59DFL2ND', 10, 1),
(30, 'Sims', 'Griffith', '1FC9833B-5E09-413F-ED39-C8CE00E19E7C', 'NDC98IPX2LS', 4, 1),
(31, 'Nieves', 'Baxter', 'CA70DCD0-EE8F-8630-A36C-343594B3A868', 'XOT13VBX1ZQ', 1, 1),
(32, 'Townsend', 'Germane', '9F7B1143-A5D3-E243-468D-5F9987CC82F6', 'NVE38VME0CN', 12, 1),
(33, 'Harrington', 'Brennan', '77CADB9F-0EC2-3C03-7068-D16352F75038', 'KEG04EKM2XT', 7, 1),
(34, 'Hendrix', 'Cody', '2D2709AC-617D-C97E-609E-7B7FD12CB88C', 'AEI21BRS0FX', 20, 1),
(35, 'Fisher', 'Kareem', '4FDDF6FC-5CD0-97D2-9FF1-1D3702478936', 'MXP90XLA7PD', 14, 1),
(36, 'Bowen', 'Dale', '91208863-BE26-E2A9-8810-D8C660581A5C', 'RMD62XKG0VE', 6, 1),
(37, 'Fischer', 'Sean', '90F09449-7C47-420D-8C18-A3D4534C1FA3', 'LVJ73NOG0IB', 14, 1),
(38, 'Mckay', 'Pamela', '27790489-940E-0D11-747C-935FA1649893', 'ZTE82ILP3QC', 6, 1),
(39, 'Oneal', 'Kasper', '2D9FF5FF-9983-0066-B823-609D03AA0541', 'OHJ61ONW9UR', 8, 1),
(40, 'Jackson', 'Tamara', '8ABA970C-0982-0C7D-B72B-5DA9895C4D0B', 'ZPG13GOT7GF', 3, 1),
(41, 'Rojas', 'Tanek', '08718D2F-8670-B73D-4028-E34084FBF13D', 'OQU16SMC0XT', 10, 1),
(42, 'Allison', 'Tatiana', '2CF0A25E-3ACB-9920-DC12-B870CF5F536F', 'EXI26TFZ6XI', 5, 1),
(43, 'Burgess', 'Griffith', 'A922AF98-A9B5-A6B2-EE6A-CF189A894F9E', 'FNR90UUC7BE', 18, 1),
(44, 'Hurley', 'Julian', '41A5C0C0-4B2F-8DD4-66C6-CDAE597E009A', 'IDK90IDI8KL', 21, 1),
(45, 'Riggs', 'Griffith', '0413001D-2206-6019-62CE-615D7D4372F0', 'IQE19KYR8DY', 4, 1),
(46, 'Cooke', 'Mary', '3F3ECA7C-7199-B259-8A13-2AD08532A837', 'GRY31CYJ2FZ', 13, 1),
(47, 'Sutton', 'Dominique', 'B546F0DD-C13F-7B5A-5FAC-054F7C6D7FDA', 'ODD30FSH6XR', 15, 1),
(48, 'Hudson', 'Stewart', 'E08D7F8B-397B-9D52-32AD-B20069B8AB27', 'AXG14GIY8FC', 9, 1),
(49, 'Bradshaw', 'Jamalia', '15D24B3C-EB2F-FB60-162A-263C69A67593', 'WXN00ROU3TB', 13, 1),
(50, 'Vega', 'Britanney', '3E548A8B-7A0E-F78D-0FFC-7FA3F7AA1E2F', 'NPB44VQB1XF', 20, 1),
(51, 'Shaffer', 'Amir', 'EB5D2D2B-FDAA-A1F6-22FD-758EB97D4403', 'YBQ26XAC6UP', 13, 1),
(52, 'Vazquez', 'Unity', '2022CDD3-44BA-6D1C-4F0D-0F768E142703', 'ANU81ARD1UI', 17, 1),
(53, 'Decker', 'Fiona', 'F2DEA01F-ADBF-2364-247C-16EEAAA5D482', 'STC23PCI6PT', 19, 1),
(54, 'Riddle', 'Walter', '3B6FA99F-B13D-B2FB-2414-5B5AD453137D', 'GEG54WQY7SL', 19, 1),
(55, 'Kemp', 'Hamish', 'AC302482-C00B-65B1-0F0E-063A1DF4C714', 'REZ80USY2ZU', 20, 1),
(56, 'Welch', 'Tyrone', 'E2818464-E62D-558E-B268-6947CA2F588A', 'VTI49ZDS0WM', 3, 1),
(57, 'Fernandez', 'Reed', '1816870A-1732-76C2-BBE2-A398C6A57ECA', 'JYR39KNO5AN', 2, 1),
(58, 'Rasmussen', 'Eve', 'C403C8FB-92FA-D89F-83D8-5C73C91566E7', 'ZON45MCG5ZY', 15, 1),
(59, 'Delaney', 'Eaton', '4903443A-1357-BE1A-CF0E-E4436E29BF3E', 'HSC81KGA2JN', 9, 1),
(60, 'Chase', 'Abel', 'C986BB0D-B959-7686-9292-82D01BC1DC21', 'OHA20SJD5PY', 19, 1),
(61, 'Valentine', 'Mechelle', '5F4CB244-E42C-E836-07FF-6A1B1854FE93', 'KLJ05CSL2HW', 5, 1),
(62, 'Gonzales', 'Illiana', 'E53D12D2-B479-3433-5DF5-685098985AA4', 'TEY46AGV5CS', 15, 1),
(63, 'Haley', 'Hadley', 'C7D35133-F605-49C8-0453-60DDE333B3E1', 'MPB73IAX3TT', 21, 1),
(64, 'Beasley', 'Burke', 'CD1AD23D-6AE2-5BFB-CF28-AA6EA16A0903', 'CZZ11SMU8KS', 20, 1),
(65, 'Oliver', 'Tamekah', '1646F42C-2B10-4BEC-F423-F04EF0AC30DD', 'FEB75FUE1LN', 9, 1),
(66, 'Cherry', 'Hector', '56E09B23-3444-4C5E-5AE7-785E502E0F6F', 'SNK75GJR5CY', 10, 1),
(67, 'Phelps', 'Levi', '7EB6B87E-D05C-FC90-CF85-348B4429680E', 'RXL48VBT9EC', 21, 1),
(68, 'Howe', 'Sage', 'D4912061-B27D-721F-6403-8E3644B20E8D', 'CUS74RZG0EM', 11, 1),
(69, 'Hernandez', 'Deanna', 'E83290A8-7F07-3E5C-3020-6F361ABC22C7', 'HHT19KUR4BT', 8, 1),
(70, 'Bird', 'Clare', 'F2261720-6230-EAD4-6CC1-218BFC9C4968', 'RTB61TOX2OR', 20, 1),
(71, 'Larson', 'Ferris', '61A849B1-8D3B-465B-DDC7-863B40A2878C', 'MHY79ORK4BT', 21, 1),
(72, 'Kirk', 'Dakota', 'AEF6454C-96F6-084A-5559-7FEFD86D639F', 'KWO46EJI5RB', 1, 1),
(73, 'Hammond', 'Signe', '41BC4795-552A-C529-BE85-6550E5155189', 'MVK36RPT3RH', 21, 1),
(74, 'Sheppard', 'Sylvester', 'A022ABA2-8C05-3581-30BE-4546928E3E7E', 'OEV43XEV1UO', 8, 1),
(75, 'Randolph', 'Aileen', '87731068-BF0F-CBD5-CD39-71851CB3D705', 'EHO06OMW1TK', 18, 1),
(76, 'Clarke', 'Faith', '664D0343-FDCB-279B-5F74-1B417B705524', 'TMZ88KSR4ZO', 7, 1),
(77, 'Key', 'Jamal', '66D75033-7348-ACD5-E5F7-C51CBF5160D0', 'SCF95JRM4QF', 14, 1),
(78, 'Lamb', 'Hyatt', 'D97533B3-FD2F-1409-ADD5-DB869076C52F', 'MEY18YBK0MT', 6, 1),
(79, 'Gordon', 'Fatima', '5EE0CD4F-9104-8381-933B-780108101331', 'TYG47ZIT6YP', 17, 1),
(80, 'Singleton', 'Boris', '3E3BEF1E-6C56-C46A-33B4-77928341EEDA', 'MDX54RES4WW', 3, 1),
(81, 'Hawkins', 'Brock', 'E8E9CB26-38D7-C871-7224-94B99C018E27', 'JWQ52LFI7GS', 11, 1),
(82, 'Stokes', 'Declan', 'DD937DF3-979E-9A02-DFEE-08FCC277AF03', 'TQL98UEX5AT', 4, 1),
(83, 'Pittman', 'Colt', 'D1E2992F-9FC9-A438-8A28-9A003E49D1FD', 'LPW76THL8KM', 20, 1),
(84, 'Guzman', 'Odessa', '2BFD959E-4B22-8468-AF18-FC1A74929E8E', 'RKW79AAT0DY', 21, 1),
(85, 'Cote', 'Melvin', '6906720C-C6B2-C8E1-827A-B927FB14C53E', 'HEZ25TWB2IA', 15, 1),
(86, 'Mcpherson', 'Jackson', '95DA0419-B243-EBA6-1F09-4B290AD32B35', 'ZCX72KJG0OD', 19, 1),
(87, 'Williams', 'Anastasia', '89C18AE6-D01D-2375-0953-82073BAE9CAE', 'QJA78RVG6LO', 12, 1),
(88, 'Raymond', 'Jesse', '5F8605E8-5EF0-7424-2E60-C053F85BAE3D', 'IMD91APY6IA', 2, 1),
(89, 'Doyle', 'Neve', '742B0A91-EB4C-96DB-1B05-AFFF8604D47B', 'JUE88DUU2EU', 11, 1),
(90, 'Soto', 'Mercedes', '99EB1AB9-ADC4-51FB-6862-65CCEBC00E32', 'BOY63YRS0RI', 15, 1),
(91, 'Mccullough', 'Scarlet', 'BFB8E7F9-1D0D-3462-22F7-C87DF4A2F0BA', 'RHZ74UDI3YJ', 20, 1),
(92, 'Keller', 'Ima', '78249D43-6A9E-7176-3A46-807B2805DF38', 'APB81AXO6TL', 11, 1),
(93, 'Mercado', 'Serina', '3461A0DD-A547-FF81-48A1-0AD33B7A7208', 'RZP55ZHQ7SS', 13, 1),
(94, 'Pickett', 'Kristen', '1D59F2A0-134C-7321-0670-B3927930B0C1', 'LUX08URJ2IH', 7, 1),
(95, 'Wyatt', 'Caldwell', '8A849014-BBC9-1FF8-B826-C076DF703453', 'FBV64XTL8KG', 11, 1),
(96, 'Kinney', 'Caesar', '81CE5C7D-F26B-7223-8372-F41C73BF5A47', 'RWU73ZPG0JE', 16, 1),
(97, 'Berg', 'Brian', 'F7BC67B3-6465-5181-5F22-9DC2412B864E', 'AHA09TKE3TG', 3, 1),
(98, 'Horne', 'Idola', '90E4A15D-9A19-07A7-12EF-3B074D9E1FC8', 'ITV35BGP9MN', 9, 1),
(99, 'Poole', 'Kameko', '934F75A4-48F6-5C70-4BF3-69C997F63773', 'BGU89HLC3GS', 13, 1),
(100, 'Glass', 'August', 'B2B15D15-F2F4-B7A6-C951-58BC4B50F1C5', 'ZLR44AJB2TZ', 16, 1),
(101, 'Duke', 'Uriah', 'CBAC8886-2FF4-CD43-DFFF-D1F5E5C91652', 'GJX54HAX3IY', 1, 1),
(102, 'Obiedzynski', 'Thomas', 't', 't', 16, 1),
(103, 'Hamel', 'Jocelyn', 'j', 'j', 21, 2);

-- --------------------------------------------------------

--
-- Structure de la table `visite`
--

DROP TABLE IF EXISTS `visite`;
CREATE TABLE IF NOT EXISTS `visite` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rendez_vous` tinyint(1) DEFAULT NULL,
  `heure_arrivee` time DEFAULT NULL,
  `heure_debut_entretien` time DEFAULT NULL,
  `heure_depart` time DEFAULT NULL,
  `date_visite` date DEFAULT NULL,
  `id_medecin` int(11) DEFAULT NULL,
  `id_utilisateur` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_visite_id_medecin` (`id_medecin`),
  KEY `FK_visite_id_utilisateur` (`id_utilisateur`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `visite`
--

INSERT INTO `visite` (`id`, `rendez_vous`, `heure_arrivee`, `heure_debut_entretien`, `heure_depart`, `date_visite`, `id_medecin`, `id_utilisateur`) VALUES
(12, 1, '08:00:00', '10:00:00', '12:00:00', '2018-04-08', 16, 102),
(14, 0, '04:01:00', '06:01:00', '10:00:00', '2018-04-07', 16, 102);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD CONSTRAINT `FK_medecin_id_cabinet` FOREIGN KEY (`id_cabinet`) REFERENCES `cabinet` (`id`);

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `FK_utilisateur_id_medecin` FOREIGN KEY (`id_medecin`) REFERENCES `medecin` (`id`),
  ADD CONSTRAINT `FK_utilisateur_id_role` FOREIGN KEY (`id_role`) REFERENCES `role` (`id`);

--
-- Contraintes pour la table `visite`
--
ALTER TABLE `visite`
  ADD CONSTRAINT `FK_visite_id_medecin` FOREIGN KEY (`id_medecin`) REFERENCES `medecin` (`id`),
  ADD CONSTRAINT `FK_visite_id_utilisateur` FOREIGN KEY (`id_utilisateur`) REFERENCES `utilisateur` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
