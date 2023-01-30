using IsTakip.Core.Classes;
using IsTakip.Core.Classes.AjandaClasses;
using IsTakip.Core.Classes.DepoClasses;
using IsTakip.Core.Classes.DurusTipClasses;
using IsTakip.Core.Classes.IsClasses;
using IsTakip.Core.Classes.KalinlikClasses;
using IsTakip.Core.Classes.MailParamsClasses;
using IsTakip.Core.Classes.MakineClasses;
using IsTakip.Core.Classes.MalzemeTipClasses;
using IsTakip.Core.Classes.MusteriClasses;
using IsTakip.Core.Classes.MusteriSinifClasses;
using IsTakip.Core.Classes.TedarikciClasses;
using IsTakip.Core.Classes.UretimClasses;
using IsTakip.Core.Classes.UretimSurecClasses;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.Core.Context
{
    public class DataContext : DbContext
    {
        #region Constructor
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        #endregion

        #region Overrides
        //CRUD -> (Create)Insert, (Read)Select, (Update)Update, (Delete)Delete
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            var result = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            return result;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
               "Server=xxx;Database=IsTakipV4;User Id=xx;Password=xxxxxx;");
            }
        }


        #endregion

        #region DbSets
        public DbSet<Ajanda> Ajanda { get; set; }
        public DbSet<Depo> Depo { get; set; }
        public DbSet<DepoEnvanter> DepoEnvanter { get; set; }
        public DbSet<DepoHareket> DepoHareket { get; set; }
        public DbSet<DepoRaf> DepoRaf { get; set; }
        public DbSet<DurusTip> DurusTip { get; set; }
        public DbSet<Is> Is { get; set; }
        public DbSet<IsDosya> IsDosya { get; set; }
        public DbSet<IsMalzeme> IsMalzeme { get; set; }
        public DbSet<IsMalzemeUretimSurec> IsMalzemeUretimSurec { get; set; }
        public DbSet<IsMusteriTemsilcisi> IsMusteriTemsilcisi { get; set; }

        public DbSet<MailParams> MailParams { get; set; }
        public DbSet<MalzemeTip> MalzemeTip { get; set; }

        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<MusteriKisitlama> MusteriKisitlama { get; set; }
        public DbSet<MusteriSinif> MusteriSinif { get; set; }
        public DbSet<Tedarikci> Tedarikci { get; set; }

        public DbSet<Uretim> Uretim { get; set; }
        public DbSet<UretimDosya> UretimDosya { get; set; }
        public DbSet<UretimDurus> UretimDurus { get; set; }
        public DbSet<UretimIsMalzeme> UretimIsMalzeme { get; set; }
        public DbSet<UretimDepoEnvanter> UretimDepoEnvanter { get; set; }

        public DbSet<UretimUretimSurec> UretimUretimSurec { get; set; }
        public DbSet<UretimSurec> UretimSurec { get; set; }
        public DbSet<Kalinlik> Kalinlik { get; set; }
        public DbSet<Makine> Makine { get; set; }
        #endregion

        #region Methods
        private void OnBeforeSaving()
        {
            //ChangeTracker -> SaveChange metodunda taşınan model/modellere ulaşmamızı sağlar.
            var entries = ChangeTracker.Entries();

            foreach (var entry in entries)
            {
                if (entry.Entity is BaseObject trackable)
                {
                    var now = DateTime.Now;

                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            trackable.GuncellemeTarihi = now;
                            trackable.GuncelleyenKullanici = "system";
                            break;

                        case EntityState.Added:
                            trackable.OlusturmaTarihi = now;
                            trackable.OlusturanKullanici = "system";
                            trackable.GuncellemeTarihi = now;
                            trackable.GuncelleyenKullanici = "system";

                            //-> Aşağıdaki iki satır eğer controller dan gödnerilecekse kapatabiliriz.
                            trackable.Aktif = true;
                            trackable.Silindi = false;
                            break;

                        case EntityState.Deleted:
                            trackable.GuncellemeTarihi = now;
                            trackable.GuncelleyenKullanici = "system";
                            trackable.Silindi = true;
                            break;
                    }
                }
            }
        }
        #endregion
    }
}