namespace Specification.Specifications
{
    using System;

    public class AndSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> firstSpecification;

        private ISpecification<T> secondSpecification;

        public AndSpecification(ISpecification<T> firstSpecification, ISpecification<T> secondSpecification)
        {
            this.FirstSpecification = firstSpecification;
            this.SecondSpecification = secondSpecification;
        }

        public ISpecification<T> FirstSpecification 
        { 
            get
            {
                return this.firstSpecification;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Specification cannot be null.");
                }

                this.firstSpecification = value;
            }
        }

        public ISpecification<T> SecondSpecification 
        {
            get
            {
                return this.secondSpecification;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Specification cannot be null.");
                }

                this.secondSpecification = value;
            } 
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return this.FirstSpecification.IsSatisfiedBy(candidate) && this.SecondSpecification.IsSatisfiedBy(candidate);
        }
    }
}
