using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    // 옵저버 인터페이스
    public interface IObserver
    {
        void Update();
    }

    // 주제(Subject) 또는 상태 변경을 감지하는 객체
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int state;

        public int State
        {
            get { return state; }
            set
            {
                state = value;
                NotifyObservers();
            }
        }
        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }
    }

    // 구체적인 옵저버 클래스
    public class ConcreteObserver : IObserver
    {
        private string name;
        private Subject subject;
        TextBox textBox;

        public ConcreteObserver(string name, Subject subject, TextBox textBox)
        {
            this.name = name;
            this.subject = subject;
            this.subject.Attach(this);
            this.textBox = textBox;
        }
        public void Update()
        {
            textBox.Text += $"{name} received update. New state: {subject.State}\n";
        }
    }
}
