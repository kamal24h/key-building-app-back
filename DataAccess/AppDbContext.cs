using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class AppDbContext : IdentityDbContext
{
    //private readonly IHttpContextAccessor _httpContextAccessor;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {      
    }

    /* Define a DbSet for each entity of the application */
    public DbSet<Building> Buildings { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
        //{
        //    b.Property<string>("Id")
        //        .HasColumnType("nvarchar(450)");

        //    b.Property<string>("ConcurrencyStamp")
        //        .IsConcurrencyToken()
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<string>("Name")
        //        .HasColumnType("nvarchar(256)")
        //        .HasMaxLength(256);

        //    b.Property<string>("NormalizedName")
        //        .HasColumnType("nvarchar(256)")
        //        .HasMaxLength(256);

        //    b.HasKey("Id");           
        //    b.ToTable("AspNetRoles");
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
        //{
        //    b.Property<int>("Id")
        //        .ValueGeneratedOnAdd()
        //        .HasColumnType("int")
        //        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //    b.Property<string>("ClaimType")
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<string>("ClaimValue")
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<string>("RoleId")
        //        .IsRequired()
        //        .HasColumnType("nvarchar(450)");

        //    b.HasKey("Id");

        //    b.HasIndex("RoleId");

        //    b.ToTable("AspNetRoleClaims");
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", static b =>
        //{
        //    b.Property<string>("Id")
        //        .HasColumnType("nvarchar(450)");

        //    b.Property<int>("AccessFailedCount")
        //        .HasColumnType("int");

        //    b.Property<string>("ConcurrencyStamp")
        //        .IsConcurrencyToken()
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<string>("Email")
        //        .HasColumnType("nvarchar(256)")
        //        .HasMaxLength(256);

        //    b.Property<bool>("EmailConfirmed")
        //        .HasColumnType("bit");

        //    b.Property<bool>("LockoutEnabled")
        //        .HasColumnType("bit");

        //    b.Property<DateTimeOffset?>("LockoutEnd")
        //        .HasColumnType("datetimeoffset");

        //    b.Property<string>("NormalizedEmail")
        //        .HasColumnType("nvarchar(256)")
        //        .HasMaxLength(256);

        //    b.Property<string>("NormalizedUserName")
        //        .HasColumnType("nvarchar(256)")
        //        .HasMaxLength(256);

        //    b.Property<string>("PasswordHash")
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<string>("PhoneNumber")
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<bool>("PhoneNumberConfirmed")
        //        .HasColumnType("bit");

        //    b.Property<string>("SecurityStamp")
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<bool>("TwoFactorEnabled")
        //        .HasColumnType("bit");

        //    b.Property<string>("UserName")
        //        .HasColumnType("nvarchar(256)")
        //        .HasMaxLength(256);

        //    b.HasKey("Id");            

        //    b.ToTable("AspNetUsers");
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
        //{
        //    b.Property<int>("Id")
        //        .ValueGeneratedOnAdd()
        //        .HasColumnType("int")
        //        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //    b.Property<string>("ClaimType")
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<string>("ClaimValue")
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<string>("UserId")
        //        .IsRequired()
        //        .HasColumnType("nvarchar(450)");

        //    b.HasKey("Id");

        //    b.HasIndex("UserId");

        //    b.ToTable("AspNetUserClaims");
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
        //{
        //    b.Property<string>("LoginProvider")
        //        .HasColumnType("nvarchar(128)")
        //        .HasMaxLength(128);

        //    b.Property<string>("ProviderKey")
        //        .HasColumnType("nvarchar(128)")
        //        .HasMaxLength(128);

        //    b.Property<string>("ProviderDisplayName")
        //        .HasColumnType("nvarchar(max)");

        //    b.Property<string>("UserId")
        //        .IsRequired()
        //        .HasColumnType("nvarchar(450)");

        //    b.HasKey("LoginProvider", "ProviderKey");

        //    b.HasIndex("UserId");

        //    b.ToTable("AspNetUserLogins");
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
        //{
        //    b.Property<string>("UserId")
        //        .HasColumnType("nvarchar(450)");

        //    b.Property<string>("RoleId")
        //        .HasColumnType("nvarchar(450)");

        //    b.HasKey("UserId", "RoleId");

        //    b.HasIndex("RoleId");

        //    b.ToTable("AspNetUserRoles");
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
        //{
        //    b.Property<string>("UserId")
        //        .HasColumnType("nvarchar(450)");

        //    b.Property<string>("LoginProvider")
        //        .HasColumnType("nvarchar(128)")
        //        .HasMaxLength(128);

        //    b.Property<string>("Name")
        //        .HasColumnType("nvarchar(128)")
        //        .HasMaxLength(128);

        //    b.Property<string>("Value")
        //        .HasColumnType("nvarchar(max)");

        //    b.HasKey("UserId", "LoginProvider", "Name");

        //    b.ToTable("AspNetUserTokens");
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
        //{
        //    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
        //        .WithMany()
        //        .HasForeignKey("RoleId")
        //        .OnDelete(DeleteBehavior.Cascade)
        //        .IsRequired();
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
        //{
        //    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
        //        .WithMany()
        //        .HasForeignKey("UserId")
        //        .OnDelete(DeleteBehavior.Cascade)
        //        .IsRequired();
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
        //{
        //    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
        //        .WithMany()
        //        .HasForeignKey("UserId")
        //        .OnDelete(DeleteBehavior.Cascade)
        //        .IsRequired();
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
        //{
        //    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
        //        .WithMany()
        //        .HasForeignKey("RoleId")
        //        .OnDelete(DeleteBehavior.Cascade)
        //        .IsRequired();

        //    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
        //        .WithMany()
        //        .HasForeignKey("UserId")
        //        .OnDelete(DeleteBehavior.Cascade)
        //        .IsRequired();
        //});

        //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
        //{
        //    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
        //        .WithMany()
        //        .HasForeignKey("UserId")
        //        .OnDelete(DeleteBehavior.Cascade)
        //        .IsRequired();
        //});

        //modelBuilder.Entity<CrmInvoiceDetail>( entity =>
        //{
        //    entity.HasOne(d => d.Invoice)
        //          .WithMany(p => p.InvoiceDetails)
        //          .HasForeignKey(d => d.InvoiceId)
        //          .OnDelete(DeleteBehavior.NoAction)
        //          .IsRequired();
        //});

        //modelBuilder.Entity<CrmPurchaseDetail>(entity =>
        //{
        //    entity.HasOne(d => d.Purchase)
        //          .WithMany(p => p.PurchaseDetails)
        //          .HasForeignKey(d => d.PurchaseId)
        //          .OnDelete(DeleteBehavior.NoAction)
        //          .IsRequired();
        //});

        //modelBuilder.Entity<InvItem>(entity =>
        //{
        //    entity.HasIndex(d => d.Code, "IX_Item_Code")
        //          .IsUnique();               
        //});



        //admin config
        string ADMIN_ID = "4b859c11-79f9-4104-9fe9-276aeaf5f115";
        string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

        //seed admin role
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Name = "SuperAdmin",
            NormalizedName = "SUPERADMIN",
            Id = ROLE_ID,
            ConcurrencyStamp = ROLE_ID
        });

        ////create user
        var appUser = new IdentityUser
        {
            Id = ADMIN_ID,
            Email = "kbastani@gmail.com",
            EmailConfirmed = true,
            //Name = "Kamal",
            //LastName = "Bastani",
            UserName = "kbastani@gmail.com",
            NormalizedUserName = "KBASTANI@GMAIL.COM"
        };

        ////set user password
        PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
        appUser.PasswordHash = ph.HashPassword(appUser, "Operation@123");

        //seed user
        modelBuilder.Entity<IdentityUser>().HasData(appUser);
        ////modelBuilder.Entity<IdentityUser>().HasData(appUser);

        ////set user role to admin
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = ROLE_ID,
            UserId = ADMIN_ID
        });
    }
}
