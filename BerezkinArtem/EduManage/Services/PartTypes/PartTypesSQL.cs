namespace EduManage.Services.PartTypes
{
    public class PartTypeSQL
    {
        public string GetAll = @"
        SELECT id, name, part_number, description, compatible_bus_models 
        FROM part_types;
        ";

        public string GetById = @"
        SELECT id, name, part_number, description, compatible_bus_models 
        FROM part_types 
        WHERE id = @id;
        ";

        public string Create = @"
        INSERT INTO part_types (name, part_number, description, compatible_bus_models)
        VALUES (@name, @partNumber, @description, @compatibleBusModels)
        RETURNING id;
        ";

        public string Update = @"
        UPDATE part_types
        SET 
            name = @name,
            part_number = @partNumber,
            description = @description,
            compatible_bus_models = @compatibleBusModels
        WHERE id = @id;
        ";

        public string Delete = @"
        DELETE FROM part_types 
        WHERE id = @id;
        ";

        public string Search = @"
        SELECT id, name, part_number, description, compatible_bus_models
        FROM part_types
        WHERE 
            name ILIKE '%' || @searchTerm || '%' OR 
            part_number ILIKE '%' || @searchTerm || '%' OR
            description ILIKE '%' || @searchTerm || '%' OR
            compatible_bus_models ILIKE '%' || @searchTerm || '%';
        ";

        public string GetByPartNumber = @"
        SELECT id, name, part_number
        FROM part_types
        WHERE part_number = @partNumber;
        ";
    }
}