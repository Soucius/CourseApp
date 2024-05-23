namespace basics.Models {
    public class Repository {
        private static readonly List<Course> _courses = new();

        static Repository() {
            _courses = new List<Course>() {
                new Course() { 
                    Id = 1,
                    Title = "aspnet kursu",
                    Description = "guzel bir kurs",
                    Image = "1.jpg",
                    Tags = new string[] {"aspnet", "web gelistirme"},
                    isActive = true,
                    isHome = true
                },

                new Course() {
                    Id = 2,
                    Title = "php kursu",
                    Description = "guzel bir kurs",
                    Image = "2.jpg",
                    Tags = new string[] {"php", "web gelistirme"},
                    isActive = true,
                    isHome = true
                },

                new Course() {
                    Id = 3,
                    Title = "django kursu",
                    Description = "guzel bir kurs",
                    Image = "3.jpg",
                    isActive = true,
                    isHome = false
                },

                new Course() {
                    Id = 4,
                    Title = "javascript kursu",
                    Description = "guzel bir kurs",
                    Image = "1.jpg",
                    isActive = true,
                    isHome = true
                },
            };
        }

        public static List<Course> Courses {
            get {
                return _courses;
            }
        }

        public static Course? GetById(int? id) {
            return _courses.FirstOrDefault(course => course.Id == id);
        }
    }
}