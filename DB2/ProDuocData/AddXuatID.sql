ALTER TABLE DUOC.CHITIETXUAT DROP PRIMARY KEY;
ALTER TABLE DUOC.CHITIETXUAT ADD XUATID CHAR(15);
CALL DUOC.SETXUATID();
ALTER TABLE DUOC.CHITIETXUAT ALTER COLUMN XUATID SET NOT NULL;
--REORG TABLE DUOC.CHITIETXUAT;
ALTER TABLE DUOC.CHITIETXUAT ADD CONSTRAINT PK_CHITIETXUAT PRIMARY KEY (XUATID);

--alter table duoc.CHITIETXUAT drop xuatid;
--select * from duoc.CHITIETXUAT;
--delete from duoc.CHITIETXUAT;