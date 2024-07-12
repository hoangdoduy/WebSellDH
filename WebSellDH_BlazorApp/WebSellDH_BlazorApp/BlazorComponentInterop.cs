using Microsoft.JSInterop;

namespace WebSellDH_BlazorApp
{
    public class BlazorComponentInterop
    {
        private readonly IJSRuntime jsRuntime;

        public BlazorComponentInterop(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public class DomElement
        {
            private readonly string selector;
            private readonly IJSRuntime jsRuntime;

            public DomElement(string selector, IJSRuntime jsRuntime)
            {
                this.selector = selector;
                this.jsRuntime = jsRuntime;
            }

            public async Task InvokeVoid(string method, params object[] args)
            {
                await jsRuntime.InvokeVoidAsync("$(selector)." + method, args);
            }
        }
    }
}
