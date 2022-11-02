using UnityEngine;
using System.Collections;

public class Quiz
{
	public int quiz_Id; //퀴즈의 아이디
	public string quiz_Select; //문제 분야
	public int quiz_Level; //문제 난이도
	public bool multiple_Choice; //TRUE = 4지선다 or FALSE = OX구분
	public string question; //문제
	public string[] choice = new string[4]; //선택지
	public int Choice_Answer; //정답 저장
	public int score; //문제를 맞췄을때 몬스터에게 줄 데미지 
};

public class Quiz_Manager : MonoBehaviour {
	public Quiz[] my_Quiz = new Quiz[50];

	// Use this for initialization
	void Start () {
		for (int i =0; i<50; i++) {
			my_Quiz[i] = new Quiz();
		}
		my_Quiz [0].quiz_Id = 1;
		my_Quiz [0].quiz_Select = "8급";
		my_Quiz [0].quiz_Level = 2;
		my_Quiz [0].multiple_Choice = true;
		my_Quiz [0].question = "";
		my_Quiz [0].choice [0] = "두 이";
		my_Quiz [0].choice [1] = "넉 사";
		my_Quiz [0].choice [2] = "석 삼";
		my_Quiz [0].choice [3] = "한 일";
		my_Quiz [0].Choice_Answer = 4;
		my_Quiz [0].score = 100;

		my_Quiz [1].quiz_Id = 2;
		my_Quiz [1].quiz_Select = "8급";
		my_Quiz [1].quiz_Level = 2;
		my_Quiz [1].multiple_Choice = true;
		my_Quiz [1].question = "";
		my_Quiz [1].choice [0] = "두 이";
		my_Quiz [1].choice [1] = "넉 사";
		my_Quiz [1].choice [2] = "석 삼";
		my_Quiz [1].choice [3] = "한 일";
		my_Quiz [1].Choice_Answer = 1;
		my_Quiz [1].score = 100;

		my_Quiz [2].quiz_Id = 3;
		my_Quiz [2].quiz_Select = "8급";
		my_Quiz [2].quiz_Level = 2;
		my_Quiz [2].multiple_Choice = true;
		my_Quiz [2].question = "";
		my_Quiz [2].choice [0] = "두 이";
		my_Quiz [2].choice [1] = "넉 사";
		my_Quiz [2].choice [2] = "석 삼";
		my_Quiz [2].choice [3] = "한 일";
		my_Quiz [2].Choice_Answer = 3;
		my_Quiz [2].score = 100;

		my_Quiz [3].quiz_Id = 4;
		my_Quiz [3].quiz_Select = "8급";
		my_Quiz [3].quiz_Level = 2;
		my_Quiz [3].multiple_Choice = true;
		my_Quiz [3].question = "";
		my_Quiz [3].choice [0] = "두 이";
		my_Quiz [3].choice [1] = "넉 사";
		my_Quiz [3].choice [2] = "석 삼";
		my_Quiz [3].choice [3] = "한 일";
		my_Quiz [3].Choice_Answer = 2;
		my_Quiz [3].score = 100;

		my_Quiz [4].quiz_Id = 5;
		my_Quiz [4].quiz_Select = "8급";
		my_Quiz [4].quiz_Level = 2;
		my_Quiz [4].multiple_Choice = true;
		my_Quiz [4].question = "";
		my_Quiz [4].choice [0] = "여섯 육";
		my_Quiz [4].choice [1] = "일곱 칠";
		my_Quiz [4].choice [2] = "다섯 오";
		my_Quiz [4].choice [3] = "여덟 팔";
		my_Quiz [4].Choice_Answer = 3;
		my_Quiz [4].score = 100;

		my_Quiz [5].quiz_Id = 6;
		my_Quiz [5].quiz_Select = "8급";
		my_Quiz [5].quiz_Level = 2;
		my_Quiz [5].multiple_Choice = true;
		my_Quiz [5].question = "";
		my_Quiz [5].choice [0] = "여섯 육";
		my_Quiz [5].choice [1] = "일곱 칠";
		my_Quiz [5].choice [2] = "다섯 오";
		my_Quiz [5].choice [3] = "여덟 팔";
		my_Quiz [5].Choice_Answer = 1;
		my_Quiz [5].score = 100;

		my_Quiz [6].quiz_Id = 7;
		my_Quiz [6].quiz_Select = "8급";
		my_Quiz [6].quiz_Level = 2;
		my_Quiz [6].multiple_Choice = true;
		my_Quiz [6].question = "";
		my_Quiz [6].choice [0] = "여섯 육";
		my_Quiz [6].choice [1] = "일곱 칠";
		my_Quiz [6].choice [2] = "다섯 오";
		my_Quiz [6].choice [3] = "여덟 팔";
		my_Quiz [6].Choice_Answer = 2;
		my_Quiz [6].score = 100;

		my_Quiz [7].quiz_Id = 8;
		my_Quiz [7].quiz_Select = "8급";
		my_Quiz [7].quiz_Level = 2;
		my_Quiz [7].multiple_Choice = true;
		my_Quiz [7].question = "";
		my_Quiz [7].choice [0] = "여섯 육";
		my_Quiz [7].choice [1] = "일곱 칠";
		my_Quiz [7].choice [2] = "다섯 오";
		my_Quiz [7].choice [3] = "여덟 팔";
		my_Quiz [7].Choice_Answer = 4;
		my_Quiz [7].score = 100;

		my_Quiz [8].quiz_Id = 9;
		my_Quiz [8].quiz_Select = "8급";
		my_Quiz [8].quiz_Level = 2;
		my_Quiz [8].multiple_Choice = true;
		my_Quiz [8].question = "";
		my_Quiz [8].choice [0] = "일백 백";
		my_Quiz [8].choice [1] = "아홉 구";
		my_Quiz [8].choice [2] = "열 십";
		my_Quiz [8].choice [3] = "일천 천";
		my_Quiz [8].Choice_Answer = 2;
		my_Quiz [8].score = 100;

		my_Quiz [9].quiz_Id = 10;
		my_Quiz [9].quiz_Select = "8급";
		my_Quiz [9].quiz_Level = 2;
		my_Quiz [9].multiple_Choice = true;
		my_Quiz [9].question = "";
		my_Quiz [9].choice [0] = "일백 백";
		my_Quiz [9].choice [1] = "아홉 구";
		my_Quiz [9].choice [2] = "열 십";
		my_Quiz [9].choice [3] = "일천 천";
		my_Quiz [9].Choice_Answer = 3;
		my_Quiz [9].score = 100;

		my_Quiz [10].quiz_Id = 11;
		my_Quiz [10].quiz_Select = "8급";
		my_Quiz [10].quiz_Level = 2;
		my_Quiz [10].multiple_Choice = true;
		my_Quiz [10].question = "";
		my_Quiz [10].choice [0] = "일백 백";
		my_Quiz [10].choice [1] = "아홉 구";
		my_Quiz [10].choice [2] = "열 십";
		my_Quiz [10].choice [3] = "일천 천";
		my_Quiz [10].Choice_Answer = 1;
		my_Quiz [10].score = 100;

		my_Quiz [11].quiz_Id = 12;
		my_Quiz [11].quiz_Select = "8급";
		my_Quiz [11].quiz_Level = 2;
		my_Quiz [11].multiple_Choice = true;
		my_Quiz [11].question = "";
		my_Quiz [11].choice [0] = "일백 백";
		my_Quiz [11].choice [1] = "아홉 구";
		my_Quiz [11].choice [2] = "열 십";
		my_Quiz [11].choice [3] = "일천 천";
		my_Quiz [11].Choice_Answer = 4;
		my_Quiz [11].score = 100;

		my_Quiz [12].quiz_Id = 13;
		my_Quiz [12].quiz_Select = "8급";
		my_Quiz [12].quiz_Level = 2;
		my_Quiz [12].multiple_Choice = true;
		my_Quiz [12].question = "";
		my_Quiz [12].choice [0] = "눈 목";
		my_Quiz [12].choice [1] = "날 일";
		my_Quiz [12].choice [2] = "달 월";
		my_Quiz [12].choice [3] = "일백 백";
		my_Quiz [12].Choice_Answer = 2;
		my_Quiz [12].score = 100;

		my_Quiz [13].quiz_Id = 14;
		my_Quiz [13].quiz_Select = "8급";
		my_Quiz [13].quiz_Level = 2;
		my_Quiz [13].multiple_Choice = true;
		my_Quiz [13].question = "";
		my_Quiz [13].choice [0] = "눈 목";
		my_Quiz [13].choice [1] = "날 일";
		my_Quiz [13].choice [2] = "달 월";
		my_Quiz [13].choice [3] = "일백 백";
		my_Quiz [13].Choice_Answer = 3;
		my_Quiz [13].score = 100;

		my_Quiz [14].quiz_Id = 15;
		my_Quiz [14].quiz_Select = "8급";
		my_Quiz [14].quiz_Level = 2;
		my_Quiz [14].multiple_Choice = true;
		my_Quiz [14].question = "";
		my_Quiz [14].choice [0] = "위 상";
		my_Quiz [14].choice [1] = "소 우";
		my_Quiz [14].choice [2] = "저녁 석";
		my_Quiz [14].choice [3] = "불 화";
		my_Quiz [14].Choice_Answer = 4;
		my_Quiz [14].score = 100;

		my_Quiz [15].quiz_Id = 16;
		my_Quiz [15].quiz_Select = "8급";
		my_Quiz [15].quiz_Level = 2;
		my_Quiz [15].multiple_Choice = true;
		my_Quiz [15].question = "";
		my_Quiz [15].choice [0] = "물 수";
		my_Quiz [15].choice [1] = "내 천";
		my_Quiz [15].choice [2] = "밭 전";
		my_Quiz [15].choice [3] = "일천 천";
		my_Quiz [15].Choice_Answer = 1;
		my_Quiz [15].score = 100;

		my_Quiz [16].quiz_Id = 17;
		my_Quiz [16].quiz_Select = "8급";
		my_Quiz [16].quiz_Level = 2;
		my_Quiz [16].multiple_Choice = true;
		my_Quiz [16].question = "";
		my_Quiz [16].choice [0] = "나무 목";
		my_Quiz [16].choice [1] = "아래 하";
		my_Quiz [16].choice [2] = "문 문";
		my_Quiz [16].choice [3] = "날 생";
		my_Quiz [16].Choice_Answer = 1;
		my_Quiz [16].score = 100;

		my_Quiz [17].quiz_Id = 18;
		my_Quiz [17].quiz_Select = "8급";
		my_Quiz [17].quiz_Level = 2;
		my_Quiz [17].multiple_Choice = true;
		my_Quiz [17].question = "";
		my_Quiz [17].choice [0] = "아버지 부";
		my_Quiz [17].choice [1] = "마디 촌";
		my_Quiz [17].choice [2] = "쇠 금";
		my_Quiz [17].choice [3] = "몸 신";
		my_Quiz [17].Choice_Answer = 3;
		my_Quiz [17].score = 100;

		my_Quiz [18].quiz_Id = 19;
		my_Quiz [18].quiz_Select = "8급";
		my_Quiz [18].quiz_Level = 2;
		my_Quiz [18].multiple_Choice = true;
		my_Quiz [18].question = "";
		my_Quiz [18].choice [0] = "밭 전";
		my_Quiz [18].choice [1] = "흙 토";
		my_Quiz [18].choice [2] = "문 문";
		my_Quiz [18].choice [3] = "손 수";
		my_Quiz [18].Choice_Answer = 2;
		my_Quiz [18].score = 100;

		my_Quiz [19].quiz_Id = 20;
		my_Quiz [19].quiz_Select = "8급";
		my_Quiz [19].quiz_Level = 2;
		my_Quiz [19].multiple_Choice = true;
		my_Quiz [19].question = "";
		my_Quiz [19].choice [0] = "양 양";
		my_Quiz [19].choice [1] = "힘 력";
		my_Quiz [19].choice [2] = "아들 자";
		my_Quiz [19].choice [3] = "설 립";
		my_Quiz [19].Choice_Answer = 2;
		my_Quiz [19].score = 100;

		my_Quiz [20].quiz_Id = 21;
		my_Quiz [20].quiz_Select = "8급";
		my_Quiz [20].quiz_Level = 2;
		my_Quiz [20].multiple_Choice = true;
		my_Quiz [20].question = "";
		my_Quiz [20].choice [0] = "뫼 산";
		my_Quiz [20].choice [1] = "아들 자";
		my_Quiz [20].choice [2] = "큰 대";
		my_Quiz [20].choice [3] = "귀 이";
		my_Quiz [20].Choice_Answer = 3;
		my_Quiz [20].score = 100;

		my_Quiz [21].quiz_Id = 22;
		my_Quiz [21].quiz_Select = "8급";
		my_Quiz [21].quiz_Level = 2;
		my_Quiz [21].multiple_Choice = true;
		my_Quiz [21].question = "";
		my_Quiz [21].choice [0] = "아들 자";
		my_Quiz [21].choice [1] = "뫼 산";
		my_Quiz [21].choice [2] = "큰 대";
		my_Quiz [21].choice [3] = "귀 이";
		my_Quiz [21].Choice_Answer = 2;
		my_Quiz [21].score = 100;

		my_Quiz [22].quiz_Id = 23;
		my_Quiz [22].quiz_Select = "8급";
		my_Quiz [22].quiz_Level = 2;
		my_Quiz [22].multiple_Choice = true;
		my_Quiz [22].question = "";
		my_Quiz [22].choice [0] = "작을 소";
		my_Quiz [22].choice [1] = "양 양";
		my_Quiz [22].choice [2] = "여자 녀";
		my_Quiz [22].choice [3] = "마음 심";
		my_Quiz [22].Choice_Answer = 1;
		my_Quiz [22].score = 100;

		my_Quiz [23].quiz_Id = 24;
		my_Quiz [23].quiz_Select = "8급";
		my_Quiz [23].quiz_Level = 2;
		my_Quiz [23].multiple_Choice = true;
		my_Quiz [23].question = "";
		my_Quiz [23].choice [0] = "소 우";
		my_Quiz [23].choice [1] = "아래 하";
		my_Quiz [23].choice [2] = "문 문";
		my_Quiz [23].choice [3] = "위 상";
		my_Quiz [23].Choice_Answer = 4;
		my_Quiz [23].score = 100;

		my_Quiz [24].quiz_Id = 25;
		my_Quiz [24].quiz_Select = "8급";
		my_Quiz [24].quiz_Level = 2;
		my_Quiz [24].multiple_Choice = true;
		my_Quiz [24].question = "";
		my_Quiz [24].choice [0] = "아래 하";
		my_Quiz [24].choice [1] = "여섯 육";
		my_Quiz [24].choice [2] = "사람 인";
		my_Quiz [24].choice [3] = "위 상";
		my_Quiz [24].Choice_Answer = 1;
		my_Quiz [24].score = 100;

		my_Quiz [25].quiz_Id = 26;
		my_Quiz [25].quiz_Select = "8급";
		my_Quiz [25].quiz_Level = 2;
		my_Quiz [25].multiple_Choice = true;
		my_Quiz [25].question = "";
		my_Quiz [25].choice [0] = "눈 목";
		my_Quiz [25].choice [1] = "귀 이";
		my_Quiz [25].choice [2] = "소 우";
		my_Quiz [25].choice [3] = "손 수";
		my_Quiz [25].Choice_Answer = 3;
		my_Quiz [25].score = 100;

		my_Quiz [26].quiz_Id = 27;
		my_Quiz [26].quiz_Select = "8급";
		my_Quiz [26].quiz_Level = 2;
		my_Quiz [26].multiple_Choice = true;
		my_Quiz [26].question = "";
		my_Quiz [26].choice [0] = "양 양";
		my_Quiz [26].choice [1] = "아들 자";
		my_Quiz [26].choice [2] = "마음 심";
		my_Quiz [26].choice [3] = "임금 왕";
		my_Quiz [26].Choice_Answer = 1;
		my_Quiz [26].score = 100;

		my_Quiz [27].quiz_Id = 28;
		my_Quiz [27].quiz_Select = "8급";
		my_Quiz [27].quiz_Level = 2;
		my_Quiz [27].multiple_Choice = true;
		my_Quiz [27].question = "";
		my_Quiz [27].choice [0] = "말 마";
		my_Quiz [27].choice [1] = "고기 어";
		my_Quiz [27].choice [2] = "뫼 산";
		my_Quiz [27].choice [3] = "위 상";
		my_Quiz [27].Choice_Answer = 2;
		my_Quiz [27].score = 100;

		my_Quiz [28].quiz_Id = 29;
		my_Quiz [28].quiz_Select = "8급";
		my_Quiz [28].quiz_Level = 2;
		my_Quiz [28].multiple_Choice = true;
		my_Quiz [28].question = "";
		my_Quiz [28].choice [0] = "힘 력";
		my_Quiz [28].choice [1] = "나무 목";
		my_Quiz [28].choice [2] = "말 마";
		my_Quiz [28].choice [3] = "내 천";
		my_Quiz [28].Choice_Answer = 3;
		my_Quiz [28].score = 100;

		my_Quiz [29].quiz_Id = 30;
		my_Quiz [29].quiz_Select = "8급";
		my_Quiz [29].quiz_Level = 2;
		my_Quiz [29].multiple_Choice = true;
		my_Quiz [29].question = "";
		my_Quiz [29].choice [0] = "소 우";
		my_Quiz [29].choice [1] = "사람 인";
		my_Quiz [29].choice [2] = "하늘 천";
		my_Quiz [29].choice [3] = "내 천";
		my_Quiz [29].Choice_Answer = 4;
		my_Quiz [29].score = 100;

		my_Quiz [30].quiz_Id = 31;
		my_Quiz [30].quiz_Select = "8급";
		my_Quiz [30].quiz_Level = 2;
		my_Quiz [30].multiple_Choice = true;
		my_Quiz [30].question = "";
		my_Quiz [30].choice [0] = "밭 전";
		my_Quiz [30].choice [1] = "저녁 석";
		my_Quiz [30].choice [2] = "넉 사";
		my_Quiz [30].choice [3] = "일백 백";
		my_Quiz [30].Choice_Answer = 1;
		my_Quiz [30].score = 100;

		my_Quiz [31].quiz_Id = 32;
		my_Quiz [31].quiz_Select = "8급";
		my_Quiz [31].quiz_Level = 2;
		my_Quiz [31].multiple_Choice = true;
		my_Quiz [31].question = "";
		my_Quiz [31].choice [0] = "밭 전";
		my_Quiz [31].choice [1] = "저녁 석";
		my_Quiz [31].choice [2] = "넉 사";
		my_Quiz [31].choice [3] = "일백 백";
		my_Quiz [31].Choice_Answer = 2;
		my_Quiz [31].score = 100;

		my_Quiz [32].quiz_Id = 33;
		my_Quiz [32].quiz_Select = "8급";
		my_Quiz [32].quiz_Level = 2;
		my_Quiz [32].multiple_Choice = true;
		my_Quiz [32].question = "";
		my_Quiz [32].choice [0] = "내 천";
		my_Quiz [32].choice [1] = "석 삼";
		my_Quiz [32].choice [2] = "하늘 천";
		my_Quiz [32].choice [3] = "소 우";
		my_Quiz [32].Choice_Answer = 3;
		my_Quiz [32].score = 100;

		my_Quiz [33].quiz_Id = 34;
		my_Quiz [33].quiz_Select = "8급";
		my_Quiz [33].quiz_Level = 2;
		my_Quiz [33].multiple_Choice = true;
		my_Quiz [33].question = "";
		my_Quiz [33].choice [0] = "힘 력";
		my_Quiz [33].choice [1] = "사람 인";
		my_Quiz [33].choice [2] = "여자 녀";
		my_Quiz [33].choice [3] = "문 문";
		my_Quiz [33].Choice_Answer = 4;
		my_Quiz [33].score = 100;

		my_Quiz [34].quiz_Id = 35;
		my_Quiz [34].quiz_Select = "8급";
		my_Quiz [34].quiz_Level = 2;
		my_Quiz [34].multiple_Choice = true;
		my_Quiz [34].question = "";
		my_Quiz [34].choice [0] = "사람 인";
		my_Quiz [34].choice [1] = "위 상";
		my_Quiz [34].choice [2] = "여덟 팔";
		my_Quiz [34].choice [3] = "작을 소";
		my_Quiz [34].Choice_Answer = 1;
		my_Quiz [34].score = 100;

		my_Quiz [35].quiz_Id = 36;
		my_Quiz [35].quiz_Select = "8급";
		my_Quiz [35].quiz_Level = 2;
		my_Quiz [35].multiple_Choice = true;
		my_Quiz [35].question = "";
		my_Quiz [35].choice [0] = "흙 토";
		my_Quiz [35].choice [1] = "날 생";
		my_Quiz [35].choice [2] = "손 수";
		my_Quiz [35].choice [3] = "여자 녀";
		my_Quiz [35].Choice_Answer = 2;
		my_Quiz [35].score = 100;

		my_Quiz [36].quiz_Id = 37;
		my_Quiz [36].quiz_Select = "8급";
		my_Quiz [36].quiz_Level = 2;
		my_Quiz [36].multiple_Choice = true;
		my_Quiz [36].question = "";
		my_Quiz [36].choice [0] = "어머니 모";
		my_Quiz [36].choice [1] = "여자 녀";
		my_Quiz [36].choice [2] = "아버지 부";
		my_Quiz [36].choice [3] = "손 수";
		my_Quiz [36].Choice_Answer = 3;
		my_Quiz [36].score = 100;

		my_Quiz [37].quiz_Id = 38;
		my_Quiz [37].quiz_Select = "8급";
		my_Quiz [37].quiz_Level = 2;
		my_Quiz [37].multiple_Choice = true;
		my_Quiz [37].question = "";
		my_Quiz [37].choice [0] = "아버지 부";
		my_Quiz [37].choice [1] = "아들 자";
		my_Quiz [37].choice [2] = "마음 심";
		my_Quiz [37].choice [3] = "어머니 모";
		my_Quiz [37].Choice_Answer = 4;
		my_Quiz [37].score = 100;

		my_Quiz [38].quiz_Id = 39;
		my_Quiz [38].quiz_Select = "8급";
		my_Quiz [38].quiz_Level = 2;
		my_Quiz [38].multiple_Choice = true;
		my_Quiz [38].question = "";
		my_Quiz [38].choice [0] = "아들 자";
		my_Quiz [38].choice [1] = "손 수";
		my_Quiz [38].choice [2] = "하늘 천";
		my_Quiz [38].choice [3] = "힘 력";
		my_Quiz [38].Choice_Answer = 1;
		my_Quiz [38].score = 100;

		my_Quiz [39].quiz_Id = 40;
		my_Quiz [39].quiz_Select = "8급";
		my_Quiz [39].quiz_Level = 2;
		my_Quiz [39].multiple_Choice = true;
		my_Quiz [39].question = "";
		my_Quiz [39].choice [0] = "마음 심";
		my_Quiz [39].choice [1] = "여자 녀";
		my_Quiz [39].choice [2] = "가운데 중";
		my_Quiz [39].choice [3] = "눈 목";
		my_Quiz [39].Choice_Answer = 2;
		my_Quiz [39].score = 100;

		my_Quiz [40].quiz_Id = 41;
		my_Quiz [40].quiz_Select = "8급";
		my_Quiz [40].quiz_Level = 2;
		my_Quiz [40].multiple_Choice = true;
		my_Quiz [40].question = "";
		my_Quiz [40].choice [0] = "쇠 금";
		my_Quiz [40].choice [1] = "고기 어";
		my_Quiz [40].choice [2] = "손 수";
		my_Quiz [40].choice [3] = "몸 신";
		my_Quiz [40].Choice_Answer = 3;
		my_Quiz [40].score = 100;

		my_Quiz [41].quiz_Id = 42;
		my_Quiz [41].quiz_Select = "8급";
		my_Quiz [41].quiz_Level = 2;
		my_Quiz [41].multiple_Choice = true;
		my_Quiz [41].question = "";
		my_Quiz [41].choice [0] = "아래 하";
		my_Quiz [41].choice [1] = "뫼 산";
		my_Quiz [41].choice [2] = "하늘 천";
		my_Quiz [41].choice [3] = "발 족";
		my_Quiz [41].Choice_Answer = 4;
		my_Quiz [41].score = 100;

		my_Quiz [42].quiz_Id = 43;
		my_Quiz [42].quiz_Select = "8급";
		my_Quiz [42].quiz_Level = 2;
		my_Quiz [42].multiple_Choice = true;
		my_Quiz [42].question = "";
		my_Quiz [42].choice [0] = "귀 이";
		my_Quiz [42].choice [1] = "소 우";
		my_Quiz [42].choice [2] = "여자 녀";
		my_Quiz [42].choice [3] = "몸 신";
		my_Quiz [42].Choice_Answer = 1;
		my_Quiz [42].score = 100;

		my_Quiz [43].quiz_Id = 44;
		my_Quiz [43].quiz_Select = "8급";
		my_Quiz [43].quiz_Level = 2;
		my_Quiz [43].multiple_Choice = true;
		my_Quiz [43].question = "";
		my_Quiz [43].choice [0] = "흙 토";
		my_Quiz [43].choice [1] = "눈 목";
		my_Quiz [43].choice [2] = "마음 심";
		my_Quiz [43].choice [3] = "하늘 천";
		my_Quiz [43].Choice_Answer = 2;
		my_Quiz [43].score = 100;

		my_Quiz [44].quiz_Id = 45;
		my_Quiz [44].quiz_Select = "8급";
		my_Quiz [44].quiz_Level = 2;
		my_Quiz [44].multiple_Choice = true;
		my_Quiz [44].question = "";
		my_Quiz [44].choice [0] = "임금 왕";
		my_Quiz [44].choice [1] = "나무 목";
		my_Quiz [44].choice [2] = "마음 심";
		my_Quiz [44].choice [3] = "몸 신";
		my_Quiz [44].Choice_Answer = 3;
		my_Quiz [44].score = 100;

		my_Quiz [45].quiz_Id = 46;
		my_Quiz [45].quiz_Select = "8급";
		my_Quiz [45].quiz_Level = 2;
		my_Quiz [45].multiple_Choice = true;
		my_Quiz [45].question = "";
		my_Quiz [45].choice [0] = "작을 소";
		my_Quiz [45].choice [1] = "발 족";
		my_Quiz [45].choice [2] = "문 문";
		my_Quiz [45].choice [3] = "몸 신";
		my_Quiz [45].Choice_Answer = 4;
		my_Quiz [45].score = 100;

		my_Quiz [46].quiz_Id = 47;
		my_Quiz [46].quiz_Select = "8급";
		my_Quiz [46].quiz_Level = 2;
		my_Quiz [46].multiple_Choice = true;
		my_Quiz [46].question = "";
		my_Quiz [46].choice [0] = "가운데 중";
		my_Quiz [46].choice [1] = "밭 전";
		my_Quiz [46].choice [2] = "나무 목";
		my_Quiz [46].choice [3] = "힘 력";
		my_Quiz [46].Choice_Answer = 1;
		my_Quiz [46].score = 100;

		my_Quiz [47].quiz_Id = 48;
		my_Quiz [47].quiz_Select = "8급";
		my_Quiz [47].quiz_Level = 2;
		my_Quiz [47].multiple_Choice = true;
		my_Quiz [47].question = "";
		my_Quiz [47].choice [0] = "마디 촌";
		my_Quiz [47].choice [1] = "설 립";
		my_Quiz [47].choice [2] = "일백 백";
		my_Quiz [47].choice [3] = "아래 하";
		my_Quiz [47].Choice_Answer = 2;
		my_Quiz [47].score = 100;

		my_Quiz [48].quiz_Id = 49;
		my_Quiz [48].quiz_Select = "8급";
		my_Quiz [48].quiz_Level = 2;
		my_Quiz [48].multiple_Choice = true;
		my_Quiz [48].question = "";
		my_Quiz [48].choice [0] = "사람 인";
		my_Quiz [48].choice [1] = "가운데 중";
		my_Quiz [48].choice [2] = "임금 왕";
		my_Quiz [48].choice [3] = "힘 력";
		my_Quiz [48].Choice_Answer = 3;
		my_Quiz [48].score = 100;

		my_Quiz [49].quiz_Id = 50;
		my_Quiz [49].quiz_Select = "8급";
		my_Quiz [49].quiz_Level = 2;
		my_Quiz [49].multiple_Choice = true;
		my_Quiz [49].question = "";
		my_Quiz [49].choice [0] = "흙 토";
		my_Quiz [49].choice [1] = "밭 전";
		my_Quiz [49].choice [2] = "손 수";
		my_Quiz [49].choice [3] = "마디 촌";
		my_Quiz [49].Choice_Answer = 4;
		my_Quiz [49].score = 100;

		//science / CommonSense
		}
	void Update () {
	

	}
}
