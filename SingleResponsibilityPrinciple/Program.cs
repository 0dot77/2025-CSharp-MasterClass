// Single Responsibility Principle
using SingleResponsibilityPrinciple.DataAccess;

var names = new Names();
var path = new NameFilePathBuilder().BuildFilePath();
var nameFormattor = new NamesFormatter();
var stringsTextualRepository = new StringTextualRepository();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    
    // 클래스의 이름으로 기능을 설명하고, 메서드는 앞에서 읽은 클래스의 이름(기능)을 활용해
    // 쉽게 유추할 수 있도록 한다.
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exists.");
    
    // 읽기용으로만 필드를 공개하면 위험하다.
    stringsTextualRepository.Write(path, names.All);
}

// 단일 책임 원칙
// SOLID 원칙 중 하나
// 클래스는 한 가지의 일만 담당해야한다.

// Refactoring - 1 
// 하나의 책임만 가질 수 있도록 클래스를 구성하기

// 데이터를 읽고 쓰거나, 저장하거나 할 때는 Repository 이름을 사용하는 것이 좋음