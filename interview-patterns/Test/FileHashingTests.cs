using System.Reflection;
using FluentAssertions;
using Lib;

namespace Test;
public class FileHashingTests
{
    [Fact]
    public void When_Files_Differ_Only_By_Whitespace_Hashes_Are_Equal()
    {
        var hash1 = FileHashing.Hash(ReadTestDataFile("FileHashing01.json"));
        var hash2 = FileHashing.Hash(ReadTestDataFile("FileHashing02.json"));

        hash1.Should().Be(hash2);
    }

    [Fact]
    public void When_Files_Differ_By_Single_NonWhitespace_Character_Hashes_Are_Different()
    {
        var hash1 = FileHashing.Hash(ReadTestDataFile("FileHashing01.json"));
        var hash2 = FileHashing.Hash(ReadTestDataFile("FileHashing03.json"));

        hash1.Should().NotBe(hash2);
    }

    private static string ReadTestDataFile(string fileName)
    {
        return File.ReadAllText(GetTestDataFilePath(fileName));
    }

    private static string GetTestDataFilePath(string fileName)
    {
        var testDataFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "TestData");
        return Path.Combine(testDataFolder, fileName);
    }
}

