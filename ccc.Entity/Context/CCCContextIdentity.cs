using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ccc.Entity.DataClasses;

namespace ccc.Entity.Context
{
    public partial class CCCContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public void OnModelCreating_Identity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(e =>
            {
                e.ToTable("User", "Auth");

                e.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                e.Property(e => e.LastName)
                    .HasMaxLength(100);

                e.Property(e => e.PasswordResetCode)
                    .HasMaxLength(100);

                e.HasData(
                    new ApplicationUser
                    {
                        Id = 1,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "f605120f-716d-40c3-9dbd-8ff473410823",
                        Email = "gelbaughcm@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "System",
                        LastName = "Administrator",
                        LockoutEnabled = false,
                        NormalizedEmail = "gelbaughcm@gmail.com",
                        NormalizedUserName = "gelbaughcm@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "dfafd561-8cef-40ad-8c7a-339dc67529d0",
                        UserName = "gelbaughcm@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 2,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "f605120f-716d-40c3-9dbd-8ff473410823",
                        Email = "corey@cordanosports.com",
                        EmailConfirmed = false,
                        FirstName = "Corey",
                        LastName = "Gelbaugh",
                        LockoutEnabled = false,
                        NormalizedEmail = "corey@cordanosports.com",
                        NormalizedUserName = "corey@cordanosports.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "dfafd561-8cef-40ad-8c7a-339dc67529d0",
                        UserName = "corey@cordanosports.com"
                    },
                    new ApplicationUser
                    {
                        Id = 3,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jbrent21@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Preston",
                        LastName = "Stackfield",
                        LockoutEnabled = false,
                        NormalizedEmail = "jbrent21@gmail.com",
                        NormalizedUserName = "jbrent21@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jbrent21@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 4,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "es2531@ymail.com",
                        EmailConfirmed = false,
                        FirstName = "Chad",
                        LastName = "Searer",
                        LockoutEnabled = false,
                        NormalizedEmail = "es2531@ymail.com",
                        NormalizedUserName = "es2531@ymail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "es2531@ymail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 5,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "maryzell4@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Timmy",
                        LastName = "Atkinson",
                        LockoutEnabled = false,
                        NormalizedEmail = "maryzell4@gmail.com",
                        NormalizedUserName = "maryzell4@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "maryzell4@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 6,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "andreamariko1k@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "Jordan",
                        LastName = "Stasyszyn",
                        LockoutEnabled = false,
                        NormalizedEmail = "andreamariko1k@yahoo.com",
                        NormalizedUserName = "andreamariko1k@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "andreamariko1k@yahoo.com"
                    },
                    new ApplicationUser
                    {
                        Id = 7,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "skyelee91@icloud.com",
                        EmailConfirmed = false,
                        FirstName = "Ferg",
                        LastName = "Thomas",
                        LockoutEnabled = false,
                        NormalizedEmail = "skyelee91@icloud.com",
                        NormalizedUserName = "skyelee91@icloud.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "skyelee91@icloud.com"
                    },
                    new ApplicationUser
                    {
                        Id = 8,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "janmcmahan@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Maggie",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "janmcmahan@gmail.com",
                        NormalizedUserName = "janmcmahan@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "janmcmahan@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 9,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jeffs99285@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Gumper",
                        LastName = "Stackfield",
                        LockoutEnabled = false,
                        NormalizedEmail = "jeffs99285@gmail.com",
                        NormalizedUserName = "jeffs99285@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jeffs99285@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 10,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "deschenmann@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Delonte",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "deschenmann@gmail.com",
                        NormalizedUserName = "deschenmann@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "deschenmann@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 11,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "ceschenman19@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Latasha",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "ceschenman19@gmail.com",
                        NormalizedUserName = "ceschenman19@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "ceschenman19@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 12,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "kwoy1508@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "Andrew",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "kwoy1508@yahoo.com",
                        NormalizedUserName = "kwoy1508@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "kwoy1508@yahoo.com"
                    },
                    new ApplicationUser
                    {
                        Id = 13,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "kabrent51@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Jamarius",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "kabrent51@gmail.com",
                        NormalizedUserName = "kabrent51@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "kabrent51@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 14,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "er1293@messiah.edu",
                        EmailConfirmed = false,
                        FirstName = "Shawn",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "er1293@messiah.edu",
                        NormalizedUserName = "er1293@messiah.edu",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "er1293@messiah.edu"
                    },
                    new ApplicationUser
                    {
                        Id = 15,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "mw681275@sju.edu",
                        EmailConfirmed = false,
                        FirstName = "Dave",
                        LastName = "H",
                        LockoutEnabled = false,
                        NormalizedEmail = "mw681275@sju.edu",
                        NormalizedUserName = "mw681275@sju.edu",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "mw681275@sju.edu"
                    },
                    new ApplicationUser
                    {
                        Id = 16,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "lydiaphelan1@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Renee",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "lydiaphelan1@gmail.com",
                        NormalizedUserName = "lydiaphelan1@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "lydiaphelan1@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 17,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "kylie.mcmahan@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Kelsey",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "kylie.mcmahan@gmail.com",
                        NormalizedUserName = "kylie.mcmahan@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "kylie.mcmahan@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 18,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "keirakapner03@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Andy",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "keirakapner03@gmail.com",
                        NormalizedUserName = "keirakapner03@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "keirakapner03@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 19,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "rkbrent1111@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Dave",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "rkbrent1111@gmail.com",
                        NormalizedUserName = "rkbrent1111@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "rkbrent1111@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 20,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "t_bear25@icloud.com",
                        EmailConfirmed = false,
                        FirstName = "Walt",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "t_bear25@icloud.com",
                        NormalizedUserName = "t_bear25@icloud.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "t_bear25@icloud.com"
                    },
                    new ApplicationUser
                    {
                        Id = 21,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "nkroof@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "Matt",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "nkroof@yahoo.com",
                        NormalizedUserName = "nkroof@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "nkroof@yahoo.com"
                    },
                    new ApplicationUser
                    {
                        Id = 22,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "felecia.williamson@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Asamara",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "felecia.williamson@gmail.com",
                        NormalizedUserName = "felecia.williamson@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "felecia.williamson@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 23,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "mxr8@pct.edu",
                        EmailConfirmed = false,
                        FirstName = "Zion",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "mxr8@pct.edu",
                        NormalizedUserName = "mxr8@pct.edu",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "mxr8@pct.edu"
                    },
                    new ApplicationUser
                    {
                        Id = 24,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "cnkford18@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "Doug",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "cnkford18@yahoo.com",
                        NormalizedUserName = "cnkford18@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "cnkford18@yahoo.com"
                    },
                    new ApplicationUser
                    {
                        Id = 25,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "taberangela@me.com",
                        EmailConfirmed = false,
                        FirstName = "Ray",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "taberangela@me.com",
                        NormalizedUserName = "taberangela@me.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "taberangela@me.com"
                    },
                    new ApplicationUser
                    {
                        Id = 26,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "cgcostalas@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "Gary",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "cgcostalas@gmail.com",
                        NormalizedUserName = "cgcostalas@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "cgcostalas@gmail.com"
                    },
                    new ApplicationUser
                    {
                        Id = 27,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "A.McGowan88@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "A.McGowan88@yahoo.com",
                        NormalizedUserName = "A.McGowan88@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "A.McGowan88@yahoo.com",
                        PhoneNumber = "7177047642"
                    },
                    new ApplicationUser
                    {
                        Id = 28,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "akendall2005@aol.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "akendall2005@aol.com",
                        NormalizedUserName = "akendall2005@aol.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "akendall2005@aol.com",
                        PhoneNumber = "7179619884"
                    },
                    new ApplicationUser
                    {
                        Id = 29,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "aktpete@aol.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "aktpete@aol.com",
                        NormalizedUserName = "aktpete@aol.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "aktpete@aol.com",
                        PhoneNumber = "7177585364"
                    },
                    new ApplicationUser
                    {
                        Id = 30,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "alan.seretti@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "alan.seretti@gmail.com",
                        NormalizedUserName = "alan.seretti@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "alan.seretti@gmail.com",
                        PhoneNumber = "4128481996"
                    },
                    new ApplicationUser
                    {
                        Id = 31,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "alesyed20@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "alesyed20@yahoo.com",
                        NormalizedUserName = "alesyed20@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "alesyed20@yahoo.com",
                        PhoneNumber = "7176095354"
                    },
                    new ApplicationUser
                    {
                        Id = 32,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "alohaparigi@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "alohaparigi@comcast.net",
                        NormalizedUserName = "alohaparigi@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "alohaparigi@comcast.net",
                        PhoneNumber = "7178052472"
                    },
                    new ApplicationUser
                    {
                        Id = 33,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "alyshiaewell@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "alyshiaewell@yahoo.com",
                        NormalizedUserName = "alyshiaewell@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "alyshiaewell@yahoo.com",
                        PhoneNumber = "7179617524"
                    },
                    new ApplicationUser
                    {
                        Id = 34,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "Amarshall541to80@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "Amarshall541to80@gmail.com",
                        NormalizedUserName = "Amarshall541to80@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "Amarshall541to80@gmail.com",
                        PhoneNumber = "7177131299"
                    },
                    new ApplicationUser
                    {
                        Id = 35,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "anelasaric78@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "anelasaric78@yahoo.com",
                        NormalizedUserName = "anelasaric78@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "anelasaric78@yahoo.com",
                        PhoneNumber = "7177136275"
                    },
                    new ApplicationUser
                    {
                        Id = 36,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "anget33@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "anget33@gmail.com",
                        NormalizedUserName = "anget33@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "anget33@gmail.com",
                        PhoneNumber = "7179622531"
                    },
                    new ApplicationUser
                    {
                        Id = 37,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "awaans@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "awaans@yahoo.com",
                        NormalizedUserName = "awaans@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "awaans@yahoo.com",
                        PhoneNumber = "7174977579"
                    },
                    new ApplicationUser
                    {
                        Id = 38,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "ayeyonce@icloud.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "ayeyonce@icloud.com",
                        NormalizedUserName = "ayeyonce@icloud.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "ayeyonce@icloud.com",
                        PhoneNumber = "7173864887"
                    },
                    new ApplicationUser
                    {
                        Id = 39,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "balleri20@aol.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "balleri20@aol.com",
                        NormalizedUserName = "balleri20@aol.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "balleri20@aol.com",
                        PhoneNumber = "7177016358"
                    },
                    new ApplicationUser
                    {
                        Id = 40,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "bcaugust@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "bcaugust@comcast.net",
                        NormalizedUserName = "bcaugust@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "bcaugust@comcast.net",
                        PhoneNumber = "7172268276"
                    },
                    new ApplicationUser
                    {
                        Id = 41,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "bcoon723@aol.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "bcoon723@aol.com",
                        NormalizedUserName = "bcoon723@aol.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "bcoon723@aol.com",
                        PhoneNumber = "7175127425"
                    },
                    new ApplicationUser
                    {
                        Id = 42,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "bete924@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "bete924@gmail.com",
                        NormalizedUserName = "bete924@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "bete924@gmail.com",
                        PhoneNumber = "7173861398"
                    },
                    new ApplicationUser
                    {
                        Id = 43,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "bevshug@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "bevshug@gmail.com",
                        NormalizedUserName = "bevshug@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "bevshug@gmail.com",
                        PhoneNumber = "7172260438"
                    },
                    new ApplicationUser
                    {
                        Id = 44,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "bls2u2002@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "bls2u2002@yahoo.com",
                        NormalizedUserName = "bls2u2002@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "bls2u2002@yahoo.com",
                        PhoneNumber = "7177980804"
                    },
                    new ApplicationUser
                    {
                        Id = 45,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "blue-dragonfly@hotmail.de",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "blue-dragonfly@hotmail.de",
                        NormalizedUserName = "blue-dragonfly@hotmail.de",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "blue-dragonfly@hotmail.de",
                        PhoneNumber = "7174624604"
                    },
                    new ApplicationUser
                    {
                        Id = 46,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "boegelm@dickinson.edu",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "boegelm@dickinson.edu",
                        NormalizedUserName = "boegelm@dickinson.edu",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "boegelm@dickinson.edu",
                        PhoneNumber = "7177130560"
                    },
                    new ApplicationUser
                    {
                        Id = 47,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "calejandro84@aol.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "calejandro84@aol.com",
                        NormalizedUserName = "calejandro84@aol.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "calejandro84@aol.com",
                        PhoneNumber = "7173864409"
                    },
                    new ApplicationUser
                    {
                        Id = 48,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "campbellj@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "campbellj@comcast.net",
                        NormalizedUserName = "campbellj@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "campbellj@comcast.net",
                        PhoneNumber = "7172588849"
                    },
                    new ApplicationUser
                    {
                        Id = 49,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "ccaajj83@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "ccaajj83@yahoo.com",
                        NormalizedUserName = "ccaajj83@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "ccaajj83@yahoo.com",
                        PhoneNumber = "2232128188"
                    },
                    new ApplicationUser
                    {
                        Id = 50,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "ccarlot1239@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "ccarlot1239@gmail.com",
                        NormalizedUserName = "ccarlot1239@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "ccarlot1239@gmail.com",
                        PhoneNumber = "2016408647"
                    },
                    new ApplicationUser
                    {
                        Id = 51,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "chrissy187230@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "chrissy187230@gmail.com",
                        NormalizedUserName = "chrissy187230@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "chrissy187230@gmail.com",
                        PhoneNumber = "7176731183"
                    },
                    new ApplicationUser
                    {
                        Id = 52,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "cmkimm@ship.edu",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "cmkimm@ship.edu",
                        NormalizedUserName = "cmkimm@ship.edu",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "cmkimm@ship.edu",
                        PhoneNumber = ""
                    },
                    new ApplicationUser
                    {
                        Id = 53,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "coreybowman21@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "coreybowman21@gmail.com",
                        NormalizedUserName = "coreybowman21@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "coreybowman21@gmail.com",
                        PhoneNumber = "7174214435"
                    },
                    new ApplicationUser
                    {
                        Id = 54,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "corrineboyer4@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "corrineboyer4@gmail.com",
                        NormalizedUserName = "corrineboyer4@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "corrineboyer4@gmail.com",
                        PhoneNumber = ""
                    },
                    new ApplicationUser
                    {
                        Id = 55,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "cway2k@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "cway2k@yahoo.com",
                        NormalizedUserName = "cway2k@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "cway2k@yahoo.com",
                        PhoneNumber = "7174218654"
                    },
                    new ApplicationUser
                    {
                        Id = 56,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "cwilsoniii1974@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "cwilsoniii1974@gmail.com",
                        NormalizedUserName = "cwilsoniii1974@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "cwilsoniii1974@gmail.com",
                        PhoneNumber = "9105547083"
                    },
                    new ApplicationUser
                    {
                        Id = 57,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "Daniellethomas442@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "Daniellethomas442@yahoo.com",
                        NormalizedUserName = "Daniellethomas442@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "Daniellethomas442@yahoo.com",
                        PhoneNumber = "7173864856"
                    },
                    new ApplicationUser
                    {
                        Id = 58,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "Datdude242003@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "Datdude242003@yahoo.com",
                        NormalizedUserName = "Datdude242003@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "Datdude242003@yahoo.com",
                        PhoneNumber = "7177061444"
                    },
                    new ApplicationUser
                    {
                        Id = 59,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "dathomas2130@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "dathomas2130@gmail.com",
                        NormalizedUserName = "dathomas2130@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "dathomas2130@gmail.com",
                        PhoneNumber = "7177609858"
                    },
                    new ApplicationUser
                    {
                        Id = 60,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "david.baldwin@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "david.baldwin@comcast.net",
                        NormalizedUserName = "david.baldwin@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "david.baldwin@comcast.net",
                        PhoneNumber = "7179600470"
                    },
                    new ApplicationUser
                    {
                        Id = 61,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "davis10108@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "davis10108@yahoo.com",
                        NormalizedUserName = "davis10108@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "davis10108@yahoo.com",
                        PhoneNumber = "7173857268"
                    },
                    new ApplicationUser
                    {
                        Id = 62,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "dawngrimes13@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "dawngrimes13@yahoo.com",
                        NormalizedUserName = "dawngrimes13@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "dawngrimes13@yahoo.com",
                        PhoneNumber = "7175743266"
                    },
                    new ApplicationUser
                    {
                        Id = 63,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "deanenegley@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "deanenegley@gmail.com",
                        NormalizedUserName = "deanenegley@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "deanenegley@gmail.com",
                        PhoneNumber = "7173851526"
                    },
                    new ApplicationUser
                    {
                        Id = 64,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "devink1973@icloud.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "devink1973@icloud.com",
                        NormalizedUserName = "devink1973@icloud.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "devink1973@icloud.com",
                        PhoneNumber = "7174488214"
                    },
                    new ApplicationUser
                    {
                        Id = 65,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "dkeeler@ritnersteel.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "dkeeler@ritnersteel.com",
                        NormalizedUserName = "dkeeler@ritnersteel.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "dkeeler@ritnersteel.com",
                        PhoneNumber = "7174488214"
                    },
                    new ApplicationUser
                    {
                        Id = 66,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "dkj717@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "dkj717@gmail.com",
                        NormalizedUserName = "dkj717@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "dkj717@gmail.com",
                        PhoneNumber = "7174222907"
                    },
                    new ApplicationUser
                    {
                        Id = 67,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "Dmjones1981@hotmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "Dmjones1981@hotmail.com",
                        NormalizedUserName = "Dmjones1981@hotmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "Dmjones1981@hotmail.com",
                        PhoneNumber = "7178567917"
                    },
                    new ApplicationUser
                    {
                        Id = 68,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "dobynsh@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "dobynsh@gmail.com",
                        NormalizedUserName = "dobynsh@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "dobynsh@gmail.com",
                        PhoneNumber = "7174621906"
                    },
                    new ApplicationUser
                    {
                        Id = 69,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "drthomas94@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "drthomas94@gmail.com",
                        NormalizedUserName = "drthomas94@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "drthomas94@gmail.com",
                        PhoneNumber = "7172264635"
                    },
                    new ApplicationUser
                    {
                        Id = 70,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "dustinheberlig@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "dustinheberlig@yahoo.com",
                        NormalizedUserName = "dustinheberlig@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "dustinheberlig@yahoo.com",
                        PhoneNumber = "7172265613"
                    },
                    new ApplicationUser
                    {
                        Id = 71,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "eiland454@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "eiland454@gmail.com",
                        NormalizedUserName = "eiland454@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "eiland454@gmail.com",
                        PhoneNumber = "7173854494"
                    },
                    new ApplicationUser
                    {
                        Id = 72,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "emilycfenner@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "emilycfenner@gmail.com",
                        NormalizedUserName = "emilycfenner@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "emilycfenner@gmail.com",
                        PhoneNumber = "4434722746"
                    },
                    new ApplicationUser
                    {
                        Id = 73,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "emilyduke2000@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "emilyduke2000@yahoo.com",
                        NormalizedUserName = "emilyduke2000@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "emilyduke2000@yahoo.com",
                        PhoneNumber = "7174483126"
                    },
                    new ApplicationUser
                    {
                        Id = 74,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "erical10028@aol.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "erical10028@aol.com",
                        NormalizedUserName = "erical10028@aol.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "erical10028@aol.com",
                        PhoneNumber = "7175035080"
                    },
                    new ApplicationUser
                    {
                        Id = 75,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "fischert@dickinson.edu",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "fischert@dickinson.edu",
                        NormalizedUserName = "fischert@dickinson.edu",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "fischert@dickinson.edu",
                        PhoneNumber = "7176097801"
                    },
                    new ApplicationUser
                    {
                        Id = 76,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "getamysmith@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "getamysmith@gmail.com",
                        NormalizedUserName = "getamysmith@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "getamysmith@gmail.com",
                        PhoneNumber = "7175769400"
                    },
                    new ApplicationUser
                    {
                        Id = 77,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "handyc316@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "handyc316@gmail.com",
                        NormalizedUserName = "handyc316@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "handyc316@gmail.com",
                        PhoneNumber = ""
                    },
                    new ApplicationUser
                    {
                        Id = 78,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "Hshararz@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "Hshararz@gmail.com",
                        NormalizedUserName = "Hshararz@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "Hshararz@gmail.com",
                        PhoneNumber = "7174221129"
                    },
                    new ApplicationUser
                    {
                        Id = 79,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "hulaulani@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "hulaulani@gmail.com",
                        NormalizedUserName = "hulaulani@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "hulaulani@gmail.com",
                        PhoneNumber = "7173867057"
                    },
                    new ApplicationUser
                    {
                        Id = 80,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "inmanjaleesa@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "inmanjaleesa@gmail.com",
                        NormalizedUserName = "inmanjaleesa@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "inmanjaleesa@gmail.com",
                        PhoneNumber = "7174629397"
                    },
                    new ApplicationUser
                    {
                        Id = 81,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jacksonwalter32@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "jacksonwalter32@gmail.com",
                        NormalizedUserName = "jacksonwalter32@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jacksonwalter32@gmail.com",
                        PhoneNumber = "7173866524"
                    },
                    new ApplicationUser
                    {
                        Id = 82,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jamiebartoli@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "jamiebartoli@comcast.net",
                        NormalizedUserName = "jamiebartoli@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jamiebartoli@comcast.net",
                        PhoneNumber = "7174330619"
                    },
                    new ApplicationUser
                    {
                        Id = 83,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jamifelton83@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "jamifelton83@gmail.com",
                        NormalizedUserName = "jamifelton83@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jamifelton83@gmail.com",
                        PhoneNumber = "7174628290"
                    },
                    new ApplicationUser
                    {
                        Id = 84,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jaygirl515@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "jaygirl515@yahoo.com",
                        NormalizedUserName = "jaygirl515@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jaygirl515@yahoo.com",
                        PhoneNumber = "2547024961"
                    },
                    new ApplicationUser
                    {
                        Id = 85,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jennifer69637@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "jennifer69637@yahoo.com",
                        NormalizedUserName = "jennifer69637@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jennifer69637@yahoo.com",
                        PhoneNumber = "7179625119"
                    },
                    new ApplicationUser
                    {
                        Id = 86,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jkosco@aol.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "jkosco@aol.com",
                        NormalizedUserName = "jkosco@aol.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jkosco@aol.com",
                        PhoneNumber = "4159391024"
                    },
                    new ApplicationUser
                    {
                        Id = 87,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jkuntz2312@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "jkuntz2312@yahoo.com",
                        NormalizedUserName = "jkuntz2312@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jkuntz2312@yahoo.com",
                        PhoneNumber = "7179619214"
                    },
                    new ApplicationUser
                    {
                        Id = 88,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "johnsonkim5845@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "johnsonkim5845@yahoo.com",
                        NormalizedUserName = "johnsonkim5845@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "johnsonkim5845@yahoo.com",
                        PhoneNumber = "7174432868"
                    },
                    new ApplicationUser
                    {
                        Id = 89,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "josephrosado2155@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "josephrosado2155@gmail.com",
                        NormalizedUserName = "josephrosado2155@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "josephrosado2155@gmail.com",
                        PhoneNumber = "2675040429"
                    },
                    new ApplicationUser
                    {
                        Id = 90,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "jrae001@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "jrae001@yahoo.com",
                        NormalizedUserName = "jrae001@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "jrae001@yahoo.com",
                        PhoneNumber = "7172260115"
                    },
                    new ApplicationUser
                    {
                        Id = 91,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "Juliepanko@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "Juliepanko@gmail.com",
                        NormalizedUserName = "Juliepanko@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "Juliepanko@gmail.com",
                        PhoneNumber = "7173855832"
                    },
                    new ApplicationUser
                    {
                        Id = 92,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "justus08jt@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "justus08jt@gmail.com",
                        NormalizedUserName = "justus08jt@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "justus08jt@gmail.com",
                        PhoneNumber = "2232128188"
                    },
                    new ApplicationUser
                    {
                        Id = 93,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "kerryannlane@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "kerryannlane@yahoo.com",
                        NormalizedUserName = "kerryannlane@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "kerryannlane@yahoo.com",
                        PhoneNumber = "7179799503"
                    },
                    new ApplicationUser
                    {
                        Id = 94,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "klatrellc@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "klatrellc@gmail.com",
                        NormalizedUserName = "klatrellc@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "klatrellc@gmail.com",
                        PhoneNumber = "7174226934"
                    },
                    new ApplicationUser
                    {
                        Id = 95,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "klingkling2k3@hotmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "klingkling2k3@hotmail.com",
                        NormalizedUserName = "klingkling2k3@hotmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "klingkling2k3@hotmail.com",
                        PhoneNumber = "7172756508"
                    },
                    new ApplicationUser
                    {
                        Id = 96,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "koss@dickinson.edu",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "koss@dickinson.edu",
                        NormalizedUserName = "koss@dickinson.edu",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "koss@dickinson.edu",
                        PhoneNumber = "7174976832"
                    },
                    new ApplicationUser
                    {
                        Id = 97,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "krh5690@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "krh5690@yahoo.com",
                        NormalizedUserName = "krh5690@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "krh5690@yahoo.com",
                        PhoneNumber = "7176018134"
                    },
                    new ApplicationUser
                    {
                        Id = 98,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "larc2411@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "larc2411@gmail.com",
                        NormalizedUserName = "larc2411@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "larc2411@gmail.com",
                        PhoneNumber = "7177064166"
                    },
                    new ApplicationUser
                    {
                        Id = 99,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "lbrown28511@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "lbrown28511@yahoo.com",
                        NormalizedUserName = "lbrown28511@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "lbrown28511@yahoo.com",
                        PhoneNumber = "7173860154"
                    },
                    new ApplicationUser
                    {
                        Id = 100,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "lee101686@hotmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "lee101686@hotmail.com",
                        NormalizedUserName = "lee101686@hotmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "lee101686@hotmail.com",
                        PhoneNumber = "7173864110"
                    },
                    new ApplicationUser
                    {
                        Id = 101,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "leesavitek@hotmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "leesavitek@hotmail.com",
                        NormalizedUserName = "leesavitek@hotmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "leesavitek@hotmail.com",
                        PhoneNumber = "4123989746"
                    },
                    new ApplicationUser
                    {
                        Id = 102,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "lizawon1234@icloud.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "lizawon1234@icloud.com",
                        NormalizedUserName = "lizawon1234@icloud.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "lizawon1234@icloud.com",
                        PhoneNumber = ""
                    },
                    new ApplicationUser
                    {
                        Id = 103,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "lizpensa@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "lizpensa@yahoo.com",
                        NormalizedUserName = "lizpensa@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "lizpensa@yahoo.com",
                        PhoneNumber = "7172564595"
                    },
                    new ApplicationUser
                    {
                        Id = 104,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "LKnight2350@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "LKnight2350@yahoo.com",
                        NormalizedUserName = "LKnight2350@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "LKnight2350@yahoo.com",
                        PhoneNumber = "7173861991"
                    },
                    new ApplicationUser
                    {
                        Id = 105,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "Loveroflife444@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "Loveroflife444@gmail.com",
                        NormalizedUserName = "Loveroflife444@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "Loveroflife444@gmail.com",
                        PhoneNumber = "7176092617"
                    },
                    new ApplicationUser
                    {
                        Id = 106,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "mariadeg14@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "mariadeg14@gmail.com",
                        NormalizedUserName = "mariadeg14@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "mariadeg14@gmail.com",
                        PhoneNumber = "7176361807"
                    },
                    new ApplicationUser
                    {
                        Id = 107,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "matthew_reichard@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "matthew_reichard@yahoo.com",
                        NormalizedUserName = "matthew_reichard@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "matthew_reichard@yahoo.com",
                        PhoneNumber = "7176095764"
                    },
                    new ApplicationUser
                    {
                        Id = 108,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "mcmeekind@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "mcmeekind@yahoo.com",
                        NormalizedUserName = "mcmeekind@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "mcmeekind@yahoo.com",
                        PhoneNumber = "4124017530"
                    },
                    new ApplicationUser
                    {
                        Id = 109,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "meganfelton4@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "meganfelton4@gmail.com",
                        NormalizedUserName = "meganfelton4@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "meganfelton4@gmail.com",
                        PhoneNumber = "7177061154"
                    },
                    new ApplicationUser
                    {
                        Id = 110,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "michael.griffie@ames.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "michael.griffie@ames.com",
                        NormalizedUserName = "michael.griffie@ames.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "michael.griffie@ames.com",
                        PhoneNumber = ""
                    },
                    new ApplicationUser
                    {
                        Id = 111,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "mikalmills78@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "mikalmills78@gmail.com",
                        NormalizedUserName = "mikalmills78@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "mikalmills78@gmail.com",
                        PhoneNumber = "7174403618"
                    },
                    new ApplicationUser
                    {
                        Id = 112,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "monicakipp@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "monicakipp@yahoo.com",
                        NormalizedUserName = "monicakipp@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "monicakipp@yahoo.com",
                        PhoneNumber = "7176453787"
                    },
                    new ApplicationUser
                    {
                        Id = 113,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "motojim@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "motojim@gmail.com",
                        NormalizedUserName = "motojim@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "motojim@gmail.com",
                        PhoneNumber = "9168387691"
                    },
                    new ApplicationUser
                    {
                        Id = 114,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "nancyjgw167@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "nancyjgw167@gmail.com",
                        NormalizedUserName = "nancyjgw167@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "nancyjgw167@gmail.com",
                        PhoneNumber = "7174408315"
                    },
                    new ApplicationUser
                    {
                        Id = 115,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "nicole.dean111@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "nicole.dean111@gmail.com",
                        NormalizedUserName = "nicole.dean111@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "nicole.dean111@gmail.com",
                        PhoneNumber = "7176099614"
                    },
                    new ApplicationUser
                    {
                        Id = 116,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "nicolemulholland172@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "nicolemulholland172@yahoo.com",
                        NormalizedUserName = "nicolemulholland172@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "nicolemulholland172@yahoo.com",
                        PhoneNumber = "7172263496"
                    },
                    new ApplicationUser
                    {
                        Id = 117,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "pstackfield@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "pstackfield@gmail.com",
                        NormalizedUserName = "pstackfield@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "pstackfield@gmail.com",
                        PhoneNumber = "7174484446"
                    },
                    new ApplicationUser
                    {
                        Id = 118,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "queenkinan80@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "queenkinan80@gmail.com",
                        NormalizedUserName = "queenkinan80@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "queenkinan80@gmail.com",
                        PhoneNumber = "7173869138"
                    },
                    new ApplicationUser
                    {
                        Id = 119,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "ranigoldsborough@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "ranigoldsborough@yahoo.com",
                        NormalizedUserName = "ranigoldsborough@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "ranigoldsborough@yahoo.com",
                        PhoneNumber = "7174242543"
                    },
                    new ApplicationUser
                    {
                        Id = 120,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "rogerthat898@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "rogerthat898@comcast.net",
                        NormalizedUserName = "rogerthat898@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "rogerthat898@comcast.net",
                        PhoneNumber = "7174227287"
                    },
                    new ApplicationUser
                    {
                        Id = 121,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "romaveron@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "romaveron@gmail.com",
                        NormalizedUserName = "romaveron@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "romaveron@gmail.com",
                        PhoneNumber = "7176495707"
                    },
                    new ApplicationUser
                    {
                        Id = 122,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "rutz31585@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "rutz31585@gmail.com",
                        NormalizedUserName = "rutz31585@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "rutz31585@gmail.com",
                        PhoneNumber = "7177129390"
                    },
                    new ApplicationUser
                    {
                        Id = 123,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "sanielleoaks@centurylink.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "sanielleoaks@centurylink.net",
                        NormalizedUserName = "sanielleoaks@centurylink.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "sanielleoaks@centurylink.net",
                        PhoneNumber = "7175123328"
                    },
                    new ApplicationUser
                    {
                        Id = 124,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "sarahstan27@hotmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "sarahstan27@hotmail.com",
                        NormalizedUserName = "sarahstan27@hotmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "sarahstan27@hotmail.com",
                        PhoneNumber = "7177137514"
                    },
                    new ApplicationUser
                    {
                        Id = 125,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "shabasil@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "shabasil@comcast.net",
                        NormalizedUserName = "shabasil@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "shabasil@comcast.net",
                        PhoneNumber = "7172412797"
                    },
                    new ApplicationUser
                    {
                        Id = 126,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "shankw@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "shankw@comcast.net",
                        NormalizedUserName = "shankw@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "shankw@comcast.net",
                        PhoneNumber = "7174488830"
                    },
                    new ApplicationUser
                    {
                        Id = 127,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "shumbergerjamie@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "shumbergerjamie@yahoo.com",
                        NormalizedUserName = "shumbergerjamie@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "shumbergerjamie@yahoo.com",
                        PhoneNumber = ""
                    },
                    new ApplicationUser
                    {
                        Id = 128,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "slusser.kyle@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "slusser.kyle@gmail.com",
                        NormalizedUserName = "slusser.kyle@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "slusser.kyle@gmail.com",
                        PhoneNumber = "7174485808"
                    },
                    new ApplicationUser
                    {
                        Id = 129,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "smaxwell68@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "smaxwell68@gmail.com",
                        NormalizedUserName = "smaxwell68@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "smaxwell68@gmail.com",
                        PhoneNumber = "8137895943"
                    },
                    new ApplicationUser
                    {
                        Id = 130,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "tjheizman@hotmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "tjheizman@hotmail.com",
                        NormalizedUserName = "tjheizman@hotmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "tjheizman@hotmail.com",
                        PhoneNumber = "7172151752"
                    },
                    new ApplicationUser
                    {
                        Id = 131,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "toshathorson@comcast.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "toshathorson@comcast.net",
                        NormalizedUserName = "toshathorson@comcast.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "toshathorson@comcast.net",
                        PhoneNumber = "7173866107"
                    },
                    new ApplicationUser
                    {
                        Id = 132,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "tperkins@ccpa.net",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "tperkins@ccpa.net",
                        NormalizedUserName = "tperkins@ccpa.net",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "tperkins@ccpa.net",
                        PhoneNumber = "7173858529"
                    },
                    new ApplicationUser
                    {
                        Id = 133,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "underdog1964@yahoo.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "underdog1964@yahoo.com",
                        NormalizedUserName = "underdog1964@yahoo.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "underdog1964@yahoo.com",
                        PhoneNumber = "9143741784"
                    },
                    new ApplicationUser
                    {
                        Id = 134,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "wpalacade@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "wpalacade@gmail.com",
                        NormalizedUserName = "wpalacade@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "wpalacade@gmail.com",
                        PhoneNumber = "7173854373"
                    },
                    new ApplicationUser
                    {
                        Id = 135,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "wpalmer24@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "wpalmer24@gmail.com",
                        NormalizedUserName = "wpalmer24@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "wpalmer24@gmail.com",
                        PhoneNumber = "7176024695"
                    },
                    new ApplicationUser
                    {
                        Id = 136,
                        AccessFailedCount = 0,
                        ConcurrencyStamp = "b39b7fd6-391c-4d74-ae0c-14a75b78866d",
                        Email = "xander.becket@gmail.com",
                        EmailConfirmed = false,
                        FirstName = "",
                        LastName = "",
                        LockoutEnabled = false,
                        NormalizedEmail = "xander.becket@gmail.com",
                        NormalizedUserName = "xander.becket@gmail.com",
                        PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                        SecurityStamp = "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB",
                        UserName = "xander.becket@gmail.com",
                        PhoneNumber = "7174875404"
                    }
                  );
            });

            modelBuilder.Entity<ApplicationRole>(e =>
            {
                e.ToTable("Role", "Auth");
            });

            modelBuilder.Entity<IdentityUserClaim<int>>(e =>
            {
                e.ToTable("UserClaim", "Auth");
            });
            modelBuilder.Entity<IdentityUserLogin<int>>(e =>
            {
                e.ToTable("UserLogin", "Auth");
                e.HasKey(x => new { x.ProviderKey, x.LoginProvider });
            });
            modelBuilder.Entity<IdentityUserToken<int>>(e =>
            {
                e.ToTable("UserToken", "Auth");
                e.HasKey(x => new { x.UserId, x.Value, x.LoginProvider });
            });
            modelBuilder.Entity<IdentityUserRole<int>>(e =>
            {
                e.ToTable("UserRole", "Auth");
                e.HasKey(x => new { x.RoleId, x.UserId });
            });
            modelBuilder.Entity<IdentityRoleClaim<int>>(e =>
            {
                e.ToTable("RoleClaim", "Auth");
            });
        }
    }
}
