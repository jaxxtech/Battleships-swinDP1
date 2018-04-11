public class Ship
{
    private ShipName _shipName;
    private int _sizeOfShip;
    private int _hitsTaken = 0;
    private List<Tile> _tiles;
    private int _row;
    private int _col;
    private Direction _direction;
    public string Name
    {
        private get
        {
            if (_shipName == ShipName.AircraftCarrier)
            {
                return "Aircraft Carrier";
            }

            return _shipName.ToString();
        }
    }

    public int Size
    {
        private get
        {
            return _sizeOfShip;
        }
    }

    public int Hits
    {
        private get
        {
            return _hitsTaken;
        }
    }

    public int Row
    {
        private get
        {
            return _row;
        }
    }

    public int Column
    {
        private get
        {
            return _col;
        }
    }

    public Direction Direction
    {
        private get
        {
            return _direction;
        }
    }

    public Ship(ShipName ship)
    {
        _shipName = ship;
        _tiles = new List<Tile>();
        _sizeOfShip = _shipName;
    }

    public void AddTile(Tile tile)
    {
        _tiles.Add(tile);
    }

    public void Remove()
    {
        foreach (Tile tile in _tiles)
        {
            tile.ClearShip();
        }

        _tiles.Clear();
    }

    public void Hit()
    {
        _hitsTaken = _hitsTaken + 1;
    }

    public bool IsDeployed
    {
        private get
        {
            return _tiles.Count > 0;
        }
    }

    public bool IsDestroyed
    {
        private get
        {
            return Hits == Size;
        }
    }

    internal void Deployed(Direction direction, int row, int col)
    {
        _row = row;
        _col = col;
        _direction = direction;
    }
}