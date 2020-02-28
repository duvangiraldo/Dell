using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Persona : MonoBehaviour
{
    // Atributos
    private string nombre;
    private string nombreDeUsuario;
    private string contrasena;
    private string correo;

    // Constructor
    public Persona(string _nombre, string _nombreDeUsuario, string _contrasena, string _correo)
    {
        this.nombre = _nombre;
        this.nombreDeUsuario = _nombreDeUsuario;
        this.contrasena = _contrasena;
        this.correo = _correo;
    }

    // Accesores
    public string Nombre { get => nombre; set => nombre = value; }
    public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
    public string Contrasena { get => contrasena; set => contrasena = value; }
    public string Correo { get => correo; set => correo = value; }

    // Métodos
    public void IniciarSesion()
    {

    }
    public void CerrarSesion()
    {

    }
}
