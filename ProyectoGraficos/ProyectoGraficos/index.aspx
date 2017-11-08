<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoGraficos.index" %>

<%@ Import Namespace="System.Drawing" %>
<%@ Import Namespace="System.Drawing.Text" %>
<%@ Import Namespace="System.Drawing.Imaging" %>
<%@ Import Namespace="System.Drawing.Drawing2D" %>


	<%
        Response.Clear();
        // Ancho del rectangulo original
        int altura = 1000;
        int ancho = 800;

        // mitad de la altura
        int midAl = altura/2;
        // mitad de la altura
        int midAn = ancho/2;

        // X numero random
        int x = 10;
        int y = 30;

        Bitmap bmp = new Bitmap(altura, ancho);

        Graphics g = Graphics.FromImage(bmp);


        g.Clear(Color.Green);


        g.DrawRectangle(Pens.Black,0,midAn,altura,midAn);
        g.DrawRectangle(Pens.Black,midAl,0,midAl,ancho);

        g.DrawRectangle(Pens.White,0,50,altura,30);
        g.DrawRectangle(Pens.White,50,0,30,ancho);


        g.DrawString(".", new Font("Arial", 15, FontStyle.Italic), SystemBrushes.WindowText, new Point(x,y) );

        bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

        g.Dispose();
        bmp.Dispose();
        Response.End();

	%>

