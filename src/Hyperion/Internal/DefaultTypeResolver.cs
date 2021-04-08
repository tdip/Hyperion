using System;

namespace Hyperion.Internal {
    internal class DefaultTypeResolver : ITypeResolver {

        public static ITypeResolver Instance = new DefaultTypeResolver();

        public Type GetType(string typename, bool throwOnError) {

            try {
                return Type.GetType(typename, true);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}