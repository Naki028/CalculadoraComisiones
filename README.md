# Calculadora de Comisiones de Ventas

## Descripcion general
Este proyecto es una aplicacion web desarrollada con Blazor Server (.NET 8) para calcular comisiones de ventas de forma automatica, transparente y consistente segun el pais de operacion del vendedor.

La solucion permite ingresar ventas totales, descuentos y pais, y devuelve el resultado de la comision neta de manera inmediata en pantalla.

## Objetivo
Facilitar el calculo de comisiones mensuales para vendedores de distintos paises, reduciendo errores manuales y asegurando que las reglas de negocio se apliquen correctamente.

## Reglas de negocio implementadas
- India: comision del 10% sobre el monto neto.
- Estados Unidos (US): comision del 15% sobre el monto neto.
- Reino Unido (UK): comision del 12% sobre el monto neto.
- Monto neto: ventas totales menos descuentos.
- Si el pais no esta definido en reglas, la comision resultante es 0.

## Funcionamiento del sistema
1. El usuario selecciona el pais.
2. El usuario ingresa ventas totales y descuentos.
3. El sistema valida los datos del formulario.
4. Si los datos son validos, se calcula el monto neto y luego la comision segun el pais.
5. El resultado se muestra con detalle en el panel de salida.
6. El boton Limpiar reinicia todos los campos y el estado de validacion.

## Validaciones aplicadas
- Pais obligatorio.
- Ventas totales obligatorias y mayores o iguales a 0.
- Descuentos obligatorios y mayores o iguales a 0.
- Los descuentos no pueden ser mayores que las ventas.

## Arquitectura de software
El proyecto sigue arquitectura por capas para mantener separacion de responsabilidades:

- Capa de presentacion: componentes Razor/Blazor para la interaccion con el usuario.
- Capa de aplicacion: servicio de calculo que coordina el proceso de negocio. Parte de la capa de Logica.
- Capa de dominio: modelos, enumeraciones e interfaces de reglas de comision. Parte de la capa de Logica.
- Capa de infraestructura: proveedor de reglas en memoria por pais. Actua como la capa de datos.

Esta organizacion facilita mantenimiento, pruebas y crecimiento del sistema.

