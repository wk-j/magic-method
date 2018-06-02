using System.Collections;

public class MyData : IEnumerable {

    private List<Type> types = new List<Type>();

    public void Add<T>(T value) {
        types.Add(typeof(T));
    }

    public IEnumerator GetEnumerator() {
        return types.GetEnumerator();
    }
}

var data = new MyData {
    1,
    "Hello",
    DateTime.Now
};

foreach (var item in data) {
    Console.WriteLine(item);
}
