using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
