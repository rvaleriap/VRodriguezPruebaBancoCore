using Microsoft.EntityFrameworkCore;

namespace BL
{
    public class Banco
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VrodriguezPruebaBancoContext context = new DL.VrodriguezPruebaBancoContext())
                {
                    var query = context.Bancos.FromSqlRaw("BancoGetAll").ToList();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Banco banco = new ML.Banco();
                            banco.IdBanco = obj.IdBanco;
                            banco.Nombre = obj.Nombre;
                            banco.NoEmpleados = obj.NoEmpleados.Value;
                            banco.NoSucursales = obj.NoSucursales.Value;
                            banco.Capital = obj.Capital.Value;
                            banco.NoClientes = obj.NoClientes.Value;

                            banco.pais = new ML.Pais();
                            banco.pais.IdPais = obj.IdPais.Value;
                            banco.pais.Nombre = obj.Nombre;

                            banco.razonSocial = new ML.RazonSocial();
                            banco.razonSocial.IdRazonSocial = obj.IdRazonSocial.Value;
                            banco.razonSocial.Nombre = obj.Nombre;

                            result.Objects.Add(banco);
                            
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public static ML.Result Add(ML.Banco banco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VrodriguezPruebaBancoContext context = new DL.VrodriguezPruebaBancoContext())
                {
                    var query = context.Database.ExecuteSqlRaw($"BancoAdd, '{banco.Nombre}','{banco.NoEmpleados}','{banco.NoSucursales}','{banco.Capital}','{banco.NoClientes}','{banco.pais.IdPais}','{banco.razonSocial.IdRazonSocial}'");
               if(query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public static ML.Result Delete(ML.Banco banco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VrodriguezPruebaBancoContext context = new DL.VrodriguezPruebaBancoContext())
                {
                    var query = context.Database.ExecuteSqlRaw($"BancoDelete, {banco.IdBanco}");
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}