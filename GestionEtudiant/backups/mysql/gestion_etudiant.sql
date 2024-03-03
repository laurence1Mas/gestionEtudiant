-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 03 mars 2024 à 17:17
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_etudiant`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `chargement_adresse` ()   BEGIN
	select id,concat(quartier,' ',commune,' ',ville) as adresses from adresse;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `chargement_etudiant` ()   begin
	select id,concat(nom,' ',postnom,' ',prenom) as noms from etudiant;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertOrUpdatadresse` (IN `p_id` INT, IN `p_quartier` VARCHAR(50), IN `p_commune` VARCHAR(50), IN `p_ville` VARCHAR(50), IN `p_pays` VARCHAR(50))   BEGIN
    DECLARE countall INT;
    /* Vérifier si l'enregistrement existe déjà*/
    SELECT COUNT(*) INTO countall FROM adresse WHERE id = p_id;
    /* Si l'enregistrement existe, effectuer une mise à jour*/
    IF countall > 0 THEN
    UPDATE `adresse` SET `quartier`=p_quartier,`commune`=p_commune,`ville`=p_ville,`pays`=p_pays WHERE `id`=p_id;
    ELSE
        /* Sinon, effectuer une insertion*/
        INSERT INTO adresse (`id`,`quartier`,`commune`,`ville`,`pays`)
        VALUES (p_id,p_quartier,p_commune,p_ville,p_pays);
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertOrUpdatedomicile` (IN `p_id` INT, IN `p_id_etudiant` VARCHAR(50), IN `p_id_adresse` VARCHAR(50), IN `p_avenue` VARCHAR(50), IN `p_numero_avenue` VARCHAR(50))   BEGIN
    DECLARE countall INT;
    /* Vérifier si l'enregistrement existe déjà*/
    SELECT COUNT(*) INTO countall FROM domicile WHERE id = p_id;
    /* Si l'enregistrement existe, effectuer une mise à jour*/
    IF countall > 0 THEN
    UPDATE `domicile` SET `id_etudiant`=p_id_etudiant,`id_adresse`=p_id_adresse,`avenue`=p_avenue,`numero_avenue`=p_numero_avenue WHERE `id`=p_id;
    ELSE
        /* Sinon, effectuer une insertion*/
        INSERT INTO telephone (`id`,`id_etudiant`,`id_adresse`,`avenue`,`numero_avenue`)
        VALUES (p_id,p_id_etudiant,p_id_adresse,p_avenue,p_numero_avenue);
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertOrUpdateEtudiant` (IN `p_id` INT, IN `p_nom` VARCHAR(50), IN `p_postnom` VARCHAR(50), IN `p_prenom` VARCHAR(50), IN `p_sexe` VARCHAR(1), IN `p_etatcivil` VARCHAR(20))   BEGIN
    DECLARE prefix VARCHAR(10);
    DECLARE year VARCHAR(4);
    DECLARE counter INT;
    DECLARE primaryKey VARCHAR(20);
    DECLARE countall INT;

    SET prefix = 'ETU'; -- Préfixe du matricule
    SET year = YEAR(CURDATE()); -- Année en cours

    -- Vérifier si le matricule avec le préfixe et l'année existe déjà
    SELECT COUNT(*) INTO counter FROM etudiant
    WHERE LEFT(matricule, 7) = CONCAT(prefix, year);

    IF counter > 0 THEN
        -- Récupérer le dernier numéro utilisé dans la clé primaire
        SELECT MAX(RIGHT(matricule, LENGTH(matricule) - 7)) INTO counter FROM etudiant 
        WHERE LEFT(matricule, 7) = CONCAT(prefix, year);
        SET counter = counter + 1;
    ELSE
        SET counter = 1;
    END IF;

    -- Générer la clé primaire finale
    SET primaryKey = CONCAT(prefix, year, LPAD(counter, 10, '0'));

    /* Vérifier si l'enregistrement existe déjà */
    SELECT COUNT(*) INTO countall FROM etudiant WHERE id = p_id;

    /* Si l'enregistrement existe, effectuer une mise à jour */
    IF countall > 0 THEN
        UPDATE `etudiant` SET `nom` = p_nom, `postnom` = p_postnom, `prenom` = p_prenom, `sexe` = p_sexe, `etat_civil` = p_etatcivil, `matricule` = primaryKey
        WHERE `id` = p_id;
    ELSE
        /* Sinon, effectuer une insertion */
        INSERT INTO etudiant (`id`, `matricule`, `nom`, `postnom`, `prenom`, `sexe`, `etat_civil`)
        VALUES (p_id, primaryKey, p_nom, p_postnom, p_prenom, p_sexe, p_etatcivil);
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertOrUpdattelephone` (IN `p_id` INT, IN `p_id_proprietaire` VARCHAR(50), IN `p_initial` VARCHAR(50), IN `p_numero` VARCHAR(50))   BEGIN
    DECLARE countall INT;
    /* Vérifier si l'enregistrement existe déjà*/
    SELECT COUNT(*) INTO countall FROM telephone WHERE id = p_id;
    /* Si l'enregistrement existe, effectuer une mise à jour*/
    IF countall > 0 THEN
    UPDATE `telephone` SET `id_proprietaire`=p_id_proprietaire,`initial`=p_initial,`numero`=p_numero WHERE `id`=p_id;
    ELSE
        /* Sinon, effectuer une insertion*/
        INSERT INTO telephone (`id`,`id_proprietaire`,`initial`,`numero`)
        VALUES (p_id,p_id_proprietaire,p_initial,p_numero);
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_telephones` ()   BEGIN
	select id,id_proprietaire,initial,numero from telephone order by numero asc;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `adresse`
