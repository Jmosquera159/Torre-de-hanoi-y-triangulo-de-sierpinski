def Hanoi (discos,origen=1,auxiliar=2,destino=3):
    
    if discos==1:
        print (origen,"a",destino)
        
    else:
        Hanoi(discos-1,origen,destino,auxiliar)
        print(origen,"a",destino)
        Hanoi (discos-1,auxiliar,origen,destino)
    return

Hanoi(3)