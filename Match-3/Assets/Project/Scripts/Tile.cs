using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public int x; //Столбцы
    public int y; //Строки
    
    public Image icon;
    public Button button;

    private Item _item;
    public Item Item
    {
        get
        {
            return _item;
        }
        set
        {
            if (_item == value) return;

            _item = value;

            icon.sprite = _item.sprite;
        }
    }

    public Tile Left => x > 0 ? Board.Instance.Tiles[x - 1, y] : null;
    public Tile Top => y > 0 ? Board.Instance.Tiles[x, y - 1] : null;
    public Tile Right => x < Board.Instance.Width - 1 ? Board.Instance.Tiles[x + 1, y] : null;
    public Tile Bottom => y < Board.Instance.Height - 1 ? Board.Instance.Tiles[x, y + 1] : null;

    public Tile[] Nighbours => new[]
    {
        Left,
        Top,
        Right,
        Bottom,
    };

    private void Start()
    {
        button.onClick.AddListener(() => Board.Instance.Select(this));
    }

    public List<Tile> GetConnectedTile(List<Tile> exclude = null)
    {
        var result = new List<Tile>{this, };

        if (exclude == null)
        {
            exclude = new List<Tile>{ this, };
        }
        else
        {
            exclude.Add(this);
        }

        foreach (var neigbour in Nighbours)
        {
            if(neigbour == null || exclude.Contains(neigbour) || neigbour.Item != Item) continue;
            
            result.AddRange(neigbour.GetConnectedTile(exclude));
        }
        
        return result;
    }
}
