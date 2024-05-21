using Assets.Scripts.Settlements.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Settlements
{
    public class SettlementInteraction : MonoBehaviour
    {
        [SerializeField] private SettlemetInteractionView _view;

        
        public void Open()
        {
            _view.OpenPanel();
        }
        public void Close()
        {
            _view.ClosePanel();
        }
    }
}
