namespace ChainOfResponsibility
{
    internal abstract class HandEvaluator
    {
        protected HandEvaluator Successor { get; set; }

        internal abstract void Evaluate(Hand hand);

        protected void SetSuccessor(HandEvaluator successor)
        {
            this.Successor = successor;
        }
    }
}
