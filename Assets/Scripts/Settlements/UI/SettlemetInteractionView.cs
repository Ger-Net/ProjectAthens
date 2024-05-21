using TMPro;
using UnityEngine;

namespace Assets.Scripts.Settlements.UI
{
    public class SettlemetInteractionView : MonoBehaviour
    {
        [SerializeField] private GameObject _panel;
        [SerializeField] private TextMeshProUGUI _name;

        public void UpdateInfo(Settlement settlement)
        {

        }

        public void OpenPanel()
        {
            _panel.SetActive(true);
        }
        public void ClosePanel()
        {
            _panel.SetActive(false);

        }
    }
}
