﻿using LibraryProyect.DAL.Entities;

namespace LibraryProyect.DAL
{
    public class SeederDb
    {

        private readonly DataBaseContext _context;
        public SeederDb(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync(); // BD de forma automática

            await PopulateBooksAsync();
            await _context.SaveChangesAsync();
        }


    //    b.Property<string>("StudentCode")
    //    b.HasIndex("StudentCode")


        private async Task PopulateStudentsAsyn()
        {
            if (!_context.Students.Any())
            {
                _context.Students.Add(new Student { StudentCode = "AB123" });
                _context.Students.Add(new Student { StudentCode = "CD456" });
                _context.Students.Add(new Student { StudentCode = "EF789" });
                _context.Students.Add(new Student { StudentCode = "GH012" });
                _context.Students.Add(new Student { StudentCode = "IJ345" });
                _context.Students.Add(new Student { StudentCode = "KL678" });
                _context.Students.Add(new Student { StudentCode = "MN901" });
                _context.Students.Add(new Student { StudentCode = "OP234" });
                _context.Students.Add(new Student { StudentCode = "QR567" });
                _context.Students.Add(new Student { StudentCode = "ST890" });
                _context.Students.Add(new Student { StudentCode = "UV123" });
                _context.Students.Add(new Student { StudentCode = "WX456" });
                _context.Students.Add(new Student { StudentCode = "YZ789" });
                _context.Students.Add(new Student { StudentCode = "12AB3" });
                _context.Students.Add(new Student { StudentCode = "34CD6" });
                _context.Students.Add(new Student { StudentCode = "56EF7" });
                _context.Students.Add(new Student { StudentCode = "78GH0" });
                _context.Students.Add(new Student { StudentCode = "91IJ3" });
                _context.Students.Add(new Student { StudentCode = "45KL6" });
                _context.Students.Add(new Student { StudentCode = "78MN9" });
                _context.Students.Add(new Student { StudentCode = "01OP2" });
                _context.Students.Add(new Student { StudentCode = "34QR5" });
                _context.Students.Add(new Student { StudentCode = "67ST8" });
                _context.Students.Add(new Student { StudentCode = "90UV1" });
                _context.Students.Add(new Student { StudentCode = "23WX4" });
                _context.Students.Add(new Student { StudentCode = "56YZ7" });
                _context.Students.Add(new Student { StudentCode = "89AB0" });
                _context.Students.Add(new Student { StudentCode = "12CD3" });
                _context.Students.Add(new Student { StudentCode = "45EF6" });
                _context.Students.Add(new Student { StudentCode = "78GH9" });
                _context.Students.Add(new Student { StudentCode = "01IJ2" });
                _context.Students.Add(new Student { StudentCode = "34KL5" });
                _context.Students.Add(new Student { StudentCode = "67MN8" });
                _context.Students.Add(new Student { StudentCode = "90OP1" });
                _context.Students.Add(new Student { StudentCode = "23QR4" });
                _context.Students.Add(new Student { StudentCode = "56ST7" });
                _context.Students.Add(new Student { StudentCode = "89UV0" });
                _context.Students.Add(new Student { StudentCode = "12WX3" });
                _context.Students.Add(new Student { StudentCode = "45YZ6" });
                _context.Students.Add(new Student { StudentCode = "78AB9" });
                _context.Students.Add(new Student { StudentCode = "01CD2" });
                _context.Students.Add(new Student { StudentCode = "34EF5" });
                _context.Students.Add(new Student { StudentCode = "67GH8" });
                _context.Students.Add(new Student { StudentCode = "90IJ1" });
                _context.Students.Add(new Student { StudentCode = "23KL4" });
                _context.Students.Add(new Student { StudentCode = "56MN7" });
                _context.Students.Add(new Student { StudentCode = "89OP0" });
                
            }


        }


