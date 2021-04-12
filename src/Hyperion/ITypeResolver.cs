using System;

namespace Hyperion {
    public interface ITypeResolver {

        Type GetType(string typename, bool throwOnError);
    }
}