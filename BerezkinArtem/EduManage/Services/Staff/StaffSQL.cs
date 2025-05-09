namespace EduManage.Services.Staff
{
    public class StaffSQL
    {
        public string Create = @"
            INSERT INTO staff (full_name, position, department, phone, hire_date)
            VALUES (@full_name, @position, @department, @phone, @hire_date)
            RETURNING id;
        ";

        public string GetById = @"
            SELECT id, user_id, full_name, position, department, phone, hire_date, is_active
            FROM staff
            WHERE id = @id;
        ";

        public string GetAll = @"
            SELECT *
            FROM staff
            ORDER BY full_name;
        ";

        public string GetForAccountant = @"
            SELECT s.id, s.full_name, s.position, s.department, s.phone, s.hire_date, s.is_active, s.user_id
            FROM staff s
            LEFT JOIN users u ON s.user_id = u.id
            LEFT JOIN roles r ON u.role_id = r.id
            WHERE r.name != 'Admin' OR r.name IS NULL
            ORDER BY s.full_name;
        ";

        public string Update = @"
            UPDATE staff
            SET full_name = @full_name,
                position = @position,
                department = @department,
                phone = @phone,
                hire_date = @hire_date
            WHERE id = @id;
        ";

        public string UpdateIsActive = @"
            UPDATE staff
            SET is_active = @is_active
            WHERE id = @id;
        ";

        public string Delete = @"
            DELETE FROM staff
            WHERE id = @id;
        ";

        public string Search = @"
            SELECT id, user_id, full_name, position, department, phone, hire_date, is_active
            FROM staff
            WHERE full_name ILIKE '%' || @searchTerm || '%' OR
                  position ILIKE '%' || @searchTerm || '%' OR
                  department ILIKE '%' || @searchTerm || '%'
            ORDER BY full_name;
        ";

        public string GetForAccountantSearch = @"
            SELECT id, full_name, position, department, phone, hire_date, is_active
            FROM staff
            WHERE user_id IS NULL AND full_name ILIKE '%' || @searchTerm || '%' OR
                  position ILIKE '%' || @searchTerm || '%' OR
                  department ILIKE '%' || @searchTerm || '%'
            ORDER BY full_name;
        ";
    }
}
