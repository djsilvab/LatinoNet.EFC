use InventoryDB
go

insert into Addresses(Line1,Line2,City,Country,PostCode) values('Av Rio Chincha','Av San luis','San Luis','Per�','051');
insert into Addresses(Line1,Line2,City,Country,PostCode) values('Jr Jaier heraud','Av Ricardo Palma','Carabayllo','Per�','051');

insert into Customers(Name, AddressId) values('David Silva Baz�n',1);

insert into Orders(Contents,ShippingAddressAddressId,BillingAddressAddressId,CustomerId) values('El se�or de los anillos',1,2,1);