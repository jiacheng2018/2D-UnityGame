using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionInfo : MonoBehaviour
{
    public  List<string> QuestionInfos = new List<string>();
    public List<string> Answers1 = new List<string>();
    public List<string> Answers2 = new List<string>();
    public List<string> Answers3 = new List<string>();

    public static QuestionInfo Instance;
    private void Awake()
    {
        Instance = this;
    }
    private string q1 = "How ____are you ?";
    private string q1_a1 = "old  ";
    private string q1_a2 = " big ";
    private string q1_a3 = " am";

    private string q2 = "I ___ seven.";
    private string q2_a1 = "am ";
    private string q2_a2 = "have ";
    private string q2_a3 = "is";

    private string q3 = "Happy birthday _____you.";
    private string q3_a1 = "for";
    private string q3_a2 = "to";
    private string q3_a3 = "is";

    private string q4 = "This is your present";
    private string q4_a1 = "Thank You";
    private string q4_a2 = "Shut up!";
    private string q4_a3 = "Get away!";

    private string q5 = "Help me!";
    private string q5_a1 = "I am fine,thanks you";
    private string q5_a2 = "No Worry";
    private string q5_a3 = "What ?";

    private string q6 = "Good Morning";
    private string q6_a1 = "My pleasure";
    private string q6_a2 = "Fine";
    private string q6_a3 = "Good Morning";

    private string q7 = "Do you want to join us?";
    private string q7_a1 = "Yes,please";
    private string q7_a2 = "No,thank you";
    private string q7_a3 = "You are welcome!";

    private string q8 = "May you come with me?";
    private string q8_a1 = "Yes,sure";
    private string q8_a2 = "Where?";
    private string q8_a3 = "Never mind";

    private string q9 = "Can you raise your hands?";
    private string q9_a1 = "Yes";
    private string q9_a2 = "Never mind";
    private string q9_a3 = "I understand";

    private string q10 = "早上的阳光特别的美丽";
    private string q10_a1 = "的确是这样的";
    private string q10_a2 = "你欠我的钱还没还";
    private string q10_a3 = "我们能换座位吗";

    private string q11 = "如何与人沟通是最舒服的";
    private string q11_a1 = "少说话";
    private string q11_a2 = "无视人的目光";
    private string q11_a3 = "打断别人的发言";

    private string q12 = "早上的阳光特别漂亮";
    private string q12_a1 = "的确是这样的";
    private string q12_a2 = "你说什么";
    private string q12_a3 = "爱你哦！";

    private string q13 = "おはようございます";
    private string q13_a1 = "こんばんは";
    private string q13_a2 = "私は去ります";
    private string q13_a3 = "私はあなたが好き";

    private string q14 = "春祭りの期間中、通常何をしますか？";
    private string q14_a1 = "記念の祖先";
    private string q14_a2 = "子を食べる曲元祭";
    private string q14_a3 = "高く登って山に登る";

    private string q15 = "あなたの父親は大丈夫ですか？";
    private string q15_a1 = "彼はとても健康的です\n";
    private string q15_a2 = "最近おもちゃを買いました";
    private string q15_a3 = "私たちは一緒に公園に行きました。";

    private string q16 = "同学们要做28个灯笼,已做好18个，还要做多少个? 　";
    private string q16_a1 = "8";
    private string q16_a2 = "9";
    private string q16_a3 = "10";

    private string q17 = "从花上飞走了36只蝴蝶，又飞走了25只，两次飞走了多少只? ";
    private string q17_a1 = "55";
    private string q17_a2 = "61";
    private string q17_a3 = "67";

    private string q18 = "May I borrow a pencil from you?";
    private string q18_a1 = "Yes,of course.";
    private string q18_a2 = "No, Don't worry";
    private string q18_a3 = "That is alright, I think";
    // Start is called before the first frame update
    void Start()
    {

        QuestionInit();
       
    }

    private void QuestionInit()
    {
        QuestionInfos.Add(q1);
        QuestionInfos.Add(q2);
        QuestionInfos.Add(q3);
        QuestionInfos.Add(q4);
        QuestionInfos.Add(q5);
        QuestionInfos.Add(q6);
        QuestionInfos.Add(q7);
        QuestionInfos.Add(q8);
        QuestionInfos.Add(q9);
        QuestionInfos.Add(q10);
        QuestionInfos.Add(q11);
        QuestionInfos.Add(q12);
        QuestionInfos.Add(q13);
        QuestionInfos.Add(q14);
        QuestionInfos.Add(q15);
        QuestionInfos.Add(q16);
        QuestionInfos.Add(q17);
        QuestionInfos.Add(q18);

        Answers1.Add(q1_a1);
        Answers1.Add(q2_a1);
        Answers1.Add(q3_a1);
        Answers1.Add(q4_a1);
        Answers1.Add(q5_a1);
        Answers1.Add(q6_a1);
        Answers1.Add(q7_a1);
        Answers1.Add(q8_a1);
        Answers1.Add(q9_a1);
        Answers1.Add(q10_a1);
        Answers1.Add(q11_a1);
        Answers1.Add(q12_a1);
        Answers1.Add(q13_a1);
        Answers1.Add(q14_a1);
        Answers1.Add(q15_a1);
        Answers1.Add(q16_a1);
        Answers1.Add(q17_a1);
        Answers1.Add(q18_a1);

        Answers2.Add(q1_a2);
        Answers2.Add(q2_a2);
        Answers2.Add(q3_a2);
        Answers2.Add(q4_a2);
        Answers2.Add(q5_a2);
        Answers2.Add(q6_a2);
        Answers2.Add(q7_a2);
        Answers2.Add(q8_a2);
        Answers2.Add(q9_a2);
        Answers2.Add(q10_a2);
        Answers2.Add(q11_a2);
        Answers2.Add(q12_a2);
        Answers2.Add(q13_a2);
        Answers2.Add(q14_a2);
        Answers2.Add(q15_a2);
        Answers2.Add(q16_a2);
        Answers2.Add(q17_a2);
        Answers2.Add(q18_a2);

        Answers3.Add(q1_a3);
        Answers3.Add(q2_a3);
        Answers3.Add(q3_a3);
        Answers3.Add(q4_a3);
        Answers3.Add(q5_a3);
        Answers3.Add(q6_a3);
        Answers3.Add(q7_a3);
        Answers3.Add(q8_a3);
        Answers3.Add(q9_a3);
        Answers3.Add(q10_a3);
        Answers3.Add(q11_a3);
        Answers3.Add(q12_a3);
        Answers3.Add(q13_a3);
        Answers3.Add(q14_a3);
        Answers3.Add(q15_a3);
        Answers3.Add(q16_a3);
        Answers3.Add(q17_a3);
        Answers3.Add(q18_a3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
