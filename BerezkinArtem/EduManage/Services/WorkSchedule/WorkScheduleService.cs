using System;
using System.Linq;
using System.Windows.Forms;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.WorkSchedule
{
    public class WorkScheduleService
    {
        private readonly DatabaseRepository _repository;
        private readonly WorkScheduleSQL _sql;

        public WorkScheduleService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new WorkScheduleSQL();
        }

        public void CreateSchedule(string zone, string type, int staffId, DateTime day, TimeSpan startTime, TimeSpan endTime)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@zone", zone),
                new NpgsqlParameter("@type", type),
                new NpgsqlParameter("@staffId", staffId),
                new NpgsqlParameter("@day", day.Date),
                new NpgsqlParameter("@startTime", startTime),
                new NpgsqlParameter("@endTime", endTime)
            };

            try
            {
                var rowsAffected = _repository.Execute(_sql.Create, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("График работы добавлен!");
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении графика работы!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании графика работы: {ex.Message}");
            }
        }

        public WorkScheduleDto GetById(int id)
        {
            return _repository.Query<WorkScheduleDto>(_sql.GetById, reader => new WorkScheduleDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Zone = reader["zone"].ToString(),
                Type = reader["type"].ToString(),
                StaffId = Convert.ToInt32(reader["staff_id"]),
                StaffName = reader["staff_name"].ToString(),
                Day = Convert.ToDateTime(reader["day"]),
                StartTime = (TimeSpan)reader["start_time"],
                EndTime = (TimeSpan)reader["end_time"]
            }, new NpgsqlParameter("id", id)).Single();
        }

        public WorkScheduleDto[] GetAllSchedules()
        {
            return _repository.Query<WorkScheduleDto>(_sql.GetAll, reader => new WorkScheduleDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Zone = reader["zone"].ToString(),
                Type = reader["type"].ToString(),
                StaffId = Convert.ToInt32(reader["staff_id"]),
                StaffName = reader["staff_name"].ToString(),
                Day = Convert.ToDateTime(reader["day"]),
                StartTime = (TimeSpan)reader["start_time"],
                EndTime = (TimeSpan)reader["end_time"]
            }).ToArray();
        }

        public WorkScheduleDto[] GetAllWithSearch(string searchTerm = null)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@searchTerm", searchTerm)
            };

            return _repository.Query<WorkScheduleDto>(_sql.GetAllWithSearch, reader => new WorkScheduleDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Zone = reader["zone"].ToString(),
                Type = reader["type"].ToString(),
                StaffId = Convert.ToInt32(reader["staff_id"]),
                StaffName = reader["staff_name"].ToString(),
                Day = Convert.ToDateTime(reader["day"]),
                StartTime = (TimeSpan)reader["start_time"],
                EndTime = (TimeSpan)reader["end_time"]
            }, parameters).ToArray();
        }

        public void DeleteSchedule(int id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
            };

            var rowsAffected = _repository.Execute(_sql.Delete, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("График работы удален!");
            }
            else
            {
                MessageBox.Show("Ошибка при удалении графика работы!");
            }
        }

        public void UpdateSchedule(int id, string zone, string type, int staffId, DateTime day, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id", id),
                    new NpgsqlParameter("@zone", zone),
                    new NpgsqlParameter("@type", type),
                    new NpgsqlParameter("@staffId", staffId),
                    new NpgsqlParameter("@day", day.Date),
                    new NpgsqlParameter("@startTime", startTime),
                    new NpgsqlParameter("@endTime", endTime)
                };

                int rowsAffected = _repository.Execute(_sql.Update, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("График работы обновлен!");
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении графика работы!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении графика работы: {ex.Message}");
            }
        }

        public WorkScheduleDto[] GetSchedulesByStaff(int staffId)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
            new NpgsqlParameter("@staffId", staffId)
            };

            return _repository.Query<WorkScheduleDto>(_sql.GetByStaffId, reader => new WorkScheduleDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Zone = reader["zone"].ToString(),
                Type = reader["type"].ToString(),
                StaffId = Convert.ToInt32(reader["staff_id"]),
                StaffName = reader["staff_name"].ToString(),
                Day = Convert.ToDateTime(reader["day"]),
                StartTime = (TimeSpan)reader["start_time"],
                EndTime = (TimeSpan)reader["end_time"]
            }, parameters).ToArray();
        }

        public WorkScheduleDto[] GetSchedulesByStaffAndDate(int staffId, DateTime date)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
            new NpgsqlParameter("@staffId", staffId),
            new NpgsqlParameter("@date", date.Date)
            };

            return _repository.Query<WorkScheduleDto>(_sql.GetByStaffIdAndDate, reader => new WorkScheduleDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Zone = reader["zone"].ToString(),
                Type = reader["type"].ToString(),
                StaffId = Convert.ToInt32(reader["staff_id"]),
                StaffName = reader["staff_name"].ToString(),
                Day = Convert.ToDateTime(reader["day"]),
                StartTime = (TimeSpan)reader["start_time"],
                EndTime = (TimeSpan)reader["end_time"]
            }, parameters).ToArray();
        }
    }
}