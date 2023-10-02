namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(Dtos.Requests.ClienteDto clienteDto);
        void Update(Dtos.Requests.ClienteDto clienteDto);
        void Remove(Dtos.Requests.ClienteDto clienteDto);
        IEnumerable<Dtos.Responses.ClienteDto> GetAll();
        Dtos.Responses.ClienteDto FindById(int id);
    }
}
