using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my1101
{
    class Base//gildong
    {
        public void xxx()
            /*public을 붙혀줘야 메인함수가 있는 클래스에서도 사용가능*/
        {
            System.Console.WriteLine("hello,world!");
        }
    }
    class Derived:Base
    {
        //베이스안에 것들이 다 들어옴 숨겨져잇는 xxx가 있음
        //눈에 보이는 멤버만 멤버인것이 아님

    }
    /*class Derived2 : Derived
    {
        //마찬가지
    }*/
    class PPP
    { 
        static void Main(string[] args)/*메인함수가 안에 잇숨니다클래스안에서 문제가 생겻어
            클래스는 객체 만들라고 있는것 객체가 있어야 메인을 호출할수 있는데 객체를 만들려면 실행되는
            코드가 있어야해 메인 함수를 static함수로 만들자 그럼 객체없이도 메인이 실행 될수잇음 객체
            만들려면 메인에서 만들어야 하는데 그럴려면 메인이 실행되야되고 그러니까 객체 없이 만들수 있게
            하자 */
        {
            Derived gildong = new Derived();//Base로 길동이 만드나 Derived로 길동이 만드나 똑같음
            gildong.xxx();
            
        }
    }
}
