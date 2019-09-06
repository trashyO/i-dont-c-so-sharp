using NUnit.Framework;
using BeginnerCSharpExercises;

namespace Tests    
{
    [TestFixture]
    public class ExercisesTest 
    {
        /*Write a C# program remove specified a character from a non-empty string using index of a character. Go to the editor
        Test Data:
        w3resource
        Sample Output:
        wresource
        w3resourc
        3resource*/
        [Test]
        public void RemoveCharacterFromString()
        {
            Exercises exercise = new Exercises();
            Assert.AreEqual("wresource", exercise.RemoveChar('3', "w3resource"));
//            Assert.AreEqual("w3rsourc", exercise.RemoveChar('e', "w3resource"));
            Assert.AreEqual("3resource", exercise.RemoveChar('w', "w3resource"));
//            Assert.AreEqual("w3resource", exercise.RemoveChar('p', "w3resource"));
        }
    }
}