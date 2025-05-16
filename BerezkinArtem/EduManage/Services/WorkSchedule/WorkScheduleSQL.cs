namespace EduManage.Services.WorkSchedule
{
    public class WorkScheduleSQL
    {
        public string Create = @"
        INSERT INTO work_schedule (zone, type, staff_id, day, start_time, end_time)
        VALUES (@zone, @type, @staffId, @day, @startTime, @endTime)
        RETURNING id;
        ";

        public string GetAll = @"
        SELECT ws.id, ws.zone, ws.type, ws.staff_id, ws.day, ws.start_time, ws.end_time,
                s.full_name as staff_name
        FROM work_schedule ws
        JOIN staff s ON ws.staff_id = s.id
        ORDER BY ws.day DESC, ws.start_time;
        ";

        public string Delete = @"
        DELETE FROM work_schedule 
        WHERE id = @id;
        ";

        public string GetById = @"
        SELECT ws.id, ws.zone, ws.type, ws.staff_id, ws.day, ws.start_time, ws.end_time,
                s.full_name as staff_name
        FROM work_schedule ws
        JOIN staff s ON ws.staff_id = s.id
        WHERE ws.id = @id;
        ";

        public string GetAllWithSearch = @"
        SELECT ws.id, ws.zone, ws.type, ws.staff_id, ws.day, ws.start_time, ws.end_time,
                s.full_name as staff_name
        FROM work_schedule ws
        JOIN staff s ON ws.staff_id = s.id
        WHERE 
            (@searchTerm IS NULL OR 
             ws.id::TEXT LIKE '%' || @searchTerm || '%' OR
             ws.zone LIKE '%' || @searchTerm || '%' OR
             ws.type LIKE '%' || @searchTerm || '%' OR
             s.full_name LIKE '%' || @searchTerm || '%' OR
             ws.day::TEXT LIKE '%' || @searchTerm || '%')
        ORDER BY ws.day DESC, ws.start_time;
        ";

        public string Update = @"
        UPDATE work_schedule 
        SET zone = @zone, 
            type = @type, 
            staff_id = @staffId, 
            day = @day, 
            start_time = @startTime, 
            end_time = @endTime
        WHERE id = @id
        RETURNING id;
       ";

        public string GetByStaffId = @"
        SELECT ws.id, ws.zone, ws.type, ws.staff_id, ws.day, ws.start_time, ws.end_time,
                s.full_name as staff_name
        FROM work_schedule ws
        JOIN staff s ON ws.staff_id = s.id
        WHERE ws.staff_id = @staffId
        ORDER BY ws.day DESC, ws.start_time;
    ";

        public string GetByStaffIdAndDate = @"
        SELECT ws.id, ws.zone, ws.type, ws.staff_id, ws.day, ws.start_time, ws.end_time,
                s.full_name as staff_name
        FROM work_schedule ws
        JOIN staff s ON ws.staff_id = s.id
        WHERE ws.staff_id = @staffId AND ws.day = @date
        ORDER BY ws.start_time;
    ";
    }
}