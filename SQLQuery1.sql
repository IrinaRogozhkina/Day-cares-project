select * from sys.tables

truncate table ChildCares

select * from Reviews

delete from Users


select * from Users

ALTER TABLE ChildCares
   ADD CONSTRAINT myUniqueConstraint UNIQUE(ChildCareName, ChildCareAdress);