![img](https://img.shields.io/badge/shell-bash%204.3.42-brightgreen.svg)
# Comicbook Packager
**Comicbook Packager** es un script en bash que te permite empaquetar las páginas de un comic/manga en forma de archivo CBZ usando la interfaz de comandos o una interfaz gráfica.

**IMPORTANTE**

Comicbook Packager solo trabaja con imágenes con extensión `.jpg`.

## Instalación

**Comicbook Packager** depende del paquete `zip`. Incluye un instalador para Debian/Ubuntu y derivadas (*Linux Mint, elemetaryOS, Mangaka Linux, etc*). En otras distribuciones se necesita instalar manualmente el paquete `zip` (disponible en los repositorios si no está instalado previamente).

**Dependencias**
 * `zip`
 * `git` (opcional)
 * `zenity` (GTK, opcional)
 * `propper-utils` (opcional)

#### Con instalador (Debian/Ubuntu)

Instala las dependencias y Comicbook Packager.

    $ git clone https://github.com/JuanjoSalvador/Comicbook-Packager.git
    $ cd Comicbook-Packager
    $ sudo chmod +x ./install
    $ sudo ./install

#### Sin instalador

Necesitas `zip` (dependencia), `propper-utils` (opcinal, para PDF) y `git` (opcional) instalado previamente en tu distribución. El paquete `zip` viene instalado por defecto en la mayoría de distribuciones.

    $ git clone https://github.com/JuanjoSalvador/Comicbook-Packager.git
    $ cd Comicbook-Packager
    $ sudo cp ./cbp /usr/local/bin

## Uso de Comicbook Packager

    $ cbp

Abre la interfaz gráfica de Comicbook Packager.

    $ cbp -r MyComicDirectory/MyComic/

Empaqueta cada directorio válido dentro del directorio indicado en un CBZ.

    $ cbp -d MyComicDirectory/MyComic/Cap1

Empaqueta el directorio `MyComicDirectory/MyComic/Cap1` en un CBZ.

    $ cbp --help

Muestra el menú de ayuda.

    $ cbp -pdf MyComicDirectory/MyComic.pdf
    
Convierte un comic en PDF a CBZ.

## Licencia

Comicbook Packager se encuentra liberado bajo licencia MIT. Ver LICENSE.
