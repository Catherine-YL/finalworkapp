/* create */
create database Liberary
use Liberary

create table login_table(
	login_id varchar(100) primary key,
	passwd varchar(100) not null,
	identy varchar(20) not null
)
create table book_info(
	Bno varchar(15) primary key,
	Bname varchar(50) not null,
	Bpub varchar(50),
	Bauthor varchar(1000),
	Bsumnum int not null,
	Bavailable int,
	Bborrow varchar(10)
)
create table reader_info(
	Rno varchar(15) primary key,
	Rname varchar(100) not null,
	Rsex varchar(5) not null,
	Rprofess varchar(100),
	Ravailable int not null,
	Rborrowed int,
	Rdpartmt varchar(100),
	Rtel varchar(30),
	login_id varchar(100)
)
create table borrow_table(
	Ino int identity(1,1) primary key,
	Rno varchar(15),
	Bno varchar(15),
	BRdate date,
	BRlimit date,
	RTdate date,
	BWfine int,
	foreign key(Rno) references reader_info(Rno),
	foreign key(Bno) references book_info(Bno)
)

/* trigger */
go
create trigger nborrow on book_info for insert,update
as
update book_info set Bborrow='���ɽ�'
from book_info,inserted
where book_info.Bno=inserted.Bno
and book_info.Bavailable=0

go
create trigger addlogin on reader_info for insert
as
insert into login_table
select login_id,login_id,'reader' from inserted


/* insert */
insert into login_table values('admin', 'admin', 'admin'),('test', 'test', 'reader')
insert into book_info values('9787118063080', '�㷨��������', '������ҵ������', '�ŵ¸�', 10, 10, '�ɽ�')
insert into book_info values('9787115428028', 'Python��� �����ŵ�ʵ��', '�����ʵ������', '[��] ����ˡ���ɪ˹��Eric Matthes�� ����Ԭ���� �룬', 5, 0, '���ɽ�')
insert into reader_info values('10000', 'wxy', 'Ů', 'ѧ��', 5, 0, '��ϢѧԺ', '12345659878', 'test')
insert into borrow_table values('10000', '9787118063080', GETDATE()-3, GETDATE()+30, NULL, 0)

/* procedure */ 
create proc 



/* grant */ 
create role adm
create role reader

grant select on book_info to reader
grant select on reader_info to reader
grant select on borrow_table to reader

/* test */ 

exec sp_adduser 'U','sa'

select user
revert


select * from book_info
select * from reader_info
select identy from login_table where login_id='test' and passwd='test'
select Rno '����֤��',Rname '����',Rsex '�Ա�',Rprofess 'ְ��',Ravailable '�ɽ�����',Rborrowed '�ѽ�����',Rdpartmt '��������',Rtel '��ϵ�绰',login_id '�˺���' from reader_info

select borrow_table.Bno '���', Bname '����', BRdate '�������', BRlimit '�޽�����', BWfine '������' from borrow_table,book_info,reader_info
where reader_info.Rno = borrow_table.Rno and book_info.Bno = borrow_table.Bno and borrow_table.RTdate is NULL

select * from borrow_table





