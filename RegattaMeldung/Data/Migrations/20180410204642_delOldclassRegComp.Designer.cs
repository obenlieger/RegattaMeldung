﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RegattaMeldung.Data;
using System;

namespace RegattaMeldung.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180410204642_delOldclassRegComp")]
    partial class delOldclassRegComp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RegattaMeldung.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RegattaMeldung.Models.Boatclass", b =>
                {
                    b.Property<int>("BoatclassId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Seats");

                    b.HasKey("BoatclassId");

                    b.ToTable("Boatclasses");
                });

            modelBuilder.Entity("RegattaMeldung.Models.CampingFee", b =>
                {
                    b.Property<int>("CampingFeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Amount");

                    b.Property<string>("Name");

                    b.HasKey("CampingFeeId");

                    b.ToTable("CampingFees");
                });

            modelBuilder.Entity("RegattaMeldung.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("VNr");

                    b.HasKey("ClubId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("RegattaMeldung.Models.Competition", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoatclassId");

                    b.Property<int>("RaceclassId");

                    b.HasKey("CompetitionId");

                    b.HasIndex("BoatclassId");

                    b.HasIndex("RaceclassId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("RegattaMeldung.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Birthyear");

                    b.Property<int>("ClubId");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.HasKey("MemberId");

                    b.HasIndex("ClubId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("RegattaMeldung.Models.Oldclass", b =>
                {
                    b.Property<int>("OldclassId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FromAge");

                    b.Property<string>("Name");

                    b.Property<int>("ToAge");

                    b.HasKey("OldclassId");

                    b.ToTable("Oldclasses");
                });

            modelBuilder.Entity("RegattaMeldung.Models.Raceclass", b =>
                {
                    b.Property<int>("RaceclassId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Length");

                    b.Property<string>("Name");

                    b.HasKey("RaceclassId");

                    b.ToTable("Raceclasses");
                });

            modelBuilder.Entity("RegattaMeldung.Models.Regatta", b =>
                {
                    b.Property<int>("RegattaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Accomodation");

                    b.Property<string>("Awards");

                    b.Property<string>("Catering");

                    b.Property<int>("ClubId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("FromDate");

                    b.Property<string>("Judge");

                    b.Property<string>("Name");

                    b.Property<string>("ReportAddress");

                    b.Property<string>("ReportFax");

                    b.Property<string>("ReportMail");

                    b.Property<DateTime>("ReportOpening");

                    b.Property<DateTime>("ReportSchedule");

                    b.Property<string>("ReportTel");

                    b.Property<string>("ReportText");

                    b.Property<string>("ScheduleText");

                    b.Property<string>("Security");

                    b.Property<int>("Startslots");

                    b.Property<float>("SubscriberFee");

                    b.Property<DateTime>("ToDate");

                    b.Property<int>("WaterId");

                    b.Property<int>("Waterdepth");

                    b.HasKey("RegattaId");

                    b.HasIndex("ClubId");

                    b.HasIndex("WaterId");

                    b.ToTable("Regattas");
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaCampingFee", b =>
                {
                    b.Property<int>("CampingFeeId");

                    b.Property<int>("RegattaId");

                    b.Property<int?>("CampingFeeId1");

                    b.HasKey("CampingFeeId", "RegattaId");

                    b.HasAlternateKey("CampingFeeId");

                    b.HasIndex("CampingFeeId1");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaCampingFees");
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaClub", b =>
                {
                    b.Property<int>("ClubId");

                    b.Property<int>("RegattaId");

                    b.Property<string>("Guid");

                    b.HasKey("ClubId", "RegattaId");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaClubs");
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaCompetition", b =>
                {
                    b.Property<int>("CompetitionId");

                    b.Property<int>("RegattaId");

                    b.HasKey("CompetitionId", "RegattaId");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaCompetitions");
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaOldclass", b =>
                {
                    b.Property<int>("OldclassId");

                    b.Property<int>("RegattaId");

                    b.HasKey("OldclassId", "RegattaId");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaOldclasses");
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaStartingFee", b =>
                {
                    b.Property<int>("StartingFeeId");

                    b.Property<int>("RegattaId");

                    b.HasKey("StartingFeeId", "RegattaId");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaStartingFees");
                });

            modelBuilder.Entity("RegattaMeldung.Models.ReportedStartboat", b =>
                {
                    b.Property<int>("ReportedStartboatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClubId");

                    b.Property<int?>("CompetitionId");

                    b.Property<string>("Gender");

                    b.Property<int?>("RegattaCompetitionCompetitionId");

                    b.Property<int>("RegattaCompetitionId");

                    b.Property<int?>("RegattaCompetitionRegattaId");

                    b.Property<int>("RegattaId");

                    b.HasKey("ReportedStartboatId");

                    b.HasIndex("ClubId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("RegattaId");

                    b.HasIndex("RegattaCompetitionCompetitionId", "RegattaCompetitionRegattaId");

                    b.ToTable("ReportedStartboats");
                });

            modelBuilder.Entity("RegattaMeldung.Models.ReportedStartboatMember", b =>
                {
                    b.Property<int>("ReportedStartboatId");

                    b.Property<int>("MemberId");

                    b.Property<int>("ReportedStartboatMemberId");

                    b.Property<int>("Seatnumber");

                    b.HasKey("ReportedStartboatId", "MemberId");

                    b.HasAlternateKey("ReportedStartboatMemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("ReportedStartboatMembers");
                });

            modelBuilder.Entity("RegattaMeldung.Models.StartingFee", b =>
                {
                    b.Property<int>("StartingFeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Amount");

                    b.Property<int>("BoatclassId");

                    b.Property<int>("OldclassId");

                    b.HasKey("StartingFeeId");

                    b.HasIndex("BoatclassId");

                    b.HasIndex("OldclassId");

                    b.ToTable("StartingFees");
                });

            modelBuilder.Entity("RegattaMeldung.Models.Water", b =>
                {
                    b.Property<int>("WaterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("WaterId");

                    b.ToTable("Waters");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RegattaMeldung.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RegattaMeldung.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaMeldung.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RegattaMeldung.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaMeldung.Models.Competition", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Boatclass", "Boatclasses")
                        .WithMany("Competitions")
                        .HasForeignKey("BoatclassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaMeldung.Models.Raceclass", "Raceclasses")
                        .WithMany("Competitions")
                        .HasForeignKey("RaceclassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaMeldung.Models.Member", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Club", "Club")
                        .WithMany("Members")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaMeldung.Models.Regatta", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Club", "Club")
                        .WithMany("Regattas")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaMeldung.Models.Water", "Waters")
                        .WithMany()
                        .HasForeignKey("WaterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaCampingFee", b =>
                {
                    b.HasOne("RegattaMeldung.Models.CampingFee", "CampingFee")
                        .WithMany("RegattaCampingFees")
                        .HasForeignKey("CampingFeeId1")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaMeldung.Models.Regatta", "Regatta")
                        .WithMany("RegattaCampingFees")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaClub", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Club", "Club")
                        .WithMany("RegattaClubs")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaMeldung.Models.Regatta", "Regatta")
                        .WithMany("RegattaClubs")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaCompetition", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Competition", "Competitions")
                        .WithMany("RegattaCompetitions")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaMeldung.Models.Regatta", "Regattas")
                        .WithMany("RegattaCompetitions")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaOldclass", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Oldclass", "Oldclasses")
                        .WithMany("RegattaOldclasses")
                        .HasForeignKey("OldclassId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaMeldung.Models.Regatta", "Regattas")
                        .WithMany("RegattaOldclasses")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaMeldung.Models.RegattaStartingFee", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Regatta", "Regattas")
                        .WithMany("RegattaStartingFees")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaMeldung.Models.StartingFee", "StartingFees")
                        .WithMany("RegattaStartingFees")
                        .HasForeignKey("StartingFeeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaMeldung.Models.ReportedStartboat", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Club", "Club")
                        .WithMany("ReportedStartboats")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaMeldung.Models.Competition")
                        .WithMany("ReportedStartboats")
                        .HasForeignKey("CompetitionId");

                    b.HasOne("RegattaMeldung.Models.Regatta", "Regatta")
                        .WithMany("ReportedStartboats")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaMeldung.Models.RegattaCompetition", "RegattaCompetition")
                        .WithMany()
                        .HasForeignKey("RegattaCompetitionCompetitionId", "RegattaCompetitionRegattaId");
                });

            modelBuilder.Entity("RegattaMeldung.Models.ReportedStartboatMember", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Member", "Member")
                        .WithMany("ReportedStartboatMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaMeldung.Models.ReportedStartboat", "ReportedStartboat")
                        .WithMany("ReportedStartboatMembers")
                        .HasForeignKey("ReportedStartboatId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaMeldung.Models.StartingFee", b =>
                {
                    b.HasOne("RegattaMeldung.Models.Boatclass", "Boatclasses")
                        .WithMany()
                        .HasForeignKey("BoatclassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaMeldung.Models.Oldclass", "Oldclasses")
                        .WithMany()
                        .HasForeignKey("OldclassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
