using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.Migrations
{
    public partial class init
    {
        private void Pre(MigrationBuilder migrationBuilder)
        {
            CreateUser(migrationBuilder);
        }

        private void CreateUser(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE USER [CCC] FOR LOGIN [CCC]");
            migrationBuilder.Sql("ALTER ROLE [db_owner] ADD MEMBER [CCC]");
        }
    }
}
