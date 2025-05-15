namespace EduManage.Services.Buses
{
    public class BusSQL
    {
        public string GetBuses = @"
        SELECT id, model, license_plate, purchase_date, 
               last_tech_inspection, next_tech_inspection, status, notes 
        FROM buses;
        ";

        public string CreateBus = @"
        INSERT INTO buses (model, license_plate, purchase_date, 
                          last_tech_inspection, next_tech_inspection, status, notes)
        VALUES (@model, @licensePlate, @purchaseDate, 
                @lastTechInspection, @nextTechInspection, @status, @notes);
        ";

        public string Search = @"
        SELECT id, model, license_plate, purchase_date, 
               last_tech_inspection, next_tech_inspection, status, notes
        FROM buses
        WHERE 
            (model ILIKE '%' || @searchTerm || '%' OR 
             license_plate ILIKE '%' || @searchTerm || '%' OR
             status ILIKE '%' || @searchTerm || '%');
        ";

        public string Delete = @"
        DELETE FROM buses 
        WHERE id = @id;
        ";

        public string Update = @"
        UPDATE buses
        SET 
            model = @model,
            license_plate = @licensePlate,
            purchase_date = @purchaseDate,
            last_tech_inspection = @lastTechInspection,
            next_tech_inspection = @nextTechInspection,
            status = @status,
            notes = @notes
        WHERE id = @id
        ";

        public string GetById = @"
        SELECT id, model, license_plate, purchase_date, 
               last_tech_inspection, next_tech_inspection, status, notes 
        FROM buses 
        WHERE id = @id;
        ";

        public string GetByLicensePlate = @"
        SELECT *
        FROM buses 
        WHERE license_plate = @licensePlate;
        ";

        public string UpdateStatus = @"
        UPDATE buses
        SET status = @status
        WHERE id = @id;
        ";
    }
}