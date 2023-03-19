namespace BTH03_12.Models.Process;

public class GiaiPhuongTrinhBac2{
    public string GiaiPhuongTrinhBac(string hesoA, string hesoB, string hesoC)
    {
      double delta,x1,x2, a = 0, b = 0, c = 0;

          if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
          if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
          if(!String.IsNullOrEmpty(hesoA)) c = Convert.ToDouble(hesoC);
          if(a == 0){
           return  "Khong phai phuong tring bac 2";}
           else{

          delta = b*b - (4 * a* c);
             if(delta ==0) {
              x1=(-b)/(2*a);
                 return  "Phuong trinh co 1 nghien" + x1;
            }else if(delta >0){
              x1 =(-b + Math.Sqrt(delta))/(2*a);
              x2 =(-b - Math.Sqrt(delta))/(2*a);
                return  "Phuong trinh co 2 nghiem: x1: "+ x1 + " và x2: "+ x2;
            }else{
                return  "Phuong trinh vo nghiem";
      }

    }
}
}