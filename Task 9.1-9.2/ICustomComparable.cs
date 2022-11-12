namespace Task_9._1_9._2
{
    public interface ICustomComparable<T>
    {
        //public string TextFormat { get; set; } // строковое представление какого-либо объекта
        public int CustomCompare(T val);
    }
}