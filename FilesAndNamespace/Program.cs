// Global Namespace
// 우리가 선언하는 모든 유형을 담는 거대한 상자로 상상할 수 있음
// 서로 관련된 유형은 동일한 네임스페이스 내에 포함되어야 함

// 전체 네임스페이스를 지정해야 해당 네임스페이스에 존재하는 클래스를 가져올 수 있음
using FilesAndNamespace.DataAccess;

var stringTextualRepository = new StringsRepository();