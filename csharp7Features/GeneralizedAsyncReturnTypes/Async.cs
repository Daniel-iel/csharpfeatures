using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace csharp7Features.GeneralizedAsyncReturnTypes
{
    class Async
    {
        public ValueTask<int> CachedFunc()
        {
            return (cache) ? new ValueTask<int>(cacheResult) : new ValueTask<int>(LoadCache());
        }
        private bool cache = false;
        private int cacheResult;
        private async Task<int> LoadCache()
        {
            // simulate async work:
            await Task.Delay(100);
            cacheResult = 100;
            cache = true;
            return cacheResult;
        }
    }
}
