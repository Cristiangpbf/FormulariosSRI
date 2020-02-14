---------Creación tabla usuarios---------
create table tbl_user
(
	IDUSER INT GENERATED ALWAYS AS IDENTITY,
	CEDULA character varying(13) not null,
	PASS character varying(20) not null
)

select * from tbl_user

insert into tbl_user (cedula,pass) values('1750024067','123456');
insert into tbl_user (cedula,pass) values('1708009350','123456');
insert into tbl_user (cedula,pass) values('1750024068','123456');
insert into tbl_user (cedula,pass) values('1750024062','123456');
insert into tbl_user (cedula,pass) values('1234567890','123456');

-------función para login-------
create function u_login(_cedula character varying, _pass character varying)
returns int as
$$
begin
	if (select count(*) from tbl_user where cedula = _cedula and pass = _pass) > 0 then
		return 1; -- Login satisfactorio
	else
		return 0;
	end if;
end
$$
language plpgsql

-----prueba funcion-----
select * from u_login('1750024067','123456');
select * from u_login('1750024067','164325');