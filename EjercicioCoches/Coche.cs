using System;


namespace EjercicioCoches
{   //EJERCICIO 1
    internal class Coche
    {
        private  int _id;
        private string _marca;
        private string _modelo;
        private int _km;
        private double _precio;


        public Coche(int id, string marca, string modelo, int km, double precio)
        {
            this._id = id;
            this._marca = marca;
            this._modelo = modelo;
            this._km = km;
            this._precio = precio;
        }
        /**
         * Getters y Setters, diferentes ALTERNATIVAS
         * **/
        public int getId()
        {
            return _id;
        }
        public void setId(int id) {this._id = id;}

        public string getMarca()
        {
            return _marca;
        }
        public void setMarca(string marca)
        {
            this._marca = marca;
        }
        //public string getModelo { get => _modelo; set => _modelo = value; } FORMA ALTERNATIVA
        public String getModelo()
        {
            return _modelo;
        }
        public void setModelo(String modelo) { this._modelo = modelo; }
        public int getKm() { return _km; }
        public void setKm(int km) {
            this._km = km;
        }
        public double getPrecio()
        { //get => _precio; set => _precio = value; }
            return _precio;
        }
        public void setPrecio(double precio) { this._precio = precio; }

        /**
         * metodo ToString() sobreescrito
         */
        public override String ToString()
        {
            return "Marca: "+getMarca()+", Modelo: "+getModelo()+", KM: "+getKm()+", con un precio de "+getPrecio()+" euros";
        }

    }
}
