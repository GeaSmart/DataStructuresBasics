using System.Collections;

Console.WriteLine("Identifying the Data Structures in .NET");
Console.WriteLine("=======================================");

//Arrays
int[] misCalificaciones = { 15, 12, 19, 14, 9 };

string[] amigos = { "Mauricio", "Estefany", "Guillermo", "José", "Rosa" };

string[] misDirecciones = new string[3];
misDirecciones[0] = "Calle Los Laureles Nro.2432";
misDirecciones[1] = "Av. Armendáriz 439";
misDirecciones[2] = "Urb. El Portal grande Mz.T Lt.8";

//Lists
List<string> misProyectos = new List<string>();
misProyectos.Add("Sistema de planillas");
misProyectos.Add("Sistema de ventas");
misProyectos.Add("Ecommerce");
misProyectos.Add("Mobile app");

var misCursos = new List<string>() { "Cálculo", "Física eléctrica" };
misProyectos.Add("Ingeniería de software");
misProyectos.Add("Sistemas Operativos");
misProyectos.Add("Teoría general de sistemas");

//Linked List
LinkedList<String> RankingAlumnos = new LinkedList<String>();
RankingAlumnos.AddLast("Ana");//antepenúltimo
RankingAlumnos.AddLast("Jorge");//penúltimo
RankingAlumnos.AddFirst("Gerson");//2do puesto
RankingAlumnos.AddLast("Nando");//último puesto
RankingAlumnos.AddFirst("Felipe");//resultará en el 1er puesto

Console.WriteLine("Ranking of students:");
foreach (string str in RankingAlumnos)
    Console.WriteLine(str);

//Stack
var misVinos = new Stack<string>();
misVinos.Push("Rosé Santiago Queirolo");
misVinos.Push("Semi seco Tacama");
misVinos.Push("Tinto Tabernero");
misVinos.Push("Cabernet Sauvignon Terranoble");

//Dictionary
var codigosTelefonicos = new Dictionary<string, int>();
codigosTelefonicos.Add("Peru", 51);
codigosTelefonicos.Add("Colombia", 57);
codigosTelefonicos.Add("Chile", 56);
codigosTelefonicos.Add("Argentina", 54);

//Queues
var clientesParaAtender = new Queue<string>();
clientesParaAtender.Enqueue("Coco");
clientesParaAtender.Enqueue("Marcela");
clientesParaAtender.Enqueue("Hugo");
clientesParaAtender.Enqueue("María");
clientesParaAtender.Enqueue("Juan Pablo");

//Hash table
Hashtable libros=new Hashtable();
libros.Add("0-7645-2641-3", "Mi libro de matematica");
libros.Add("0-7645-2641-2", "Física IV 3da edición");
libros.Add("0-7645-2641-1", "Algebra booleana");
libros.Add("0-7645-2641-7", "Algebra clásica 4ta ed.");


//Hashset
var calificacionesValidas = new HashSet<string>();
calificacionesValidas.Add("A");
calificacionesValidas.Add("B+");
calificacionesValidas.Add("B");
calificacionesValidas.Add("C+");
calificacionesValidas.Add("C");
