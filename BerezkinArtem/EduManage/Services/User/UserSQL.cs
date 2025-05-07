namespace EduManage.Services.User
{
    public class UserSQL
    {
        public string SignIn = @"
            SELECT 
                u.id, u.login, u.password,
                r.id as role_id, r.name as role_name,
                s.id as staff_id, s.full_name, s.position, 
                s.department, s.phone, s.hire_date, s.is_active
            FROM users u
            JOIN roles r ON u.role_id = r.id
            LEFT JOIN staff s ON u.id = s.user_id
            WHERE u.login = @login AND u.password = @password;
        ";

        public string GetAll = @"
    SELECT 
        u.id, u.login, u.password,
        r.id as role_id, r.name as role_name,
        s.id as staff_id, s.full_name, s.position, 
        s.department, s.phone, s.hire_date, s.is_active
    FROM users u
    JOIN roles r ON u.role_id = r.id
    LEFT JOIN staff s ON u.id = s.user_id
    ORDER BY u.login;
";

        public string CheckStaffHasUser = @"
        SELECT EXISTS(
            SELECT 1 FROM staff 
            WHERE id = @staffId AND user_id IS NOT NULL
        )";

        public string ClearStaffUserReference = @"
        UPDATE staff SET user_id = NULL 
        WHERE user_id = @userId";

        public string Create = @"
            INSERT INTO users (login, password, role_id)
            VALUES (@login, @password, @roleId)
            RETURNING id;
        ";

        public string UpdateStaffUserId = @"
            UPDATE staff
            SET user_id = @userId
            WHERE id = @staffId;
        ";

        public string GetById = @"
            SELECT u.id, u.login, u.role_id, r.name as role_name,
                   s.id as staff_id, s.full_name, s.position, s.department
            FROM users u
            JOIN roles r ON u.role_id = r.id
            LEFT JOIN staff s ON u.id = s.user_id
            WHERE u.id = @id;
        ";


        public string Update = @"
            UPDATE users
            SET login = @login,
                password = @password,
                role_id = @roleId
            WHERE id = @id;
        ";

        public string Delete = @"
            DELETE FROM users
            WHERE id = @id;
        ";

        public string Search = @"
            SELECT u.id, u.login, u.role_id, r.name as role_name,
                   s.id as staff_id, s.full_name, s.position, s.department
            FROM users u
            JOIN roles r ON u.role_id = r.id
            LEFT JOIN staff s ON u.id = s.user_id
            WHERE u.login ILIKE '%' || @searchTerm || '%' OR
                  s.full_name ILIKE '%' || @searchTerm || '%'
            ORDER BY u.login;
        ";
    }
}
