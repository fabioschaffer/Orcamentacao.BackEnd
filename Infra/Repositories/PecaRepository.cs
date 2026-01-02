using Application.Interfaces.Repository;
using Domain;
using Infra.Data;

namespace Infra.Repositories;

public class PecaRepository(ApplicationDbContext context) : IPecaRepository {

    public async Task CriarPeca(Peca peca) {
        await context.Pecas.AddAsync(peca);
        await context.SaveChangesAsync();
    }

}