﻿namespace Domain.Entity;

public class BookCategorys
{
    public int BookId { get; set; }
    public int CategoryId { get; set; }

    public Book? Book { get; set; }
    public Category? Catigory { get; set; }
}
