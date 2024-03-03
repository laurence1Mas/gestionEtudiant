--drop database gestion_personne
--go

create database gestion_etudiant
go

use gestion_etudiant
go
-- ============================================= TABLE ETUDIANT==================================
create table etudiant
(
	id int,
	matricule varchar(10),
	nom varchar(50) not null,
	postnom varchar(50),
	prenom varchar(50),
	sexe varchar(1) default 'M' not null,
	etat_civil varchar(20),
	constraint pk_etudiant primary key(id),
	constraint uk_etudiant unique(nom,postnom,prenom)
)
go
--insert or update student
create procedure sp_insert_or_update_etudiant
	@id int,
	@nom varchar(50),
	@postnom varchar(50),
	@prenom varchar(50),
	@sexe varchar(1),
	@etat_civil varchar(20)
as
begin
	declare @matricule varchar(10)
	set @matricule='ETU'+RIGHT('00000'+CONVERT(varchar(5),(select COUNT(*)from etudiant)+1),5);
	declare @primary int=(select coalesce(max(id),0)+1 from etudiant);
	if not exists(select * from etudiant where id=@id)
		insert into etudiant(id,matricule,nom,postnom,prenom,sexe,etat_civil) values 
		(@primary,@matricule,@nom,@postnom,@prenom,@sexe,@etat_civil)
	else
		update etudiant set nom=@nom,postnom=@postnom,prenom=@prenom,
		sexe=@sexe,matricule=@matricule where id=@id
end
go
--delete student
create procedure sp_delete_etudiant
	@id int
as
begin
	if exists(select * from etudiant where id=@id)
		delete from etudiant where id=@id
end
go
--Select many students
create procedure sp_select_etudiants
as
begin 
	select id,matricule,nom,postnom,prenom,sexe,etat_civil from etudiant order by nom asc
end
go

--Select one student
create procedure sp_select_etudiant
	@id int
as
begin
	select id,matricule,nom,postnom,prenom,sexe from etudiant 
	where id=@id
end
-- ============================================= TABLE TELEPHONE==================================
create table telephone 
(
	id int,
	id_proprietaire int,
	initial varchar(10) ,
	numero varchar(20),
	constraint pk_telephone primary key(id),
	constraint fk_etudiant_telephone foreign key(id_proprietaire) references etudiant(id) on update cascade on delete set null
)
drop table telephone
go
--Insert or Update telephone
create procedure sp_insert_or_update_telephone
	@id int,
	@id_proprietaire int,
	@initial varchar(10),
	@numero varchar(20)
as
begin
	declare @primary int=(select coalesce(max(id),0)+1 from telephone);
	if not exists(select * from telephone where id=@id)
		insert into telephone(id,id_proprietaire,initial,numero) values 
		(@primary,@id_proprietaire,@initial,@numero)
	else
		update telephone set id_proprietaire=@id_proprietaire,
		initial=@initial,numero=@numero where id=@id
end
go

--Delete telephone
create procedure sp_delete_telephone
	@id int
as
begin
	if exists(select * from telephone where id=@id)
		delete from telephone where id=@id
end
go

--Select all telephone
create procedure sp_select_telephones
as
begin
	select id,id_proprietaire,initial,numero from telephone order by numero asc
end
go

--Select all telephone of personne
create procedure sp_select_telephones_personne
	@id_personne int	
as
begin
	select id,id_proprietaire,initial,numero
	from telephone where id_proprietaire=@id_personne
	order by numero asc
end
go

--Select one telephone
create procedure sp_select_telephone
	@id int
as
begin
	select id,id_proprietaire,initial,numero from telephone
	where id=@id
end
-- ============================================= TABLE ADRESSE==================================
create table adresse
(
	id int,
	quartier varchar(50),
	commune varchar(50),
	ville varchar(50),
	pays varchar(50) not null,
	constraint pk_adresse primary key(id)
)
go

--Insert or Update adresse
create procedure sp_insert_or_update_adresse
	@id int,
	@quartier varchar(50),
	@commune varchar(50),
	@ville varchar(50),
	@pays varchar(50)
as
begin
	declare @primary int=(select coalesce(max(id),0)+1 from adresse);
	if not exists(select * from adresse where id=@id)
		insert into adresse(id,quartier,commune,ville,pays) values 
		(@primary,@quartier,@commune,@ville,@pays)
	else
		update adresse set quartier=@quartier,
		commune=@commune,ville=@ville,pays=@pays where id=@id
end
go

--Delete adresse
create procedure sp_delete_adresse
	@id int
as
begin
	if exists(select * from adresse where id=@id)
		delete from adresse where id=@id
end
go

--Select all adresse
create procedure sp_select_adresses
as
begin
	select id,quartier,commune,ville,pays from adresse order by quartier asc
end
go
create procedure sp_select_adresse
	@id int
as
begin
	select id,quartier,commune,ville,pays from adresse
	where id=@id
end
go
-- ============================================= TABLE DOMICILE==================================
create table domicile
(
	id int,
	id_etudiant int,
	id_adresse int ,
	avenue varchar(50),
	numero_avenue int,
	constraint pk_domicile primary key(id),
	constraint fk_personne_domicile foreign key(id_etudiant) references etudiant(id) on update cascade on delete set null,
	constraint fk_addresse_domicile foreign key(id_adresse)references adresse(id) on update cascade on delete set null
)
go
create procedure sp_insert_or_update_domicile
	@id int,
	@id_etudiant int,
	@id_adresse int ,
	@avenue varchar(50),
	@numero_avenue int
as
begin
	declare @primary int=(select coalesce(max(id),0)+1 from domicile);
	if not exists(select * from domicile where id=@id)
		insert into domicile(id,id_etudiant,id_adresse,avenue,numero_avenue) values 
		(@primary,@id_etudiant,@id_adresse,@avenue,@numero_avenue)
	else
		update domicile set id_etudiant=@id_etudiant,
		id_adresse=@id_adresse,avenue=@avenue,numero_avenue=@numero_avenue where id=@id
end
go

--Delete domicile
create procedure sp_delete_domicile
	@id int
as
begin
	if exists(select * from domicile where id=@id)
		delete from domicile where id=@id
end
go

--Select all domicile
create procedure sp_select_domiciles
as
begin
	select id,id_etudiant,id_adresse,avenue,numero_avenue from domicile order by id asc
end
go
create procedure sp_select_domicile
	@id int
as
begin
	select id,id_etudiant,id_adresse,avenue,numero_avenue from domicile
	where id=@id
end
