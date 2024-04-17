Feature: SpecFlowMediaTekDocuments
	

@rechercheLivres

Scenario: Recherche d'un livre par l'id
	Given je saisis le numéro 00001
	When je clique sur le bouton rechercher
	Then txbLivresIsbn.Text doit être 1234569877896
	
Scenario: Recherche d'un livre par le titre
	Given je saisis le titre "Quand sort la recluse"
	Then txbLivresIsbn.Text doit être 1234569877896

Scenario: Recherche d'un livre par le genre
	When je choisis le genre qui se trouve à la ligne 2 dans le cbx
	Then dgvLivresListe comporte 5 livres

Scenario: Recherche d'un livre par le public
	When je choisis le public qui se trouve à la ligne 0 dans le cbx
	Then dgvLivresListe comporte 3 livres

Scenario: Recherche d'un livre par le rayon
	When je choisis le rayon qui se trouve à la ligne 0 dans le cbx
	Then dgvLivresListe comporte 4 livres

