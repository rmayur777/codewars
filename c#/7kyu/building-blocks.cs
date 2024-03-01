// Write a class Block that creates a block (Duh..)
// Requirements

// The constructor should take an array as an argument, this will contain 3 integers of the form [width, length, height] from which the Block should be created.

// Define these methods:

// `GetWidth()` return the width of the `Block`

// `GetLength()` return the length of the `Block`

// `GetHeight()` return the height of the `Block`

// `GetVolume()` return the volume of the `Block`

// `GetSurfaceArea()` return the surface area of the `Block`

class Block
{
    private readonly int _width;
    private readonly int _length;
    private readonly int _height;

    public Block(int[] dimensions)
    {
        _width = dimensions[0];
        _length = dimensions[1];
        _height = dimensions[2];
    }

    public int GetWidth()=> _width;
    public int GetHeight()=> _height;
    public int GetLength()=> _length;
    public int GetVolume() => _width * _height * _length;
    public int GetSurfaceArea() => 2 * (_width * _length + _height * length + _width * _height)

}