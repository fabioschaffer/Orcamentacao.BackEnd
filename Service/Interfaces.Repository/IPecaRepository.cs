using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Repository;

public interface IPecaRepository {
    void CriarPeca(Peca peca);
}
