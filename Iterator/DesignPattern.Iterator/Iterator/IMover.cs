namespace DesignPattern.Iterator.Iterator
{
    public interface IMover<T>
    {

        IIterator<T> CreateIterator(); //yeni yineleyici olustur
    }
}
