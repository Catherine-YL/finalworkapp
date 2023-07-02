/* create */
create database Liberary
use Liberary

create table login_table(
	login_id varchar(30) primary key,
	passwd varchar(100) not null,
	identy varchar(20) not null
)
create table book_info(
	Bno varchar(15) primary key,
	Bname varchar(50) not null,
	Bpub varchar(30),
	Bauthor varchar(30),
	Bsumnum int not null,
	Bavailable int,
	Bborrow int
)
create table reader_info(
	Rno varchar(15) primary key,
	Rname varchar(30) not null,
	Rsex varchar(5) not null,
	Rprofess varchar(30),
	Ravailable int not null,
	Rborrowed int,
	Rdpartmt varchar(30),
	Rtel varchar(30),
	login_id varchar(30) foreign key references login_table(login_id)
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






/* insert */
insert into login_table values('admin', 'admin', 'admin'),('test', 'test', 'reader')
insert into book_info values('9787118063080', '算法设计与分析', '国防工业出版社', '张德富', 10, 10, 1)
insert into reader_info values('10000', 'wxy', '女', '学生', 5, 0, '信息学院', '12345659878', 'test')

/* procedure */ 

