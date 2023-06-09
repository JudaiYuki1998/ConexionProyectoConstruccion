USE [POE_DB]
GO
/****** Object:  StoredProcedure [dbo].[ModificarProcto]    Script Date: 8/5/2023 15:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ModificarProductos]


@Id_Producto INT, @NomProducto varchar(80),@Valor_Producto int,@Cantidad_Producto int,@stado varchar(1)


as

UPDATE TB_PRODUCTO SET NOMBRE_PRODUCTO=@NomProducto, VALOR_PRODUCTO=@Valor_Producto, CANTIDAD_PRODUCTO=@Cantidad_Producto,ESTADO=@stado WHERE ID_PRODUCTO=@Id_Producto ;
