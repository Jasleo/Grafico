<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoGraficos.index" %>

<%@ Import Namespace="System.Drawing" %>
<%@ Import Namespace="System.Drawing.Text" %>
<%@ Import Namespace="System.Drawing.Imaging" %>
<%@ Import Namespace="System.Drawing.Drawing2D" %>


	<%
        Response.Clear();
        // Ancho del rectangulo original
        int altura = 800;
        int ancho = 600;

        int midAl = 400;
        int midAn = 300;

        // X numero random
        int x = 10;
        int y = 30;

        Bitmap bmp = new Bitmap(altura, ancho);

        Graphics g = Graphics.FromImage(bmp);


        g.Clear(Color.Green);


        g.DrawRectangle(Pens.Black,0,midAn,altura,midAn);
        g.DrawRectangle(Pens.Black,midAl,0,midAl,ancho);

       

        g.DrawString(".", new Font("Arial", 15, FontStyle.Italic), SystemBrushes.WindowText, new Point(x,y) );

        bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

        g.Dispose();
        bmp.Dispose();
        Response.End();

	%>

