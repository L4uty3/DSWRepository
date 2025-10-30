using Dsw2025Ej8.Data;

namespace Dsw2025Ej8.Domain;

public class CuentaBancaria
{

    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public Estado Estado { get; set; }
    public decimal TasaDeInteres { get; init; }
    public decimal LimiteDeDescubierto { get; init; }
    public string[] Titulares { get; set; }
    public TipoCuenta Tipo{ get; set; }

    public CuentaBancaria(string numero, decimal saldo, string[] titulares, TipoCuenta tipo)
    {
        this.Numero = numero;
        this.Saldo = saldo;
        this.Estado = Estado.Activa;
        this.Titulares = titulares;
    
    }

    public virtual bool Depositar(decimal monto, bool flag = false)
    {
        if ( Estado == Estado.Activa)
        {
            if ((monto <= 0) == false)
            {
                Saldo += monto;
                return flag = true;
            }
            else
            {
                throw new MontoNoValido();
            }
        }
        else
        {
            throw new CuentaNoActiva(Estado);
        }
    }

    public bool Retirar(decimal monto, bool flag = false)
    {
        if (Estado == Estado.Inactiva || Estado == Estado.Suspendida)
        {
            throw new CuentaNoActiva(Estado);

        }
        else if (monto <= 0)
        {
            throw new MontoNoValido();
        }
        else if (monto > Saldo + LimiteDeDescubierto)
        {
            Estado = Estado.Suspendida;
            throw new SaldoInsuficiente();
        }
        else
        {
            Saldo -= monto;

            if (Saldo <= 0)
            {
                Estado = Estado.Suspendida;
                throw new CuentaSuspendida(Numero);
            }
            return flag = true;
        }

            
    }

    public virtual void Transferir(decimal monto, string numeroDestino)
    {
        if (Estado != Estado.Activa)
        {
            throw new CuentaNoActiva(Estado);
        }
        else if (monto <= 0)
        {
            throw new MontoNoValido();
        }
        else if (monto > Saldo + LimiteDeDescubierto)
        {
            Estado = Estado.Suspendida;
            throw new SaldoInsuficiente();
        }
        else
        {
            Saldo -= monto;
            foreach (var cuenta in Persistencia.GetCuentas())
            {
                if (cuenta.Numero == numeroDestino)
                {
                    cuenta.Depositar(monto);
                    return;
                }

            }
            // Aquí se debería agregar la lógica para transferir a la cuenta destino
            // Por simplicidad, no se implementa en este ejemplo.
        }
    }

    public decimal ConsultarSaldo()
    {
        return Saldo;
    }
  
}
