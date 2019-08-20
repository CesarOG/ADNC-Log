using SharpRaven;
using SharpRaven.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSOFT.Log.API.Helper
{
    public static class Sentry
    {
        public static void Write(Exception ex)
        {
            RavenClient ravenClient = new RavenClient("https://1707306d5daa46febe5c873535dccf73@sentry.io/1535413");
            ravenClient.Capture(new SentryEvent(ex));
        }
    }
}
