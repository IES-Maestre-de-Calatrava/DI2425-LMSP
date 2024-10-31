/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.lmsp.di.ejercicio2;

import java.util.Random;

/**
 *
 * @author LMSP by Lucas Manuel Serrano Perez
 */
public class Ejercicio2 {

    public static void main(String[] args) {
        ListaEnlazada lista = new ListaEnlazada<Producto>();
        int numProductos = generaIntRandom(8,1);
        double precioFinal;
        for (int i = 0; i < numProductos; i++) {
            Producto p = new Producto(generaIntRandom(10,1),generaDblRandom(10,1));
            lista.introducirDato(i,p);
        }
        /*for (int i = 0; i < numProductos; i++) {
            precioFinal+=lista.devolverDato(i).getPrecio();
        }
        */
        
    }
    public static int generaIntRandom(int max, int min){
        Random random = new Random();
        int result = random.nextInt(max) + min;
        return result;
    }
    public static double generaDblRandom(int max, int min){
        Random random = new Random();
        double result = random.nextDouble(max) + min;
        return result;
    }
}
