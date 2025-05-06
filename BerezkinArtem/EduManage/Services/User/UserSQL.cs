using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Services.User
{
    public class UserSQL
    {
        public string signIn = @"
        SELECT 
            u.id, 
            u.login, 
            u.password,
            r.name as role_name, 
            s.full_name,
            s.position,
            s.department,
            s.phone,
            s.hire_date,
            s.is_active
        FROM 
            users u
        LEFT JOIN 
            roles r ON u.role_id = r.id
        LEFT JOIN 
            staff s ON u.id = s.user_id
        WHERE 
            u.password = @password AND u.login = @login;
        ";
    }
}
