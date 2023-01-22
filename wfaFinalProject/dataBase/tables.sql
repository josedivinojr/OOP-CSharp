-- create and populate tables

DROP TABLE IF EXISTS costumer;

CREATE TABLE costumer(
	costumer_id SERIAL NOT NULL,
	costumer_cpfcnpj VARCHAR (100) PRIMARY KEY  NOT NULL,
	costumer_name VARCHAR (100) NOT NULL, --Nome Fantasia
	costumer_address VARCHAR (100) NOT NULL,
	costumer_email VARCHAR (100) NOT NULL,
	costumer_phone VARCHAR (100) NOT NULL
);
-- valores gerados do https://www.4devs.com.br/gerador_de_empresas
INSERT INTO costumer (costumer_cpfcnpj, costumer_name, costumer_address, costumer_email, costumer_phone)
VALUES ('86.660.772/0001-75', 'Dell Computadores do Brasil Ltda.', 'São Paulo', 'dell@email.com', '(31) 98765-4321')

INSERT INTO costumer (costumer_cpfcnpj, costumer_name, costumer_address, costumer_email, costumer_phone)
VALUES ('60.975.228/0001-29', 'Vinicius e Nair Ferragens Ltda.', 'Minas Gerais', 'viniciusenairferragensltda@email.com', '(34) 99448-6943')

INSERT INTO costumer (costumer_cpfcnpj, costumer_name, costumer_address, costumer_email, costumer_phone)
VALUES ('08.611.832/0001-56', 'Telecomunicações Ltda.', 'São Paulo', 'telecom@email.com', '(11) 97122-1234')

INSERT INTO costumer (costumer_cpfcnpj, costumer_name, costumer_address, costumer_email, costumer_phone)
VALUES ('220.482.721-74', 'Armando Silva.', 'Rio de Janeiro', 'armandosilva@email.com', '(21) 65473-4321')

INSERT INTO costumer (costumer_cpfcnpj, costumer_name, costumer_address, costumer_email, costumer_phone)
VALUES ('198.271.324-70', 'Tobias Pes.', 'Minas Gerais', 'tobias@email.com', '(34) 12365-9191')

drop table if exists asset;

CREATE TABLE asset(
	asset_id SERIAL PRIMARY KEY,
	asset_serial VARCHAR(100) UNIQUE NOT NULL,
	asset_model VARCHAR(100) UNIQUE NOT NULL,
	costumer_cpfcnpj VARCHAR (100) REFERENCES costumer(costumer_cpfcnpj)
);

INSERT INTO asset (asset_serial, asset_model, costumer_cpfcnpj)
VALUES ('2270674-80', 'R-45n', '198.271.324-70')

INSERT INTO asset (asset_serial, asset_model, costumer_cpfcnpj)
VALUES ('4028240-17', 'R-75i', '08.611.832/0001-56')

INSERT INTO asset (asset_serial, asset_model, costumer_cpfcnpj)
VALUES ('7989896-43', 'IRN-150', '220.482.721-74')

INSERT INTO asset (asset_serial, asset_model, costumer_cpfcnpj)
VALUES ('7353794-21', 'R-90ne', '86.660.772/0001-75')

INSERT INTO asset (asset_serial, asset_model, costumer_cpfcnpj)
VALUES ('8007953-84', 'R-7,5n', '86.660.772/0001-75')

INSERT INTO asset (asset_serial, asset_model, costumer_cpfcnpj)
VALUES ('7080822-87', 'R-90i', '86.660.772/0001-75')

INSERT INTO asset (asset_serial, asset_model, costumer_cpfcnpj)
VALUES ('5951518-40', 'R75-ne', '86.660.772/0001-75')

INSERT INTO asset (asset_serial, asset_model, costumer_cpfcnpj)
VALUES ('6939844-22', 'UP6-30-125', '08.611.832/0001-56')

select * from asset


drop table if exists appointment;

CREATE TABLE appointment (
	appointment_date DATE,
	appointment_time time,
	asset_serial VARCHAR(100) REFERENCES asset(asset_serial) UNIQUE
);

INSERT INTO appointment (appointment_date, appointment_time, asset_serial)
VALUES ('2022-12-30', '08:25:00', '2270674-80')

INSERT INTO appointment (appointment_date, appointment_time, asset_serial)
VALUES ('2023-01-15', '09:15:00', '7353794-21')

INSERT INTO appointment (appointment_date, appointment_time, asset_serial)
VALUES ('2024-01-29', '13:25:00', '7989896-43')

INSERT INTO appointment (appointment_date, appointment_time, asset_serial)
VALUES ('2023-02-28', '08:25:00', '7080822-87')

INSERT INTO appointment (appointment_date, appointment_time, asset_serial)
VALUES ('2023-01-21', '16:25:00', '6939844-22')

drop table if exists parts;

CREATE TABLE parts (
	asset_model VARCHAR(100) REFERENCES asset (asset_model),
	air_filter_element VARCHAR(100) NOT NULL,
	air_oil_separator_element VARCHAR(100) NOT NULL,
	coolant_spin_on_element VARCHAR(100) NOT NULL,
	coolant_kit VARCHAR(100) NOT NULL
);

insert into parts (asset_model, air_filter_element, air_oil_separator_element, coolant_spin_on_element, coolant_kit)
values ('R-45n', 'CD88171913', 'CD24121913', 'CD39321913', 'CD47518591913')

insert into parts (asset_model, air_filter_element, air_oil_separator_element, coolant_spin_on_element, coolant_kit)
values ('R-75i', 'CD99178532', 'CD45128532', 'CD89328532', 'CD32518598532')

insert into parts (asset_model, air_filter_element, air_oil_separator_element, coolant_spin_on_element, coolant_kit)
values ('IRN-150','CD88171373', 'CD24121373', 'CD39321373', 'CD73418591373')

insert into parts (asset_model, air_filter_element, air_oil_separator_element, coolant_spin_on_element, coolant_kit)
values ('R-75i', 'CD88179367', 'CD24129367', 'CD39329367', 'CD99218599367')

insert into parts (asset_model, air_filter_element, air_oil_separator_element, coolant_spin_on_element, coolant_kit)
values ('R-90ne', 'CD88173323', 'CD24123323', 'CD39323323', 'CD30618593323')

insert into parts (asset_model, air_filter_element, air_oil_separator_element, coolant_spin_on_element, coolant_kit)
values ('R-7,5n', 'CD88174840', 'CD24124840', 'CD39324840', 'CD85718594840')

insert into parts (asset_model, air_filter_element, air_oil_separator_element, coolant_spin_on_element, coolant_kit)
values ('R75-ne', 'CD88174593', 'CD24124593', 'CD39324593', 'CD43648594593')

insert into parts (asset_model, air_filter_element, air_oil_separator_element, coolant_spin_on_element, coolant_kit)
values ('UP6-30-125', 'CD88171174', 'CD24121174', 'CD39321174', 'CD15418591174')