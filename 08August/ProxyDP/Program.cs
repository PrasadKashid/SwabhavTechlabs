using ProxyDesignPattern.Model;

class Program
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee("Prasad Kashid", "123456", "CEO");
        Employee employee2 = new Employee("Subhashish Mahapatra", "123456", "Developer");
        Employee employee3 = new Employee("Shantanu Rane", "123456", "Client");

        Console.WriteLine("CEO Accessing");
        SharedFolderProxy folderProxy = new SharedFolderProxy(employee1);
        folderProxy.ReadWriteOperation();
        Console.WriteLine();


        Console.WriteLine("Developer Accessing");
        SharedFolderProxy folderProxy2 = new SharedFolderProxy(employee2);
        folderProxy2.ReadWriteOperation();
        Console.WriteLine();


        Console.WriteLine("Client Accessing");
        SharedFolderProxy folderProxy3 = new SharedFolderProxy(employee3);
        folderProxy3.ReadWriteOperation();
    }
}