namespace EconomyPrototype
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;


    [CreateAssetMenu(menuName ="Economy Prototype/Current Resources")]
    public class CurrentResources : ScriptableObject
    {
        #region Public Fields
        [SerializeField]
        public Resource Current;
        #endregion


        public void Awake()
        {
            Restore();
        }




        #region Private Fields
        private void Restore()
        {
            Current.A = 100;
            Current.B = 100;
            Current.C = 100;
        }


        #endregion

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
