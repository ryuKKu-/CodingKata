# PokeStarter 

Le but de cet exercice est de mettre en place un host générique permettant de consommer l'api [PokéAPI](https://pokeapi.co/).
Il est encouragé d'utiliser le plus possible les fonctionnalités .NET6 et C#10. 
Il est autorisé d'utiliser internet pour lire la documentation des outils / librairies.

## TODO:
	- Créer un service permettant de consommer l'api [PokéAPI](https://pokeapi.co/) au travers d'un HttpClientFactory
		- récupérer la liste paginée (https://pokeapi.co/docs/v2#resource-listspagination-section) des Pokémons https://pokeapi.co/api/v2/pokemon/
		- afficher la liste des pokemons retournés dans un log
	- Ajouter du logging avec Serilog
	- Ajouter une stratégie de résilience avec Polly. Cette stratégie devra retry le call en cas de réponse HTTP autre que 2XX
	- Ajouter une stratégie de caching pour garder en mémoire 5min le résultat du call HTTP
