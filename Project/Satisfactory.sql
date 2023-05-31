--create database Satisfactory

use Satisfactory
go 

--create table Item
--(
--	Id int identity primary key,
--	[Name] nvarchar(120) not null,
--	[Description] nvarchar(250) not null,
--	QuantityOfGoods int default 0 check(QuantityOfGoods >= 0),
--	Price money default 0 check(Price >= 0.0),
--	TypeId int
--)
--alter table Item
--alter column [Description] nvarchar(2000)

--insert into Item ([Name], [Description], QuantityOfGoods, Price)
--values 
--(N'Pills', N'They help cure some disease or ensure a healthy state of a person or creature', 500, 12.0),
--(N'Fruits', N'The sweet and fleshy product of a tree or other plant that contains seed and can be eaten as food.', 1000, 1.5),
--(N'Vegetables', N'A vegetable is the edible portion of a plant. Vegetables are usually grouped according to the portion of the plant that is eaten.', 1000, 2.5),
--(N'Iphone 13', N'The iPhone 13 display has rounded corners that follow a beautiful curved design, and these corners are within a standard rectangle. When measured as a standard rectangular shape, the screen is 6.06 inches diagonally (actual viewable area is less).', 160, 1000.0),
--(N'Iphone 14', N'The iPhone 14 is the latest flagship smartphone from Apple. It features a sleek design with a stunning display, offering immersive visuals and vibrant colors. With advanced technology, the iPhone 14 delivers lightning-fast performance and smooth multitasking. Its camera system captures high-quality photos and videos, while innovative features enhance the user experience. The iPhone 14 is equipped with a powerful processor, ample storage space, and long-lasting battery life, ensuring optimal performance throughout the day. It also incorporates advanced security measures and supports the latest connectivity options, making it a top choice for tech enthusiasts.', 50, 1100.0),
--(N'Iphone 14 pro', N'The iPhone 14 Pro is a premium smartphone by Apple, offering a luxurious and refined design. It boasts a stunning ProMotion display with high resolution and adaptive refresh rate, delivering a seamless and immersive visual experience. Powered by a cutting-edge processor, it offers lightning-fast performance for demanding tasks and smooth multitasking. The camera system on the iPhone 14 Pro is exceptional, capturing professional-grade photos and videos with enhanced low-light capabilities. With ample storage, advanced security features, and a long-lasting battery, the iPhone 14 Pro provides a premium user experience. It supports the latest connectivity options and includes innovative features that make it a top choice for professionals and enthusiasts alike.', 120, 1200.0),
--(N'Iphone 13 pro', N'The iPhone 13 Pro is a flagship smartphone from Apple, featuring a sleek and elegant design. It showcases a stunning Super Retina XDR display with vibrant colors and high contrast. Powered by a powerful A15 Bionic chip, it delivers exceptional performance and smooth multitasking. The advanced camera system captures stunning photos and videos with impressive low-light capabilities. With ample storage and enhanced security features, the iPhone 13 Pro ensures a seamless user experience. It supports 5G connectivity and incorporates innovative features like Face ID and MagSafe technology. The iPhone 13 Pro is a top choice for those seeking a premium and feature-rich smartphone.', 158, 1050.0)

--create table [Type]
--(
--	Id int identity primary key,
--	[Type] nvarchar(50) not null
--)

--insert into [Type] ([Type])
--values
--(N'Medicine'),
--(N'Food'),
--(N'Technologies'),
--(N'Technologies'),
--(N'Technologies'), 
--(N'Technologies'), 
--(N'Technologies')
--create table Storage
--(
--	Id int identity primary key,
--	ItemId int,
--	UserId int
--)

--create table Users
--(
--	Id int identity primary key,
--	[Login] nvarchar (100) not null unique,
--	[Password] nvarchar (100) not null unique,
--	FirstName nvarchar (100) not null,
--	LastName nvarchar (100) not null,
--	[isRoot] bit not null
--)

--insert into Users ([Login], [Password], FirstName, LastName, [isRoot])
--values 
--('Rootuser', 'rootpassword', 'Root', 'User', 1),
--('User1', 'password1', 'John', 'Doe', 0),
--('User2', 'password2', 'Jane', 'Smith', 0),
--('User3', 'password3', 'David', 'Johnson', 0),
--('User4', 'password4', 'Emily', 'Brown', 0),
--('User5', 'password5', 'Michael', 'Wilson', 0),
--('User6', 'password6', 'Sarah', 'Taylor', 0)
--alter table Item
--add foreign key (TypeId) references [Type](Id)
--go
--alter table Storage
--add foreign key (ItemId) references Item(Id)
--go
--alter table Storage
--add foreign key (UserId) references Users(Id)


--create proc sp_add_item_to_storage
--    @Name nvarchar(120),
--    @Description nvarchar(2000),
--    @QuantityOfGoods int,
--    @Price money,
--    @TypeId INT
--as
--begin
--    if (select [isRoot] from Users where [Login] = current_user and [isRoot] = 1) = 1
--    begin
--        -- Insert the item into the Item table
--        insert into Item ([Name], [Description], QuantityOfGoods, Price, TypeId)
--        values (@Name, @Description, @QuantityOfGoods, @Price, @TypeId)

