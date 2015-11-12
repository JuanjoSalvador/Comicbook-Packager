![img](https://img.shields.io/badge/shell-bash%204.3.42-brightgreen.svg)
# CPacket
CPacket es un script de Linux que te permite empaquetar las páginas de un comic/manga en forma de archivo CBZ usando la interfaz de comandos.

**IMPORTANTE**

CPacket solo trabaja con imágenes con extensión `.jpg`.

## Instalación

**CPacket** depende del paquete `zip`. Incluye un instalador para Debian/Ubuntu y derivadas (*Linux Mint, elemetaryOS, Mangaka Linux, etc*). En otras distribuciones se necesita instalar manualmente el paquete `zip` (disponible en los repositorios si no está instalado previamente).

**Dependencias**
 * `zip`
 * `git`

#### Con instalador (Debian/Ubuntu)

Instala las dependencias y CPacket.

    $ git clone https://github.com/JuanjoSalvador/CPacket.git
    $ cd CPacket
    $ sudo chmod +x ./install.sh
    $ sudo ./install.sh

#### Sin instalador

Necesitas `zip` y `git` instalado previamente en tu distribución. El paquete `zip` viene instalado por defecto en la mayoría de distribuciones.

    $ git clone https://github.com/JuanjoSalvador/CPacket.git
    $ cd CPacket
    $ sudo cp ./cpacket /usr/local/bin

## Uso de CPacket

    $ cpacket -r MyComicDirectory/MyComic/

Empaqueta recursivamente TODO el directorio introducido como parámetro.

    $ cpacket -d MyComicDirectory/MyComic/Cap1

Empaqueta el directorio `MyComicDirectory/MyComic/Cap1` en un CBZ.

    $ cpacket --help

Muestra el menú de ayuda.

## Licencia

CPacket se encuentra liberado bajo licencia MIT. Ver LICENSE.
