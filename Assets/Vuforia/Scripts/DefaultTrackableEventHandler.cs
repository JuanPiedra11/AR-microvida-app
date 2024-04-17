/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;



namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {





        #region PRIVATE_MEMBER_VARIABLES

		 
        private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
		{



            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();

            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

			//Canvas[] canvasComponents = GetComponentsInChildren <Canvas> (true);

			//foreach (Canvas component in canvasComponents) {
			//	component.enabled = true;

			//}



            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }

			Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");















			if (mTrackableBehaviour.TrackableName == "Vorticella") {
				PlayerPrefs.SetInt ("info", 1);
				PlayerPrefs.SetInt ("checkvorticela", 1);

			}

			else if (mTrackableBehaviour.TrackableName == "Euglema") {
				PlayerPrefs.SetInt ("info", 2);
				PlayerPrefs.SetInt ("checkeuglena", 1);

			} else if (mTrackableBehaviour.TrackableName == "Paramecium") {
				PlayerPrefs.SetInt ("info", 3);
				PlayerPrefs.SetInt ("checkparamecium", 1);

			} else if (mTrackableBehaviour.TrackableName == "Stentor") {
				PlayerPrefs.SetInt ("info", 4);
				PlayerPrefs.SetInt ("checkstentor", 1);

			}
			else if (mTrackableBehaviour.TrackableName == "Colpidium") {
				PlayerPrefs.SetInt ("info", 5);
				PlayerPrefs.SetInt ("checkcolpidium", 1);

			}
			else if (mTrackableBehaviour.TrackableName == "Ameba") {
				PlayerPrefs.SetInt ("info", 6);
				PlayerPrefs.SetInt ("checkameba", 1);

			}
			else if (mTrackableBehaviour.TrackableName == "Proterospongia") {
				PlayerPrefs.SetInt ("info", 7);
				PlayerPrefs.SetInt ("checkproteros", 1);

			}
			else if (mTrackableBehaviour.TrackableName == "Giardia") {
				PlayerPrefs.SetInt ("info", 8);
				PlayerPrefs.SetInt ("checkgiardia", 1);

			}
			else {



				Debug.Log ("Trackable " + mTrackableBehaviour.TrackableName + " found");
			}
        }


        private void OnTrackingLost()
        {

			// aqui cambien el true por false 
			Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

			// ARREGLO DE CANVAS PARA ELIMINAR CUANDO SALGA DEL TRACK
			//Canvas[] canvasComponents = GetComponentsInChildren <Canvas> (true);

			PlayerPrefs.SetInt ("info", 0);

			//foreach (Canvas component in canvasComponents) {
			//	component.enabled = false;
			
			//}




            // Disable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // Disable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
        }

        #endregion // PRIVATE_METHODS
    }
}
