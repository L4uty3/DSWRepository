namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    public TipoCuenta Tipo{ get; }
    public string Numero{get;}
    public decimal Saldo{get;protected set;}
    public Estado Estado{get;set;}
    public decimal TasaDeInteres{ get; init; }
    public decimal LimiteDeDescubierto{get; init;}
    public decimal Comision{get;}
    public string[] Titulares{get;}

    public CuentaBancaria(string numero, decimal saldo, TipoCuenta tipo, string[] titulares)
    {
        Numero = numero;
        Saldo = saldo;
        Tipo = tipo;
        Estado = Estado.Activa;
        Titulares = titulares;
    }

    public abstract void Depositar(decimal monto);
    public abstract void Retirar(decimal monto);   

    public void ValidarCuenta()
    {
        if (Estado != Estado.Activa)
        {
            throw new CuentaNoActiva(Estado.ToString());
        }
    }

    public void AplicarInteres()
    {
        if (Tipo == TipoCuenta.CajaDeAhorro)
        {
            Saldo += Saldo * TasaDeInteres;
        }
    }
}
