namespace MusicStream.Forms.MenuForm
{
    public static class RecommendationEngineProvider
    {
        private static RecommendationEngine recommendationEngine;

        public static void Initialize()
        {
            recommendationEngine = new RecommendationEngine();
        }

        public static RecommendationEngine GetRecommendationEngine()
        {
            return recommendationEngine;
        }
    }
}
