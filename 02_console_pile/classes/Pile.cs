using System;

namespace _02_pile_program.classes
{
    public class Pile
    {
        Position first;
        public void AddToPile(object item) {
            first = new Position(first, item);
        } //End AddToPile

        public object RemoveFromPile() {
            if (first == null)
            {
                throw new InvalidOperationException();
            } //End if

            object result = first.item;
            first = first.next;
            return result;
        } //End RemoveFromPile

        class Position {
            public Position next;
            public object item;
            public Position(Position next, object item)
            {
                this.next = next;
                this.item = item;
            }
        }
        
    } //End Pile

} //End namespace _02_pile_program.classes
