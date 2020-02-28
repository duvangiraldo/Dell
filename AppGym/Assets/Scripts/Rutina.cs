using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rutina : MonoBehaviour
{
    // Atributos
    private string nombreRutina;
    private GrupoMuscular[] gruposMusculares;

    // Constructor
    public Rutina(string _nombreRutina, GrupoMuscular[] _gruposMusculares)
    {
        this.nombreRutina = _nombreRutina;
        this.gruposMusculares = _gruposMusculares;
    }

    // Accesores
    public string NombreRutina { get => nombreRutina; set => nombreRutina = value; }
    public GrupoMuscular[] GruposMusculares { get => gruposMusculares; set => gruposMusculares = value; }

    // Métodos
    public void AgregarGrupoMuscular()
    {

    }
    public void EliminarGrupoMuscular()
    {

    }
    public void CrearMetasRutina()
    {

    }
    public void EliminarRutina()
    {

    }
}
