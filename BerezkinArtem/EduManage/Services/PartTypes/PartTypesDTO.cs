using System.ComponentModel;

namespace EduManage.Services.PartTypes
{
    public class PartTypeDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Номер запчасти")]
        public string PartNumber { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Совместимые модели")]
        public string CompatibleBusModels { get; set; }
    }
}