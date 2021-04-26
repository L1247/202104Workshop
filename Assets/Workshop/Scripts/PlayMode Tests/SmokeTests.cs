using System.Collections;
using NUnit.Framework;
using Unity.RecordedTesting;
using Unity.RecordedTesting.TestTools;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class SmokeTests : RecordedTestSuite
    {
        [UnityTest]
        [RecordedTest("Recordings/load_tutorial.json.json")]
        public IEnumerator validate_tutorial_loads_And_Button_Is_Clicked()
        {
            SceneManager.LoadScene("0_Title");
            SceneManager.LoadScene("Tutorial" , LoadSceneMode.Additive);

            //wait until the Tutorial scene loads
            do
            {
                yield return null;
            } while (SceneManager.GetActiveScene().name == "Tutorial");

            var gameObject = GameObject.Find("Button");
            Assert.NotNull(gameObject);
            yield return new WaitForSeconds(2);
            var activeInHierarchy = gameObject.activeInHierarchy;
            Assert.AreEqual(false , activeInHierarchy);
        }
    }
}