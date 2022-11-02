using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Acme.BookStore.Dtos;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();

        CreateMap<CreateUpdateBookDto, Book>();
        
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        CreateMap<Author, AuthorDto>();

        CreateMap<Author, AuthorLookupDto>();

    }
}
