using System;

namespace Seventh.Desafio.Business.Entidades.Base
{
    public abstract class Entity
    {
        
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

    }
}
