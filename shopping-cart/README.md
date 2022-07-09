# README

## Projekt aufsetzen

Das Arbeitsverzeichnis erstellen und hineinwechseln:

    mkdir shopping-cart
    cd shopping-cart

Eine neue Solution erzeugen:

    dotnet new sln

Eine neue Konsolenanwendung erstellen und der Solution hinzufügen:

    dotnet new console -o ShoppingCart
    dotnet sln add ShoppingCart/ShoppingCart.csproj

Die generierte Anwendung ausführen:

    dotnet run --project ShoppingCart

## Das Projekt mit Git verwalten

Eine `.gitignore`-Datei für ein C#-Projekt erstellen (Inhalt):

    .vscode/
    bin/
    obj/

Die Dateien dem Staging-Bereich hinzufügen:

    git add .gitignore
    git add shopping-cart.sln
    git add ShoppingCart

Den initialen Commit erstellen:

    git commit -m 'initial commit'

Das Repository auf ein vorher erstelltes serverseitiges Repository hochladen:

    git remote add origin [url von Gitea]
    git push -u origin master

## Ein Projekt für Unit Tests hinzufügen

Ein neues xUnit-Projekt erstellen:

    dotnet new xunit -o ShoppingCart.Tests

Das Testing-Projekt der Solution hinzufügen:

    dotnet sln add ShoppingCart.Tests/ShoppingCart.Tests.csproj

Eine Referenz vom Testing-Projekt auf das Projekt mit dem Produktivcode anlegen:

    dotnet add ShoppingCart.Tests/ShoppingCart.Tests.csproj reference ShoppingCart/ShoppingCart.csproj

Das neue Projekt und die erweiterte Solution-Datei ins Git-Repository aufnehmen:

    git add shopping-cart.sln ShoppingCart.Tests
    git commit -m 'added xUnit test project'
    git push
