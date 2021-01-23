using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface arayüz demek şablon
    //Okunurluğunu anlamak için interfacelerin başına I harfigelir
    //eğerki birisi bu interfacei kullanırsa bu arkadaş aşağıdaki metotları kullanmalı
    interface ICreditManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
