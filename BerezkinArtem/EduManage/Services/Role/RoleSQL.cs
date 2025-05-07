using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Services.Role
{
    public class RoleSQL
    {
        public string Create = @"
            INSERT INTO roles (name, description)
            VALUES (@name, @description)
            RETURNING id;
        ";

        public string GetById = @"
            SELECT id, name, description
            FROM roles
            WHERE id = @id;
        ";

        public string GetAll = @"
            SELECT id, name, description
            FROM roles
            ORDER BY name;
        ";

        public string Update = @"
            UPDATE roles
            SET name = @name,
                description = @description
            WHERE id = @id;
        ";

        public string Delete = @"
            DELETE FROM roles
            WHERE id = @id;
        ";

        public string Exists = @"
            SELECT EXISTS(SELECT 1 FROM roles WHERE name = @name) as exists;
        ";
    }
}
