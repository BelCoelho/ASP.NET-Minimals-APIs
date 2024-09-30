using Microsoft.EntityFrameworkCore;
using MinimalAPI.Dominio.Entidades;

namespace MinimalAPI.Infraestrutura.Db;

public class DbContexto : DbContext
{

    private readonly IConfiguration _configuracaoAppSettings;
    public DbContexto (IConfiguration configuracaoAppSettings)
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }

    public DbSet<Administrador> Administradores { get; set;} = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if(!optionsBuilder.IsConfigured)
        {

            var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();
            //O ponto de interrogação é para caso não tenha nada, volta vazio
            if(!string.IsNullOrEmpty(stringConexao))
            {
                optionsBuilder.UseMySql(
                    stringConexao,
                    ServerVersion.AutoDetect(stringConexao)
                );
            }
        }

        optionsBuilder.UseMySql("string de conexão", ServerVersion.AutoDetect("string de conexão"));
    }
}