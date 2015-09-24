namespace Specification.Specifications
{
    using System;

    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> specification;

        public NotSpecification(ISpecification<T> specification)
        {
            this.Specification = specification;
        }

        public ISpecification<T> Specification 
        { 
            get
            {
                return this.specification;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Specification cannot be null.");
                }

                this.specification = value;
            }
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return !this.Specification.IsSatisfiedBy(candidate);
        }
    }
}
