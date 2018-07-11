/*-- BEGIN Order Status --*/
insert into GNRL_LOOKUPGROUP (LOOKUPGROUPID,NAME) select 107,'Order Status'
insert into GNRL_LOOKUPITEM (LOOKUPITEMID,FIELDVALUE,FIELDTEXT,DESCRIPTION,ITEMORDER,ISACTIVE,LOOKUPGROUPID) select 107001,'','','Initial State',1,1,107
insert into GNRL_LOOKUPITEM (LOOKUPITEMID,FIELDVALUE,FIELDTEXT,DESCRIPTION,ITEMORDER,ISACTIVE,LOOKUPGROUPID) select 107002,'','Invoice Sent','Invoice Sent',2,1,107
insert into GNRL_LOOKUPITEM (LOOKUPITEMID,FIELDVALUE,FIELDTEXT,DESCRIPTION,ITEMORDER,ISACTIVE,LOOKUPGROUPID) select 107003,'','Past Due','Past Due',3,1,107
insert into GNRL_LOOKUPITEM (LOOKUPITEMID,FIELDVALUE,FIELDTEXT,DESCRIPTION,ITEMORDER,ISACTIVE,LOOKUPGROUPID) select 107004,'','Paid','Paid',4,1,107
insert into GNRL_LOOKUPITEM (LOOKUPITEMID,FIELDVALUE,FIELDTEXT,DESCRIPTION,ITEMORDER,ISACTIVE,LOOKUPGROUPID) select 107005,'','Order Submitted','Order Submitted',5,1,107

/*-- END Order Status --*/