create table tbl_usuario(
	login varchar(100),
	senha varchar(15),
	nome_completo varchar(100),
	Constraint pk_user primary key (login),
	Constraint uk_usuario_login unique (login)
);

insert into tbl_usuario values ('adm' , '123admin' , 'Administrador');
insert into tbl_usuario values ('johnny' , '123admin' , 'Felipe Johnny');
insert into tbl_usuario values ('matheus' , '123admin' , 'Matheus Leao');

drop table tbl_usuario
select * from tbl_usuario