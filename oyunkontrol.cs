using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrol : MonoBehaviour
{
    // Start is called before the first frame updatee
    int minSayi = 1;
    int maxSayi = 100;
    int tahmin;
    bool oyunBasladi = false;
    bool oyunBitti = false;
    void Start()
    
    {
        print("Benimle oyun oynamak ister misin?(E/H)");
    }

    // Update is called once per framee
    void Update()
    {
        if (!oyunBasladi) {
        //---------------Başlangıç-----------------------------------------------------
        if(Input.GetKeyDown(KeyCode.E)) {
            print("Harika! Aklından 1-100 arasında bir sayı tut ve Enter tuşuna bas!");
        }  else if (Input.GetKeyDown(KeyCode.H)) {print("Sen bilirsin!");}
        else if (Input.GetKeyDown(KeyCode.Return)) {Kontrol(); oyunBasladi = true; }

}
                //---------------Başlangıç-----------------------------------------------------
                //---------------Oyun-----------------------------------------------------
else if(!oyunBitti) {
        if(Input.GetKeyDown(KeyCode.UpArrow)) {minSayi = tahmin;
        Kontrol();

        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxSayi = tahmin;
            Kontrol();



        }

        else if (Input.GetKeyDown(KeyCode.Space)) 
        {
            print("Yaşasın, aklındaki sayıyı buldum.");
            oyunBitti=true;
        }
                        //---------------Oyun-----------------------------------------------------
        }
        void Kontrol() 
        {tahmin= (minSayi + maxSayi) / 2;
        print("Aklından tuttuğun sayı" + tahmin + "mi? Daha büyük ise yukarı, daha küçük ise aşağı yön tuşuna bas! Doğruysa boşluk tuşuna bas!" );} 
    }
}
