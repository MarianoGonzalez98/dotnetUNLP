//correcta
class A{
    static int s_a=0;
    static A() {
    s_a++;
    }
    public A() {
    s_a++;
    }
}

class B {
    static int s_b = 0;
    public static B() { //tiene un modificador de acceso public (no se permite ni sentido tiene)
    s_b++;
    }
    B() {
    s_b++;
    }
}

class C {
    static int s_a = 0;
    static C(int a) { //Un constructor estatico no puede tener parametros
        s_a=a;
    }
    C(int a) { // es un constructor de instancia??
        s_a = a;
    }
}

class D {
    static int s_D = 0;
    int d = 0;
    static D() {
        s_D = 30;
    }
    D(int D) { //constructor normal de instancia?
        s_D = D;
        this.d = d;
    }
}