namespace EduManage.Services.Purchases
{
    public class PurchaseSQL
    {
        public string Create = @"
        INSERT INTO purchases (supplier_id, item_name, amount, date)
        VALUES (@supplierId, @itemName, @amount, CURRENT_DATE)
        RETURNING id;
    ";

        public string GetById = @"
        SELECT p.id, p.supplier_id, s.name as supplier_name, 
               p.item_name, p.amount, p.date
        FROM purchases p
        JOIN suppliers s ON p.supplier_id = s.id
        WHERE p.id = @id;
    ";

        public string GetAll = @"
        SELECT p.id, p.supplier_id, s.name as supplier_name, 
               p.item_name, p.amount, p.date
        FROM purchases p
        JOIN suppliers s ON p.supplier_id = s.id
        ORDER BY p.date DESC;
    ";

        public string Update = @"
        UPDATE purchases
        SET supplier_id = @supplierId,
            item_name = @itemName,
            amount = @amount,
            date = @date
        WHERE id = @id;
    ";

        public string Delete = @"
        DELETE FROM purchases
        WHERE id = @id;
    ";


        public string Search = @"
        SELECT p.id, p.supplier_id, s.name as supplier_name, 
               p.item_name, p.amount, p.date
        FROM purchases p
        JOIN suppliers s ON p.supplier_id = s.id
        WHERE p.item_name ILIKE '%' || @searchTerm || '%' OR
              s.name ILIKE '%' || @searchTerm || '%'
        ORDER BY p.date DESC;
    ";
    }
}
