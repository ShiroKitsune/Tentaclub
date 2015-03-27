# Documentation

## Principe

* Écriture facilité, pas besoin d'utiliser de guillemets
* Une ligne = une action
* Utilisation de commandes pour utiliser les fonctionnalités
* Système Goto-Label pour les bifurcations
* Possibilité de mettre des commentaires

## Scénario
	
	 :Locuteur
	Blablablablabla blabla bla blablabla
	Blabla bla blablabla
	
	:Locuteur2
	Blablablablabla blabla bla blablabla

## Commandes spéciales

Format : /commande param1;param2;...

### Visuel

	/character url|#null
	/background url|#null
	/transition name
	/endtransition

### Son

	/music url|#null
	/sound url

### Bifurcations

	/goto name
	/label name
	/menu text1/label1/text2/label2/text3/label3

## Mots-clé

* `#null` : représente la valeur "vide"

## Commentaires

	// Commentaire en ligne
	/*
	... Bloc de commentaire ...
	*/

# Exemple

	/transition pixel
	/character fred-sakura
	/background fred-sakuraroom
	/music fred-dansedescanard
	/sound fred-coincoin
	/endtransition

	:Sakura
	Voilà c'est ma chambre.
	Mes parents ne sont pas là tu sais...

	:Moi
	Je ne vois pas ce que vous voulez dire madame.
	Je suis un homme parfaitement intègre vous savez.

	:Sakura
	Allez montre ton robinet !

	/menu Bon... Okay./kenildioui/Non c'est non !/kenildinon

	/label kenildioui
	...
	/goto suite

	/label kenildinon
	...
	/goto suite

	/label suite

	/sound fred-ouverture-porte

	:Plombier
	On a parlé de robinet ?

	/character fred-plombier
	/music fred-mario-niveau1
	/sound fred-mario-champignon

	:Moi
	Mais qui êtes vous ?

	:Mario
	It's me, Mario !

	// TODO : Mario baise tout le monde, vole la caisse et se barre par la fenêtre

	/*
	:Mario
	Oh oui Yoshi ! Vas-y, lèche moi mon anus !

	:Yoshi
	Blblblblblblblblblbllb...
	Hihihiihiiiii !
	Blblblblblblblbllb....
	*/

	/character #null
	/background #null
	/music #null

	:
	THE END
