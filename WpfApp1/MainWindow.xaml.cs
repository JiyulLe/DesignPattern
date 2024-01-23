using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Singleton Pattern
            // 싱글톤 인스턴스 생성
            Singleton singleton_instance1 = Singleton.Instance;
            Singleton singleton_instance2 = Singleton.Instance;

            // 두 인스턴스가 동일한지 확인
            bool areEqual = singleton_instance1 == singleton_instance2;
            if (areEqual)
            {
                TextBox_singleton.Text = "Singleton 구현 성공\n";
            }
            else
            {
                TextBox_singleton.Text = "Singleton 구현 실패\n";
            }

            // Observer Pattern
            // 상태 변경을 감지할 주제
            Subject subject = new Subject();

            ConcreteObserver observer1 = new ConcreteObserver("Observer 1", subject, TextBox_singleton);
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2", subject, TextBox_singleton);

            // 상태가 변경되었을 시
            subject.State = 10;
        }
    }
}