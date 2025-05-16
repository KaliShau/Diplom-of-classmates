namespace EduManage.Services.PartOperations
{
    public class PartOperationSQL
    {
        public string GetAll = @"
        SELECT po.*,
               bp.serial_number || ' (' || pt.name || ')' as part_info,
               b.model || ' (' || b.license_plate || ')' as bus_info,
               pt.name as part_type_info,
               s.last_name || ' ' || s.first_name || ' ' || s.middle_name as staff_info,
               sup.name as supplier_info
        FROM part_operations po
        LEFT JOIN bus_parts bp ON po.part_id = bp.id
        LEFT JOIN part_types pt ON po.part_type_id = pt.id
        LEFT JOIN buses b ON po.bus_id = b.id
        LEFT JOIN staff s ON po.performed_by = s.id
        LEFT JOIN suppliers sup ON po.supplier_id = sup.id;
        ";

        public string GetById = @"
        SELECT po.*,
               bp.serial_number || ' (' || pt2.name || ')' as part_info,
               b.model || ' (' || b.license_plate || ')' as bus_info,
               pt.name as part_type_info,
               s.last_name || ' ' || s.first_name || ' ' || s.middle_name as staff_info,
               sup.name as supplier_info
        FROM part_operations po
        LEFT JOIN bus_parts bp ON po.part_id = bp.id
        LEFT JOIN part_types pt ON po.part_type_id = pt.id
        LEFT JOIN part_types pt2 ON bp.part_type_id = pt2.id
        LEFT JOIN buses b ON po.bus_id = b.id
        LEFT JOIN staff s ON po.performed_by = s.id
        LEFT JOIN suppliers sup ON po.supplier_id = sup.id
        WHERE po.id = @id;
        ";

        public string Create = @"
        INSERT INTO part_operations (
            part_id, operation_type, bus_id, part_type_id, quantity, unit, 
            price, operation_date, performed_by, supplier_id, notes
        )
        VALUES (
            @partId, @operationType, @busId, @partTypeId, @quantity, @unit, 
            @price, @operationDate, @performedBy, @supplierId, @notes
        )
        RETURNING id;
        ";

        public string Update = @"
        UPDATE part_operations
        SET 
            part_id = @partId,
            operation_type = @operationType,
            bus_id = @busId,
            part_type_id = @partTypeId,
            quantity = @quantity,
            unit = @unit,
            price = @price,
            operation_date = @operationDate,
            performed_by = @performedBy,
            supplier_id = @supplierId,
            notes = @notes
        WHERE id = @id;
        ";

        public string Delete = @"
        DELETE FROM part_operations 
        WHERE id = @id;
        ";

        public string Search = @"
        SELECT po.*,
               bp.serial_number || ' (' || pt2.name || ')' as part_info,
               b.model || ' (' || b.license_plate || ')' as bus_info,
               pt.name as part_type_info,
               s.last_name || ' ' || s.first_name || ' ' || s.middle_name as staff_info,
               sup.name as supplier_info
        FROM part_operations po
        LEFT JOIN bus_parts bp ON po.part_id = bp.id
        LEFT JOIN part_types pt ON po.part_type_id = pt.id
        LEFT JOIN part_types pt2 ON bp.part_type_id = pt2.id
        LEFT JOIN buses b ON po.bus_id = b.id
        LEFT JOIN staff s ON po.performed_by = s.id
        LEFT JOIN suppliers sup ON po.supplier_id = sup.id
        WHERE 
            po.operation_type ILIKE '%' || @searchTerm || '%' OR
            bp.serial_number ILIKE '%' || @searchTerm || '%' OR
            pt.name ILIKE '%' || @searchTerm || '%' OR
            b.model ILIKE '%' || @searchTerm || '%' OR
            b.license_plate ILIKE '%' || @searchTerm || '%' OR
            s.last_name ILIKE '%' || @searchTerm || '%' OR
            sup.name ILIKE '%' || @searchTerm || '%';
        ";

        public string GetByPartId = @"
        SELECT po.*,
               b.model || ' (' || b.license_plate || ')' as bus_info,
               pt.name as part_type_info,
               s.last_name || ' ' || s.first_name || ' ' || s.middle_name as staff_info,
               sup.name as supplier_info
        FROM part_operations po
        LEFT JOIN buses b ON po.bus_id = b.id
        LEFT JOIN part_types pt ON po.part_type_id = pt.id
        LEFT JOIN staff s ON po.p   LEFT JOIN part_types pt2 ON bp.part_type_id = pt2.id
        LEFT JOIN staff s ON po.performed_by = s.id
        LEFT JOIN suppliers sup ON po.supplier_id = sup.id
        WHERE po.bus_id = @busId po.operation_type = @operation_type;erformed_by = s.id
        LEFT JOIN suppliers sup ON po.supplier_id = sup.id
        WHERE po.part_id = @partId;
        ";

        public string GetByBusId = @"
        SELECT 
            po.*,
            bp.serial_number || ' (' || pt2.name || ')' as part_info,
            b.license_plate || ' (' || b.model || ')' as bus_info,
            pt.name as part_type_info,
            s.full_name as staff_info,
            sup.name as supplier_info
        FROM part_operations po
        LEFT JOIN buses b ON po.bus_id = b.id 
        LEFT JOIN bus_parts bp ON po.part_id = bp.id
        LEFT JOIN part_types pt ON po.part_type_id = pt.id
        LEFT JOIN part_types pt2 ON bp.part_type_id = pt2.id
        LEFT JOIN staff s ON po.performed_by = s.id
        LEFT JOIN suppliers sup ON po.supplier_id = sup.id
        WHERE po.bus_id = @busId AND po.operation_type = @operation_type;
        ";

        public string GetByPartTypeId = @"
        SELECT po.*,
               bp.serial_number || ' (' || pt2.name || ')' as part_info,
               b.model || ' (' || b.license_plate || ')' as bus_info,
               s.last_name || ' ' || s.first_name || ' ' || s.middle_name as staff_info,
               sup.name as supplier_info
        FROM part_operations po
        LEFT JOIN bus_parts bp ON po.part_id = bp.id
        LEFT JOIN part_types pt2 ON bp.part_type_id = pt2.id
        LEFT JOIN buses b ON po.bus_id = b.id
        LEFT JOIN staff s ON po.performed_by = s.id
        LEFT JOIN suppliers sup ON po.supplier_id = sup.id
        WHERE po.part_type_id = @partTypeId;
        ";

        public string GetByDateRange = @"
        SELECT po.*,
               bp.serial_number || ' (' || pt2.name || ')' as part_info,
               b.model || ' (' || b.license_plate || ')' as bus_info,
               pt.name as part_type_info,
               s.last_name || ' ' || s.first_name || ' ' || s.middle_name as staff_info,
               sup.name as supplier_info
        FROM part_operations po
        LEFT JOIN bus_parts bp ON po.part_id = bp.id
        LEFT JOIN part_types pt ON po.part_type_id = pt.id
        LEFT JOIN part_types pt2 ON bp.part_type_id = pt2.id
        LEFT JOIN buses b ON po.bus_id = b.id
        LEFT JOIN staff s ON po.performed_by = s.id
        LEFT JOIN suppliers sup ON po.supplier_id = sup.id
        WHERE po.operation_date BETWEEN @startDate AND @endDate;
        ";
    }
}