using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace miPrimerProyectoCsharp
{
    /// <summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertirMasa()
        { 
        
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
                            case "USD":
                                respuesta = cantidad; // USD a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad * 0.86; // USD a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad * 0.74; // USD a Libra Esterlina
                                break;
                            case "JPY":
                                respuesta = cantidad * 147.73; // USD a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad * 18.80; // USD a Peso Mexicano
                                break;
                            case "COP": 
                                respuesta = cantidad * 4053.41; // USD a Peso Colombiano
                                break;
                            case "ARS":
                                respuesta = cantidad * 1298.50; // USD a Peso Argentino
                                break;
                            case "GTQ":
                                respuesta = cantidad * 7.66; // USD a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad * 3.75; // USD a Riyal Saudí
                                break;
                            case "CRC": 
                                respuesta = cantidad * 504.94; // USD a Colón Costarricense 
                                break;
                        }
                        break;

                    case "EUR":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad / 1.16; // EUR a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad; // EUR a EUR
                                break; 
                            case "GBP": 
                                respuesta = cantidad * 0.86; // EUR a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad * 172.00; // EUR a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad * 21.91;  // EUR a Peso Mexicano
                                break;
                            case "COP": 
                                respuesta = cantidad * 4712.21; // EUR a Peso Colombiano
                                break;
                            case "ARS":
                                respuesta = cantidad * 1512.43; // EUR a Peso Argentino
                                break;
                            case "GTQ":
                                respuesta = cantidad * 8.97; // EUR a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad * 4.37; // EUR a Riyal Saudí
                                break;
                            case "CRC":
                                respuesta = cantidad * 591.40; // EUR a Colón Costarricense
                                break;
                        }
                        break;

                    case "GBP":
                        switch (monedaDestino)
                        {
                            case "USD": 
                                respuesta = cantidad / 1.35; // Libra Esterlina a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad / 1.16; // Libra Esterlina a EUR
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
                                respuesta = cantidad / 0.0068; // Yen Japonés a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad / 0.0058; // Yen Japonés a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad / 0.0050; // Yen Japonés a Libra Esterlina
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
                                respuesta = cantidad / 0.053; // Peso Mexicano a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad / 0.046; // Peso Mexicano a EUR
                                break;
                            case "GBP": respuesta = cantidad / 0.039; // Peso Mexicano a Libra Esterlina
                                break;
                            case "JPY":
                                respuesta = cantidad / 7.86; /// Peso Mexicano a Yen Japonés
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
                                respuesta = cantidad / 0.00025;  // Peso Colombiano a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad / 0.00021; // Peso Colombiano a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad / 0.00018; // Peso Colombiano a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad / 0.037; // Peso Colombiano a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad / 0.0046; // Peso Colombiano a Peso Mexicano
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
                                respuesta = cantidad / 0.00077; // Peso Argentino a USD
                                break;
                            case "EUR":
                                respuesta = cantidad / 0.00066;  // Peso Argentino a EUR
                                break;
                            case "GBP":
                                respuesta = cantidad / 0.00057; // Peso Argentino a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad / 0.11; // Peso Argentino a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad / 0.014; // Peso Argentino a Peso Mexicano
                                break;
                            case "COP": 
                                respuesta = cantidad / 3.07; // Peso Argentino a Peso Colombiano
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
                                respuesta = cantidad / 0.13; // Quetzal Guatemalteco a USD
                                break;
                            case "EUR":
                                respuesta = cantidad / 0.11; // Quetzal Guatemalteco a EUR
                                break;
                            case "GBP":
                                respuesta = cantidad / 0.096;  // Quetzal Guatemalteco a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad / 19.25; // Quetzal Guatemalteco a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad / 2.45;  // Quetzal Guatemalteco a Peso Mexicano
                                break;
                            case "COP":
                                respuesta = cantidad / 528.23; // Quetzal Guatemalteco a Peso Colombiano
                                break;
                            case "ARS": 
                                respuesta = cantidad / 169.31; // Quetzal Guatemalteco a Peso Argentino
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
                                respuesta = cantidad / 0.27; // Riyal Saudí a USD
                                break;
                            case "EUR": 
                                respuesta = cantidad / 0.23; // Riyal Saudí a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad / 0.20; // Riyal Saudí a Libra Esterlina
                                break;
                            case "JPY": 
                                respuesta = cantidad / 39.34; // Riyal Saudí a Yen Japonés
                                break;
                            case "MXN":
                                respuesta = cantidad / 5.01; // Riyal Saudí a Peso Mexicano
                                break;
                            case "COP": 
                                respuesta = cantidad / 1079.62;  // Riyal Saudí a Peso Colombiano
                                break;
                            case "ARS": 
                                respuesta = cantidad / 346.05;  // Riyal Saudí a Peso Argentino
                                break;
                            case "GTQ": respuesta = cantidad / 2.04; 
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
                                respuesta = cantidad / 0.0020; // Colón Costarricense a USD
                                break;
                            case "EUR":
                                respuesta = cantidad / 0.0017;  // Colón Costarricense a EUR
                                break;
                            case "GBP": 
                                respuesta = cantidad / 0.0015;  // Colón Costarricense a Libra Esterlina
                                break;
                            case "JPY":
                                respuesta = cantidad / 0.29; // Colón Costarricense a Yen Japonés
                                break;
                            case "MXN": 
                                respuesta = cantidad / 0.037; // Colón Costarricense a Peso Mexicano
                                break;
                            case "COP": respuesta = cantidad / 8.01; // Colón Costarricense a Peso Colombiano
                                break;
                            case "ARS": 
                                respuesta = cantidad / 2.57;  // Colón Costarricense a Peso Argentino
                                break;
                            case "GTQ": 
                                respuesta = cantidad / 0.015; // Colón Costarricense a Quetzal Guatemalteco
                                break;
                            case "SAR": 
                                respuesta = cantidad / 0.0074; // Colón Costarricense a Riyal Saudí
                                break;
                            case "CRC":
                                respuesta = cantidad; // Colón Costarricense a Colón Costarricense
                                break;
                        }
                        break;
                }

              
                lblResultado.Text = string.Format( "{0:N2} {1} = {2:N2} {3}", cantidad, monedaOrigen, respuesta, monedaDestino);

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
                double gramos = 0;
                double respuesta = 0;

                string unidadOrigen = cmbDe.SelectedItem.ToString();
                string unidadDestino = cmbA.SelectedItem.ToString();

                // Convertir de la unidad de origen a gramos
                switch (unidadOrigen)
                {
                    case "Gramos": 
                        gramos = cantidad;
                        break;
                    case "Kilogramos":
                        gramos = cantidad * 1000;
                        break;
                    case "Miligramos": 
                        gramos = cantidad / 1000;
                        break;
                    case "Libras": 
                        gramos = cantidad * 453.592;
                        break;
                    case "Onzas": 
                        gramos = cantidad * 28.3495; 
                        break;
                    case "Toneladas": 
                        gramos = cantidad * 1_000_000;
                        break;
                    case "Stone": 
                        gramos = cantidad * 6_350.29;
                        break;
                    case "Quintales": gramos = cantidad * 100_000;
                        break;
                    case "Microgramos": gramos = cantidad / 1_000_000;
                        break;
                    case "Nanogramos": gramos = cantidad / 1_000_000_000;
                        break;
                }

                // Convertir de gramos a la unidad de destino
                switch (unidadDestino)
                {
                    case "Gramos": 
                        respuesta = gramos;
                        break;
                    case "Kilogramos": 
                        respuesta = gramos / 1000;
                        break;
                    case "Miligramos":
                        respuesta = gramos * 1000; 
                        break;
                    case "Libras":
                        respuesta = gramos / 453.592; 
                        break;
                    case "Onzas":
                        respuesta = gramos / 28.3495; 
                        break;
                    case "Toneladas":
                        respuesta = gramos / 1_000_000; 
                        break;
                    case "Stone":
                        respuesta = gramos / 6_350.29;
                        break;
                    case "Quintales":
                        respuesta = gramos / 100_000; break;
                    case "Microgramos":
                        respuesta = gramos * 1_000_000; 
                        break;
                    case "Nanogramos":
                        respuesta = gramos * 1_000_000_000;
                        break;
                }

                
                lblResultado.Text = string.Format( "{0:N6} {1} = {2:N6} {3}", cantidad, unidadOrigen, respuesta, unidadDestino);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico válido y seleccione las unidades.");
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
    }
    
}
