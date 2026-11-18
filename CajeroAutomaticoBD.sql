-- Creamos la nueva base de datos limpia
CREATE DATABASE CajeroAutomaticoBD;
GO

USE CajeroAutomaticoBD;
GO

-- 1. Tabla de Cuentas bancarias
CREATE TABLE Cuentas (
    IdCuenta INT IDENTITY(1,1) PRIMARY KEY,
    NumeroCuenta VARCHAR(20) NOT NULL UNIQUE,
    Titular VARCHAR(100) NOT NULL,
    Saldo DECIMAL(18,2) NOT NULL,
    LimiteDiario DECIMAL(18,2) NOT NULL,
    Alias VARCHAR(50) NULL
);
GO

-- 2. Tabla de Tarjetas
CREATE TABLE Tarjetas (
    IdTarjeta INT IDENTITY(1,1) PRIMARY KEY,
    NroTarjeta VARCHAR(20) NOT NULL UNIQUE,
    PinHash VARCHAR(100) NOT NULL,
    IdCuenta INT NOT NULL,
    Bloqueada BIT NOT NULL DEFAULT 0,
    IntentosFallidos INT NOT NULL DEFAULT 0,
    FOREIGN KEY (IdCuenta) REFERENCES Cuentas(IdCuenta)
);
GO

-- 3. Tabla de Transacciones / Log de Auditoría
CREATE TABLE LogTransacciones (
    IdRegistro INT IDENTITY(1,1) PRIMARY KEY,
    FechaHora DATETIME NOT NULL DEFAULT GETDATE(),
    TipoOperacion VARCHAR(50) NOT NULL,
    NroTransaccion VARCHAR(50) NOT NULL,
    Resultado VARCHAR(20) NOT NULL
);
GO

-- ==========================================
-- DATOS DE PRUEBA OFICIALES
-- ==========================================
INSERT INTO Cuentas (NumeroCuenta, Titular, Saldo, LimiteDiario, Alias) 
VALUES ('0001-234567/8', 'Juan Pérez', 125430.50, 100000.00, 'dexter.mendez');

INSERT INTO Tarjetas (NroTarjeta, PinHash, IdCuenta, Bloqueada, IntentosFallidos) 
VALUES ('450789123456', '1234', 1, 0, 0);
GO

USE CajeroAutomaticoBD;
GO

UPDATE Tarjetas 
SET Bloqueada = 0, IntentosFallidos = 0 
WHERE NroTarjeta = '450789123456';
GO