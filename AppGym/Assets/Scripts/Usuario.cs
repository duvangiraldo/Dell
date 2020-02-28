using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuario : Persona
{
    // Atributos
    private Rutina[] rutinas;

    // Constructor
    public Usuario(string _nombre,string _nombreusuario,
        string _contrasena,string _correo):
        base(_nombre,_nombreusuario,_contrasena,_correo)
    {       
    }
    // Accesores
    public Rutina[] Rutinas { get => rutinas; set => rutinas = value; }

    // Métodos
    public void RegistrarUsuario()
    {

    }

    public void CrearRutina()
    {

    }
}
