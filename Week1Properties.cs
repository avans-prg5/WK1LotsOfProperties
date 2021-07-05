namespace WK1LotsOfProperties
{
    public class Week1Properties
    {
        private string readAndWritePropertyWithMethods;
        private string readAndWritePropertyFullLambda;
        private string readAndWritePropertyFull;

        /// <summary>
        /// Separate Set method for a private variable with room for validation
        /// </summary>
        /// <returns></returns>
        public string GetReadAndWritePropertyWithMethods()
        {
            return readAndWritePropertyWithMethods;
        }

        /// <summary>
        /// Separate Set method for a private variable with room for validation
        /// </summary>
        /// <param name="value"></param>
        public void SetReadAndWritePropertyWithMethods(string value)
        {
            readAndWritePropertyWithMethods = value;
        }
        /// <summary>
        /// Simple property with automatic getter and setter. No private variable necessary, it's magic
        /// </summary>
        public string ReadAndWriteProperty { get; set; }

        /// <summary>
        /// Property with lambda expressions (week 2 material), returns and modifies private variable.
        /// Lambda expressions can be extended with more code, but make sure code retains readability
        /// </summary>
        public string ReadAndWritePropertyFullLambda { get => readAndWritePropertyFullLambda; set => readAndWritePropertyFullLambda = value; }

        /// <summary>
        /// sets and returns a private variable, with room for validation in setter and room for formatting in getter;
        /// </summary>
        public string ReadAndWritePropertyFull {
            get {
                return readAndWritePropertyFull;
            }
            set {
                readAndWritePropertyFull = value;
            }
        }
    }
}
