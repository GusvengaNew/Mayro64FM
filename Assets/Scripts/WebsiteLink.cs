using UnityEngine;
using System.Collections;

namespace Gusvenga
{
	public class WebsiteLink : MonoBehaviour
	{

		public void OpenWebsite(string url)
		{
			Application.OpenURL(url);
		}
	}
}