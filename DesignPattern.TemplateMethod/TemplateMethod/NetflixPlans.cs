namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public abstract class NetflixPlans
    {

     
        public abstract string PlanType(string plantype);
        public abstract int CountPerson(int countPerson);
        public abstract double Price(double price);

        public abstract string Resolution(string resolution);
        public abstract string Content(string content);




    }
}
