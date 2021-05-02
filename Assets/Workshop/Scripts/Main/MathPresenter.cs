using UnityEngine;
using UnityEngine.UI;
using Utilities.Contract;

namespace Main
{
    public class MathPresenter : MonoBehaviour
    {
        private StarMath starMath;

        [SerializeField]
        private Button button_Calculate;

        [SerializeField]
        private InputField inputField_1;

        [SerializeField]
        private InputField inputField_2;

        [SerializeField]
        private Text text_Result;

        [SerializeField]
        private Panel_ErrorMessage panel_ErrorMessage;

        private void Start()
        {
            starMath = new StarMath();
            button_Calculate.onClick.AddListener(() =>
            {
                var number1 = int.Parse(inputField_1.text);
                var number2 = int.Parse(inputField_2.text);
                try
                {
                    var result = starMath.Add(number1 , number2);
                    text_Result.text = result.ToString();
                }
                catch (PreconditionViolationException e)
                {
                    panel_ErrorMessage.SetText(e.Message);
                    panel_ErrorMessage.Open();
                }
                catch (PostConditionViolationException e)
                {
                    panel_ErrorMessage.SetText(e.Message);
                    panel_ErrorMessage.Open();
                }
            });
        }
    }
}