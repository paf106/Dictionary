REM Borra las carpetas basura de un proyecto c#
@echo off
:menu
cls
echo 1. Borrar basura (Si ya estas en la misma carpeta del proyecto)
echo 2. Establecer carpeta del proyecto
echo    Escribe un numero: 
set /p respuesta=

if %respuesta% == 1 goto:borrarBasura
if %respuesta% == 2 goto:carpetaProyecto

:borrarBasura
cls
REM Carpetas a borrar
REM IF exist %temp%/ruta.txt echo existe
IF exist bin (rd /s /q bin && echo carpeta bin borrada) ELSE (echo no existe la carpeta bin)
IF exist obj (rd /s /q obj && echo carpeta obj borrada) ELSE (echo no existe la carpeta obj)
IF exist .vs (rd /s /q .vs && echo carpeta .vs borrada) ELSE (echo no existe la carpeta .vs)
pause>nul
exit

:carpetaProyecto
cls
echo Introduce la ruta absoluta de la carpeta del proyecto:
set /p ruta=

REM echo %ruta% > %temp%/ruta.txt
cd %ruta%
goto:borrarBasura