using System.Collections.Generic;
public static class Extension{
    //If you call this filter from another file it would look like... The actual Filter(numbers, x => x > 3);
    public static List<T> Filter<T>(this List<T> records,Func<T,bool> func)
    {
        List<T> filteredList = new List<T>();

        foreach(T record in records) 
        {
            if (func(record)) 
            {
                filteredList.Add(record);
            }
        }
        return filteredList;
    }
}