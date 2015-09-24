namespace Specification.Specifications
{
    using System;

    public class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        private Func<T, bool> expression;

        public ExpressionSpecification(Func<T, bool> expression)
        {
            this.Expression = expression;
        }

        public Func<T, bool> Expression
        {
            get
            {
                return this.expression;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Expression specification cannot be null.");
                }

                this.expression = value;
            }
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return this.Expression(candidate);
        }
    }
}
