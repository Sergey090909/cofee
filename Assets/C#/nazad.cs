using System;
using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class nazad : MonoBehaviour
{
    private InterstitialAd ad;
   
    private const string gameOverAd = "ca-app-pub-9531651273568222/7501864239";

    public GameObject panel0; bool panel00 = false;

    public GameObject panel1; bool panel11 = false;
  
    public GameObject panel2; bool panel22 = false;

    public GameObject panel3; bool panel33 = false;

    public GameObject panel4; bool panel44 = false;

    public GameObject panel5; bool panel55 = false;

    public GameObject panel6; bool panel66 = false;

    public GameObject panel7; bool panel77 = false;

    public GameObject panel8;  bool panel88 = false;

    public GameObject panel9; bool panel99 = false;




    void Start()
    {
          RequestBanner();
    }

     private void RequestBanner()
      {
          string adUnitId = "ca-app-pub-9531651273568222/4441775990";

          BannerView bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
          AdRequest request = new AdRequest.Builder().Build();

          bannerView.LoadAd(request);
      }

    void Update()

    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (panel00 == true)
            {
                panel00 = false;
                reklama();
                panel0.SetActive(!panel0.activeSelf);
            }
            else
            {
                if (panel11 == true)
                {
                    panel11= false;
                    reklama();
                    panel1.SetActive(!panel1.activeSelf);
                }
                else
                {
                    if (panel22 == true)
                    {
                        panel22 = false;
                        reklama();
                        panel2.SetActive(!panel2.activeSelf);
                    }
                    else
                    {
                        if (panel33 == true)
                        {
                            panel33 = false;
                            reklama();
                            panel3.SetActive(!panel3.activeSelf);
                        }
                        else
                        {
                            if (panel44== true)
                            {
                                panel44 = false;
                                reklama();
                                panel4.SetActive(!panel4.activeSelf);
                            }
                            else
                            {
                                if (panel55 == true)
                                {
                                    panel55 = false;
                                    reklama();
                                    panel5.SetActive(!panel5.activeSelf);
                                }
                                else
                                {
                                    if (panel66 == true)
                                    {
                                        panel66 = false;
                                        reklama();
                                        panel6.SetActive(!panel6.activeSelf);
                                    }
                                    else
                                    {
                                        if (panel77 == true)
                                        {
                                            panel77 = false;
                                            reklama();
                                            panel7.SetActive(!panel7.activeSelf);
                                        }
                                        else
                                        {
                                            if (panel88 == true)
                                            {
                                                panel88= false;
                                                reklama();
                                                panel8.SetActive(!panel8.activeSelf);
                                            }
                                            else
                                            {
                                                if (panel99 == true)
                                                {
                                                    panel99 = false;
                                                    reklama();
                                                    panel9.SetActive(!panel9.activeSelf);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
           
           
          
        }

    }

    public void reklama()
    {






            ad = new InterstitialAd(gameOverAd);
            AdRequest request = new AdRequest.Builder().Build();
           
            ad.LoadAd(request);

            ad.OnAdLoaded += OnAdLoaded;

            ad.Show();
           




    }

    public void OnAdLoaded(object senber, EventArgs args)
    {
        ad.Show();
    }
    
    public void rrr()
    {
        panel0.SetActive(!panel0.activeSelf);
        panel00 = true;
       
    } 
    public void rrr1()
    {
        panel1.SetActive(!panel1.activeSelf);
        panel11 = true;
       
    }
    public void rrr2()
    {
        panel2.SetActive(!panel2.activeSelf);
        panel22 = true;
       
    }
    public void rrr3()
    {
        panel33 = true;
        panel3.SetActive(!panel3.activeSelf);
    }
    public void rrr4()
    {
        panel44 = true;
        panel4.SetActive(!panel4.activeSelf);
    }
    public void rrr5()
    {
        panel55 = true;
        panel5.SetActive(!panel5.activeSelf);
    }
    public void rrr6()
    {
        panel66 = true;
        panel6.SetActive(!panel6.activeSelf);
    }
    public void rrr7()
    {
        panel77 = true;
        panel7.SetActive(!panel7.activeSelf);
    }
    public void rrr8()
    {
        panel88 = true;
        panel8.SetActive(!panel8.activeSelf);
    }
    public void rrr9()
    {
        panel99 = true;
        panel9.SetActive(!panel9.activeSelf);
    }
    public void OnMouseDown()
    {
        
       Application.LoadLevel(1);
      
    }
    public void recl()
    {
        ad = new InterstitialAd(gameOverAd);
        AdRequest request = new AdRequest.Builder().Build();

        ad.LoadAd(request);

        ad.OnAdLoaded += OnAdLoaded;

        ad.Show();
       
    }
}