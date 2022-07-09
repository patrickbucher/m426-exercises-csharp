# Repository klonen

Klonen Sie das vorliegende Repository folgendermassen:

```bash
git clone https://code.frickelbude.ch/m426/hello-csharp.git
```

# .NET-Framework 5 installieren

## Windows 10

Befolgen Sie die Anweisungen der [offiziellen
Anleitung](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50):

1. Laden Sie sich den [64-Bit Installer](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.402-windows-x64-installer) für das .NET-Framework herunter.
2. Führen Sie die Installationsroutine mit den Standardeinstellungen durch.

Öffnen Sie eine PowerShell und führen Sie den folgenden Befehl aus:

```powershell
dotnet --list-sdks
```

Es sollte Eine Versionsnummer der Form `5.x.y` ausgegeben werden.

## Ubuntu Linux 20.04 LTS

Öffnen Sie ein Terminal (Konsole) und führen Sie folgende Befehle aus
([Quelle](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu)):

```bash
wget 'https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb' -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
sudo apt update
sudo apt install -y apt-transport-https
sudo apt update
sudo apt install -y dotnet-sdk-5.0
```

Überprüfen Sie Ihre Installation mit dem folgenden Befehl:

```bash
dotnet --list-sdks
```

Es sollte Eine Versionsnummer der Form `5.x.y` ausgegeben werden.

# Tests ausführen

Wechseln Sie ins Arbeitsverzeichnis des geklonten Git-Repositories und führen
Sie folgenden Befehl aus:

```bash
dotnet test
```

Dies kann bei der ersten Ausführung einige Minuten lang dauern. Anschliessend
sollte eine grüne Erfolgsmeldung (`Passed!` bzw. `Bestanden!`) ausgegeben
werden.
