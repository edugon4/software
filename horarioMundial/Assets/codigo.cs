using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class codigo : MonoBehaviour {

    public Camera cam;
    public Dropdown dropdown;
    public Text textClock;

    string reloj;



    // Update is called once per frame
    void Update () {

        

        DateTime time = DateTime.Now;
        string hour = time.Hour.ToString().PadLeft(2, '0');
        string minute = time.Minute.ToString().PadLeft(2, '0'); ;
        string second = time.Second.ToString().PadLeft(2, '0'); ;

        int hora;
        int v;
        string h;
        
        
        //string reloj;


        switch (dropdown.value)
        {

            case 0:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 1);

                if ((hora + 1) > 24)
                {
                    v = (hora + 1) - 24;
                    if ((hora + 1) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break; 

            case 1:

                reloj = hour + ":" + minute + ":" + second;
                break;

            case 2:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 1);

                if ((hora + 1) > 24)
                {
                    v = (hora + 1) - 24;
                    if ((hora + 1) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }


                break;


            case 3:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora - 2);

                if ((hora - 2) < 0)
                {
                    v = (hora - 2) + 24;
                    if ((hora - 2) == 0)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {
                   
                    reloj = h + ":" + minute + ":" + second;

                }

                break;


            case 4:


                reloj = hour + ":" + minute + ":" + second;

                break;


            case 5:


                reloj = hour + ":" + minute + ":" + second;

                break;


            case 6:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 1);

                if ((hora + 1) > 24)
                {
                    v = (hora + 1) - 24;
                    if ((hora + 1) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;


            case 7:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 3);

                if ((hora + 3) > 24)
                {
                    v = (hora + 3) - 24;
                    if ((hora + 3) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;


            case 8:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 4);

                if ((hora + 4) > 24)
                {
                    v = (hora + 4) - 24;
                    if ((hora + 4) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;


            case 9:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 3);

                if ((hora + 3) > 24)
                {
                    v = (hora + 3) - 24;
                    if ((hora + 3) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;


            case 10:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 6);

                if ((hora + 6) > 24)
                {
                    v = (hora + 6) - 24;
                    if ((hora + 6) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;


            case 11:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 7);

                if ((hora + 7) > 24)
                {
                    v = (hora + 7) - 24;
                    if ((hora + 7) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;


            case 12:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 8);

                if ((hora + 8) > 24)
                {
                    v = (hora + 8) - 24;
                    if ((hora + 8) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;

            case 13:

                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 9);

                if ((hora + 9) > 24)
                {
                    v = (hora + 9) - 24;
                    if ((hora + 9) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;

            case 14:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 14);

                if ((hora + 14) > 24)
                {
                    v = (hora + 14) - 24;
                    if ((hora + 14) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }



                break;

            case 15:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 15);

                if ((hora + 15) > 24)
                {
                    v = (hora + 15) - 24;
                    if ((hora + 15) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }



                break;

            case 16:
                hora = Convert.ToInt32(hour);
                h = Convert.ToString(hora + 17);

                if ((hora + 17) > 24)
                {
                    v = (hora + 17) - 24;
                    if ((hora + 17) == 24)
                    {
                        v = 00;
                    }
                    reloj = v + ":" + minute + ":" + second;

                }
                else
                {

                    reloj = h + ":" + minute + ":" + second;

                }

                break;




        }

        textClock.text = reloj;
    }
}
