using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GIBDD
{
    public partial class Model1 : DbContext
    {
        public Model1(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Gunsmith> Gunsmith { get; set; }
        public virtual DbSet<Gunsmith_Service_weapon> Gunsmith_Service_weapon { get; set; }
        public virtual DbSet<Inspector> Inspector { get; set; }
        public virtual DbSet<inspector_offender> inspector_offender { get; set; }
        public virtual DbSet<Issuance_car> Issuance_car { get; set; }
        public virtual DbSet<Issuance_weapon> Issuance_weapon { get; set; }
        public virtual DbSet<Mechanic> Mechanic { get; set; }
        public virtual DbSet<Mechanic_Police_Car> Mechanic_Police_Car { get; set; }
        public virtual DbSet<Offender> Offender { get; set; }
        public virtual DbSet<Offender_Offense> Offender_Offense { get; set; }
        public virtual DbSet<Offense> Offense { get; set; }
        public virtual DbSet<Police_Car> Police_Car { get; set; }
        public virtual DbSet<Reception_car> Reception_car { get; set; }
        public virtual DbSet<Reception_weapon> Reception_weapon { get; set; }
        public virtual DbSet<Resolution> Resolution { get; set; }
        public virtual DbSet<Service_weapon> Service_weapon { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Withdrawal_DL> Withdrawal_DL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.vin)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.brand)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.colour)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.region_of_registration)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.car_numbers)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.passport_series)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.passport_number)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.rank)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.Locality)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .Property(e => e.Home_number)
                .IsUnicode(false);

            modelBuilder.Entity<Gunsmith>()
                .HasMany(e => e.Gunsmith_Service_weapon)
                .WithRequired(e => e.Gunsmith)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.passport_series)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.passport_number)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.rank)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.Locality)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.Home_number)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.token_number)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.card_number)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.number_waybill)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .HasMany(e => e.inspector_offender)
                .WithRequired(e => e.Inspector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Issuance_car>()
                .Property(e => e.car_number)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_car>()
                .Property(e => e.number_waybill)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_car>()
                .Property(e => e.fuel_displacement)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_car>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_weapon>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_weapon>()
                .Property(e => e.card_number)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_weapon>()
                .Property(e => e.tipe)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_weapon>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_weapon>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Issuance_weapon>()
                .Property(e => e.quantity_bullets)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.passport_series)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.passport_number)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.rank)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.Locality)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .Property(e => e.Home_number)
                .IsUnicode(false);

            modelBuilder.Entity<Mechanic>()
                .HasMany(e => e.Mechanic_Police_Car)
                .WithRequired(e => e.Mechanic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.passport_series)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.passport_number)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.Locality)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.Home_number)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.driver_license_number)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.osago_policy)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .Property(e => e.TIN)
                .IsUnicode(false);

            modelBuilder.Entity<Offender>()
                .HasMany(e => e.Car)
                .WithRequired(e => e.Offender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offender>()
                .HasMany(e => e.inspector_offender)
                .WithRequired(e => e.Offender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offender>()
                .HasMany(e => e.Offender_Offense)
                .WithRequired(e => e.Offender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offender>()
                .HasMany(e => e.Resolution)
                .WithRequired(e => e.Offender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offender>()
                .HasMany(e => e.Withdrawal_DL)
                .WithRequired(e => e.Offender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offense>()
                .Property(e => e.tipe_of_violation)
                .IsUnicode(false);

            modelBuilder.Entity<Offense>()
                .Property(e => e.series_of_documents)
                .IsUnicode(false);

            modelBuilder.Entity<Offense>()
                .Property(e => e.document_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Offense>()
                .Property(e => e.type_of_intoxication)
                .IsUnicode(false);

            modelBuilder.Entity<Offense>()
                .HasMany(e => e.Offender_Offense)
                .WithRequired(e => e.Offense)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Police_Car>()
                .Property(e => e.car_number)
                .IsUnicode(false);

            modelBuilder.Entity<Police_Car>()
                .Property(e => e.VIN)
                .IsUnicode(false);

            modelBuilder.Entity<Police_Car>()
                .Property(e => e.brand)
                .IsUnicode(false);

            modelBuilder.Entity<Police_Car>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Police_Car>()
                .Property(e => e.colour)
                .IsUnicode(false);

            modelBuilder.Entity<Police_Car>()
                .HasMany(e => e.Issuance_car)
                .WithRequired(e => e.Police_Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Police_Car>()
                .HasMany(e => e.Mechanic_Police_Car)
                .WithRequired(e => e.Police_Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Police_Car>()
                .HasMany(e => e.Reception_car)
                .WithRequired(e => e.Police_Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reception_car>()
                .Property(e => e.car_number)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_car>()
                .Property(e => e.number_waybill)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_car>()
                .Property(e => e.mileage)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_car>()
                .Property(e => e.fuel_consumption)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_car>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_weapon>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_weapon>()
                .Property(e => e.card_number)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_weapon>()
                .Property(e => e.tipe)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_weapon>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_weapon>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Reception_weapon>()
                .Property(e => e.quantity_bullets)
                .IsUnicode(false);

            modelBuilder.Entity<Resolution>()
                .Property(e => e.series_resolution)
                .IsUnicode(false);

            modelBuilder.Entity<Resolution>()
                .Property(e => e.number_of_resolution)
                .IsUnicode(false);

            modelBuilder.Entity<Resolution>()
                .Property(e => e.tocken_number)
                .IsUnicode(false);

            modelBuilder.Entity<Resolution>()
                .Property(e => e.locality)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.tipe)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.weight)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.sighting_range)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.bullet_speed)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.rate_of_fire)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.capacity)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.weapon_length)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.weapon_height)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .Property(e => e.caliber)
                .IsUnicode(false);

            modelBuilder.Entity<Service_weapon>()
                .HasMany(e => e.Gunsmith_Service_weapon)
                .WithRequired(e => e.Service_weapon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service_weapon>()
                .HasMany(e => e.Issuance_weapon)
                .WithRequired(e => e.Service_weapon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service_weapon>()
                .HasMany(e => e.Reception_weapon)
                .WithRequired(e => e.Service_weapon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Withdrawal_DL>()
                .Property(e => e.driver_license_number)
                .IsUnicode(false);
        }
    }
}
