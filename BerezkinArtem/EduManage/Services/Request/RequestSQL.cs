namespace EduManage.Services.Request
{
    public class RequestSQL
    {
        public string Create = @"
        INSERT INTO requests (inventory_id, user_id, date, problem, status)
        VALUES (@inventoryId, @userId, CURRENT_DATE, @problem, 'Новая')
        RETURNING id;
        ";

        public string GetAll = @"
        SELECT r.id, r.inventory_id, r.user_id, r.date, r.problem, r.status,
                i.name as inventory_name,
                u.login as user_name
        FROM requests r
        JOIN inventory i ON r.inventory_id = i.id
        JOIN users u ON r.user_id = u.id
        ORDER BY r.date DESC;
        ";

        public string Delete = @"
        DELETE FROM requests 
        WHERE id = @id;
        ";

        public string GetById = @"
        SELECT r.id, r.inventory_id, r.user_id, r.date, r.problem, r.status,
                i.name as inventory_name,
                u.login as user_name
        FROM requests r
        JOIN inventory i ON r.inventory_id = i.id
        JOIN users u ON r.user_id = u.id
        WHERE r.id = @id;
        ";

        public string GetAllWithSearch = @"
        SELECT r.id, r.inventory_id, r.user_id, r.date, r.problem, r.status,
                i.name as inventory_name,
                u.login as user_name
        FROM requests r
        JOIN inventory i ON r.inventory_id = i.id
        JOIN users u ON r.user_id = u.id
        WHERE 
            (@searchTerm IS NULL OR 
             r.id::TEXT LIKE '%' || @searchTerm || '%' OR
             i.name LIKE '%' || @searchTerm || '%' OR
             u.login LIKE '%' || @searchTerm || '%' OR
             r.problem LIKE '%' || @searchTerm || '%' OR
             r.status LIKE '%' || @searchTerm || '%')
        ORDER BY r.date DESC;
        ";

        public string UpdateStatus = @"
        UPDATE requests 
        SET status = @status 
        WHERE id = @requestId
        RETURNING id;
       ";
    }
}
