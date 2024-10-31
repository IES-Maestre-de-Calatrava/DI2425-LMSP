/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.lmsp.di.ejercicio1;

import java.util.Random;
import com.lmsp.di.ejercicio1.Persona;

/**
 *
 * @author LMSP by Lucas Manuel Serrano Perez
 * @version 1.0
 * Created on 16 sept 2024
 */
public class Ejercicio1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ListaEnlazada cola = new ListaEnlazada<Persona>();
        
        int numPersonas = generaCola();
        
        int recaudacion = 0;
        
        for (int i = 0; i < numPersonas; i++) {
            Persona p = new Persona(generaEdad());
            cola.introducirDato(i,p);
        }
        
        for(int i=0;i<cola.cuantosElementos();i++){
            Persona pCola = (Persona)cola.devolverDato(i);
            int edad = pCola.getEdad();
            if(calculaPrecioEntrada(edad)==1.0){
                recaudacion+=1.0;
            }
            else if(calculaPrecioEntrada(edad)==2.5){
                recaudacion+=2.5;                
            }
            else if(calculaPrecioEntrada(edad)==3.5){
                recaudacion+=3.5;  
            }
            cola.borraPosicion(i);
            
        }
        System.out.println(recaudacion);
        
       
   
    }
    public static int generaEdad(){
        Random random = new Random();
        int edad = random.nextInt(56) + 5;
        return edad;
    }
    public static int generaCola(){
        Random random = new Random();
        int personas = random.nextInt(50) + 0;
        return personas;
    }
    public static double calculaPrecioEntrada(int edad){
        if(edad>=5 && edad <=10){
            return 1.0;
        }
        else if (edad>=11 && edad <=17){
            return 2.5;
        }
        else if(edad>=18){
            return 3.5;
        }
        else{
            return 0;
        }
     }
    public static void completaCola(){
        
    }
}
