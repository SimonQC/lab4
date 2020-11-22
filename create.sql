/*

CREATE DATABASE `lab4a`

CREATE TABLE `utilisateurs` (
  `IdUtilisateur` varchar(32) NOT NULL,
  `Prenom` varchar(45) DEFAULT NULL,
  `Nom` varchar(45) DEFAULT NULL,
  `Courriel` varchar(45) DEFAULT NULL,
  `MotDePasse` varchar(45) DEFAULT NULL,
  `DateDeNaissance` datetime DEFAULT NULL,
  `Homme` tinyint(4) DEFAULT NULL,
  `Telephone` varchar(45) DEFAULT NULL,
  `NumCivique` int(11) DEFAULT NULL,
  `Rue` varchar(45) DEFAULT NULL,
  `NumCarteCredit` varchar(45) DEFAULT NULL,
  `CouleurPreferee` int(11) DEFAULT NULL,
  `SiteWeb` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IdUtilisateur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
SELECT * FROM lab4a.utilisateurs;

*/