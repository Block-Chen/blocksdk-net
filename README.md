# C# REST API SDK for BLOCKSDK V3
[![@BLOCKSDK on Facebook](https://img.shields.io/badge/facebook-%40BLOCKSDK-blue.svg)](https://www.facebook.com/blocksdk)
[![NuGet downloads](https://img.shields.io/nuget/dt/BLOCKSDK)](https://www.nuget.org/packages/BLOCKSDK)

__BlockSDK C#__에 오신 것을 환영합니다. 이 저장소에는 BlockSDK의 C# SDK와 REST API용 샘플이 포함되어 있습니다.

## 지원중인 블록체인 네트워크
비트코인 , 라이트코인 , 비트코인 캐시 , 웹후크 는 V2버전 에서 지원되고 있습니다.
```
1.이더리움
2.클레이튼  
3.바이낸스 스마트 체인
4.폴리곤
5.아발란체
6.이더리움 클래식
```
## 개발자 문서
* [BlockSDK REST API V3 문서](https://documenter.getpostman.com/view/20292093/Uz5FKwxw)
* [BlockSDK REST API V2 문서](https://docs-v2.blocksdk.com/ko/#fa255f0ccc)
* [BLOCKSDK C# SDK V3 문서](https://github.com/Block-Chen/blocksdk-net/wiki)

## 시작하기

### NuGet을 사용하여 패키지 설치

#### Package Manager Console을 사용하는 경우
```sh
Install-Package blocksdk-net
```
#### .NET CLI를 사용하는 경우
```shell
dotnet add package blocksdk-net
```
#### Visual Studio를 사용하는 경우
```
1. NuGet Package Manager를 엽니다.
2. Browse 탭에서 blocksdk-net을 검색합니다.
3. 찾은 패키지를 선택하고 Install 버튼을 클릭합니다.
```

## 코드 샘플

### 이더리움 테스트넷 클라이언트 생성
```cs
var ethereumClient = new BlockSDK.Ethereum("YOU_TOKEN");
```

### 이더리움 메인넷 클라이언트 생성
```cs
var ethereumClient = new BlockSDK.Ethereum("YOU_TOKEN","https://mainnet-api.blocksdk.com");
```

### 이더리움 블록체인 정보 가져오기
```cs
const result = await ethereumClient.GetBlockChainInfo();
```

### 이더리움 테스트넷 특정 컨트렉트 NFT 목록 가져오기
```cs
var result = await blocksdk.GetSingleNfts(new Dictionary<string, object>
{
    { "contract_address", "0xf5de760f2e916647fd766b4ad9e85ff943ce3a2b" },
    { "offset", 0 },
    { "limit", 10 }
});
```