﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OutcomesFirst.Data;

namespace OutcomesFirst.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

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

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OutcomesFirst.Models.ArchiveReason", b =>
                {
                    b.Property<int>("ArchiveReasonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArchiveDecisionBy");

                    b.Property<string>("ArchiveReasonName");

                    b.HasKey("ArchiveReasonId");

                    b.ToTable("ArchiveReason");
                });

            modelBuilder.Entity("OutcomesFirst.Models.ArchiveReferral", b =>
                {
                    b.Property<int>("ArchiveReferralId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArchiveReferralAge");

                    b.Property<int?>("ArchiveReferralArchiveReasonId");

                    b.Property<string>("ArchiveReferralComments");

                    b.Property<int>("ArchiveReferralGenderId");

                    b.Property<int?>("ArchiveReferralLocalAuthorityId");

                    b.Property<string>("ArchiveReferralName");

                    b.Property<string>("ArchiveReferralNotSuitableComments");

                    b.Property<DateTime>("ArchiveReferralReceivedDate");

                    b.Property<int>("ArchiveReferralStatusId");

                    b.Property<bool?>("ArchiveReferralSuitable");

                    b.Property<string>("ArchiveReferralSuitableColor");

                    b.Property<string>("ArchiveReferralSuitableComments");

                    b.Property<int>("ArchiveReferralType");

                    b.Property<int>("OriginalReferralId");

                    b.HasKey("ArchiveReferralId");

                    b.HasIndex("ArchiveReferralArchiveReasonId");

                    b.HasIndex("ArchiveReferralGenderId");

                    b.HasIndex("ArchiveReferralLocalAuthorityId");

                    b.HasIndex("ArchiveReferralStatusId");

                    b.ToTable("ArchiveReferral");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName");

                    b.HasKey("GenderId");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("OutcomesFirst.Models.LeavingReason", b =>
                {
                    b.Property<int>("LeavingReasonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LeavingReasonName");

                    b.HasKey("LeavingReasonId");

                    b.ToTable("LeavingReason");
                });

            modelBuilder.Entity("OutcomesFirst.Models.LocalAuthority", b =>
                {
                    b.Property<int>("LocalAuthorityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocalAuthorityName");

                    b.Property<int?>("LocalAuthorityRegionId");

                    b.HasKey("LocalAuthorityId");

                    b.HasIndex("LocalAuthorityRegionId");

                    b.ToTable("LocalAuthority");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Placement", b =>
                {
                    b.Property<int>("PlacementId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PlacementAgeAtLeaving");

                    b.Property<DateTime>("PlacementDOB");

                    b.Property<DateTime>("PlacementDateStartedWithGroup");

                    b.Property<string>("PlacementFirstName");

                    b.Property<string>("PlacementFramework");

                    b.Property<int>("PlacementGenderId");

                    b.Property<string>("PlacementLastName");

                    b.Property<DateTime?>("PlacementLeaveDate");

                    b.Property<string>("PlacementLeaverType");

                    b.Property<int?>("PlacementLeavingReasonId");

                    b.Property<int?>("PlacementLengthOfStayWithGroup");

                    b.Property<int?>("PlacementLengthOfStayWithPlacement");

                    b.Property<int>("PlacementLocalAuthorityId");

                    b.Property<string>("PlacementNotes");

                    b.Property<DateTime?>("PlacementPlacementStartDate");

                    b.Property<string>("PlacementRefId");

                    b.Property<int>("PlacementServiceId");

                    b.Property<bool?>("PlacementServiceTransition");

                    b.Property<int>("PlacementType");

                    b.Property<int?>("PlacementWeeklyFee");

                    b.HasKey("PlacementId");

                    b.HasIndex("PlacementGenderId");

                    b.HasIndex("PlacementLeavingReasonId");

                    b.HasIndex("PlacementLocalAuthorityId");

                    b.HasIndex("PlacementServiceId");

                    b.ToTable("Placement");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Referral", b =>
                {
                    b.Property<int>("ReferralId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReferralAge");

                    b.Property<int?>("ReferralArchiveReasonId");

                    b.Property<string>("ReferralComments");

                    b.Property<DateTime>("ReferralDOB");

                    b.Property<int>("ReferralGenderId");

                    b.Property<int>("ReferralLocalAuthorityId");

                    b.Property<string>("ReferralName")
                        .IsRequired();

                    b.Property<string>("ReferralNotSuitableComments");

                    b.Property<DateTime?>("ReferralPlacementStartDate");

                    b.Property<DateTime>("ReferralReceivedDate");

                    b.Property<int>("ReferralStatusId");

                    b.Property<bool?>("ReferralSuitable");

                    b.Property<string>("ReferralSuitableColor");

                    b.Property<string>("ReferralSuitableComments");

                    b.Property<int>("ReferralType");

                    b.HasKey("ReferralId");

                    b.HasIndex("ReferralArchiveReasonId");

                    b.HasIndex("ReferralGenderId");

                    b.HasIndex("ReferralLocalAuthorityId");

                    b.HasIndex("ReferralStatusId");

                    b.ToTable("Referral");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionName");

                    b.Property<int>("RegionRegionalManagerId");

                    b.Property<int?>("RegionalManagerId");

                    b.HasKey("RegionId");

                    b.HasIndex("RegionalManagerId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("OutcomesFirst.Models.RegionalManager", b =>
                {
                    b.Property<int>("RegionalManagerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionalManagerName");

                    b.HasKey("RegionalManagerId");

                    b.ToTable("RegionalManager");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceAddress1");

                    b.Property<string>("ServiceAddress2");

                    b.Property<string>("ServiceAddress3");

                    b.Property<string>("ServiceAddress4");

                    b.Property<string>("ServiceContact");

                    b.Property<string>("ServiceContactNumber");

                    b.Property<string>("ServiceName");

                    b.Property<int>("ServicePlaces");

                    b.Property<string>("ServicePostcode");

                    b.Property<int?>("ServiceRegionId");

                    b.HasKey("ServiceId");

                    b.HasIndex("ServiceRegionId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName");

                    b.Property<int>("StatusOffersActivityReportOrder");

                    b.Property<int>("StatusPriority");

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Submission", b =>
                {
                    b.Property<int>("SubmissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("SubmissionPlacementStartDate");

                    b.Property<int>("SubmissionReferralId");

                    b.Property<int>("SubmissionServiceId");

                    b.Property<int?>("SubmissionStatusId");

                    b.HasKey("SubmissionId");

                    b.HasIndex("SubmissionReferralId");

                    b.HasIndex("SubmissionServiceId");

                    b.HasIndex("SubmissionStatusId");

                    b.ToTable("Submission");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OutcomesFirst.Models.ArchiveReferral", b =>
                {
                    b.HasOne("OutcomesFirst.Models.ArchiveReason", "ArchiveReferralArchiveReason")
                        .WithMany()
                        .HasForeignKey("ArchiveReferralArchiveReasonId");

                    b.HasOne("OutcomesFirst.Models.Gender", "ArchiveReferralGender")
                        .WithMany()
                        .HasForeignKey("ArchiveReferralGenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OutcomesFirst.Models.LocalAuthority", "ArchiveReferralLocalAuthority")
                        .WithMany()
                        .HasForeignKey("ArchiveReferralLocalAuthorityId");

                    b.HasOne("OutcomesFirst.Models.Status", "ArchiveReferralStatus")
                        .WithMany()
                        .HasForeignKey("ArchiveReferralStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OutcomesFirst.Models.LocalAuthority", b =>
                {
                    b.HasOne("OutcomesFirst.Models.Region", "LocalAuthorityRegion")
                        .WithMany()
                        .HasForeignKey("LocalAuthorityRegionId");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Placement", b =>
                {
                    b.HasOne("OutcomesFirst.Models.Gender", "PlacementGender")
                        .WithMany()
                        .HasForeignKey("PlacementGenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OutcomesFirst.Models.LeavingReason", "PlacementLeavingReason")
                        .WithMany()
                        .HasForeignKey("PlacementLeavingReasonId");

                    b.HasOne("OutcomesFirst.Models.LocalAuthority", "PlacementLocalAuthority")
                        .WithMany()
                        .HasForeignKey("PlacementLocalAuthorityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OutcomesFirst.Models.Service", "PlacementService")
                        .WithMany()
                        .HasForeignKey("PlacementServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OutcomesFirst.Models.Referral", b =>
                {
                    b.HasOne("OutcomesFirst.Models.ArchiveReason", "ReferralArchiveReason")
                        .WithMany()
                        .HasForeignKey("ReferralArchiveReasonId");

                    b.HasOne("OutcomesFirst.Models.Gender", "ReferralGender")
                        .WithMany()
                        .HasForeignKey("ReferralGenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OutcomesFirst.Models.LocalAuthority", "ReferralLocalAuthority")
                        .WithMany()
                        .HasForeignKey("ReferralLocalAuthorityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OutcomesFirst.Models.Status", "ReferralStatus")
                        .WithMany()
                        .HasForeignKey("ReferralStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OutcomesFirst.Models.Region", b =>
                {
                    b.HasOne("OutcomesFirst.Models.RegionalManager", "RegionalManager")
                        .WithMany()
                        .HasForeignKey("RegionalManagerId");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Service", b =>
                {
                    b.HasOne("OutcomesFirst.Models.Region", "ServiceRegion")
                        .WithMany()
                        .HasForeignKey("ServiceRegionId");
                });

            modelBuilder.Entity("OutcomesFirst.Models.Submission", b =>
                {
                    b.HasOne("OutcomesFirst.Models.Referral", "SubmissionReferral")
                        .WithMany("Submissions")
                        .HasForeignKey("SubmissionReferralId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OutcomesFirst.Models.Service", "SubmissionService")
                        .WithMany()
                        .HasForeignKey("SubmissionServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OutcomesFirst.Models.Status", "SubmissionStatus")
                        .WithMany()
                        .HasForeignKey("SubmissionStatusId");
                });
#pragma warning restore 612, 618
        }
    }
}
