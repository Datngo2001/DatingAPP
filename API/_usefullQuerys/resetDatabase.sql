DELETE FROM Users;
DELETE FROM Photos;
--reset identity
delete from sqlite_sequence where name='Users';
delete from sqlite_sequence where name='Photos';