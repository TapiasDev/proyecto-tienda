CREATE DATABASE LaQuiebraBD
GO

USE LaQuiebraBD;
GO

CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    usuario VARCHAR(50) UNIQUE NOT NULL,
    contrasena VARCHAR(50) NOT NULL,
    rol VARCHAR(30) NOT NULL,
    fecha_creacion DATETIME DEFAULT GETDATE()
);

CREATE TABLE Clientes (
    codigo INT PRIMARY KEY NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(20),
    correo VARCHAR(100),
    direccion VARCHAR(150),
    fecha_registro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Creditos (
    id_credito INT IDENTITY(1,1) PRIMARY KEY,
    codigo_cliente INT NOT NULL,
    monto_inicial DECIMAL(12,2) NOT NULL,
    saldo_actual DECIMAL(12,2) NOT NULL,
    estado VARCHAR(20) DEFAULT 'Activo' CHECK (estado IN ('Activo', 'Cumplido', 'Anulado')),
    fecha_otorgamiento DATE NOT NULL,
    CONSTRAINT fk_credito_cliente FOREIGN KEY (codigo_cliente) 
        REFERENCES Clientes(codigo) 
        ON UPDATE CASCADE
);

CREATE TABLE Pagos (
    id_pago INT IDENTITY(1,1) PRIMARY KEY,
    id_credito INT NOT NULL,
    valor_cuota DECIMAL(12,2) NOT NULL,
    fecha_pago DATETIME DEFAULT GETDATE(),
    observacion VARCHAR(255),
    CONSTRAINT fk_pago_credito FOREIGN KEY (id_credito) 
        REFERENCES Creditos(id_credito) 
        ON UPDATE CASCADE
);
GO

CREATE VIEW Vw_EstadoCartera AS
SELECT 
    c.codigo AS codigo_cliente,
    c.nombre AS nombre_cliente,
    cr.id_credito,
    cr.monto_inicial,
    cr.saldo_actual,
    cr.estado AS estado_credito
FROM Clientes c
INNER JOIN Creditos cr ON c.codigo = cr.codigo_cliente;
GO

CREATE TRIGGER trg_actualizar_saldo_pago
ON Pagos
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE c
    SET 
        c.saldo_actual = c.saldo_actual - i.valor_cuota,
        c.estado = CASE 
                    WHEN (c.saldo_actual - i.valor_cuota) <= 0 THEN 'Cumplido' 
                    ELSE c.estado 
                   END
    FROM Creditos c
    INNER JOIN inserted i ON c.id_credito = i.id_credito;
END;
GO