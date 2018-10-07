DROP DATABASE dentistdb;
CREATE DATABASE IF NOT EXISTS dentistdb;

use dentistdb;

CREATE TABLE IF NOT EXISTS users (
  id int(4) zerofill auto_increment,
  firstname varchar(50) not null,
  middlename varchar(50) not null,
  lastname varchar(50) not null,
  address varchar(100) not null,
  contact varchar(20) not null,
  gender varchar(20) not null,
  position varchar(20) not null,
  username varchar(20) not null,
  password varchar(20) not null,
  secretques varchar(60) not null,
  answer varchar(60),
  primary key(id)
);

INSERT INTO users(firstname, middlename, lastname, address, contact, gender, position, username, password, secretques, answer)
VALUES('abc', 'def', 'hij', 'Cavinti, Laguna', '09213708901','Female','Dentist','admin', 'admin123','What is your favorite movie', 'SDTG');


CREATE TABLE IF NOT EXISTS patients (
  id smallint auto_increment,
  firstname varchar(50) not null,
  middlename varchar(50) not null,
  lastname varchar(50) not null,
  address varchar(100) not null,
  birthday DATE not null,
  contact varchar(20) not null,
  isDeleted boolean not null DEFAULT false,
  primary key(id)
);

CREATE TABLE IF NOT EXISTS services (
  id smallint auto_increment,
  name varchar(100) not null,
  primary key(id)
);

INSERT INTO services(name) VALUES('Procedure');
INSERT INTO services(name) VALUES('Fluoride Application with Oral Prophylaxis');
INSERT INTO services(name) VALUES('Restoration');
INSERT INTO services(name) VALUES('Endodontic Cases(including X-ray)');
INSERT INTO services(name) VALUES('Oral Prophylaxis');
INSERT INTO services(name) VALUES('Surgery');
INSERT INTO services(name) VALUES('Orthodontic Treatment');
INSERT INTO services(name) VALUES('Prosthetics');
INSERT INTO services(name) VALUES('Removable Partial Denture(Plastic)');
INSERT INTO services(name) VALUES('Complete Denture(Plastic Upper and Lower)');
INSERT INTO services(name) VALUES('Complete Denture(Porcelain Upper and Lower)');
INSERT INTO services(name) VALUES('Flexible Denture');

CREATE TABLE IF NOT EXISTS sub_services (
  id smallint auto_increment,
  svc_id smallint not null,
  name varchar(100) not null,
  price varchar(100) not null,
  amount int not null,
  PRIMARY KEY(id),
  FOREIGN KEY(svc_id) REFERENCES services(id)
);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(1, 'Consultation Fee', '300', 300);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(1, 'Periapical X-ray', '400-500', 400);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(2, 'Pedo', '1500', 1500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(2, 'Adult(Intensive)', '3500-4000', 3500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(2, 'Periodontal Cases', '5000 per quadrant', 5000);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(3, 'Temporary Filling', '400++ per surface', 400);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(3, 'LightCure(Incipient Caries)', '500++ per surface', 500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(3, 'LightCure(with base)', '800++ per surface', 800);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(3, 'Pit and Fissure Sealant', '600', 600);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(3, 'Diastema Closure', '1500 per tooth/side', 1500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(3, 'Direct Composite Lamination', '3500', 3500);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(4, 'Root Canal Treatment', '4000 per canal', 4000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(4, 'Dowel Post(Preformed)', '3000', 3000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(4, 'Dowel Post(Caster)', '3500', 3500);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(5, 'Oral Prophylaxis(Pedo)', '500++', 500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(5, 'Oral Prophylaxis(Adult)', '500++', 500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(5, 'Light', '500', 500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(5, 'Moderate', '600', 600);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(5, 'Heavy', '800', 800);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(5, 'Super Heavy', '500 up per quadrant', 500);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(6, 'Extraction(Pedo or Adult)', '500++ per tooth', 500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(6, 'Extraction Third Molar(Normal Eruption)', '800++ per tooth', 800);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(6, 'Special Cases(Odontectomy)', '8000-10000 per tooth', 8000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(6, '(Case to Case Basis)', '8000-10000 per tooth', 8000);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(7, 'Simple Cases', '45000-50000', 45000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(7, 'Case to Case Basis(Minimum Down Payment)', '10000-15000', 10000);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Repair Minor Fracture', '500++', 500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Repair Major Fracture', '1000-1500', 1000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'If Impression is needed add', '500', 500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Pontic Re-Attachment(Plastic)', '500++', 500);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Pontic Re-Attachment(Porcelain)', '800++', 800);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Pontic Replacement(Plastic)', '600++', 600);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Pontic Replacement(Porcelain)', '1000++', 1000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Rebase', '5000 per arch', 5000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Reline', '2000 per arch', 2000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(8, 'Re-Cementation of Loose Crown and bridge', '800 per tooth', 800);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(9, 'Anterior or Posterior Only(Wire Clasps)', '5000++', 5000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(9, 'Anterior or Posterior Only(Casted Clasps)', '6000++', 6000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(9, 'One Piece Casting-Anterior or Posterior', '10000-15000', 10000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(9, 'Metal Framework + Pontic', '8000+800 per tooth', 8000);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(10, 'Leeformatron', '10000++', 10000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(10, 'Natural Tone/ Lee Blend', '12000', 12000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(10, 'Biotone', '14000-15000', 14000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(10, 'Bioform', '15000-18000', 15000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(10, 'Ivocap', '35000-40000++', 35000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(10, 'BPS', '50000++', 50000);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(11, 'Natural Dent', '18000++', 18000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(11, 'Vita Form', '20000++', 20000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(11, 'Trubyte Bioform', '25000++', 25000);

INSERT INTO sub_services(svc_id, name, price, amount) VALUES(12, 'Partial Flexible', '12000-15000 per arch', 12000);
INSERT INTO sub_services(svc_id, name, price, amount) VALUES(12, 'Complete', '15000-18000 per arch', 15000);

CREATE TABLE IF NOT EXISTS patient_history (
  id smallint auto_increment,
  p_id smallint not null,
  service_quantity varchar(250) not null,
  addtl_charge int,
  discount int,
  totaldue int not null,
  cash_paid int not null,
  date_created TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY(id),
  FOREIGN KEY(p_id) REFERENCES patients(id)
);

CREATE TABLE IF NOT EXISTS appointments(
  id smallint auto_increment, 
  k_id smallint not null,
  dates DATE not null,
  fromTimeSelected varchar(10) not null,
  toTimeSelected varchar(10) not null,
  primary key(id),
  FOREIGN KEY(k_id) REFERENCES patients(id),
  isDone boolean not null DEFAULT false
);

CREATE TABLE IF NOT EXISTS balance(
  id smallint auto_increment,
  p_id smallint not null,
  ph_id smallint not null,
  total_balance int not null,
  date_created TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  primary key(id),
  FOREIGN KEY(p_id) REFERENCES patients(id),
  FOREIGN KEY(ph_id) REFERENCES patient_history(id)
);
