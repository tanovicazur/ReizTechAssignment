
class Task2{
    class Branch
    {
        List<Branch> branches;
        public string name;
        public Branch()
        {
            this.branches = new List<Branch>();
            this.name = " ";
        }

        public Branch(List<Branch> branches, string name)
        {
            this.branches = branches;
            this.name = name;
        }

        public Branch(string name)
        {
            this.branches = new List<Branch>();
            this.name = name;
        }

        public List<Branch> getBranches()
        {
            return branches;
        }

    }

    static void Main()
    {
        Branch obj1 = new Branch("1");
        Branch obj2 = new Branch("2");
        Branch obj3 = new Branch("3");
        Branch obj4 = new Branch("4");
        Branch obj5 = new Branch("5");
        obj1.getBranches().Add(obj2);
        obj1.getBranches().Add(obj3);
        obj2.getBranches().Add(obj4);
        obj3.getBranches().Add(obj5);
        for(int i = 0; i < obj1.getBranches().Count; i++)
        {
            Console.WriteLine(obj1.getBranches().ElementAt(i).name);
        }
    }
}
