// yes this is one of my previous deliverables with the logic moved into a class file, im running out of ideas and this fits the bill.

using System;
using fish_search;

Console.Write("Fish search: ");
string? searchTerm = Console.ReadLine();
string searchReturnValue = FishList.Search(searchTerm);

Console.WriteLine(searchReturnValue);