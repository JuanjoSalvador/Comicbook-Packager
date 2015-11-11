#!/bin/bash

# CPacket Installer
# Version 2.1
# Author: Juanjo Salvador
# Website: http://juanjosalvador.github.io/
# Repo: https://github.com/JuanjoSalvador/CPacket

	if [ "$EUID" -ne 0 ]; then 

		echo "Necesita privilegios de superusuario. Ejecuta el instalador como root."
		exit

	else

		echo "Instalando CPacket..."

		cp ./cpacket /usr/local/bin

		echo "Finalizado"

	fi
