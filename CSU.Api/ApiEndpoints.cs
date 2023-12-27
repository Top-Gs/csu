﻿namespace CSU.Api
{
    public static class ApiEndpoints
    {
        private const string BaseApi = "api";

        public static class V1
        {
            private const string VersionBase = $"{BaseApi}/v1";

            public static class News
            {
                private const string Base = $"{VersionBase}/news";

                public const string Create = Base;
            }

            public static class Identity
            {
                private const string Base = $"{VersionBase}/identity";

                public const string Login = $"{Base}/login";

                public const string Register = $"{Base}/register";

                public const string RefreshToken = $"{Base}/refresh";
            }
        }
    }
}
