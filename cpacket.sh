#!/bin/bash

# Version 2.0
# Author: Juanjo Salvador
# Website: http://juanjosalvador.github.io/

IFS='
'

for i in * ; do
	
	newName=`echo $i | tr " " _`
        mv $i $newName	

	if [ -d "$newName" ]; then
		packed=`echo $newName.cbz`
		zip $packed $i/*.jpg
	fi
done
