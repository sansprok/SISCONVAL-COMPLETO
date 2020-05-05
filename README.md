# SISCONVAL-COMPLETO
MODULOS DE CONTROL DE VALORES Y COBRANZA COACTIVA
Luego de clonar el proyecto localmente, para continuar trabajando se presento el siguiente problema

Unable to load DLL 'SqlServerSpatial140.dll': The specified module could not be found

el cual fue resuelto en el siguiente link:
https://stackoverflow.com/questions/42654893/unable-to-load-dll-sqlserverspatial140-dll-the-specified-module-could-not-be

con el siguiente comando se soluciono el proble:

update-package -reinstall microsoft.sqlserver.types
