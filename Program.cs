using System.Numerics;

#region Vars

StaticEntity Goblin = new StaticEntity();

Player @player = new Player();

#endregion


while (true)
{
    
}

internal class Funcs
{
    
}

#region 

internal class Player : Entity
{
    internal Player(string name, BigInteger power, EntityId entity) : base(name, power, entity)
    {
        
    }
}

internal 

internal class Entity
{
    private string _name;
    private BigInteger _power;
    private EntityId _entity;
    internal Entity(string name,BigInteger power,EntityId entity)
    {
        _name = name;
        _power = power;
        _entity = entity;
    }
    internal Entity FromStatic(StaticEntity staticEntity)
    {
        return new Entity(staticEntity._name,staticEntity._power,staticEntity._entity);
    }

    internal static bool Fight(Entity defender,Entity fighter)
    {
        return true;
    }
}

internal struct StaticEntity
{
    internal string _name;
    internal BigInteger _power;
    internal EntityId _entity;
    internal BigInteger _mhp;

    internal StaticEntity(string name,BigInteger power,EntityId entity)
    {
        _name = name;
        _power = power;
        _entity = entity;
    }
}

internal enum EntityId
{
    Player,
    Zombie,
    Goblin,
}

#endregion