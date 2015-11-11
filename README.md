# CPacket
CPacket es un script de Linux que te permite empaquetar las páginas de un comic/manga en forma de archivo CBZ usando la interfaz de comandos.

## Instalación

**CPacket** depende del paquete `zip`. Incluye un instalador para Debian/Ubuntu y derivadas (Linux Mint, elemetaryOS, Mangaka Linux, etc). En otras distribuciones se necesita instalar manualmente el paquete `zip` (disponible en los repositorios si no está instalado previamente).

**Dependencias**
 * `zip`
 * `git`

#### Con instalador (Debian/Ubuntu)

    $ git clone https://github.com/JuanjoSalvador/CPacket.git
    $ cd CPacket
    $ sudo chmod +x ./install.sh
    $ sudo ./install.sh

#### Sin instalador

    $ git clone https://github.com/JuanjoSalvador/CPacket.git
    $ cd CPacket
    $ sudo cp ./cpacket /usr/local/bin

## Uso de CPacket

    $ cpacket

Empaqueta recursivamente TODO el directorio actual.

    $ cpacket -d MyComicDirectory/MyComic/Cap1

Empaqueta el directorio `MyComicDirectory/MyComic/Cap1` en un CBZ.

    $ cpacket --help

Muestra el menú de ayuda.

## Licencia

CPacket se encuentra liberado bajo licencia MIT. Ver LICENSE.
