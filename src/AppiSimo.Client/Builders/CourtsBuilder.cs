namespace AppiSimo.Client.Builders
{
    using Abstract;
    using Model;

    public class CourtsBuilder : IQueryBuilder<Court>
    {
        public string Fields =>
            "id, name, light { lightType, price, enabled, id }, heat { heatType, price, enabled, id }, enabled";

        public string BuildCreate(Court court) =>
            $@"{{
                ""court"": {{
                    ""id"":""{court.Id}"",
                    ""name"":""{court.Name}"",
                    ""lightId"":""{court.Light.Id}"",
                    ""heatId"":""{court.Heat.Id}"",
                    ""enabled"":{court.Enabled.ToString().ToLowerInvariant()}
                }}
            }}";

        public string BuildUpdate(Court court) =>
            $@"{{
                ""id"":""{court.Id}"",
                ""patch"":
                {{
                    ""name"":""{court.Name}"",
                    ""lightId"":""{court.Light.Id}"",
                    ""heatId"":""{court.Heat.Id}"",
                    ""enabled"":{court.Enabled.ToString().ToLowerInvariant()}
                }}
            }}";
    }
}