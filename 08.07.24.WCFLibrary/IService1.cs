using System.ServiceModel;

namespace _08._07._24.WCFLibrary
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int HesapTopla(int Sayi1, int Sayi2);

        [OperationContract]
        int HesapCikar(int sayi1, int sayi2);

        [OperationContract]
        int HesapCarp(int sayi1, int sayi2);

        [OperationContract]
        double HesapBol(int sayi1, int sayi2);
    }
}
