namespace coverlet_library_sample
{
    public sealed class Calculator
    {
        /// <summary>
        /// Division method represents the breaking of x into an equal y of parts, it is not commutative and is a basic arithmetic operation.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public decimal Division(decimal x, decimal y)
        {
            return x / y;
        }

        /// <summary>
        /// Addition method represents the sum of x and y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public decimal Addition(decimal x, decimal y)
        {
            return x + y;
        }

        /// <summary>
        /// Subtraction method represents the difference of x and y, the inverse of addition.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public decimal Subraction(decimal x, decimal y)
        {
            return x - y;
        }
    }
}
