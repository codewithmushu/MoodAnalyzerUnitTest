using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Test
{
    public class MoodAnalyzeTest
    {
        
        MoodAnalyse moodAnalyse = new MoodAnalyse();
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            string result = moodAnalyse.AnalyseMood("Im in Sad mood.");
            Assert.AreEqual(result,"Sad");
        }
    }
}
