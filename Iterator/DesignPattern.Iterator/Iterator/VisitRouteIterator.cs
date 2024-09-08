namespace DesignPattern.Iterator.Iterator
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }
        private int CurrentIndex = 0;
        private  VisitRouteMover _visitRouteMover { get; set; }

        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
           if (CurrentIndex <_visitRouteMover.VisitRouteCount)
            {
                CurrentItem = _visitRouteMover.visitRoutes[CurrentIndex++];
                return true;
            }
           return false;
        }
    }
}
