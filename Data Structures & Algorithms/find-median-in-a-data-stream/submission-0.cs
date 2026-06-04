public class MedianFinder {

    List<int> list;
    public MedianFinder() {
        list = new ();
    }
    
    public void AddNum(int num) {
        list.Add(num);
    }
    
    public double FindMedian() {
        list.Sort();
        int middle = list.Count / 2;
        if(list.Count %2 == 1){
            return list[middle];
        }
        else{
            return (list[middle] + list[middle - 1]) / 2.0f;
        }
    }
}
