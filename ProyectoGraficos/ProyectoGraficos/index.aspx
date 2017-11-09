<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoGraficos.index" %>

<%@ Import Namespace="System.Drawing" %>
<%@ Import Namespace="System.Drawing.Text" %>
<%@ Import Namespace="System.Drawing.Imaging" %>
<%@ Import Namespace="System.Drawing.Drawing2D" %>
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
        // Ancho del rectangulo original
        int altura = 1000;
        int ancho = 800;

        // mitad de la altura
        int midAl = altura/2;
        // mitad de la altura
        int midAn = ancho/2;

        // X numero random
        int x = 0;
        int y = 0;

        x = int.Parse(Request.Form["txtEjex"]);
        y = int.Parse(Request.Form["txtEjey"]);
        


        Bitmap bmp = new Bitmap(altura, ancho);

        Graphics g = Graphics.FromImage(bmp);


        g.Clear(Color.Green);


        g.DrawRectangle(Pens.Black,0,midAn,altura,midAn);
        g.DrawRectangle(Pens.Black,midAl,0,midAl,ancho);

        g.DrawRectangle(Pens.White,0,50,altura,30);
        g.DrawRectangle(Pens.White,50,0,30,ancho);


        g.DrawString(".", new Font("Arial", 70, FontStyle.Italic), SystemBrushes.WindowText, new Point(x,y) );

        bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

        g.Dispose();
        bmp.Dispose();
        Response.End();
        }
        
	%>

</body>
</html>
    


