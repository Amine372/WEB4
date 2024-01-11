# Quest Web Java Project

## Description
Ce projet est une application Spring Boot développée pour le module RTP-WEB4. Elle implémente une API REST simple avec trois routes de test.

## Fonctionnalités
- **Test Success Route** (`/testSuccess`): Retourne un statut HTTP 200 avec un message "success".
- **Test Not Found Route** (`/testNotFound`): Retourne un statut HTTP 404 avec un message "not found".
- **Test Error Route** (`/testError`): Retourne un statut HTTP 500 avec un message "error".

## Configuration
- Java Version: 17 ou 20
- Spring Boot Version: 3.0.* / 3.1.*
- Port d'écoute: 8090

## Démarrage de l'Application
Pour démarrer l'application, exécutez la commande suivante dans le répertoire racine du projet :
./mvnw spring-boot:run
ou si vous avez Maven installé localement :
mvn spring-boot:run

## Test de l'API
Après avoir démarré l'application, vous pouvez tester les routes API en utilisant un outil comme Postman ou en accédant aux URL suivantes via un navigateur :
- http://localhost:8090/testSuccess
- http://localhost:8090/testNotFound
- http://localhost:8090/testError

## Comment Construire
Pour construire le projet, utilisez la commande suivante :
./mvnw clean install
ou, si vous avez Maven installé localement :
mvn clean install
Cela générera un fichier JAR exécutable dans le dossier `target`.

## Dépendances
- Spring Boot Starter Web
- Autres dépendances nécessaires pour votre projet

## Auteur
Amine NAKHIL

## Licence
Aucune



