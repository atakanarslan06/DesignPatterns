namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitorRoute>
    {
        public List<VisitorRoute> visitorRoutes = new List<VisitorRoute> ();
        
        public void AddVisitRoute(VisitorRoute visitorRoute)
        {
            visitorRoutes.Add(visitorRoute);
        }


        
        public Iterator<VisitorRoute> CreateIterator()
        {
            
        }
    }
}
