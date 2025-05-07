namespace EduManage.Services.Suppliers
{
    public class SupplierSql
    {
        public string Create = @"
        INSERT INTO suppliers (name, contact, phone)
        VALUES (@name, @contact, @phone)
        RETURNING id;
    ";

        public string GetById = @"
        SELECT id, name, contact, phone
        FROM suppliers
        WHERE id = @id;
    ";

        public string GetAll = @"
        SELECT id, name, contact, phone
        FROM suppliers
        ORDER BY name;
    ";

        public string GetAllWithSearch = @"
        SELECT id, name, contact, phone
        FROM suppliers
        WHERE @searchTerm IS NULL OR
              name ILIKE '%' || @searchTerm || '%' OR
              contact ILIKE '%' || @searchTerm || '%' OR
              phone ILIKE '%' || @searchTerm || '%'
        ORDER BY name;
    ";

        public string Update = @"
        UPDATE suppliers
        SET name = @name,
            contact = @contact,
            phone = @phone
        WHERE id = @id;
    ";

        public string Delete = @"
        DELETE FROM suppliers
        WHERE id = @id;
    ";
    }
}
