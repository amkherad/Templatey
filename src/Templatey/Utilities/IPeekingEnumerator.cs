using System.Collections.Generic;

namespace Templatey.Utilities
{
    public interface IPeekingEnumerator<T> : IEnumerator<T>
    {
        T Next { get; }

        bool TryPeek(
            out T next
        );
    }
}