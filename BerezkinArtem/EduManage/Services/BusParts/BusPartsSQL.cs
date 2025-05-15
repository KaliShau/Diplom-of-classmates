namespace EduManage.Services.BusParts
{
    public class BusPartSQL
    {
        public string GetAll = @"
        SELECT bp.id, bp.part_type_id, bp.bus_id, bp.serial_number, 
               bp.status, bp.quantity, bp.unit, bp.installation_date, 
               bp.defect_date, bp.defect_description,
               pt.name as part_type_name,
               b.model || ' (' || b.license_plate || ')' as bus_info
        FROM bus_parts bp
        LEFT JOIN part_types pt ON bp.part_type_id = pt.id
        LEFT JOIN buses b ON bp.bus_id = b.id;
        ";

        public string GetById = @"
        SELECT bp.id, bp.part_type_id, bp.bus_id, bp.serial_number, 
               bp.status, bp.quantity, bp.unit, bp.installation_date, 
               bp.defect_date, bp.defect_description,
               pt.name as part_type_name,
               b.model || ' (' || b.license_plate || ')' as bus_info
        FROM bus_parts bp
        LEFT JOIN part_types pt ON bp.part_type_id = pt.id
        LEFT JOIN buses b ON bp.bus_id = b.id
        WHERE bp.id = @id;
        ";

        public string Create = @"
        INSERT INTO bus_parts (part_type_id, bus_id, serial_number, status, 
                             quantity, unit, installation_date, defect_date, defect_description)
        VALUES (@partTypeId, @busId, @serialNumber, @status, 
                @quantity, @unit, @installationDate, @defectDate, @defectDescription)
        RETURNING id;
        ";

        public string Update = @"
        UPDATE bus_parts
        SET 
            part_type_id = @partTypeId,
            bus_id = @busId,
            serial_number = @serialNumber,
            status = @status,
            quantity = @quantity,
            unit = @unit,
            installation_date = @installationDate,
            defect_date = @defectDate,
            defect_description = @defectDescription
        WHERE id = @id;
        ";

        public string Delete = @"
        DELETE FROM bus_parts 
        WHERE id = @id;
        ";

        public string Search = @"
        SELECT bp.id, bp.part_type_id, bp.bus_id, bp.serial_number, 
               bp.status, bp.quantity, bp.unit, bp.installation_date, 
               bp.defect_date, bp.defect_description,
               pt.name as part_type_name,
               b.model || ' (' || b.license_plate || ')' as bus_info
        FROM bus_parts bp
        LEFT JOIN part_types pt ON bp.part_type_id = pt.id
        LEFT JOIN buses b ON bp.bus_id = b.id
        WHERE 
            bp.serial_number ILIKE '%' || @searchTerm || '%' OR
            pt.name ILIKE '%' || @searchTerm || '%' OR
            b.model ILIKE '%' || @searchTerm || '%' OR
            b.license_plate ILIKE '%' || @searchTerm || '%' OR
            bp.status ILIKE '%' || @searchTerm || '%';
        ";

        public string GetByBusId = @"
        SELECT bp.id, bp.part_type_id, bp.bus_id, bp.serial_number, 
               bp.status, bp.quantity, bp.unit, bp.installation_date, 
               bp.defect_date, bp.defect_description,
               pt.name as part_type_name
        FROM bus_parts bp
        LEFT JOIN part_types pt ON bp.part_type_id = pt.id
        WHERE bp.bus_id = @busId;
        ";

        public string GetByPartTypeId = @"
        SELECT bp.id, bp.part_type_id, bp.bus_id, bp.serial_number, 
               bp.status, bp.quantity, bp.unit, bp.installation_date, 
               bp.defect_date, bp.defect_description,
               b.model || ' (' || b.license_plate || ')' as bus_info
        FROM bus_parts bp
        LEFT JOIN buses b ON bp.bus_id = b.id
        WHERE bp.part_type_id = @partTypeId;
        ";

        public string UpdateStatus = @"
        UPDATE bus_parts
        SET status = @status
        WHERE id = @id;
        ";
    }
}