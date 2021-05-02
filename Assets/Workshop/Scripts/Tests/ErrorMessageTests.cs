using Main;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace MainTests
{
    [TestFixture]
    public class ErrorMessageTests
    {
        [Test]
        public void Should_Text_Correct_With_Custom_Text()
        {
            // Arrang
            var gameObject        = new GameObject();
            var panelErrorMessage = gameObject.AddComponent<Panel_ErrorMessage>();
            var textComponent     = gameObject.AddComponent<Text>();
            panelErrorMessage.text_ErrorMessage = textComponent;
            Assert.NotNull(panelErrorMessage.text_ErrorMessage);

            // Act
            panelErrorMessage.SetText("abc");

            // Assert
            Assert.AreEqual("abc" , textComponent.text);
        }

        [Test]
        public void Should_Open_Panel()
        {
            // Arrang
            var gameObject        = new GameObject();
            var panelErrorMessage = gameObject.AddComponent<Panel_ErrorMessage>();
            gameObject.SetActive(false);
            Assert.AreEqual(false , gameObject.activeInHierarchy);
            // Act
            panelErrorMessage.Open();
            // Assert
            Assert.AreEqual(true , gameObject.activeInHierarchy);
        }

        [Test]
        public void Should_Close_Panel()
        {
            // Arrang
            var gameObject        = new GameObject();
            var panelErrorMessage = gameObject.AddComponent<Panel_ErrorMessage>();
            gameObject.SetActive(true);
            Assert.AreEqual(true , gameObject.activeInHierarchy);
            // Act
            panelErrorMessage.Close();
            // Assert
            Assert.AreEqual(false , gameObject.activeInHierarchy);
        }
    }
}