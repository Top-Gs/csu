namespace CSU.Api
{
    public static class ApiEndpoints
    {
        private const string BaseApi = "api";

        public static class V1
        {
            private const string VersionApi = $"{BaseApi}/v1";

            public static class News
            {
                private const string Base = $"{VersionApi}/news";

                public const string Create = Base;
                public const string Get = $"{Base}/{{id:guid}}";
                public const string GetAll = Base;
                public const string Update = $"{Base}/{{id:guid}}";
                public const string Delete = $"{Base}/{{id:guid}}";
            }
        }
    }
}
