namespace Task_9._1_9._2
{
    public interface ICustomComparable<T>
    {
        public string TextFormat { get; set; } //объект
        int CustomCompare(T val);




    }
}