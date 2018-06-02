class Iterator {
    public string Current { get; private set; } = "";
    public Iterator() { }

    public bool MoveNext() {
        if (Current.Length == 10) return false;
        Current += ":";
        return true;
    }
}
class MyLoop {
    public Iterator GetEnumerator() {
        return new Iterator();
    }
}

foreach (var item in new MyLoop()) {
    Console.WriteLine(item);
}