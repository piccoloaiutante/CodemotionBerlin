using System;
using System.Threading.Tasks;
using RestSharp;

namespace OrangeCode.Codemotion.SpotifyViewer.Infrastructure
{
    public static class RestClientExtensions
    {
        public static Task<IRestResponse<T>> ExecuteTaskAsync<T>(this RestClient @this, IRestRequest request) where T : new()
        {
            if (@this == null)
                throw new NullReferenceException();

            var tcs = new TaskCompletionSource<IRestResponse<T>>();

            @this.ExecuteAsync<T>(request, (response) =>
                                               {
                                                   if (response.ErrorException != null)
                                                       tcs.TrySetException(response.ErrorException);
                                                   else
                                                       tcs.TrySetResult(response);
                                               });

            return tcs.Task;
        }
    }
}