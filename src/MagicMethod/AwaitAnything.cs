using System;
using System.Runtime.CompilerServices;

namespace MagicMethod {
    public static class AwaiterExtensions {
        public static Awaiter<int> GetAwaiter(this int val) {
            return new Awaiter<int>(val);
        }
    }

    public class Awaiter<T> : INotifyCompletion {
        private string value;
        public Awaiter(T val) {
            value = val.ToString() + " 555";
        }

        public bool IsCompleted { get { return true; } }
        public void OnCompleted(Action func) {

        }
        public string GetResult() {
            return value;
        }
    }
}