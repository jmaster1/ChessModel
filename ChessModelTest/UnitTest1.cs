using Chess.Model;

namespace ChessModelTest;

public class Tests
{
    private Desk desk = new();
    
    [SetUp]
    public void Setup()
    {
        desk.CreateMap();
    }

    [Test]
    public void Test1()
    {
        var rook = desk.GetPieceAt(new Vector2Int(0, 0));
        Assert.AreEqual(PieceType.Rook, rook.GetPieceType());
    }
}