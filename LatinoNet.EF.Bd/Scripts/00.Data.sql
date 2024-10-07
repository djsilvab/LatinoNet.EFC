use InventoryDB
go

insert into Addresses(Line1,Line2,City,Country,PostCode) values('Av Rio Chincha','Av San luis','San Luis','Perú','051');
insert into Addresses(Line1,Line2,City,Country,PostCode) values('Jr Jaier heraud','Av Ricardo Palma','Carabayllo','Perú','051');

insert into Customers(Name, AddressId) values('David Silva Bazán',1);

insert into Orders(Contents,ShippingAddressAddressId,BillingAddressAddressId,CustomerId) values('El señor de los anillos',1,2,1);