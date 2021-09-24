using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class BasqueteVirtualContext : DbContext
    {
        public BasqueteVirtualContext()
        {
        }

        public BasqueteVirtualContext(DbContextOptions<BasqueteVirtualContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApostasNoJogo> ApostasNoJogos { get; set; }
        public virtual DbSet<HandicapDePontosAlternativo> HandicapDePontosAlternativos { get; set; }
        public virtual DbSet<HandicapEtotai> HandicapEtotais { get; set; }
        public virtual DbSet<JogoTotalImparPar> JogoTotalImparPars { get; set; }
        public virtual DbSet<JogoTotalMaisAlternativa> JogoTotalMaisAlternativas { get; set; }
        public virtual DbSet<MargemDeVitoria5Opco> MargemDeVitoria5Opcoes { get; set; }
        public virtual DbSet<MargemDeVitoria5OpcoesEtotalDePonto> MargemDeVitoria5OpcoesEtotalDePontos { get; set; }
        public virtual DbSet<MargemDeVitoria7Opco> MargemDeVitoria7Opcoes { get; set; }
        public virtual DbSet<MargemDeVitoria7OpcoesEtotalDePonto> MargemDeVitoria7OpcoesEtotalDePontos { get; set; }
        public virtual DbSet<QuartoMaisProdutivo> QuartoMaisProdutivos { get; set; }
        public virtual DbSet<ResultadoDuplo> ResultadoDuplos { get; set; }
        public virtual DbSet<ResultadoEtotal> ResultadoEtotals { get; set; }
        public virtual DbSet<Tempo1ParaGanhar3Opco> Tempo1ParaGanhar3Opcoes { get; set; }
        public virtual DbSet<TimeTotai> TimeTotais { get; set; }
        public virtual DbSet<TotaldoJogoIntervalos10Ponto> TotaldoJogoIntervalos10Pontos { get; set; }
        public virtual DbSet<TotaldoJogoIntervalos5Ponto> TotaldoJogoIntervalos5Pontos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HUI8QNB\\OLSENDEV;Database=BasqueteVirtual;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<ApostasNoJogo>(entity =>
            {
                entity.ToTable("ApostasNoJogo");

                entity.Property(e => e.Handicap)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Odds)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaGanhar)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HandicapDePontosAlternativo>(entity =>
            {
                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Odds)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HandicapEtotai>(entity =>
            {
                entity.ToTable("HandicapETotais");

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Odds)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeMaisDe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeMenosDe)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JogoTotalImparPar>(entity =>
            {
                entity.ToTable("JogoTotalImparPar");

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Impar)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Par)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JogoTotalMaisAlternativa>(entity =>
            {
                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaisDe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MenosDe)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Odds)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MargemDeVitoria5Opco>(entity =>
            {
                entity.Property(e => e.De11Ate15)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De16Ate20)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De1Ate5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De6Ate10)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaisDe21)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MargemDeVitoria5OpcoesEtotalDePonto>(entity =>
            {
                entity.ToTable("MargemDeVitoria5OpcoesETotalDePontos");

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MargemDeVitoria7Opco>(entity =>
            {
                entity.Property(e => e.De10Ate13)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De14Ate16)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De17Ate20)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De1Ate2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De3Ate6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De7Ate9)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaisDe21)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MargemDeVitoria7OpcoesEtotalDePonto>(entity =>
            {
                entity.ToTable("MargemDeVitoria7OpcoesETotalDePontos");

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuartoMaisProdutivo>(entity =>
            {
                entity.ToTable("QuartoMaisProdutivo");

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Quarto1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quarto2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quarto3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quarto4)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResultadoDuplo>(entity =>
            {
                entity.ToTable("ResultadoDuplo");

                entity.Property(e => e.Confronto1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Confronto1Odd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Confronto1_Odd");

                entity.Property(e => e.Confronto2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Confronto2Odd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Confronto2_Odd");

                entity.Property(e => e.Confronto3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Confronto3Odd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Confronto3_Odd");

                entity.Property(e => e.Confronto4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Confronto4Odd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Confronto4_Odd");

                entity.Property(e => e.Confronto5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Confronto5Odd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Confronto5_Odd");

                entity.Property(e => e.Confronto6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Confronto6Odd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Confronto6_Odd");

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResultadoEtotal>(entity =>
            {
                entity.ToTable("ResultadoETotal");

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Odds)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeMaisDe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeMenosDe)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tempo1ParaGanhar3Opco>(entity =>
            {
                entity.Property(e => e.Empate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTime1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTime2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Odds)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeTotai>(entity =>
            {
                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaisDe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MenosDe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Odds)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TotaldoJogoIntervalos10Ponto>(entity =>
            {
                entity.Property(e => e.De180Ate189)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De190Ate199)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De200Ate209)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De210Ate219)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De220Ate229)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De230Ate239)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De240Ate249)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De250Ate259)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaisDe259)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenosDe180)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TotaldoJogoIntervalos5Ponto>(entity =>
            {
                entity.Property(e => e.De180Ate184)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De185Ate189)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De190Ate194)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De195Ate199)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De200Ate204)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De205Ate209)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De210Ate214)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De215Ate219)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De220Ate224)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De225Ate229)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De230Ate234)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De235Ate239)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De240Ate244)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.De245Ate249)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaisDe249)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenosDe180)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
