using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linkmanager : MonoBehaviour
{
   public void openLinkedin()
   {
    Application.OpenURL("https://www.linkedin.com/in/shubham-yadav-ab7388209");
   }
   public void openInstagram()
   {
    Application.OpenURL("https://www.instagram.com/shubham.ai1/?igshid=NGExMmI2YTkyZg%3D%3D");
   }
   public void openGit()
   {
    Application.OpenURL("https://github.com/Shubhroger482");
   }
   
   public void openYoutube()
   {
    Application.OpenURL("https://youtube.com/@Solo_leveling3");
   }
     public void makePhoneCall()
    {
        string phoneNumber = "tel:8707498816";
        Application.OpenURL(phoneNumber);
    }
}
