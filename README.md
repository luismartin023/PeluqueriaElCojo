# Peluquería El Cojo - Sistema de Gestión 💈

## Información del Estudiante
- **Nombre:** Luis Martin Peña Mejia
- **Matrícula:** 2023-4341
- **Asignatura:** ISW-123 Programación Media
- **Profesor:** Ing. Ivan Zorrilla

## Descripción del Proyecto
Este sistema es una solución integral para la gestión de la barbería "El Cojo". Permite administrar clientes, manejar un inventario dinámico conectado a SQL Server, realizar cobros polimórficos de servicios y productos, y visualizar un ranking de empleados basado en su rendimiento.

## Requisitos del Sistema
- **Lenguaje:** C# 7.3 (.NET Framework 4.8)
- **Base de Datos:** SQL Server (Script de creación incluido)
- **IDE:** Visual Studio 2022

## Conceptos Técnicos Implementados (Unidad 3)
- ✅ **Encapsulación:** Validación de datos en propiedades de las clases `Cliente` y `Producto`.
- ✅ **Herencia:** Estructura basada en la clase `Servicio` con derivados como `CorteNormal` y `Afeitado`.
- ✅ **Polimorfismo:** Uso de la interfaz `IFacturable` para procesar cobros de diferentes tipos de objetos en una misma lista.
- ✅ **Interfaces Propias:** Creación de `IFacturable` para estandarizar el cálculo de precios y recibos.
- ✅ **IComparable:** Implementado en `Empleado` para generar un ranking automático por ventas.
- ✅ **ICloneable / IEquatable:** Implementados en `Producto` para clonación de registros y detección de códigos duplicados.
- ✅ **Atributos Personalizados:** Uso de `[Requerido]`, `[Rango]` y `[Longitud]` para marcar reglas de negocio.
- ✅ **Reflection:** Validador dinámico que lee atributos y reporta errores sin hard-coding.
- ✅ **Genéricos:** Uso de `List<T>` y métodos genéricos para la generación de reportes.
- ✅ **Persistencia:** Integración completa con SQL Server para clientes, productos y facturación.
