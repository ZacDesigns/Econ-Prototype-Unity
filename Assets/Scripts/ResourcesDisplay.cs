namespace EconomyPrototype
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class ResourcesDisplay : MonoBehaviour
    {



        [SerializeField]
        public CurrentResources CurrentResources;


        [SerializeField]
        private Image[] m_Meters;





        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        public void OnResourceChange()
        {
            m_Meters[0].fillAmount = CurrentResources.Current.A / 100;
            m_Meters[1].fillAmount = CurrentResources.Current.B / 100;
            m_Meters[2].fillAmount = CurrentResources.Current.C / 100;
        }
    }

}
