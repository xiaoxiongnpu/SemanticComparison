﻿using System;
using SemanticComparison;

namespace SemanticComparisonUnitTest
{
    internal class DelegatingSpecification<T> : ISpecification<T>
    {
        internal DelegatingSpecification()
        {
            this.OnIsSatisfiedBy = x => false;
        }

        public bool IsSatisfiedBy(T request)
        {
            return this.OnIsSatisfiedBy(request);
        }

        internal Func<T, bool> OnIsSatisfiedBy { get; set; }
    }
}
