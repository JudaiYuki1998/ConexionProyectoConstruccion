USE [POE_DB]
GO
/****** Object:  StoredProcedure [dbo].[insertarProductos]    Script Date: 8/5/2023 15:29:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[insertarProductos]
@Id_Producto INT, @NomProducto varchar(80),@Valor_Producto int,@Cantidad_Producto int,@stado varchar(1)

as
set identity_insert TB_PRODUCTO ON;
INSERT INTO TB_PRODUCTO(ID_PRODUCTO,NOMBRE_PRODUCTO,VALOR_PRODUCTO,CANTIDAD_PRODUCTO,ESTADO)VALUES(@Id_Producto,@NomProducto,@Valor_Producto,@Cantidad_Producto,@stado);

SELECT *FROM TB_PRODUCTO