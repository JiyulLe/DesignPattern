# 디자인 패턴

여러 소프트웨어 개발자들이 공통적으로 겪는 문제를 해결하기 위해 만들어졌습니다.
설계 문제에 대한 해결책을 제공하며, 개발자들이 특정 상황에서 적절한 설계 결정을 내리는 데 도움을 줍니다.

- 싱글톤 패턴(Singleton Pattern)

특정 클래스에 객체 인스턴스가 하나만 만들어지도록 해주는 패턴입니다.
싱글턴 패턴을 사용하면 전역 변수를 사용할 때와 마찬가지로 객체 인스턴스를 어디서든지 액세스 할 수 있게 만들 수 있습니다.

- 옵저버 패턴(Observer Pattern)

한 객체의 상태가 바뀌면 그 객체에 의존하는 다른 객체에게 연락이 가고 자동으로 내용이 갱신되는 방식으로 일대다 의존성을 정의합니다.
옵저버 패턴은 한 객체의 상태 변화를 감지하여 다른 객체들에게 알리는 메커니즘을 제공합니다.
