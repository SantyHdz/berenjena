//creacion de clases con los atributos de un libro
public class libro{
    // establece atributos de libro
    private string titulo, autor;
    // establece atributos de libro
    private int IBSN, npages;

//creacion de get que  se ejecuta cuando se lee la propiedad.  
    public string gettitulo(){
        // retorna la promesa
        return (this.titulo);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public string settitulo(string nombrel){
    // retorna la promesa
        return this.titulo=nombrel;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public string getautor(){
        // retorna la promesa
        return (this.autor);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public string setautor(string nombrea){
    // retorna la promesa
        return this.autor=nombrea;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public int getIBSN(){
        // retorna la promesa
        return (this.IBSN);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public int setIBSN(int ncode){
    // retorna la promesa
        return this.IBSN=ncode;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public int getnpages(){
        // retorna la promesa
        return this.npages;
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public int setnpages(int npagi){
    // retorna la promesa
        return this.npages=npagi;
}
//creacion de la consulta por autor de libro
public void tostring(){ 
    // muestra en pantalla la concantenacion de los valores
    Console.WriteLine("El libro "+this.titulo+" con ISBN "+this.IBSN+" creado por el autor "+this.autor+" tiene "+this.npages+" páginas.");
    // Fin
}
// Fin
}