--

CREATE TABLE `adresse` (
  `id` int(11) NOT NULL,
  `quartier` varchar(50) DEFAULT NULL,
  `commune` varchar(50) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `pays` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `adresse`
--

INSERT INTO `adresse` (`id`, `quartier`, `commune`, `ville`, `pays`) VALUES
(1, 'kahembe', 'karisimbi', 'goma', 'RDC'),
(3, 'le volcan', 'goma', 'goma', 'RDC'),
(4, 'Katindo', 'Goma', 'Goma', 'RDC');

-- --------------------------------------------------------

--
-- Structure de la table `domicile`
--

CREATE TABLE `domicile` (
  `id` int(11) NOT NULL,
  `id_etudiant` int(11) DEFAULT NULL,
  `id_adresse` int(11) DEFAULT NULL,
  `avenue` varchar(50) DEFAULT NULL,
  `numero_avenue` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `domicile`
--

INSERT INTO `domicile` (`id`, `id_etudiant`, `id_adresse`, `avenue`, `numero_avenue`) VALUES
(1, 7, 3, 'yyyyy', 4);

-- --------------------------------------------------------

--
-- Structure de la table `etudiant`
--

CREATE TABLE `etudiant` (
  `id` int(11) NOT NULL,
  `matricule` varchar(10) DEFAULT NULL,
  `nom` varchar(50) NOT NULL,
  `postnom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `sexe` varchar(1) NOT NULL DEFAULT 'M',
  `etat_civil` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `etudiant`
--

INSERT INTO `etudiant` (`id`, `matricule`, `nom`, `postnom`, `prenom`, `sexe`, `etat_civil`) VALUES
(6, 'ETU2024000', 'kilingo', 'kikwayabo', 'jean-paul', 'M', 'celibataire'),
(7, 'ETU2024000', 'masika', 'mak', 'laure', 'F', 'celibataire'),
(8, 'ETU2024000', 'muhindo', 'kami', 'el-bethel', 'M', 'celibataire');

-- --------------------------------------------------------

--
-- Structure de la table `telephone`
--

CREATE TABLE `telephone` (
  `id` int(11) NOT NULL,
  `id_proprietaire` int(11) DEFAULT NULL,
  `initial` varchar(10) DEFAULT NULL,
  `numero` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `telephone`
--

INSERT INTO `telephone` (`id`, `id_proprietaire`, `initial`, `numero`) VALUES
(1, 8, 'uuuuuu', '+243973626826');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `adresse`
--
ALTER TABLE `adresse`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `domicile`
--
ALTER TABLE `domicile`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_personne_domicile` (`id_etudiant`),
  ADD KEY `fk_addresse_domicile` (`id_adresse`);

--
-- Index pour la table `etudiant`
--
ALTER TABLE `etudiant`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `uk_etudiant` (`nom`,`postnom`,`prenom`);

--
-- Index pour la table `telephone`
--
ALTER TABLE `telephone`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_etudiant_telephone` (`id_proprietaire`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `adresse`
--
ALTER TABLE `adresse`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `domicile`
--
ALTER TABLE `domicile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `etudiant`
--
ALTER TABLE `etudiant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `telephone`
--
ALTER TABLE `telephone`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `domicile`
--
ALTER TABLE `domicile`
  ADD CONSTRAINT `fk_addresse_domicile` FOREIGN KEY (`id_adresse`) REFERENCES `adresse` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_personne_domicile` FOREIGN KEY (`id_etudiant`) REFERENCES `etudiant` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `telephone`
--
ALTER TABLE `telephone`
  ADD CONSTRAINT `fk_etudiant_telephone` FOREIGN KEY (`id_proprietaire`) REFERENCES `etudiant` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
