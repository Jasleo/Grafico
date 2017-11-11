<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoGraficos.index" %>

<%@ Import Namespace="System.Drawing" %>
<%@ Import Namespace="System.Drawing.Text" %>
<%@ Import Namespace="System.Drawing.Imaging" %>
<%@ Import Namespace="System.Drawing.Drawing2D" %>
<%@ Import Namespace="ProyectoGraficos.model"%>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Grafico</title>
</head>
<body>
    <%//Formulario para poner un punto.%>
    <form action="index.aspx" method="post">
        Ingrese x:
        <input type="number" name="txtEjex" placeholder="Ingrese Eje X">
        Ingrese y:
        <input type="number" name="txtEjey" placeholder="Ingrese Eje y">
        <input type="submit" value="Ingresar Punto">
    </form>

	<%
        if (Request.Form["txtEjex"] != null || Request.Form["txtEjey"] != null)//Si los datos no vienen vacios.
        {
            Response.Clear();
            // Ancho del rectangulo original (ancho x, altura y)
            int ancho = 1000;
            int altura = 1000;

            // coordenadas a graficar
            int x = int.Parse(Request.Form["txtEjex"]);
            int y = int.Parse(Request.Form["txtEjey"]);


            //(x, y)
            Bitmap bmp = new Bitmap(ancho, altura);
            Graphics g = Graphics.FromImage(bmp);
            // color de fondo
            g.Clear(Color.Beige);

            // dibuja el eje x y el eje y
            g.DrawRectangle(Pens.Black,0,altura/2,ancho,altura/2);
            g.DrawRectangle(Pens.Black,ancho/2,0,ancho/2,altura);

            //g.DrawRectangle(Pens.White,0,50,altura,30);
            //g.DrawRectangle(Pens.White,50,0,30,ancho);

            Data d = new Data(); // creamos un objeto del tipo Data 
            x = d.coord_x_real(x,ancho); // obtenemos el valor real de x
            y = d.coord_y_real(y,altura); // obtenemos el valor real de y
            g.DrawEllipse(Pens.Black,x,y,5,5); // dibuja el punto



            ////g.DrawString(".", new Font("Arial", 70, FontStyle.Italic), SystemBrushes.WindowText, new Point(x,y) );

            bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

            g.Dispose();
            bmp.Dispose();
            Response.End();
        }

	%>

</body>
</html>
    


