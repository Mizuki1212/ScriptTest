using UnityEngine;
using System.Collections;


public class Boss {

	//-----発展課題　:Bossクラスに変数mpとMagic関数を作成してstart関数から呼び出す

	// int型の変数mpを宣言し53で初期化

	private int mp =53;            // 魔力

	// 魔力消費用の関数




	public void Magic (int mpdamage){
		
		int magicdamage;
		if (mp >= mpdamage) {
			this.mp -= mpdamage;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);

		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}
				
public class Test : MonoBehaviour {

			void Start () {
		
		// -----課題その１ ：配列を宣言して出力する-----------

		// 要素数5の配列を初期化する
		int[] points = new int[5];

		// 配列の各要素に値を代入する
		points [0] = 22;
		points [1] = 51;
		points [2] = 8;
		points [3] = 16;
		points [4] = 33;

		// for文を使って配列の各要素を順番に表示させる
		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}

		// for文を使って配列の各要素を逆順に表示させる
		for (int i = 4; i > -1; i--) {
			Debug.Log (points [i]);
	
			}
	// -----------------------------------------------
   //-----発展課題　:Bossクラスに変数mpとMagic関数を作成してstart関数から呼び出す
		Boss lastboss = new Boss ();

		// Magic関数を10回使った後に、更にMagic関数を呼び出しMPが足りないのメッセージを表示させる



		for (int i = 0; i <= 10; i++){ 
			lastboss.Magic (5);


		}
	}

	//Update is called once per frame
		void Update () {
		}
}