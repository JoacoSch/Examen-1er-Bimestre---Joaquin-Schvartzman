using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int cantidadDeUnidades;
    public int periodoDeDias;

    int costoCombustible = 130;
    int KmXLitro = 15;
    int KmPorUnidad = 90;
    float litrosTotales;
    float LitrosDescuento = 100;
    float Descuento = .20f;
    float aplicarDescuento = .80f;
    float costoTotalCombustible;
    float costoTotalCombustibleD;
    float KilometrosTotales;
    float montoDescontado;



    void Start()
    {
        if (periodoDeDias < 5 || cantidadDeUnidades < 1)
        {
            Debug.Log("datos incorrectos,compruebe que estas condiciones se cumplan: cantidad de dias >= 5; cantidad de unidades >= 1");
            return;
        }

        KilometrosTotales = cantidadDeUnidades * KmPorUnidad * periodoDeDias;
        litrosTotales = KilometrosTotales / KmXLitro;
        costoTotalCombustible = costoCombustible * litrosTotales;

        Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " dias implicara un gasto de " + costoTotalCombustible + " pesos concepto de combustible");
        if (litrosTotales >= LitrosDescuento)
        {
            costoTotalCombustibleD = costoTotalCombustible * aplicarDescuento;
            montoDescontado = costoTotalCombustible * Descuento;
            Debug.Log("Pero gracias al descuento del 20%, se le descuentan " + montoDescontado + " pesos, teniendo que pagar un precio final de " + costoTotalCombustibleD + " pesos");
        }
    }


    void Update()
    {

    }
}
