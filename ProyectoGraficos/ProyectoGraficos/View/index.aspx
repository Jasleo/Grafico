<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoGraficos.index" %>

<%@ Import Namespace="System.Drawing" %>
<%@ Import Namespace="System.Drawing.Text" %>
<%@ Import Namespace="System.Drawing.Imaging" %>
<%@ Import Namespace="System.Drawing.Drawing2D" %>
<%@ Import Namespace="ProyectoGraficos.model" %>
<%@ Import Namespace="ProyectoGraficos.Model" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Grafico</title>
</head>
<body>
    <%//Formulario para preguntar cuantos puntos graficara
        Data d = new Data();// creamos un objeto del tipo Data 
        Coordenada coo = new Coordenada(); // creamos un objeto del tipo coordenada
        List<Coordenada> listCoordenadas; // creamos una lista de coordenadas


        if (Request.Params["cantPuntos"] == null) {%>
    <form action="index.aspx" method="post">
        <input type="radio" name="cantPuntos" value="3" />
        3 Puntos
            <input type="radio" name="cantPuntos" value="4" />
        4 Puntos

            <input type="submit" value="Continuar">
    </form>
    <%}%>


    <% //pedira los puntos a graficar segun los radio button de antes 
        int cantPuntos = 0;

        if (Request.Params["cantPuntos"] != null) {
            cantPuntos = int.Parse(Request.Params["cantPuntos"]); //rescatamos los datos del radio
        }

        if (cantPuntos == 3) {%>

    <form action="index.aspx" method="post">
        Punto A:
                <input type="number" name="txtPuntoA" placeholder="Ingrese Punto A">
        Punto B:
                <input type="number" name="txtPuntoB" placeholder="Ingrese Punto B">
        Punto C:
                <input type="number" name="txtPuntoC" placeholder="Ingrese Punto C">

        <input type="submit" value="Graficar">
    </form>

    <%}
        if (cantPuntos == 4) {%>
    <form action="index.aspx" method="post">
        Punto A:
                    <input type="number" name="txtPuntoA" placeholder="Ingrese Punto A">
        Punto B:
                    <input type="number" name="txtPuntoB" placeholder="Ingrese Punto B">
        Punto C:
                    <input type="number" name="txtPuntoC" placeholder="Ingrese Punto C">
        Punto D:
                    <input type="number" name="txtPuntoD" placeholder="Ingrese Punto D">

        <input type="submit" value="Graficar">
    </form>

    <%}
        if (Request.Params["txtPuntoA"] != null && Request.Params["txtPuntoB"] != null && Request.Params["txtPuntoC"] != null && Request.Params["txtPuntoD"] == null) {
            Response.Clear();

            // Ancho del plano (ancho x, altura y)
            int ancho = 1000;
            int altura = 1000;

            //(x, y)
            Bitmap bmp = new Bitmap(ancho, altura);
            Graphics g = Graphics.FromImage(bmp);
            // color de fondo
            g.Clear(Color.Beige);

            // dibuja el eje x y el eje y
            g.DrawRectangle(Pens.Black, 0, altura / 2, ancho, altura / 2);
            g.DrawRectangle(Pens.Black, ancho / 2, 0, ancho / 2, altura);

            listCoordenadas = new List<Coordenada>();

            int x1 = 0, x2 = 0, x3 = 0, y1 = 0, y2 = 0, y3 = 0;
            String[] cortar;
            String coo1, coo2, coo3;

            coo1 = Request.Params["txtPuntoA"];
            coo2 = Request.Params["txtPuntoB"];
            coo3 = Request.Params["txtPuntoC"];

            // separamos el primer punto por la coma y lo agregamos al objeto para luego agregarlo a la lista
            cortar = coo1.Split(',');
            coo = new Coordenada(1, int.Parse(cortar[0]), int.Parse(cortar[1]));
            listCoordenadas.Add(coo);

            // separamos el segundo punto por la coma y lo agregamos al objeto para luego agregarlo a la lista
            cortar = coo2.Split(',');
            coo = new Coordenada(2, int.Parse(cortar[0]), int.Parse(cortar[1]));
            listCoordenadas.Add(coo);

            // separamos el tercer punto por la coma y lo agregamos al objeto para luego agregarlo a la lista
            cortar = coo3.Split(',');
            coo = new Coordenada(3, int.Parse(cortar[0]), int.Parse(cortar[1]));
            listCoordenadas.Add(coo);

            // dibuja el punto
            foreach (Coordenada c in listCoordenadas) {
                if (c.Id == 1) {
                    x1 = c.X;
                    y1 = c.Y;
                    g.DrawEllipse(Pens.Black, d.coord_x_real(c.X, ancho), d.coord_y_real(c.Y, altura), 5, 5);
                } else if (c.Id == 2) {
                    x2 = c.X;
                    y2 = c.Y;
                    g.DrawEllipse(Pens.Black, d.coord_x_real(c.X, ancho), d.coord_y_real(c.Y, altura), 5, 5);
                } else if (c.Id == 3) {
                    x3 = c.X;
                    y3 = c.Y;
                    g.DrawEllipse(Pens.Black, d.coord_x_real(c.X, ancho), d.coord_y_real(c.Y, altura), 5, 5);
                }
            }

            //une los puntos 
            x1 = d.coord_x_real(x1, ancho);
            y1 = d.coord_y_real(y1, altura);

            x2 = d.coord_x_real(x2, ancho);
            y2 = d.coord_y_real(y2, altura);

            x3 = d.coord_x_real(x3, ancho);
            y3 = d.coord_y_real(y3, altura);



            g.DrawLine(Pens.Black, x1, y1, x2, y2);
            g.DrawLine(Pens.Black, x2, y2, x3, y3);
            g.DrawLine(Pens.Black, x1, y1, x3, y3);

            bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

            g.Dispose();
            bmp.Dispose();
            Response.End();

        }

        if (Request.Params["txtPuntoA"] != null && Request.Params["txtPuntoB"] != null && Request.Params["txtPuntoC"] != null && Request.Params["txtPuntoD"] != null) {
            Response.Clear();

            // Ancho del plano (ancho x, altura y)
            int ancho = 1000;
            int altura = 1000;

            //(x, y)
            Bitmap bmp = new Bitmap(ancho, altura);
            Graphics g = Graphics.FromImage(bmp);
            // color de fondo
            g.Clear(Color.Beige);

            // dibuja el eje x y el eje y
            g.DrawRectangle(Pens.Black, 0, altura / 2, ancho, altura / 2);
            g.DrawRectangle(Pens.Black, ancho / 2, 0, ancho / 2, altura);

            listCoordenadas = new List<Coordenada>();

            int x1 = 0, x2 = 0, x3 = 0, x4 = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0;
            String[] cortar;
            String coo1, coo2, coo3, coo4;

            coo1 = Request.Params["txtPuntoA"];
            coo2 = Request.Params["txtPuntoB"];
            coo3 = Request.Params["txtPuntoC"];
            coo4 = Request.Params["txtPuntoD"];

            // separamos el primer punto por la coma y lo agregamos al objeto para luego agregarlo a la lista
            cortar = coo1.Split(',');
            coo = new Coordenada(1, int.Parse(cortar[0]), int.Parse(cortar[1]));
            listCoordenadas.Add(coo);

            // separamos el segundo punto por la coma y lo agregamos al objeto para luego agregarlo a la lista
            cortar = coo2.Split(',');
            coo = new Coordenada(2, int.Parse(cortar[0]), int.Parse(cortar[1]));
            listCoordenadas.Add(coo);

            // separamos el tercer punto por la coma y lo agregamos al objeto para luego agregarlo a la lista
            cortar = coo3.Split(',');
            coo = new Coordenada(3, int.Parse(cortar[0]), int.Parse(cortar[1]));
            listCoordenadas.Add(coo);

            // separamos el cuarto punto por la coma y lo agregamos al objeto para luego agregarlo a la lista
            cortar = coo4.Split(',');
            coo = new Coordenada(4, int.Parse(cortar[0]), int.Parse(cortar[1]));
            listCoordenadas.Add(coo);

            // dibuja el punto
            foreach (Coordenada c in listCoordenadas) {
                if (c.Id == 1) {
                    x1 = c.X;
                    y1 = c.Y;
                    g.DrawEllipse(Pens.Black, d.coord_x_real(c.X, ancho), d.coord_y_real(c.Y, altura), 5, 5);
                } else if (c.Id == 2) {
                    x2 = c.X;
                    y2 = c.Y;
                    g.DrawEllipse(Pens.Black, d.coord_x_real(c.X, ancho), d.coord_y_real(c.Y, altura), 5, 5);
                } else if (c.Id == 3) {
                    x3 = c.X;
                    y3 = c.Y;
                    g.DrawEllipse(Pens.Black, d.coord_x_real(c.X, ancho), d.coord_y_real(c.Y, altura), 5, 5);
                } else if (c.Id == 4) {
                    x4 = c.X;
                    y4 = c.Y;
                    g.DrawEllipse(Pens.Black, d.coord_x_real(c.X, ancho), d.coord_y_real(c.Y, altura), 5, 5);
                }
            }

            //une los puntos 
            x1 = d.coord_x_real(x1, ancho);
            y1 = d.coord_y_real(y1, altura);

            x2 = d.coord_x_real(x2, ancho);
            y2 = d.coord_y_real(y2, altura);

            x3 = d.coord_x_real(x3, ancho);
            y3 = d.coord_y_real(y3, altura);

            x4 = d.coord_x_real(x4, ancho);
            y4 = d.coord_y_real(y4, altura);



            g.DrawLine(Pens.Black, x1, y1, x2, y2);
            g.DrawLine(Pens.Black, x2, y2, x3, y3);
            g.DrawLine(Pens.Black, x3, y3, x4, y4);
            g.DrawLine(Pens.Black, x1, y1, x4, y4);

            bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

            g.Dispose();
            bmp.Dispose();
            Response.End();

        }%>
</body>
</html>



