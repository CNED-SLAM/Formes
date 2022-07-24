Feature: Formes

Scenario: Calcul perimetre carre
	Given je saisis la valeur 5
	When je clic sur le bouton radio RdbCarre
	Then le resultat est 20 dans TxtPerimetre

Scenario: Calcul aire carre
	Given je saisis la valeur 5
	When je clic sur le bouton radio RdbCarre
	Then le resultat est 25 dans TxtAire

Scenario: Calcul perimetre cercle
	Given je saisis la valeur 5
	When je clic sur le bouton radio RdbCercle
	Then le resultat est 31.41 dans TxtPerimetre

Scenario: Calcul aire cercle
	Given je saisis la valeur 5
	When je clic sur le bouton radio RdbCercle
	Then le resultat est 78.53 dans TxtAire

Scenario: Calcul aire cube
	Given je saisis la valeur 5
	When je clic sur le bouton radio RdbCube
	Then le resultat est 150 dans TxtAire

Scenario: Calcul volume cube
	Given je saisis la valeur 5
	When je clic sur le bouton radio RdbCube
	Then le resultat est 125 dans TxtVolume

Scenario: Calcul aire sphere
	Given je saisis la valeur 5
	When je clic sur le bouton radio RdbSphere
	Then le resultat est 314.16 dans TxtAire

Scenario: Calcul volume sphere
	Given je saisis la valeur 5
	When je clic sur le bouton radio RdbSphere
	Then le resultat est 523.59 dans TxtVolume