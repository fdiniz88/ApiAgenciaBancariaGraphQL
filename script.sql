CREATE TABLE AgenciasBancaria (
    AgenciaBancariaId UUID PRIMARY KEY,
    Nome TEXT NOT NULL,
    Endereco TEXT
);

-- Criação da tabela ContaBancaria
CREATE TABLE ContasBancaria (
    ContaBancariaId UUID PRIMARY KEY,
    NumeroConta TEXT NOT NULL,
    Saldo REAL,
    AgenciaBancariaId UUID REFERENCES AgenciaBancaria(AgenciaBancariaId)
);

-- Criação da tabela Cliente
CREATE TABLE Clientes (
    ClienteId UUID PRIMARY KEY,
    Nome TEXT NOT NULL,
    Sobrenome TEXT,
    Email TEXT,
    ContaBancariaId UUID REFERENCES ContaBancaria(ContaBancariaId)
);



-- Inserção de dados fictícios na tabela AgenciaBancaria
INSERT INTO AgenciaBancaria (AgenciaBancariaId, Nome, Endereco) VALUES
    ('29d94a898d9649d49e9c335eab2b650a', 'AgenciaA', 'Rua A, 123'),
    ('3a21dbcef7f64b9abaef504511263cee', 'AgenciaB', 'Avenida B, 456'),
    ('a87c8e0e63f14cc7b83a1a6b60959d36', 'AgenciaC', 'Praça C, 789');

-- Inserção de dados fictícios na tabela ContaBancaria
INSERT INTO ContaBancaria (ContaBancariaId, NumeroConta, Saldo, AgenciaBancariaId) VALUES
    ('7f5e1c23d7744922b8f9ff8667fb42bf', '123456789', 1000.00, '29d94a898d9649d49e9c335eab2b650a'),
    ('33c5b0bb73954ebaa9222c3322e267bc', '987654321', 500.00, '3a21dbcef7f64b9abaef504511263cee'),
    ('6d08a9dd4907452d8ea1a46e75d171cd', '111222333', 1500.00, 'a87c8e0e63f14cc7b83a1a6b60959d36');

-- Inserção de dados fictícios na tabela Cliente
INSERT INTO Cliente (ClienteId, Nome, Sobrenome, Email, ContaBancariaId) VALUES
    ('c5a66b10862d4d5da98d3a14e4e3da92', 'João', 'Silva', 'joao.silva@email.com', '7f5e1c23d7744922b8f9ff8667fb42bf'),
    ('3cbf93e503a04c39a126f7a1e150ca9b', 'Maria', 'Santos', 'maria.santos@email.com', '33c5b0bb73954ebaa9222c3322e267bc'),
    ('edb236972d0a458d8a1d87481a361515', 'Carlos', 'Ferreira', 'carlos.ferreira@email.com', '6d08a9dd4907452d8ea1a46e75d171cd');
