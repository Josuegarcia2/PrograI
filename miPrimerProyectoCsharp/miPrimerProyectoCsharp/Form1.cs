using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    /// <summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoConversor.Items.AddRange(new string[]
                {
                "Monedas",
                "Masa",
                "Volumen",
                "Longitud",
                "Almacenamiento",
                "Tiempo"
            });



        }

        private void btnConvertir_Click(object sender, EventArgs e)
            
        {
            
            string tipo = cmbTipoConversor.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Seleccione un tipo de conversor.");
                return;
            }

            switch (tipo)
            {
                case "Monedas":
                    ConvertirMonedas();
                    break;
                case "Masa":
                    ConvertirMasa();
                    break;
                case "Volumen":
                    ConvertirVolumen();
                    break;
                case "Longitud":
                    ConvertirLongitud();
                    break;
                case "Almacenamiento":
                    ConvertirAlmacenamiento();  
                    break;
                case "Tiempo":
                    ConvertirTiempo();
                    break;




            }
        }

        private void ConvertirMonedas()
        {
            try
            {
                double cantidad, respuesta = 0;
                cantidad = Double.Parse(txtValorAConvertir.Text);

                string monedaOrigen = cmbDe.SelectedItem.ToString();
                string monedaDestino = cmbA.SelectedItem.ToString();

                switch (monedaOrigen)
                {
                    case "USD":
                        switch (monedaDestino)
                        {
                            case "EUR":
                                respuesta = cantidad * 0.85; // USD a EUR
                                break;
                            case "GBP":
                                respuesta = cantidad * 0.74; // USD a Libra Esterlina
                                break;
                            case "JPY":
                                respuesta = cantidad * 146.32; // USD a Yen Japonés
                                break;
                            case "MXN":
                                respuesta = cantidad * 18.50; // USD a Peso Mexicano
                                break;
                            case "COP":
                                respuesta = cantidad * 3990.00; // USD a Peso Colombiano
                                break;
                            case "ARS":
                                respuesta = cantidad * 1280.00; // USD a Peso Argentino
                                break;
                            case "GTQ":
                                respuesta = cantidad * 7.80; // USD a Quetzal Guatemalteco
                                break;
                            case "CRC":
                                respuesta = cantidad * 525.00; // USD a Colón Costarricense
                                break;
                            case "SAR":
                                respuesta = cantidad * 3.75; // USD a Riyal Saudí
                                break;
                            case "USD":
                                respuesta = cantidad; // USD a USD
                                break;
                        }
                        break;

                    case "EUR":
                        switch (monedaDestino)
                        {
                            case "USD":
                                respuesta = cantidad * 1.18; // EUR a USD
                                break;
                            case "GBP":
                                respuesta = cantidad * 0.87; // EUR a Libra Esterlina
                                break;
                            case "JPY":
                                 respuesta = cantidad * 173.20; // EUR a Yen Japonés
                                break;
                            case "MXN":
                                respuesta = cantidad * 21.80; // EUR a Peso Mexicano
                                break;
                            case "COP":
                                respuesta = cantidad * 4680.00; // EUR a Peso Colombiano
                                break;
                            case "ARS":
                                respuesta = cantidad * 1500.00; // EUR a Peso Argentino
                                break;
                            case "GTQ":
                                respuesta = cantidad * 9.10; // EUR a Quetzal Guatemalteco
                                break;
                            case "CRC":
                                respuesta = cantidad * 610.00; // EUR a Colón Costarricense
                                break;
                            case "SAR":
                                respuesta = cantidad * 4.35; // EUR a Riyal Saudí
                                break;
                            case "EUR":
                                respuesta = cantidad; // EUR a EUR
                                break;
                        }
                        break;


                    case "GBP":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad * 1.35; // Libra Esterlina a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad * 1.16; // Libra Esterlina a EUR
                                break;
                            case "GBP":
                                respuesta = cantidad; // Libra Esterlina a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad * 199.98; //  Libra Esterlina a Yan Japones
                                break;
                            case "MXN": 
                                respuesta = cantidad * 25.44; // Libra Esterlina a Peso Mexicano
                                break;
                            case "COP": 
                                respuesta = cantidad * 5472.42; // Libra Esterlina a Peso Colombiano
                                break;
                            case "ARS": 
                                respuesta = cantidad * 1757.09;  // Libra Esterlina a Peso Argentino
                                break;
                            case "GTQ": 
                                respuesta = cantidad * 10.38;  // Libra Esterlina a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad * 5.08; // Libra Esterlina a Riyal Saudí
                                break;
                            case "CRC": 
                                respuesta = cantidad * 684.46; // Libra Esterlina a Colón Costarricense
                                break;
                        }
                        break;

                    case "JPY":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad * 0.0068; // Yen Japonés a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad * 0.0058; // Yen Japonés a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad * 0.0050; // Yen Japonés a Libra Esterlina
                                break;
                            case "JPY":
                                respuesta = cantidad; // Yen Japonés a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad * 0.13; // Yen Japonés a Peso Mexicano
                                break;
                            case "COP":
                                respuesta = cantidad * 27.44; // Yen Japonés a Peso Colombiano
                                break;
                            case "ARS":
                                respuesta = cantidad * 8.79; // Yen Japonés a Peso Argentino
                                break;
                            case "GTQ":
                                respuesta = cantidad * 0.052; // Yen Japonés a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad * 0.025; // Yen Japonés a Riyal Saudí
                                break;
                            case "CRC":
                                respuesta = cantidad * 3.42; // Yen Japonés a Colón Costarricense
                                break;
                        }
                        break;

                    case "MXN":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad * 0.053; // Peso Mexicano a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad * 0.046; // Peso Mexicano a EUR
                                break;
                            case "GBP": respuesta = cantidad * 0.039; // Peso Mexicano a Libra Esterlina
                                break;
                            case "JPY":
                                respuesta = cantidad * 7.86; /// Peso Mexicano a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad; // Peso Mexicano a Peso Mexicano
                                break;
                            case "COP": 
                                respuesta = cantidad * 215.75; // Peso Mexicano a Peso Colombiano
                                break;
                            case "ARS": 
                                respuesta = cantidad * 69.10; // Peso Mexicano a Peso Argentino
                                break;
                            case "GTQ":
                                respuesta = cantidad * 0.41; // Peso Mexicano a Quetzal Guatemalteco
                                break;
                            case "SAR":
                                respuesta = cantidad * 0.20;  // Peso Mexicano a Riyal Saudí
                                break;
                            case "CRC": 
                                respuesta = cantidad * 26.92; // Peso Mexicano a Colón Costarricense
                                break;
                        }
                        break;

                    case "COP":
                        switch (monedaDestino)
                        {
                            case "USD":
                                respuesta = cantidad * 0.00025;  // Peso Colombiano a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad * 0.00021; // Peso Colombiano a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad ; // Peso Colombiano a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad * 0.037; // Peso Colombiano a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad * 0.0046; // Peso Colombiano a Peso Mexicano
                                break;
                            case "COP":
                                respuesta = cantidad;  // Peso Colombiano a Peso Colombiano
                                break;
                            case "ARS":
                                respuesta = cantidad * 0.32; // Peso Colombiano a Peso Argentino
                                break;
                            case "GTQ": 
                                respuesta = cantidad * 0.0019; // Peso Colombiano a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad * 0.00093; // Peso Colombiano a Riyal Saudí
                                break;
                            case "CRC": 
                                respuesta = cantidad * 0.13; /// Peso Colombiano a Colón Costarricense
                                break;
                        }
                        break;

                    case "ARS":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad * 0.00077; // Peso Argentino a USD
                                break;
                            case "EUR":
                                respuesta = cantidad * 0.00066;  // Peso Argentino a EUR
                                break;
                            case "GBP":
                                respuesta = cantidad * 0.00057; // Peso Argentino a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad * 0.11; // Peso Argentino a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad * 0.014; // Peso Argentino a Peso Mexicano
                                break;
                            case "COP": 
                                respuesta = cantidad * 3.07; // Peso Argentino a Peso Colombiano
                                break;
                            case "ARS":
                                respuesta = cantidad; // Peso Argentino a Peso Argentino
                                break;
                            case "GTQ":
                                respuesta = cantidad * 0.0059; // Peso Argentino a Quetzal Guatemalteco
                                break;
                            case "SAR":
                                respuesta = cantidad * 0.0029; // Peso Argentino a Riyal Saudí
                                break;
                            case "CRC": 
                                respuesta = cantidad * 0.39;  // Peso Argentino a Colón Costarricense
                                break;
                        }
                        break;

                    case "GTQ":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad * 0.13; // Quetzal Guatemalteco a USD
                                break;
                            case "EUR":
                                respuesta = cantidad * 0.11; // Quetzal Guatemalteco a EUR
                                break;
                            case "GBP":
                                respuesta = cantidad * 0.096;  // Quetzal Guatemalteco a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad * 19.25; // Quetzal Guatemalteco a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad * 2.45;  // Quetzal Guatemalteco a Peso Mexicano
                                break;
                            case "COP":
                                respuesta = cantidad * 528.23; // Quetzal Guatemalteco a Peso Colombiano
                                break;
                            case "ARS": 
                                respuesta = cantidad * 169.31; // Quetzal Guatemalteco a Peso Argentino
                                break;
                            case "GTQ": 
                                respuesta = cantidad; // Quetzal Guatemalteco a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad * 0.49; // Quetzal Guatemalteco a Riyal Saudí
                                break;
                            case "CRC": 
                                respuesta = cantidad * 65.96; // Quetzal Guatemalteco a Colón Costarricense
                                break;
                        }
                        break;

                    case "SAR":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad * 0.27; // Riyal Saudí a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad * 0.23; // Riyal Saudí a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad * 0.20; // Riyal Saudí a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad * 39.34; // Riyal Saudí a Yen Japonés
                                break;
                            case "MXN":
                                respuesta = cantidad * 5.01; // Riyal Saudí a Peso Mexicano
                                break;
                            case "COP": 
                                respuesta = cantidad * 1079.62;  // Riyal Saudí a Peso Colombiano
                                break;
                            case "ARS": 
                                respuesta = cantidad * 346.05;  // Riyal Saudí a Peso Argentino
                                break;
                            case "GTQ": respuesta = cantidad * 2.04; // Riyal Saudí a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad; // Riyal Saudí a Riyal Saudí
                                break;
                            case "CRC": 
                                respuesta = cantidad * 134.81; 
                                break;
                        }
                        break;

                    case "CRC":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad * 0.0020; // Colón Costarricense a USD
                                break;
                            case "EUR":
                                respuesta = cantidad * 0.0017;  // Colón Costarricense a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad * 0.0015;  // Colón Costarricense a Libra Esterlina
                                break;
                            case "JPY":
                                respuesta = cantidad * 0.29; // Colón Costarricense a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad * 0.037; // Colón Costarricense a Peso Mexicano
                                break;
                            case "COP": respuesta = cantidad * 8.01; // Colón Costarricense a Peso Colombiano
                                break;
                            case "ARS": 
                                respuesta = cantidad * 2.57;  // Colón Costarricense a Peso Argentino
                                break;
                            case "GTQ": 
                                respuesta = cantidad * 0.015; // Colón Costarricense a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad * 0.0074; // Colón Costarricense a Riyal Saudí
                                break;
                            case "CRC":
                                respuesta = cantidad; // Colón Costarricense a Colón Costarricense
                                break;
                        }
                        break;
                }

                lblResultado.Text = string.Format(CultureInfo.InvariantCulture, "{0:N2} {1} = {2:N2} {3}",cantidad, monedaOrigen, respuesta, monedaDestino);


            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido y seleccione las monedas.");
            }
        }

        private void ConvertirMasa()
        {
            try
            {
                double cantidad = Double.Parse(txtValorAConvertir.Text);
                double respuesta = 0;

                string unidadOrigen = cmbDe.SelectedItem.ToString();
                string unidadDestino = cmbA.SelectedItem.ToString();

               
                switch (unidadOrigen)
                {
                    case "Gramos":

                        switch(unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad; // Gramos a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad / 1000.0; // Gramos a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad * 1000.0; // Gramos a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad / 453.5; // Gramos a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad / 28.34; // Gramos a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 1_000_000.0; // Gramos a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad / 6350; // Gramos a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad / 1000000; // Gramos a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 1_000_000.0; // Gramos a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 1_000_000_000.0; // Gramos a Nanogramos
                                break;
                        }
                        break;

                     case "Kilogramos":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad * 1000; // Kilogramos  a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad; // kilogramos a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad * 1.000000; // kilogramos a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad * 2.205; // kilogramos a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad / 35.274; // kilogramos a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 1000; // kilogramos a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad / 6.35; // kilogramos a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad / 100; // kilogramos a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 1000000; // kilogramos a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 1000000000000; // kilogramos a Nanogramos
                                break;
                        }
                        break;

                    case "Miligramos":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad / 1000; // Miligramos  a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad / 1000000; // Miligramos a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad; // Miligramos a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad / 453600; // Miligramos a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad / 28350; // Miligramosa Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 1000000000; // Miligramos a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad / 6.35; // Miligramos a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad / 100000000; // Miligramos a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 1000; // Miligramos a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 1000000; // Miligramos a Nanogramos
                                break;
                        }
                        break;

                    case "Libras":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad * 453.6; // Libras  a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad / 2.205; // Libras a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad * 453600; // Libras a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad; // Libras a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad * 16; // Libras a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 2205; // Libras a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad / 14; // Libras a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad / 220.5; // Libras a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 453.6; // Libras a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 4536; // Libras a Nanogramos
                                break;
                        }
                        break;


                    case "Onzas":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad * 28.35; // Onza a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad / 35.274; // Onza a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad * 28350; // Onza a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad  / 16; // Onza a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad;  // Onza a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 35270; // Onza a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad / 224; // Onza a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad / 3527; // Onza a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 2835000; // Onza a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 28350000000; // Onza a Nanogramos
                                break;
                        }
                        break;


                    case "Toneladas":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad * 1000000; // Toneladas a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad * 1000; // Toneladas a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad * 1000000000; // Toneladas a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad * 2205; // Toneladas a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad * 35270;  // Toneladas a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad; // Toneladas a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad * 157.5; // Toneladas a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad * 10; // Toneladas a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 1000000000000; // Toneladas a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 1000000000000000; //Toneladas a Nanogramos
                                break;
                        }
                        break;

                    case "Stone":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad * 6350; // Stone a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad * 6.35; // Stone a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad * 6350000; // Stone a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad * 14; // Stone a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad * 224;  // Stone a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 157.5; // Stone a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad; // Stone a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad / 15.747; // Stone a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 6350000000; // Stone a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 6350000000000; // Stone a Nanogramos
                                break;
                        }
                        break;

                    case "Quintales":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad * 100000; // Quintales a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad * 100; // Quintales a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad * 100000000; // Quintales a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad *  220.5; // Quintales a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad * 3527;  // Quintales a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 10; // Quintales a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad * 15.747; // Quintales a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad; // Quintales a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 100000000000; // Quintales a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 100000000000000; // Quintales a Nanogramos
                                break;
                        }
                        break;


                    case "Microgramos":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad / 1000000; // Microgramos a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad / 1000000000; // Microgramos a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad / 1000; // Microgramos a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad * 453600000; // Microgramos a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad / 28350000;  // Microgramos a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 1000000000000; // Microgramos a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad / 6350000000; // Microgramos a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad * 100000000000; // Microgramos a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad * 100000000000; // Microgramos a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad * 1000; // Microgramos a Nanogramos
                                break;
                        }
                        break;

                    case "Nanogramos":

                        switch (unidadDestino)
                        {
                            case "Gramos":
                                respuesta = cantidad / 1000000000; // Nanogramos a Gramos
                                break;
                            case "Kilogramos":
                                respuesta = cantidad / 1000000000000; // Nanogramos a Kilogramos
                                break;
                            case "Miligramos":
                                respuesta = cantidad / 1000000; // Nanogramos a Miligramos
                                break;
                            case "Libras":
                                respuesta = cantidad / 453600000000; // Nanogramos a Libras
                                break;
                            case "Onzas":
                                respuesta = cantidad / 28350000000;  // Nanogramos a Onzas
                                break;
                            case "Toneladas ":
                                respuesta = cantidad / 1000000000000000; // Nanogramos a Toneladas
                                break;
                            case "Stone":
                                respuesta = cantidad / 6350000000000; // Nanogramos a Stone
                                break;
                            case "Quintales":
                                respuesta = cantidad / 100000000000000; // Nanogramos a Quintales
                                break;
                            case "Microgramos":
                                respuesta = cantidad / 1000; // Nanogramos a Microgramos
                                break;
                            case "Nanogramos":
                                respuesta = cantidad; // Nanogramos a Nanogramos
                                break;
                        }
                        break;




                }

                lblResultado.Text = string.Format(CultureInfo.InvariantCulture, "{0:N2} {1} = {2:N2} {3}", cantidad, unidadOrigen, respuesta, unidadDestino);

            }



            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido y seleccione las unidades.");
            }


        }

        private void ConvertirVolumen()
        {
            try
            {
                double cantidad = Double.Parse(txtValorAConvertir.Text);
                double respuesta = 0;
                
                string unidadOrigen = cmbDe.SelectedItem.ToString();
                string unidadDestino = cmbA.SelectedItem.ToString();


                switch (unidadOrigen)
                {
                    case "Litros":
                        switch (unidadDestino)
                        {
                            case "Litros":
                                respuesta = cantidad; //    Litros a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 1000; // Litros a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad * 100; // Litros a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad / 3785.41; //Litros a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad * 2.113; // Litros a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad * 1.06; // Litros a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 33.814; // Litros a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad / 1000;  //  Litros a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 1000;  //  Litros a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad * 0.00628981; // Litros a Barriles 
                                break;
                        }
                        break;

                    case "Mililitros":
                        switch (unidadDestino)
                        
                            {
                            case "Litros":
                                respuesta = cantidad / 1000; //    Mililitros a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad; // Mililitros a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad / 10; // Mililitros a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad / 3785.41; //Mililitros a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad / 473.2; // Mililitros a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad * 946.35; // Mililitros a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 0.033814; // Mililitros a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad / 1000000;  //  Mililitros a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 1;  //  Mililitros a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad * 6.289; // Mililitros a Barriles 
                                break;
                            }
                            break;

                    case "Centilitros":
                        switch (unidadDestino)

                        {
                            case "Litros":
                                respuesta = cantidad / 100; //    Centilitros a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 10; // Centilitros a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad; // Centilitros a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad / 378.5; //Centilitros a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad / 47.318; // Centilitros a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad * 0.0105; // Centilitros a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 0.033814; // Centilitros a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad / 1000000;  //  Centilitros a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 100000;  //  Centilitros a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad * 6.289; // Centilitros a Barriles 
                                break;
                        }
                        break;


                    case "Galones":
                        switch (unidadDestino)

                        {
                            case "Litros":
                                respuesta = cantidad * 3.785; //    Galones a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 3785; // Galones a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad * 378.5; // Galones a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad; //Galones a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad * 8; // Galones a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad * 4.0; // Galones a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 128.0; // Galones a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad / 1000000;  //  Galones a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 0.00378541;  //  Galones a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad / 42.0; // Galones a Barriles 
                                break;
                        }
                        break;

                    case "Pintas":
                        switch (unidadDestino)

                        {
                            case "Litros":
                                respuesta = cantidad / 2113; //    Pintas a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 473.2; // Pintas a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad * 47.318; // Pintas a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad / 8; //Pintas a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad; // Pintas a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad / 2; // Pintas a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 16.0; // Pintas a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad * 0.000473176;  //  Pintas a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 473.176;  //  Pintas a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad / 336.0; // Pintas a Barriles 
                                break;
                        }
                        break;

                    case "Cuartos":
                        switch (unidadDestino)

                        {
                            case "Litros":
                                respuesta = cantidad * 0.946352946; //    Cuartos a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 946.352946; // Cuartos a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad * 94.6352946; // Cuartos a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad / 4.0; //Cuartos a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad * 2.0; // Cuartos a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad; // Cuartos a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 32.0; // Cuartos a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad * 0.000946352946;  //  Cuartos a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 946.352946;  //  Cuartos a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad / 0.00588235; // Cuartos a Barriles 
                                break;
                        }
                        break;


                    case "Onzas líquidas":
                        switch (unidadDestino)

                        {
                            case "Litros":
                                respuesta = cantidad * 0.0295735296; //    Onzas líquidas a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 29.5735296; // Onzas líquidas a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad * 2.95735296; // Onzas líquidas a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad / 128.0; //Onzas líquidas a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad / 16.0; // Onzas líquidas a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad / 32.0; // Onzas líquidas a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad; // Onzas líquidas a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad * 2.95735;  //  Onzas líquidas a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 29.5735296;  //  Onzas líquidas a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad / 5376.0; // Onzas líquidas a Barriles 
                                break;
                        }
                        break;

                    case "Metros cúbicos":
                        switch (unidadDestino)

                        {
                            case "Litros":
                                respuesta = cantidad * 1000; //    Metros cúbicos a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 1000000; // Metros cúbicos a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad * 100000; // Metros cúbicos a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad * 264.2; // Metros cúbicos a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad * 2113; // Metros cúbicos a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad * 1056.68; // Metros cúbicos a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 33814.0227; // Metros cúbicos a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad ;  //  Metros cúbicos a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 1000000;  //  Metros cúbicos a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad * 6.28981; //Metros cúbicos a Barriles 
                                break;


                        }
                        break;

                    case "Centímetros cúbicos":
                        switch (unidadDestino)

                        {
                            case "Litros":
                                respuesta = cantidad / 1000; //   Centímetros cúbicos a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 1; // Centímetros cúbicos  a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad / 10; //  Centímetros cúbicos a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad / 3785; //  Centímetros cúbicos a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad / 473.2; //  Centímetros cúbicos a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad * 0.0010566882094326; //  Centímetros cúbicos a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 0.0338140227; //  Centímetros cúbicos a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad * 0.000001;  //   Centímetros cúbicos a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad;  //   Centímetros cúbicos a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad * 0.00000628981; // Centímetros cúbicos a Barriles 
                                break;


                        }
                        break;

                    case "Barriles":
                        switch (unidadDestino)

                        {
                            case "Litros":
                                respuesta = cantidad * 158.987294928; //   Barriles  a Litros 
                                break;
                            case "Mililitros":
                                respuesta = cantidad * 158987.294928; //  Barriles  a Mililitros 
                                break;
                            case "Centilitros":
                                respuesta = cantidad * 15898.7294928; //   Barriles a Centilitros
                                break;
                            case "Galones":
                                respuesta = cantidad * 42.0; //   Barriles a Galones
                                break;
                            case "Pintas":
                                respuesta = cantidad * 336.0; //   Barriles a Pintas
                                break;
                            case "Cuartos":
                                respuesta = cantidad * 168.0; //   Barriles a Cuartos 
                                break;
                            case "Onzas líquidas":
                                respuesta = cantidad * 5376.0; //   Barriles a Onzas líquidas
                                break;
                            case "Metros cúbicos":
                                respuesta = cantidad * 0.158987294928;  //    Barriles a Metros cúbicos
                                break;
                            case "Centímetros cúbicos":
                                respuesta = cantidad * 158987.294928; //    Barriles a Centímetros cúbicos
                                break;
                            case "Barriles":
                                respuesta = cantidad; //  Barriles a Barriles 
                                break;


                        }
                        break;

                }

                 lblResultado.Text = $"{cantidad:N2} {unidadOrigen} = {respuesta:N3} {unidadDestino}";
            }
                        catch
                        {
                           MessageBox.Show("Ingrese un valor numérico válido y seleccione el Volumen.");
                        }


        }



        private void ConvertirLongitud()
        {
            try
            {
                double cantidad = Double.Parse(txtValorAConvertir.Text);
                double respuesta = 0;

                string unidadOrigen = cmbDe.SelectedItem.ToString();
                string unidadDestino = cmbA.SelectedItem.ToString();

                
                switch (unidadOrigen)
                {
                    case "Metros":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad; //    Metros a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad * 100; // Metros a centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad * 1000; // Metros a  milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad / 1000; //Metros a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad * 1000000; // Metros a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad / 1000000000; // Metros a Nanómetros 
                                break;
                            case "Pulgadas":
                                respuesta = cantidad * 39.37; // Metros a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad * 3.281;  //  Metros a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad * 1.094;  //  Metros a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 1609; // Metros a Millas 
                                break;
                        }
                        break;

                    case "Centímetros":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad / 100; //    Centímetros a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad; // Centímetros a centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad * 10; // Centímetros a  milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad / 100000; //Centímetros a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad * 10000; // Centímetros a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad * 10000000; // Centímetros a Nanómetros 
                                break;
                            case "Pulgadas":
                                respuesta = cantidad / 2.54; // Centímetros a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad / 30.48;  //  Centímetros a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad / 91.44;  //  Centímetros a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 160900; // Centímetros a Millas 
                                break;
                        }
                        break;

                    case "Milímetros":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad / 1000; //    Milímetros a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad / 10.0; // Milímetros a centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad; // Milímetros a  milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad / 1000000; //Milímetros a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad * 1000; // Milímetros a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad * 1000000; // Milímetros a Nanómetros 
                                break;
                            case "Pulgadas":
                                respuesta = cantidad / 25.4; // Milímetros a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad / 304.8;  //  Milímetros a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad / 914.4;  //  Milímetros a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 1609000; // Milímetros a Millas 
                                break;
                        }
                        break;

                    case "Kilómetros":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad * 1000; //    Kilómetros a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad / 100000; // Kilómetros a centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad * 1000000; // Kilómetros a  milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad; //Kilómetros a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad * 1000000000; // Kilómetros a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad * 1000000000000; // Kilómetros a Nanómetros 
                                break;
                            case "Pulgadas":
                                respuesta = cantidad * 39370; // Kilómetros a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad * 3281;  //  Kilómetros a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad * 1094;  //  Kilómetros a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 1.609; // Kilómetros a Millas 
                                break;
                        }
                        break;



                    case "Micrómetros":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad / 1000000; //    Micrómetros a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad / 10000; // Micrómetros a centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad / 1000; // Micrómetros a  milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad / 1000000000; //Micrómetros a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad; // Micrómetros a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad * 1000; // Micrómetros a Nanómetros 
                                break;
                            case "Pulgadas":
                                respuesta = cantidad / 25400; // Micrómetros a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad / 304800;  //  Micrómetros a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad / 914400;  //  Micrómetros a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 1.609; // Micrómetros a Millas 
                                break;
                        }
                        break;


                        case "Nanómetros":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad / 100000000; //    Nanómetros a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad / 10000000; // Nanómetros a centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad / 1000000; // Nanómetros a  milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad / 1000000000000; //Nanómetros a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad / 1000; // Nanómetros a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad; // Nanómetros a Nanómetros 
                                break;
                            case "Pulgadas":
                                respuesta = cantidad / 25400000; // Nanómetros a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad / 30480000;  //  Nanómetros a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad / 914400000;  //  Nanómetros a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 1609344000; // Micrómetros a Millas 
                                break;
                        }
                        break;


                    case "Pulgadas":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad / 39.37; //    Pulgadas a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad * 2.54; // Pulgadas a centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad * 25.4; // Pulgadas a  milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad / 39370; //Pulgadas a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad * 25400; // Pulgadas a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad * 25400000; // Pulgadas a Nanómetros 
                                break;
                            case "Pulgadas":
                                respuesta = cantidad; // Pulgadas a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad / 12;  //  Pulgadas a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad / 36;  //  Pulgadas a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 63360.0; // Pulgadas a Millas 
                                break;
                        }
                        break;

                    case "Pies":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad * 0.3048; // Pies a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad * 30.48; // Pies a Centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad * 304.8; // Pies a Milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad * 0.0003048; // Pies a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad * 304800; // Pies a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad * 3.048e+8; // Pies a Nanómetros
                                break;
                            case "Pulgadas":
                                respuesta = cantidad * 12; // Pies a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad; // Pies a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad / 3; // Pies a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 5280; // Pies a Millas
                                break;
                        }
                        break;

                    case "Yardas":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad * 0.9144; // Yardas a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad * 91.44; // Yardas a Centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad * 914.4; // Yardas a Milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad * 0.0009144; // Yardas a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad * 914400; // Yardas a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad * 9.144e+8; // Yardas a Nanómetros
                                break;
                            case "Pulgadas":
                                respuesta = cantidad * 36; // Yardas a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad * 3; // Yardas a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad; // Yardas a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad / 1760; // Yardas a Millas
                                break;
                        }
                        break;


                    case "Millas":
                        switch (unidadDestino)
                        {
                            case "Metros":
                                respuesta = cantidad * 1609.34; // Millas a Metros
                                break;
                            case "Centímetros":
                                respuesta = cantidad * 160934; // Millas a Centímetros
                                break;
                            case "Milímetros":
                                respuesta = cantidad * 1.609e+6; // Millas a Milímetros
                                break;
                            case "Kilómetros":
                                respuesta = cantidad * 1.60934; // Millas a Kilómetros
                                break;
                            case "Micrómetros":
                                respuesta = cantidad * 1.609e+9; // Millas a Micrómetros
                                break;
                            case "Nanómetros":
                                respuesta = cantidad * 1.609e+12; // Millas a Nanómetros
                                break;
                            case "Pulgadas":
                                respuesta = cantidad * 63360; // Millas a Pulgadas
                                break;
                            case "Pies":
                                respuesta = cantidad * 5280; // Millas a Pies
                                break;
                            case "Yardas":
                                respuesta = cantidad * 1760; // Millas a Yardas
                                break;
                            case "Millas":
                                respuesta = cantidad; // Millas a Millas
                                break;
                        }
                        break;


                }

                lblResultado.Text = string.Format("{0:N2} {1} = {2:N3} {3}", cantidad, unidadOrigen, respuesta, unidadDestino);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido y seleccione la Longitud.");
            }


        }


        private void ConvertirAlmacenamiento()
        {
            try
            {
                double cantidad = Double.Parse(txtValorAConvertir.Text);
                double respuesta = 0;

                string unidadOrigen = cmbDe.SelectedItem.ToString();
                string unidadDestino = cmbA.SelectedItem.ToString();

                switch (unidadOrigen)
                {
                    case "Bits":
                        switch (unidadDestino)
                        {
                            case "Bits": 
                                respuesta = cantidad; // Bits a Bits
                                break;
                            case "Bytes":
                                respuesta = cantidad / 8; // Bits a Bytes
                                break;
                            case "Kilobytes": 
                                respuesta = cantidad / 8000; // Bits a Kilobytes
                                break;
                            case "Megabytes": 
                                respuesta = cantidad / (8 * 1024 * 1024); // Bits a Megabytes
                                break;
                            case "Gigabytes":
                                respuesta = cantidad / (8d * 1024 * 1024 * 1024); // Bits a Gigabytes
                                break;
                            case "Terabytes": 
                                respuesta = cantidad / (8d * 1024 * 1024 * 1024 * 1024);// Bits a Terabytes
                                break;
                            case "Petabytes": 
                                respuesta = cantidad / (8d * Math.Pow(1024, 5)); // Bits a Petabytes
                                break;
                            case "Exabytes": 
                                respuesta = cantidad / (8d * Math.Pow(1024, 6)); // Bits a Exabytes
                                break;
                            case "Zettabytes": 
                                respuesta = cantidad / (8d * Math.Pow(1024, 7)); // Bits a Zettabytes
                                break;
                            case "Yottabytes": 
                                respuesta = cantidad / (8d * Math.Pow(1024, 8)); // Bits aYottabytes
                                break;
                        }
                        break;

                    case "Bytes":
                        switch (unidadDestino)
                        {
                            case "Bits": 
                                respuesta = cantidad * 8;  //Bytes a Bits
                                break;
                            case "Bytes": respuesta = cantidad;
                                break;
                            case "Kilobytes": respuesta = cantidad / 1024; //Bytes a Bytes
                                break;
                            case "Megabytes": respuesta = cantidad / Math.Pow(1024, 2); //Bytes a Megabytes
                                break;
                            case "Gigabytes": respuesta = cantidad / Math.Pow(1024, 3); //Bytes a Gigabytes
                                break;
                            case "Terabytes": respuesta = cantidad / Math.Pow(1024, 4); //Bytes a Terabytes
                                break;
                            case "Petabytes": respuesta = cantidad / Math.Pow(1024, 5); //Bytes a Petabytes
                                break;
                            case "Exabytes": respuesta = cantidad / Math.Pow(1024, 6); //Bytes  a Exabytes
                                break;
                            case "Zettabytes": respuesta = cantidad / Math.Pow(1024, 7); //Bytes a Zettabytes
                                break;
                            case "Yottabytes": respuesta = cantidad / Math.Pow(1024, 8); //Bytes a Yottabytes
                                break;
                        }
                        break;

                    case "Kilobytes":
                        switch (unidadDestino)
                        {
                            case "Bits": 
                                respuesta = cantidad * 8 * 1024; // Kilobytes a
                                break;
                            case "Bytes": respuesta = cantidad * 1024; // Kilobytes a Bytes
                                break;
                            case "Kilobytes": respuesta = cantidad; // Kilobytes a Kilobytes
                                break;
                            case "Megabytes": 
                                respuesta = cantidad / 1024; // Kilobytes a Megabytes
                                break;
                            case "Gigabytes": 
                                respuesta = cantidad / Math.Pow(1024, 2); // Kilobytes a  Gigabytes
                                break;
                            case "Terabytes": 
                                respuesta = cantidad / Math.Pow(1024, 3); // Kilobytes a  Terabytes
                                break;
                            case "Petabytes": 
                                respuesta = cantidad / Math.Pow(1024, 4); // Kilobytes a Petabytes
                                break;
                            case "Exabytes": 
                                respuesta = cantidad / Math.Pow(1024, 5);  // Kilobytes a Exabytes
                                break;
                            case "Zettabytes":
                                respuesta = cantidad / Math.Pow(1024, 6); // Kilobytes a Zettabytes
                                break;
                            case "Yottabytes":
                                respuesta = cantidad / Math.Pow(1024, 7); // Kilobytes a Yottabytes
                                break;
                        }
                        break;

                    case "Megabytes":
                        switch (unidadDestino)
                        {
                            case "Bits": 
                                respuesta = cantidad * 8 * Math.Pow(1024, 2); // Megabytes a Bits
                                break;
                            case "Bytes": 
                                respuesta = cantidad * Math.Pow(1024, 2); // Megabytes a Bytes
                                break;
                            case "Kilobytes": 
                                respuesta = cantidad * 1024; // Megabytes a Kilobytes
                                break;
                            case "Megabytes": 
                                respuesta = cantidad; // Megabytes a Megabytes
                                break;
                            case "Gigabytes": 
                                respuesta = cantidad / 1024; // Megabytes a Gigabytes
                                break;
                            case "Terabytes": 
                                respuesta = cantidad / Math.Pow(1024, 2); // Megabytes a Terabytes
                                break;
                            case "Petabytes":
                                respuesta = cantidad / Math.Pow(1024, 3); // Megabytes a Petabytes
                                break;
                            case "Exabytes": 
                                respuesta = cantidad / Math.Pow(1024, 4); // Megabytes a Exabytes
                                break;
                            case "Zettabytes": 
                                respuesta = cantidad / Math.Pow(1024, 5); // Megabytes a Zettabytes
                                break;
                            case "Yottabytes":
                                respuesta = cantidad / Math.Pow(1024, 6); // Megabytes a Yottabytes
                                break;
                        }
                        break;

                    case "Gigabytes":
                        switch (unidadDestino)
                        {
                            case "Bits": 
                                respuesta = cantidad * 8 * Math.Pow(1024, 3); // Gigabytes a Bits
                                break;
                            case "Bytes": 
                                respuesta = cantidad * Math.Pow(1024, 3); // Gigabytes a Bytes
                                break;
                            case "Kilobytes": 
                                respuesta = cantidad * Math.Pow(1024, 2); // Gigabytes a Kilobytes
                                break;
                            case "Megabytes":
                                respuesta = cantidad * 1024; // Gigabytes a Megabytes
                                break;
                            case "Gigabytes": 
                                respuesta = cantidad; // Gigabytes a Gigabytes
                                break;
                            case "Terabytes":
                                respuesta = cantidad / 1024; // Gigabytes a Terabytes
                                break;
                            case "Petabytes": 
                                respuesta = cantidad / Math.Pow(1024, 2); // Gigabytes a Petabytes
                                break;
                            case "Exabytes":
                                respuesta = cantidad / Math.Pow(1024, 3); // Gigabytes a Exabytes
                                break;
                            case "Zettabytes": 
                                respuesta = cantidad / Math.Pow(1024, 4); // Gigabytes a Zettabytes
                                break;
                            case "Yottabytes": 
                                respuesta = cantidad / Math.Pow(1024, 5); // Gigabytes a Yottabytes
                                break;
                        }
                        break;

                    case "Terabytes":
                        switch (unidadDestino)
                        {
                            case "Bits": 
                                respuesta = cantidad * 8 * Math.Pow(1024, 4); // Terabytes a Bits
                                break;
                            case "Bytes": respuesta = cantidad * Math.Pow(1024, 4); // Terabytes a Bytes
                                break;
                            case "Kilobytes":
                                respuesta = cantidad * Math.Pow(1024, 3); // Terabytes a Kilobytes
                                break;
                            case "Megabytes": 
                                respuesta = cantidad * Math.Pow(1024, 2); // Terabytes a Megabytes
                                break;
                            case "Gigabytes": 
                                respuesta = cantidad * 1024;  // Terabytes a Gigabytes
                                break;
                            case "Terabytes":
                                respuesta = cantidad; // Terabytes a Terabytes
                                break;
                            case "Petabytes": 
                                respuesta = cantidad / 1024; // Terabytes a Petabytes
                                break;
                            case "Exabytes":
                                respuesta = cantidad / Math.Pow(1024, 2);  // Terabytes a Exabytes
                                break;
                            case "Zettabytes":
                                respuesta = cantidad / Math.Pow(1024, 3); // Terabytes a Zettabytes
                                break;
                            case "Yottabytes": 
                                respuesta = cantidad / Math.Pow(1024, 4); // Terabytes a Yottabytes
                                break;
                        }
                        break;

                    case "Petabytes":
                        switch (unidadDestino)
                        {
                            case "Bits":
                                respuesta = cantidad * 8 * Math.Pow(1024, 5); // Petabytes a Bits
                                break;
                            case "Bytes": 
                                respuesta = cantidad * Math.Pow(1024, 5); // Petabytes a Bytes
                                break;
                            case "Kilobytes": 
                                respuesta = cantidad * Math.Pow(1024, 4); // Petabytes a Kilobytes
                                break;
                            case "Megabytes":
                                respuesta = cantidad * Math.Pow(1024, 3); // Petabytes a Megabytes
                                break;
                            case "Gigabytes": 
                                respuesta = cantidad * Math.Pow(1024, 2); // Petabytes a Gigabytes
                                break;
                            case "Terabytes":
                                respuesta = cantidad * 1024; // Petabytes a Terabytes
                                break;
                            case "Petabytes":
                                respuesta = cantidad; // Petabytes a Petabytes
                                break;
                            case "Exabytes": 
                                respuesta = cantidad / 1024; // Petabytes a Exabytes
                                break;
                            case "Zettabytes":
                                respuesta = cantidad / Math.Pow(1024, 2); // Petabytes a Zettabytes
                                break;
                            case "Yottabytes": 
                                respuesta = cantidad / Math.Pow(1024, 3); // Petabytes a Yottabytes
                                break;
                        }
                        break;

                    case "Exabytes":
                        switch (unidadDestino)
                        {
                            case "Bits": 
                                respuesta = cantidad * 8 * Math.Pow(1024, 6); // Exabytes a Bits
                                break;
                            case "Bytes": 
                                respuesta = cantidad * Math.Pow(1024, 6); // Exabytes a Bytes
                                break;
                            case "Kilobytes": 
                                respuesta = cantidad * Math.Pow(1024, 5); // Exabytes a Kilobytes
                                break;
                            case "Megabytes": 
                                respuesta = cantidad * Math.Pow(1024, 4); // Exabytes a Megabytes
                                break;
                            case "Gigabytes":
                                respuesta = cantidad * Math.Pow(1024, 3); // Exabytes a Gigabytes
                                break;
                            case "Terabytes": 
                                respuesta = cantidad * Math.Pow(1024, 2); // Exabytes a Terabytes
                                break;
                            case "Petabytes":
                                respuesta = cantidad * 1024; // Exabytes a Petabytes
                                break;
                            case "Exabytes": 
                                respuesta = cantidad; // Exabytes a Exabytes
                                break;
                            case "Zettabytes":
                                respuesta = cantidad / 1024; // Exabytes a Zettabytes
                                break;
                            case "Yottabytes": 
                                respuesta = cantidad / Math.Pow(1024, 2); // Exabytes a Yottabytes
                                break;
                        }
                        break;

                    
                        
                            case "Zettabytes":
                                switch (unidadDestino)
                                {
                                    case "Bits":
                                        respuesta = cantidad * 8 * Math.Pow(1024, 7); // Zettabytes a Bits
                                        break;
                                    case "Bytes":
                                        respuesta = cantidad * Math.Pow(1024, 7); // Zettabytes a Bytes
                                        break;
                                    case "Kilobytes":
                                        respuesta = cantidad * Math.Pow(1024, 6); // Zettabytes a Kilobytes
                                        break;
                                    case "Megabytes":
                                        respuesta = cantidad * Math.Pow(1024, 5); // Zettabytes a Megabytes
                                        break;
                                    case "Gigabytes":
                                        respuesta = cantidad * Math.Pow(1024, 4); // Zettabytes a Gigabytes
                                        break;
                                    case "Terabytes":
                                        respuesta = cantidad * Math.Pow(1024, 3); // Zettabytes a Terabytes
                                        break;
                                    case "Petabytes":
                                        respuesta = cantidad * Math.Pow(1024, 2); // Zettabytes a Petabytes
                                        break;
                                    case "Exabytes":
                                        respuesta = cantidad * 1024; // Zettabytes a Exabytes
                                        break;
                                    case "Zettabytes":
                                        respuesta = cantidad; // Zettabytes a Zettabytes
                                        break;
                                    case "Yottabytes":
                                        respuesta = cantidad / 1024; // Zettabytes a Yottabytes
                                        break;
                                }
                                break;


                    case "Yottabytes":
                        switch (unidadDestino)
                        {
                            case "Bits":
                                respuesta = cantidad * 8 * Math.Pow(1024, 8); // Yottabytes a Bits
                                break;
                            case "Bytes":
                                respuesta = cantidad * Math.Pow(1024, 8); // Yottabytes a Bytes
                                break;
                            case "Kilobytes":
                                respuesta = cantidad * Math.Pow(1024, 7); // Yottabytes a Kilobytes
                                break;
                            case "Megabytes":
                                respuesta = cantidad * Math.Pow(1024, 6); // Yottabytes a Megabytes
                                break;
                            case "Gigabytes":
                                respuesta = cantidad * Math.Pow(1024, 5); // Yottabytes a Gigabytes
                                break;
                            case "Terabytes":
                                respuesta = cantidad * Math.Pow(1024, 4); // Yottabytes a Terabytes
                                break;
                            case "Petabytes":
                                respuesta = cantidad * Math.Pow(1024, 3); // Yottabytes a Petabytes
                                break;
                            case "Exabytes":
                                respuesta = cantidad * Math.Pow(1024, 2); // Yottabytes a Exabytes
                                break;
                            case "Zettabytes":
                                respuesta = cantidad * 1024; // Yottabytes a Zettabytes
                                break;
                            case "Yottabytes":
                                respuesta = cantidad; // Yottabytes a Yottabytes
                                break;
                        }
                        break;

                }

                lblResultado.Text = string.Format("{0:N2} {1} = {2:N3} {3}", cantidad, unidadOrigen, respuesta, unidadDestino);

            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido y seleccione el valor de  almacenamiento.");
            }
        }


        private void ConvertirTiempo()
        {
            try
            {
                double cantidad = Double.Parse(txtValorAConvertir.Text);
                double respuesta = 0;

                string unidadOrigen = cmbDe.SelectedItem.ToString();
                string unidadDestino = cmbA.SelectedItem.ToString();

                switch (unidadOrigen)
                {
                    case "Segundos": 
                        switch (unidadDestino)
                        {
                            case "Milisegundos":
                                respuesta = cantidad * 1000; // Segundos a Milisegundos
                                break;
                            case "Segundos":
                                respuesta = cantidad; // Segundos a Segundos
                                break;
                            case "Minutos": 
                                respuesta = cantidad / 60; // Segundos a Minutos
                                break;
                            case "Horas": 
                                respuesta = cantidad / 3600;  // Segundos a Horas
                                break;
                            case "Días": 
                                respuesta = cantidad / 86400; // Segundos a Días
                                break;
                            case "Semanas": 
                                respuesta = cantidad / 604800; // Segundos a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad / (30d * 86400); // Segundos a Meses (aprox)
                                break;
                            case "Años":
                                respuesta = cantidad / (365d * 86400); // Segundos a Años
                                break;
                            case "Décadas": 
                                respuesta = cantidad / (10d * 365 * 86400); // Segundos a Décadas
                                break;
                            case "Siglos": 
                                respuesta = cantidad / (100d * 365 * 86400); // Segundos a Siglos
                                break;
                        }
                        break;

                    case "Milisegundos":
                        switch (unidadDestino)
                        {
                            case "Milisegundos": 
                                respuesta = cantidad; // Milisegundos a Milisegundos
                                break;
                            case "Segundos": 
                                respuesta = cantidad / 1000; // Milisegundos a Segundos
                                break;
                            case "Minutos": 
                                respuesta = cantidad / (1000 * 60); // Milisegundos a Minutos
                                break;
                            case "Horas": 
                                respuesta = cantidad / (1000 * 3600); // Milisegundos a Horas
                                break;
                            case "Días": 
                                respuesta = cantidad / (1000 * 86400); // Milisegundos a Días
                                break;
                            case "Semanas": 
                                respuesta = cantidad / (1000 * 604800);// Milisegundos a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad / (1000 * 30d * 86400);   // Milisegundos a Meses
                                break;
                            case "Años": 
                                respuesta = cantidad / (1000 * 365d * 86400);  // Milisegundos a Años
                                break;
                            case "Décadas": 
                                respuesta = cantidad / (1000 * 10d * 365 * 86400); // Milisegundos a Décadas
                                break;
                            case "Siglos": 
                                respuesta = cantidad / (1000 * 100d * 365 * 86400);  // Milisegundos a Siglos
                                break;
                        }
                        break;

                    case "Minutos": 
                        switch (unidadDestino)
                        {
                            case "Milisegundos":
                                respuesta = cantidad * 60 * 1000; // Minutos a Milisegundos
                                break;
                            case "Segundos":
                                respuesta = cantidad * 60;  // Minutos a Segundos
                                break;
                            case "Minutos": 
                                respuesta = cantidad;  // Minutos a Minutos
                                break;
                            case "Horas": 
                                respuesta = cantidad / 60;  // Minutos a Horas
                                break;
                            case "Días": 
                                respuesta = cantidad / (60 * 24);   // Minutos a Días
                                break;
                            case "Semanas":
                                respuesta = cantidad / (60 * 24 * 7); // Minutos a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad / (60 * 24 * 30d);  // Minutos a Meses
                                break;
                            case "Años": 
                                respuesta = cantidad / (60 * 24 * 365d); // Minutos a Años
                                break;
                            case "Décadas": 
                                respuesta = cantidad / (60 * 24 * 365d * 10);  // Minutos a Décadas
                                break;
                            case "Siglos": 
                                respuesta = cantidad / (60 * 24 * 365d * 100); // Minutos a Siglos
                                break;
                        }
                        break;

                    case "Horas": 
                        switch (unidadDestino)
                        {
                            case "Milisegundos": 
                                respuesta = cantidad * 3600 * 1000;  // Horas a Milisegundos
                                break;
                            case "Segundos": respuesta = cantidad * 3600;  // Horas a Segundos
                                break;
                            case "Minutos": respuesta = cantidad * 60;   // Horas a Minutos
                                break;
                            case "Horas": respuesta = cantidad;  // Horas a Horas
                                break;
                            case "Días": respuesta = cantidad / 24;  // Horas a Días
                                break;
                            case "Semanas": respuesta = cantidad / (24 * 7); // Horas a Semanas
                                break;
                            case "Meses": respuesta = cantidad / (24 * 30d); // Horas a Meses
                                break;
                            case "Años": respuesta = cantidad / (24 * 365d);  // Horas a Años
                                break;
                            case "Décadas": respuesta = cantidad / (24 * 365d * 10);   // Horas a Décadas
                                break;
                            case "Siglos": respuesta = cantidad / (24 * 365d * 100);  // Horas a Siglos
                                break;
                        }
                        break;

                    case "Días":
                        switch (unidadDestino)
                        {
                            case "Milisegundos":
                                respuesta = cantidad * 86400 * 1000;  // Días a Milisegundos
                                break;
                            case "Segundos":
                                respuesta = cantidad * 86400;  // Días a Segundos
                                break;
                            case "Minutos":
                                respuesta = cantidad * 1440;  // Días a Minutos
                                break;
                            case "Horas":
                                respuesta = cantidad * 24;  // Días a Horas
                                break;
                            case "Días":
                                respuesta = cantidad;  // Días a Días
                                break;
                            case "Semanas":
                                respuesta = cantidad / 7;  // Días a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad / 30d;  // Días a Meses
                                break;
                            case "Años":
                                respuesta = cantidad / 365d;  // Días a Años
                                break;
                            case "Décadas":
                                respuesta = cantidad / (365d * 10);  // Días a Décadas
                                break;
                            case "Siglos":
                                respuesta = cantidad / (365d * 100);  // Días a Siglos
                                break;
                        }
                        break;

                    case "Semanas":
                        switch (unidadDestino)
                        {
                            case "Milisegundos":
                                respuesta = cantidad * 7 * 86400 * 1000;  // Semanas a Milisegundos
                                break;
                            case "Segundos":
                                respuesta = cantidad * 7 * 86400;  // Semanas a Segundos
                                break;
                            case "Minutos":
                                respuesta = cantidad * 7 * 1440;  // Semanas a Minutos
                                break;
                            case "Horas":
                                respuesta = cantidad * 7 * 24;  // Semanas a Horas
                                break;
                            case "Días":
                                respuesta = cantidad * 7;  // Semanas a Días
                                break;
                            case "Semanas":
                                respuesta = cantidad;  // Semanas a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad / (30d / 7);  // Semanas a Meses
                                break;
                            case "Años":
                                respuesta = cantidad / (365d / 7);  // Semanas a Años
                                break;
                            case "Décadas":
                                respuesta = cantidad / ((365d * 10) / 7);  // Semanas a Décadas
                                break;
                            case "Siglos":
                                respuesta = cantidad / ((365d * 100) / 7);  // Semanas a Siglos
                                break;
                        }
                        break;

                    case "Meses":
                        switch (unidadDestino)
                        {
                            case "Milisegundos":
                                respuesta = cantidad * 30d * 86400 * 1000;  // Meses a Milisegundos
                                break;
                            case "Segundos":
                                respuesta = cantidad * 30d * 86400;  // Meses a Segundos
                                break;
                            case "Minutos":
                                respuesta = cantidad * 30d * 1440;  // Meses a Minutos
                                break;
                            case "Horas":
                                respuesta = cantidad * 30d * 24;  // Meses a Horas
                                break;
                            case "Días":
                                respuesta = cantidad * 30d;  // Meses a Días
                                break;
                            case "Semanas":
                                respuesta = cantidad * (30d / 7);  // Meses a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad;  // Meses a Meses
                                break;
                            case "Años":
                                respuesta = cantidad / 12d;  // Meses a Años
                                break;
                            case "Décadas":
                                respuesta = cantidad / 120d;  // Meses a Décadas
                                break;
                            case "Siglos":
                                respuesta = cantidad / 1200d;  // Meses a Siglos
                                break;
                        }
                        break;

                    case "Años":
                        switch (unidadDestino)
                        {
                            case "Milisegundos":
                                respuesta = cantidad * 365d * 86400 * 1000;  // Años a Milisegundos
                                break;
                            case "Segundos":
                                respuesta = cantidad * 365d * 86400;  // Años a Segundos
                                break;
                            case "Minutos":
                                respuesta = cantidad * 365d * 1440;  // Años a Minutos
                                break;
                            case "Horas":
                                respuesta = cantidad * 365d * 24;  // Años a Horas
                                break;
                            case "Días":
                                respuesta = cantidad * 365d;  // Años a Días
                                break;
                            case "Semanas":
                                respuesta = cantidad * (365d / 7);  // Años a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad * 12d;  // Años a Meses
                                break;
                            case "Años":
                                respuesta = cantidad;  // Años a Años
                                break;
                            case "Décadas":
                                respuesta = cantidad / 10d;  // Años a Décadas
                                break;
                            case "Siglos":
                                respuesta = cantidad / 100d;  // Años a Siglos
                                break;
                        }
                        break;

                    case "Décadas":
                        switch (unidadDestino)
                        {
                            case "Milisegundos":
                                respuesta = cantidad * 10 * 365d * 86400 * 1000;  // Décadas a Milisegundos
                                break;
                            case "Segundos":
                                respuesta = cantidad * 10 * 365d * 86400;  // Décadas a Segundos
                                break;
                            case "Minutos":
                                respuesta = cantidad * 10 * 365d * 1440;  // Décadas a Minutos
                                break;
                            case "Horas":
                                respuesta = cantidad * 10 * 365d * 24;  // Décadas a Horas
                                break;
                            case "Días":
                                respuesta = cantidad * 10 * 365d;  // Décadas a Días
                                break;
                            case "Semanas":
                                respuesta = cantidad * (10 * 365d / 7);  // Décadas a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad * 120d;  // Décadas a Meses
                                break;
                            case "Años":
                                respuesta = cantidad * 10d;  // Décadas a Años
                                break;
                            case "Décadas":
                                respuesta = cantidad;  // Décadas a Décadas
                                break;
                            case "Siglos":
                                respuesta = cantidad / 10d;  // Décadas a Siglos
                                break;
                        }
                        break;

                    case "Siglos":
                        switch (unidadDestino)
                        {
                            case "Milisegundos":
                                respuesta = cantidad * 100 * 365d * 86400 * 1000;  // Siglos a Milisegundos
                                break;
                            case "Segundos":
                                respuesta = cantidad * 100 * 365d * 86400;  // Siglos a Segundos
                                break;
                            case "Minutos":
                                respuesta = cantidad * 100 * 365d * 1440;  // Siglos a Minutos
                                break;
                            case "Horas":
                                respuesta = cantidad * 100 * 365d * 24;  // Siglos a Horas
                                break;
                            case "Días":
                                respuesta = cantidad * 100 * 365d;  // Siglos a Días
                                break;
                            case "Semanas":
                                respuesta = cantidad * (100 * 365d / 7);  // Siglos a Semanas
                                break;
                            case "Meses":
                                respuesta = cantidad * 1200d;  // Siglos a Meses
                                break;
                            case "Años":
                                respuesta = cantidad * 100d;  // Siglos a Años
                                break;
                            case "Décadas":
                                respuesta = cantidad * 10d;  // Siglos a Décadas
                                break;
                            case "Siglos":
                                respuesta = cantidad;  // Siglos a Siglos
                                break;
                        }
                        break;
                }
                lblResultado.Text = string.Format("{0:N2} {1} = {2:N15} {3}", cantidad, unidadOrigen, respuesta, unidadDestino);

            }

            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido y seleccione el valor de  Tiempo.");
            }

        }


    
        
           




        private void lblValorAConvertir_Click(object sender, EventArgs e)
        {

        }

        private void txtValorAConvertir_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDe.Items.Clear();
            cmbA.Items.Clear();

            string tipo = cmbTipoConversor.SelectedItem.ToString();

            switch (tipo)
            {
                case "Monedas":
                    cmbDe.Items.AddRange(new string[] { "USD", "EUR", "GBP", "JPY", "MXN", "COP", "ARS", "GTQ", "SAR", "CRC" });
                    cmbA.Items.AddRange(new string[] { "USD", "EUR", "GBP", "JPY", "MXN", "COP", "ARS", "GTQ", "SAR", "CRC" });
                    break;

                case "Masa":
                    cmbDe.Items.AddRange(new string[] { "Gramos", "Kilogramos", "Miligramos", "Libras", "Onzas", "Toneladas", "Stone", "Quintales", "Microgramos", "Nanogramos" });
                    cmbA.Items.AddRange(new string[] { "Gramos", "Kilogramos", "Miligramos", "Libras", "Onzas", "Toneladas", "Stone", "Quintales", "Microgramos", "Nanogramos" });
                    break;

                case "Volumen":
                    cmbDe.Items.AddRange(new string[] { "Litros", "Mililitros", "Centilitros", "Galones", "Pintas", "Cuartos", "Onzas líquidas", "Metros cúbicos", "Centímetros cúbicos", "Barriles" });
                    cmbA.Items.AddRange(new string[] { "Litros", "Mililitros", "Centilitros", "Galones", "Pintas", "Cuartos", "Onzas líquidas", "Metros cúbicos", "Centímetros cúbicos", "Barriles" });
                    break;

                case "Longitud":
                    cmbDe.Items.AddRange(new string[] { "Metros", "Centímetros", "Milímetros", "Kilómetros", "Micrómetros", "Nanómetros", "Pulgadas", "Pies", "Yardas", "Millas" });
                    cmbA.Items.AddRange(new string[] { "Metros", "Centímetros", "Milímetros", "Kilómetros", "Micrómetros", "Nanómetros", "Pulgadas", "Pies", "Yardas", "Millas" });
                    break;

                case "Almacenamiento":
                    cmbDe.Items.AddRange(new string[] { "Bits", "Bytes", "Kilobytes", "Megabytes", "Gigabytes", "Terabytes", "Petabytes", "Exabytes", "Zettabytes", "Yottabytes" });
                    cmbA.Items.AddRange(new string[] { "Bits", "Bytes", "Kilobytes", "Megabytes", "Gigabytes", "Terabytes", "Petabytes", "Exabytes", "Zettabytes", "Yottabytes" });
                    break;

                case "Tiempo":
                    cmbDe.Items.AddRange(new string[] { "Segundos", "Milisegundos", "Minutos", "Horas", "Días", "Semanas", "Meses", "Años", "Décadas", "Siglos" });
                    cmbA.Items.AddRange(new string[] { "Segundos", "Milisegundos", "Minutos", "Horas", "Días", "Semanas", "Meses", "Años", "Décadas", "Siglos" });
                    break;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Borra el valor ingresado
               txtValorAConvertir.Clear();

            // Quita la selección de las monedas
            cmbDe.SelectedIndex = -1;
            cmbA.SelectedIndex = -1;

            // Limpia el resultado
            lblResultado.Text = string.Empty;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int tempIndex = cmbDe.SelectedIndex;
            cmbDe.SelectedIndex = cmbA.SelectedIndex;
            cmbA.SelectedIndex = tempIndex;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
    
}
