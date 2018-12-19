using System;

namespace SKBKontur.SeleniumTesting.Tests.TestEnvironment
{
    internal class TravisEnvironment
    {
        public static bool IsExecutionViaTravis
        {
            get
            {
                if(isExecutionViaTravis == null)
                    isExecutionViaTravis = !(string.IsNullOrEmpty(Environment.GetEnvironmentVariable("TRAVIS")) && string.IsNullOrEmpty(Environment.GetEnvironmentVariable("TEAMCITY_VERSION")));
                return isExecutionViaTravis.Value;
            }
        }

        private static bool? isExecutionViaTravis;
    }
}
