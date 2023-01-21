using System;

namespace Seventh.Desafio.Business.Entidades.Base
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }

    }
}
