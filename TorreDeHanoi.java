import java.util.*;

public class TorreDeHanoi {
  
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int NDicos;

        System.out.println("Ingrese el numero de discos: ");
        NDicos = scanner.nextInt();

        TorreDeHanoi(NDicos,1,2,3);
    }

public static void TorreDeHanoi(int NDicos, int origen,  int auxiliar, int destino) {

  if(NDicos==1)

  System.out.println("mover disco de " + origen + " a " + destino);

  else{
    TorreDeHanoi(NDicos-1, origen, destino, auxiliar);

     System.out.println("mover disco de "+ origen + " a " + destino);

     TorreDeHanoi(NDicos-1, auxiliar, origen, destino);

   }

 }

}