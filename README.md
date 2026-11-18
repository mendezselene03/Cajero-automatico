# 🏧 Sistema de Cajero Automático (ATM)

> **Institución:** ISFT Nº 93 de San Vicente.  
> **Carrera:** Tecnicatura Superior en Análisis, Desarrollo y Programación de Aplicaciones. 
> **Ciclo Lectivo:** 2026.
> **Profesor:** Mariano Spala.
> **Integrantes:** Ledesma Franco, Mendez Selene.

---

## 📋 1. Introducción
El presente proyecto consiste en el desarrollo de un software a medida para un **Cajero Automático (ATM)**. El sistema permite gestionar de manera integral las sesiones de los usuarios, validar credenciales de tarjetas y PIN, ejecutar operaciones bancarias (consultas de saldo, extracciones de dinero y transferencias), registrar cada transacción en un LOG de auditoría e imprimir comprobantes físicos o gestionar contingencias ante fuera de servicio.

---

## 🛠️ 2. Tecnologías y Entorno
* **Lenguaje:** C# (.NET / Windows Forms)
* **Base de Datos / Arquitectura:** Integración con Sucursal y Red Central (Simulación de BD)
* **Control de Versiones:** Git / GitHub

---

## ⚙️ 3. Requerimientos Funcionales del Software

* **Gestión de Sesión y Autenticación:** Control del ciclo de vida de la sesión (validación de tarjeta, ingreso de PIN, menú de operaciones y cierre seguro). Incluye un bloqueo preventivo de la tarjeta y cierre de sesión tras **3 intentos fallidos** de PIN.
* **Operaciones Bancarias:** Ejecución de consultas de saldo, extracciones con validación de límites diarios y disponibilidad de efectivo, y transferencias por Alias/CVU.
* **Auditoría (LOG):** Registro automático e inalterable en un LOG de transacciones (almacenando ID, fecha, hora, tipo de operación y resultado).
* **Emisión de Comprobantes:** Control del estado de la impresora para emitir el ticket correspondiente y expulsión física de la tarjeta al finalizar.

---

## 🖥️ 4. Manual de Usuario (Interfaces del Sistema)

### 1. Inserción de Tarjeta (`FrmInsertarTarjeta`)
* **Descripción:** Pantalla principal de bienvenida que permite iniciar sesión ingresando los 16 dígitos de la tarjeta.
* **Controles:** Campo de texto de tarjeta, botón **"INSERTAR TARJETA"**, área de mensajes de error y botón **"Salir"**.

### 2. Ingreso de PIN (`FrmPin`)
* **Descripción:** Interfaz de autenticación por clave numérica de 4 dígitos.
* **Controles:** Visualización enmascarada (`••••`), contador de intentos restantes (máx. 3), teclado numérico virtual (0-9), botones **"BORRAR"**, **"ACEPTAR"**, **"CANCELAR"** y temporizador de sesión (60s).

### 3. Menú Principal (`FrmMenu`)
* **Descripción:** Interfaz central tras una autenticación exitosa que muestra las opciones operativas y los datos enmascarados de la tarjeta activa.
* **Opciones:** *Consultar Saldo*, *Extraer Dinero*, *Ver Movimientos (Log)*, *Transferencia* y botón **"FINALIZAR"**.

### 4. Consulta de Saldo (`Consulta de Saldo`)
* **Descripción:** Visualiza el saldo disponible, número de cuenta y la marca de tiempo exacta de la consulta.

### 5. Extracción de Dinero (`FrmExtraccion`)
* **Descripción:** Permite retirar efectivo seleccionando montos rápidos (`2.000`, `5.000`, `10.000`, `20.000`) o escribiendo un monto personalizado, validando siempre el límite diario restante.

### 6. Transferencias (`FrmConfirmarTransferencia`)
* **Descripción:** Módulo para transferir fondos ingresando el **Alias / CVU de destino** y el monto exacto a envia.

### 7. Registro de Transacciones / Auditoría (`FrmLog`)
* **Descripción:** Grilla (`DataGridView`) que lista las operaciones históricas (`ID`, `Fecha y Hora`, `Operación`, `Nº Transacción`, `Resultado`) con un menú desplegable para filtrar por tipo de movimiento.

### 8. Emisión de Ticket (`FrmTicket`)
* **Descripción:** Vista previa del comprobante y opciones para imprimir (`IMPRIMIR TICKET`) u omitir (`SIN TICKET`), culminando con la expulsión de la tarjeta y despedida.

---

## 📂 5. Estructura de Clases Principal
El diseño orientado a objetos incluye las clases:
* `CajeroAutomatico`.
* `Sesion`.
* `Tarjeta`.
* `Operacion` (con sus clases hijas: `Consulta`, `Extraccion`, `Transferencia`).
* `LogTransaccion`.

---