--        print ('Item added to the warehouse successfully.')
--    end
--    else
--    begin
--        print ('You do not have the required permissions to perform this action.')
--    end
--end
--exec sp_add_item_to_storage
--    @Name = N'Lenovo',
--    @Description = N'Lenovo phone',
--    @QuantityOfGoods = 100,
--    @Price = 9.00,
--    @TypeId = 8;

--create proc sp_edit_item_in_Stotage 
--    @ItemId int,
--    @NewItemName nvarchar(120),
--    @NewDescription nvarchar(2000),
--    @NewQuantityOfGoods int,
--    @NewPrice money
--as
--begin
--    -- Check if the current user has root rights
--    if (select [isRoot] from Users where [Login] = current_user and [isRoot] = 1) = 1
--    BEGIN
--        -- Check if the item exists in the storage
--        if exists (select 1 from Item where Id = @ItemId)
--        begin
--            -- Update the item in the storage
--            update Item
--            set [Name] = @NewItemName,
--                [Description] = @NewDescription,
--                QuantityOfGoods = @NewQuantityOfGoods,
--                Price = @NewPrice
--            where Id = @ItemId;

--            print ('Item in the storage updated successfully.')
--        end
--        else
--        begin
--            print ('Item does not exist in the storage.')
--        end
--    end
--    else
--    begin
--        print ('You do not have the required permissions to perform this action.')
--    end
--end

--exec sp_edit_item_in_Stotage
--    @ItemId = 1, 
--    @NewItemName = N'Updated I',
--    @NewDescription = N'....',
--    @NewQuantityOfGoods = 150,
--    @NewPrice = 15.00;

--create proc sp_delete_item_in_storage 
--    @ItemId int
--as
--begin
--    -- Check if the current user has root rights
--    if (select [isRoot] from Users where [Login] = current_user and [isRoot] = 1) = 1
--    begin
--        -- Check if the item exists in the storage
--        if exists (select 1 from Item where Id = @ItemId)
--        begin
--            -- Remove the item from the storage
--            delete from Item where Id = @ItemId

--            print ('Item removed from the storage successfully.')
--        end
--        else
--        begin
--            print ('Item does not exist in the storage.')
--        end
--    end
--    else
--    begin
--        print ('You do not have the required permissions to perform this action.')
--    end
--end
--exec sp_delete_item_in_storage
--    @ItemId = 1; -- Provide the ID of the item to be removed

--create proc srp_search_item_in_storage 
--    @SearchKeyword nvarchar(100)
--as
--begin
--    -- Perform the search query
--    select Id, [Name], [Description], QuantityOfGoods, Price
--    from Item
--    where [Name] like '%' + @SearchKeyword + '%' or [Description] like '%' + @SearchKeyword + '%';
--end
--exec srp_search_item_in_storage
--    @SearchKeyword = N'Pills';

--create proc sp_user_authentication
--    @Login nvarchar(100),
--    @Password nvarchar(100),
--    @IsAuthorized bit output
--as
--begin
--    set @IsAuthorized = 0; -- Initialize the authorization flag to 0 (not authorized)

--    -- Check if the user exists and the provided credentials are correct
--    if exists (select 1 from Users where [Login] = @Login and [Password] = @Password)
--    begin
--        -- Check if the user is authorized (has root rights)
--        if exists (select 1 from Users where [Login] = @Login and [isRoot] = 1)
--        begin
--            set @IsAuthorized = 1; -- Set the authorization flag to 1 (authorized)
--        end
--    end
--end
--declare @IsAuthorized bit;

--exec sp_user_authentication
--    @Login = N'User1',
--    @Password = N'password1',
--    @IsAuthorized = @IsAuthorized output;

--if @IsAuthorized = 1
--begin
--    print 'User is authenticated and authorized.'
--end
--else
--begin
--    print 'The user does not have root rights'
--end

--create proc sp_view_item_in_storage 
--as
--begin
--    -- Retrieve the items in the storage
--    select Id, [Name], [Description], QuantityOfGoods, Price
--    from Item;
--end
--exec sp_view_item_in_storage


--create proc sp_user_login_without_root
--    @Login nvarchar(100),
--    @Password nvarchar(100),
--    @IsAuthorizedNoRoot bit output
--as
--begin
--    -- Check if the user exists and the password matches
--    if exists (select 1 from Users where [Login] = @Login and [Password] = @Password)
--    begin
--        -- User authentication successful
--        set @IsAuthorizedNoRoot = 1;
--        print 'User authenticated successfully.'
--    end
--    else
--    begin
--        -- User authentication failed
--        set @IsAuthorizedNoRoot = 0;
--        print 'Authentication failed. Invalid username or password.';
--    end
--end

declare @IsAuthorizedNoRoot bit;

exec sp_user_login_without_root
    @Login = N'User1',
    @Password = N'password1',
    @IsAuthorizedNoRoot = @IsAuthorizedNoRoot OUTPUT;

if @IsAuthorizedNoRoot = 1
begin
    -- User is authorized, perform further actions
    print 'User is authorized. Proceed with non-root operations.';
    -- Perform additional actions or call other procedures as needed
end
else
begin
    -- User is not authorized, handle accordingly
    print 'User is not authorized. Access denied.';
    -- Handle unauthorized access
end
