#!/bin/bash

# CPacket Installer
# Version 2.1 for Debian/Ubuntu
# Author: Juanjo Salvador
# Website: http://juanjosalvador.github.io/
# Repo: https://github.com/JuanjoSalvador/CPacket

	if [ "$EUID" -ne 0 ]; then 

		echo "Necesita privilegios de superusuario. Ejecuta el instalador como root."
		exit

	else
		
		echo "Instalando CPacket..."
		echo "CPacket depende de zip."
		
		if [ -e "/usr/bin/zip" ]; then
			echo "El paquete zip está instalado."
			cp ./cpacket /usr/local/bin
			chmod +x /usr/local/bin/cpacket
			echo "Finalizado"
		else
			echo "El paquete zip no está instalado. Instalando..."
			apt-get install zip
			cp ./cpacket /usr/local/bin
			chmod +x /usr/local/bin/cpacket
			echo "Finalizado"
		fi
	fi
