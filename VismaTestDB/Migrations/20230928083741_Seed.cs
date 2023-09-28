using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VismaTestDB.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                INSERT INTO public."Department"("Name", "Info")
                VALUES ('Department1', 'The only department exists');
                """);

            migrationBuilder.Sql("""
                DO $$DECLARE dep_id int;
                BEGIN
                select d."Id" into dep_id from public."Department" d 
                Where d."Name" = 'Department1';

                INSERT INTO public."Managers"("FirstName", "LastName", "Email", "Salary", "DepartmentId")
                VALUES  ('Moe', 'Smith', 'm.smith@email.com', 3500, dep_id),
                		('Loe', 'Smith', 'l.smith@email.com', 4500, dep_id),
                		('Koe', 'Smith', 'k.smith@email.com', 5500, dep_id);
                end$$;
                """);

            migrationBuilder.Sql("""
                DO $$DECLARE 
                	dep_id int;
                	mng_id int;
                BEGIN
                select d."Id" into dep_id from public."Department" d 
                Where d."Name" = 'Department1';

                select mng."Id" into mng_id from public."Managers" mng 
                Where mng."FirstName" = 'Moe';

                INSERT INTO public."Developers"(
                	"FirstName", "LastName", "Email", "Salary", "ManagerId", "DepartmentId")
                	VALUES  ('Alice', 'Smith', 'a.smith@email.com', 1000, mng_id, dep_id),
                       		('Bob', 'Smith', 'b.smith@email.com', 2000, mng_id, dep_id);
                end$$;
                """);          

            migrationBuilder.Sql("""
                DO $$DECLARE 
                	dep_id int;
                	mng_id int;
                BEGIN
                select d."Id" into dep_id from public."Department" d 
                Where d."Name" = 'Department1';

                select mng."Id" into mng_id from public."Managers" mng 
                Where mng."FirstName" = 'Loe';

                INSERT INTO public."Developers"(
                	"FirstName", "LastName", "Email", "Salary", "ManagerId", "DepartmentId")
                	VALUES  ('Chris', 'Smith', 'c.smith@email.com', 3000, mng_id, dep_id),
                       		('David', 'Smith', 'd.smith@email.com', 4000, mng_id, dep_id),
                			('Evan', 'Smith', 'e.smith@email.com', 5000, mng_id, dep_id);
                end$$;
                """);

            migrationBuilder.Sql("""
                DO $$DECLARE 
                	dep_id int;
                	mng_id int;
                BEGIN
                select d."Id" into dep_id from public."Department" d 
                Where d."Name" = 'Department1';

                select mng."Id" into mng_id from public."Managers" mng 
                Where mng."FirstName" = 'Koe';

                INSERT INTO public."Developers"(
                	"FirstName", "LastName", "Email", "Salary", "ManagerId", "DepartmentId")
                	VALUES  ('France', 'Smith', 'f.smith@email.com', 6000, mng_id, dep_id),
                       		('George', 'Smith', 'g.smith@email.com', 7000, mng_id, dep_id),
                			('Harry', 'Smith', 'h.smith@email.com', 8000, mng_id, dep_id),
                			('Ivo', 'Smith', 'i.smith@email.com', 9000, mng_id, dep_id);
                end$$;
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
