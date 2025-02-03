// Global Using
// 모든 프로젝트에서 반복적으로 Using 이 존재하는 경우가 많음

// 시간 측정과 같은 유틸이 많이 포함되어 있음
// 전역으로 설정해주면 프로젝트 내부의 모든 파일에서 사용할 수 있음
// global using System.Diagnostics;

// 내가 생성하지 않은 using 의 경우에는?
// console application config를 사용해서 자동으로 추가해줄 것들을 설정해줄 수 있음

var stopwatch = Stopwatch.StartNew();

for (int i = 0; i < 1000; i++)
{
    Console.WriteLine($"Loop number {i}");
}

stopwatch.Stop();
Console.WriteLine("Time in ms: " + stopwatch.ElapsedMilliseconds);