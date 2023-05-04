////using Study_42_43;
////using System;


////namespace PartialClassDemo
////{
////    class PartialClassDemo
////    {
////        static void Main()
////        {
////            var hello = new Hello();
////            hello.Hi();
////            hello.Bye();
////        }
////    }
////}

//using System;

//namespace ConstructorInheritance
//{
//    public class Parent
//    {
//        public string Word { get; set; }
//        public Parent(string word) // 생성자로 속성을 초기화
//        {
//            this.Word = word;
//        }
//    }

//    public class Child : Parent
//    {
//        //[1] this() 형태로, 나 자신의 매개변수가 있는 생성자에게 기본 문자열 전달
//        public Child() : this("[1] 매개변수가 없는 생성자 실행") { }

//        //[2] base() 형태로, 매개변수 값을 부모 클래스의 매개변수가 있는 생성자에게 전달 
//        public Child(string message) : base(message) { }
//        public void Say() => Console.WriteLine(base.Word); // 부모의 World 속성 출력
//    }

//    class ConstructorInheritance
//    {
//        static void Main()
//        {
//            (new Child()).Say();
//            (new Child("[2] 매개변수가 있는 생성자 실행")).Say();
//        }
//    }
//}


using System;

namespace FieldHiding
{
    class Parent
    {
        //[1] 필드 숨김: 필드는 무조건 private으로 설정
        private string _word;

        //[2] protected는 자식 클래스에서만 호출 가능한 멤버
        protected string Word
        {
            get { return _word; }
            set { _word = value; }
        }
    }

    class Child : Parent
    {
        public void SetWord(string word)
        {
            base.Word = word;
        }
        public string GetWord()
        {
            return Word; // 부모 클래스의 Word 속성 접근
        }
    }

    class FieldHiding
    {
        static void Main()
        {
            Child child = new Child();
            child.SetWord("필드 숨기기 및 자식 클래스에게만 멤버 상속하기");
            Console.WriteLine(child.GetWord());
        }
    }
}
