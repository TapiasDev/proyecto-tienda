USE LaQuiebraBD;
GO

INSERT INTO Usuarios (usuario, contrasena, rol) VALUES
('admin', 'admin123', 'Administrador'),
('invitado1', 'clave123', 'Invitado');

INSERT INTO Clientes (codigo, nombre, telefono, correo, direccion) VALUES
(1, 'Carlos', '3001234567', 'carlos@mail.com', 'Calle 10 #20-30'),
(2, 'Empresa Logística', '6019876543', 'contacto@logistica.com', 'Avenida 17 #45-12'),
(3, 'María', '3157654321', 'maria@mail.com', 'Carrera 7 #12-08');

INSERT INTO Creditos (codigo_cliente, monto_inicial, saldo_actual, estado, fecha_otorgamiento) VALUES
(1, 5000000.00, 5000000.00, 'Activo', '2026-01-15'),
(2, 12000000.00, 12000000.00, 'Activo', '2026-02-01'),
(3, 2000000.00, 2000000.00, 'Activo', '2026-01-05');

INSERT INTO Pagos (id_credito, valor_cuota, observacion) VALUES
(1, 500000.00, 'Pago primera cuota'),
(3, 2000000.00, 'Pago total para retirar crédito cumplido');
GO