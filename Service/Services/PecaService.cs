using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Domain;

namespace Application.Services;

public class PecaService(IPecaRepository pecaRepository) : IPecaService {

    public void CriarPeca() {

        var peca = new Peca("1", "Peça Exemplo");

        pecaRepository.CriarPeca(peca);
    }

}
