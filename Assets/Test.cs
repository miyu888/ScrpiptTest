using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;





public class Boss
{
    private int hp = 10000;      //体力
    private int power = 25;    //攻撃力
    private int Mp = 53;       //魔法ゲージ

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }




    public void Magic()
    {
        //mpが5以上あれば消費
        if (Mp > 5)
        {
            Mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + Mp);
        }
        //足りない場合は消費できない
        else if (Mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }


}






public class Test : MonoBehaviour
{

    //「goodbye UnityChan」と表示する関数
    void goodbye()
    {
        Debug.Log("Goodbye, UnityChan");
    }



    //「HELLO」に続けて因数の数字を表示する関数
    void HelloName(int name)
    {
        Debug.Log("Hello, " + name.ToString());
    }


    //第一引数と第二引数の値を足した値を返す関数
    int Add(int a1, int b1, int c1)
    {
        //第一引数と第二引数の値を足して、変数ｃに代入する
        int d1 = a1 + b1 + c1;
        //変数ｃを呼び出し元の関数に返す
        return d1;
    }




    // Start is called before the first frame update, use this for initialization
    void Start()
    {
    
        //コンソール内にHello, worldと表示
        Debug.Log("Hello,world");

        //変数の宣言
        int score;
        //変数の代入
        score = 150;
        //コンソールに変数の中身を表示
        Debug.Log(score);

        //変数を初期化する
        int a = 3;
        int b = 4;
        //変数aと変数bの合計値を変数cに代入する
        int c = a + b;
        //変数cを表示する
        Debug.Log(c);


        //moneyを200で初期化する
        int money = 100;

        if (money <= 50)
        {
            //moneyが50以下だった場合の処理
            Debug.Log("武器を売る");
        }
        else if (money >= 200)
        {
            //moneyが200以上だった場合の処理
            Debug.Log("武器を買う");
        }
        else
        {
            //それ以外の場合の処理
            Debug.Log("ポーションを買う");
        }


        //numを1で初期化する
        int num = 1;
        //valに代入する値を条件によって変える（三項演算子）
        int val = (num == 1) ? -100 : 100;
        //valの値を表示する
        Debug.Log(val);


        if (a == 3)
        {
            //変数が3の場合、変数xを5で初期化する
            int x = 5;
            //変数xの値を表示する
            Debug.Log(x);
        }


        //5回処理を繰り返す
        for (int i = 0; i < 5; i ++)
        {
            Debug.Log(i);
        }


        //sumを0で初期化する
        int sum = 0;
        //10回処理を繰り返す
        for( int i =1; i <= 10; i++)
        {
            //iの値をsumに足す
            sum  += i;
        }
        //sumの値を表示する
        Debug.Log(sum);





        //配列を初期化する
        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        //配列の要素数の分だけ処理を繰り返す
        for(int i = 0; i < points.Length; i++)
        {
            //配列の要素が50以上の場合
            if(points[i] >= 50 )
            {
                //配列の要素を表示する
                Debug.Log(points[i]);
            }
        }


        {
            //Goodbye関数を呼び出す
            goodbye();
        }


        {
            //HELLONAME関数に値を渡す
            HelloName(14);
        }

        {
            //Add関数に「３」と「６」の引数を渡し、返り値をnum関数に代入する
            int renew = Add(3, 6, 15);
            //numを表示する
            Debug.Log(renew);
        }


        {
            //Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

            //攻撃用の関数を呼び出す
            lastboss.Attack();
            //防御用の関数を呼び出す
            lastboss.Defence(3);

            for (int i = 0; i < 11; i++)
            {
                lastboss.Magic();
            }

        }



        {
            //Middle Boss を宣言
            Boss middleboss = new Boss();

            //攻撃用
            middleboss.Attack();
            //防御用
            middleboss.Defence(8);

        }



        {
            //練習

            //int型の配列を初期化
            int[] array = { 53, 27, 32, 68, 49 };
            //配列の各要素の値を順に表示
            for (int y = 0; y < array.Length; y++)
            {
                Debug.Log(array[y]);
            }
            //配列の各要素の値を逆順に表示
            for(int y = array.Length -1; 0 <= y; y--)
            {
                Debug.Log(array[y]);
            }
        }

    }
    
    
　

    // Update is called once per frame
    void Update()
    {

    }

}