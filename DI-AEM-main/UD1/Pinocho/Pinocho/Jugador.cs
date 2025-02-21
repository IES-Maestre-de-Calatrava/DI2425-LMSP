﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinocho
{
    internal class Jugador
    {
        private string _id;
        private string _nombreCompleto;
        private int _vidas;
        private int _saltos;
        private int _peces;
        private int _fila; // Posición en fila del jugador
        private int _columna; // Posición en columna del jugador
        private StringBuilder _posicionesF = new StringBuilder(); // Para guardar las posiciones de las filas
        private StringBuilder _posicionesC = new StringBuilder(); // Para guardar las posiciones de las columnas

        public Jugador(string nombre, string nombreCompleto, int vidasIniciales, int saltos)
        {
            this._id = nombre;
            this._nombreCompleto = nombreCompleto;
            this._vidas = vidasIniciales;
            this._peces = 0;
            this._fila = 0; // Posición inicial (puedes cambiarla según la lógica del juego)
            this._columna = 0; // Posición inicial (puedes cambiarla según la lógica del juego)
            this._saltos = saltos;
            _posicionesF.Append(_fila + " ");
            _posicionesC.Append(_columna+  " ");

        }

        public void AñadirPosicionF()
        {
            _posicionesF.Append(this._fila + " ");
        }

        public void AñadirPosicionC()
        {
            _posicionesC.Append(this._columna + " ");
        }

        public int GetSaltos()
        {
            return _saltos;
        }

        public void SetSaltos(int saltos)
        {
            this._saltos = saltos;
        }

        public string GetId()
        {
            return _id;
        }

        public string GetNombreCompleto()
        {
            return _nombreCompleto;
        }

        public int GetVidas()
        {
            return _vidas;
        }

        public void SetVidas(int vidas)
        {
            this._vidas = vidas;
        }

        public int GetPeces()
        {
            return _peces;
        }

        public void SetPeces(int peces)
        {
            this._peces = peces;
        }

        // Métodos para manejar la posición en el tablero
        public int GetFila()
        {
            return _fila;
        }

        public void SetFila(int fila)
        {
            this._fila = fila;
        }

        public int GetColumna()
        {
            return _columna;
        }

        public void SetColumna(int columna)
        {
            this._columna = columna;
        }

        public StringBuilder GetPosicionesF()
        {
            return _posicionesF;
        }

        public StringBuilder GetPosicionesC()
        {
            return _posicionesC;
        }
    }
}
