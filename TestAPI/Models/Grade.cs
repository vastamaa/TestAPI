using System.Text.Json.Serialization;

#nullable disable

namespace TestAPI.Models
{
    public partial class Grade
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int Grade1 { get; set; }
        [JsonIgnore]
        public int StudentId { get; set; }

        [JsonIgnore]
        public virtual Student Student { get; set; }
    }
}
