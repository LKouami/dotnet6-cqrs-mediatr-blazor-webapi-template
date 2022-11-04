using SSMLibrary.Models;

namespace SSMLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<CourseModel> GetCourse();
        CourseModel InsertCourse(string Name);
    }
}