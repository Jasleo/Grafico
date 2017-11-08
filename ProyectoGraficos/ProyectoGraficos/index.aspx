<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoGraficos.index" %>

<%@ Import Namespace="System.Drawing" %>
<%@ Import Namespace="System.Drawing.Text" %>
<%@ Import Namespace="System.Drawing.Imaging" %>
<%@ Import Namespace="System.Drawing.Drawing2D" %>


	<%
        Response.Clear();
        // Ancho del rectangulo original
        int height = 100;
        int width = 200;

        // X numero random
        int x = 10;
        int y = 30;

        Bitmap bmp = new Bitmap(width, height);

        Graphics g = Graphics.FromImage(bmp);


        g.Clear(Color.Green);


        g.DrawRectangle(Pens.Black, 0, width/2, height, width/2);
         //g.DrawRectangle(Pens.Black, 0, 0, width/2, height/2);
        //g.DrawRectangle(Pens.White, 100 , 50, width/2, height/2);
        g.DrawRectangle(Pens.White, height/2 , 0, height/2, width);

       

        g.DrawString(".", new Font("Arial", 15, FontStyle.Italic), SystemBrushes.WindowText, new Point(x,y) );

        bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

        g.Dispose();
        bmp.Dispose();
        Response.End();

	%>