        //b.Property<string>("AutorLibro")
        //b.Property<int>("CantidadLibros")     
        //b.Property<string>("Genero")      
        //b.Property<string>("NombreLibro")      
        private async Task PopulateBooksAsync()
        {
            if (!_context.Books.Any())
            {
                // _context.Books.Add(new Book { AutorLibro = "", CantidadLibros = 0, Genero = "", NombreLibro = "" });
                _context.Books.Add(new Book { AutorLibro = "Oscar Wilde", CantidadLibros = 2, Genero = "Drama", NombreLibro = "El retrato de Dorian Gray" });
                _context.Books.Add(new Book { AutorLibro = "Oscar Wilde", CantidadLibros = 1, Genero = "Comedia", NombreLibro = "El hombre que contaba historias" });
                _context.Books.Add(new Book { AutorLibro = "Oscar Wilde", CantidadLibros = 3, Genero = "Drama", NombreLibro = "El princi" });
                _context.Books.Add(new Book { AutorLibro = "Jorge Luis Borges", CantidadLibros = 2, Genero = "Ficción", NombreLibro = "Ficciones" });
                _context.Books.Add(new Book { AutorLibro = "Franz Kafka", CantidadLibros = 2, Genero = "Ficcion", NombreLibro = "La metamorfosis" });
                _context.Books.Add(new Book { AutorLibro = "Antoine de Saint-Exupéry", CantidadLibros = 5, Genero = "Infantil", NombreLibro = "El principito" });
                _context.Books.Add(new Book { AutorLibro = "Antoine de Saint-Exupéry", CantidadLibros = 3, Genero = "Biografia", NombreLibro = "Tierra de hombres" });
                _context.Books.Add(new Book { AutorLibro = "Antoine de Saint-Exupéry", CantidadLibros = 4, Genero = "Ficcion", NombreLibro = "vuelo nocturno" });
                _context.Books.Add(new Book { AutorLibro = "Jane Austen", CantidadLibros = 6, Genero = "Novela clásica", NombreLibro = "Orgullo y prejuicio" });
                _context.Books.Add(new Book { AutorLibro = "Jane Austen", CantidadLibros = 5, Genero = "Novela clásica", NombreLibro = "Sentido y sensibilidad" });
                _context.Books.Add(new Book { AutorLibro = "Jane Austen", CantidadLibros = 1, Genero = "Novela clásica", NombreLibro = "Emma" });
                _context.Books.Add(new Book { AutorLibro = "Gabriel García Márquez", CantidadLibros = 2, Genero = " Realismo mágico", NombreLibro = "Cien años de soledad" });
                _context.Books.Add(new Book { AutorLibro = "Gabriel García Márquez", CantidadLibros = 1, Genero = " Realismo mágico", NombreLibro = "El amor en los tiempos del cólera" });
                _context.Books.Add(new Book { AutorLibro = "Gabriel García Márquez", CantidadLibros = 3, Genero = " Realismo mágico", NombreLibro = "Crónica de una muerte anunciada" });
                _context.Books.Add(new Book { AutorLibro = "Gabriel García Márquez", CantidadLibros = 2, Genero = " Realismo mágico", NombreLibro = "El otoño del patriarca" });
                _context.Books.Add(new Book { AutorLibro = "George Orwell", CantidadLibros = 2, Genero = "Distopía", NombreLibro = "Rebelión en la granja" });
                _context.Books.Add(new Book { AutorLibro = "George Orwell", CantidadLibros = 3, Genero = "Distopía", NombreLibro = "1984" });
                _context.Books.Add(new Book { AutorLibro = "J.R.R. Tolkien", CantidadLibros = 1, Genero = "Fantasía épica", NombreLibro = "El Señor de los Anillos 1" });
                _context.Books.Add(new Book { AutorLibro = "Harper Lee", CantidadLibros = 2, Genero = "Novela", NombreLibro = "Matar a un ruiseñor" });
                _context.Books.Add(new Book { AutorLibro = "William Shakespeare", CantidadLibros = 3, Genero = "Teatro", NombreLibro = "Romeo y Julieta" });
                _context.Books.Add(new Book { AutorLibro = "William Shakespeare", CantidadLibros = 2, Genero = "Teatro", NombreLibro = "Hamlet" });
                _context.Books.Add(new Book { AutorLibro = "William Shakespeare", CantidadLibros = 1, Genero = "Teatro", NombreLibro = "El sueño de una noche de verano" });
                _context.Books.Add(new Book { AutorLibro = "J.R.R. Tolkien", CantidadLibros = 3, Genero = "Fantasía épica", NombreLibro = "El Señor de los Anillos" });
                _context.Books.Add(new Book { AutorLibro = "Virginia Woolf", CantidadLibros = 2, Genero = "Feminismo", NombreLibro = "La señora Dalloway" });
                _context.Books.Add(new Book { AutorLibro = "Julio Verne", CantidadLibros = 3, Genero = "Ciencia ficción", NombreLibro = "Veinte mil leguas de viaje submarino" });
                _context.Books.Add(new Book { AutorLibro = "Emily Brontë", CantidadLibros = 2, Genero = "Romance gótico", NombreLibro = "Cumbres borrascosas" });
                _context.Books.Add(new Book { AutorLibro = "Albert Camus", CantidadLibros = 2, Genero = "Filosofía", NombreLibro = "La peste" });
                _context.Books.Add(new Book { AutorLibro = "Leo Tolstoy", CantidadLibros = 4, Genero = "Novela histórica", NombreLibro = "Guerra y paz" });
                _context.Books.Add(new Book { AutorLibro = "Miguel de Cervantes", CantidadLibros = 3, Genero = "Novela de caballerías", NombreLibro = "Don Quijote de la Mancha" });
                _context.Books.Add(new Book { AutorLibro = "Harper Lee", CantidadLibros = 2, Genero = "Novela clásica", NombreLibro = "Matar a un ruiseñor" });
                
        }
        }

    }
}
