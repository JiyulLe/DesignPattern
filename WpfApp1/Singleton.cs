using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    //일반적인 싱글톤 패턴 구현 - 다중 스레드 환경에서 안전성을 확인해야 한다.
    //서로다른 A,B 스레드가 모두 if (instance == null) 조건을 만족한다면, A와 B 모두 인스턴스를 생성하게 되어 싱글톤 패턴을 위반하기 때문이다.
    public class Singleton
    {
        // 인스턴스를 저장할 정적 변수
        private static Singleton instance;

        // 다른 클래스에서 인스턴스를 생성하지 못하도록 private 생성자
        private Singleton() { }

        // 인스턴스에 접근할 수 있는 메서드
        public static Singleton Instance
        {
            get
            {
                // 인스턴스가 없으면 생성하고, 이미 있는 경우 그대로 반환
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
