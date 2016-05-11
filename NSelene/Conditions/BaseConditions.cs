﻿using System.Linq;

namespace NSelene
{
    namespace Conditions
    {

        // TODO: find the way to DRY conditions:) Generics? keep it simple enough though...

        public abstract class Condition<TEntity>
        {

            public abstract bool Apply(TEntity entity);

            public override string ToString()
            {
                return string.Format("{0}", this.GetType());
            }
        }

        public abstract class DescribedCondition<TEntity> : Condition<TEntity>
        {
//            public abstract string DescribeActual();

//            public abstract string DescribeExpected();


            public virtual string DescribeActual()
            {
                return false.ToString(); // TODO: consider providing more "universal" approach... because this makes sense only in case of failed condition:(
            }

            public virtual string DescribeExpected()
            {
                return true.ToString();
            }

            public override string ToString()
            {
                return string.Format("{0}" +
                    "\n Expected: {1}" +
                    "\n Actual: {2}", 
                    this.GetType().Name, DescribeExpected(), DescribeActual());
            }

        }

    }

}
