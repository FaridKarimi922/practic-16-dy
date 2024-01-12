namespace tamrin__5__16_dy
{
    public interface ICourse
    {
        string Name { get; set; }
        int Unit { get; }

        void AddStudent(Student st);
    }
}