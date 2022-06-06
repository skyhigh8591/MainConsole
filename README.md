# MainConsole
--------------------------------------------------
    開發環境為 visual studio 2019 .Net5
    此程式為一個主控台，集合許多C#初始邏輯應用的Form
    包含基礎的Hello字串的輸出、List篩選、繪畫套件使用、螢幕保護程式等..功能展示

## 目錄
---------------------------------------------------
+ ### [Console](https://github.com/skyhigh8591/MainConsole/blob/main/MainConsole/Console.cs) 主控台介面
  + ### [Hello](https://github.com/skyhigh8591/MainConsole/blob/main/MainConsole/FolderHello/Hello.cs)
        輸入中文英文姓名、性別、星座後點選按鈕，會觸發彈跳視窗，分別對應Hello與Hi字串。
  + ### [Loan](https://github.com/skyhigh8591/MainConsole/blob/main/MainConsole/FolderLoan/Loan.cs)
        輸入貸款金額、年限、利率、頭期款，可計算每用應付多少，全部繳清需要多少錢。
  + ### [Pos](https://github.com/skyhigh8591/MainConsole/blob/main/MainConsole/FolderPos/Pos.cs)
        酒吧點餐的Pos機，利用按鈕進行點餐，會自動計算總金額與列出購物清單。
  + ### [StudentStruct](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderStudentStruct/StudentStruct.cs)
        輸入姓名、國文、英文、數學，旁邊會顯示輸入的項目並計算出最大值與最小值的成績。
  + ### [StudentsGrade](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderStudentsGrade/StudentsGrade.cs)
        輸入姓名與成績可以將資料加入DataGridView
        View會顯示個人的三科成績/總分/平均/最高分科目/最低分科目
        按下統計按鈕後下方View會統計整個DataGridView全部人
        各科成績總分/平均/最高分/最低分。
  + ### [StudentsGradeList](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderStudentsGradeList/StudentsGradeList.cs)
        此Form與上方StudentsGrade類似
        新增功能:由最下方插入資料，移除最後一筆資料，清除Data全部的資料
        搜尋國文範圍內的成績並顯示在DataGridView
        下方View由Label改為listBox顯示。
  + ### [Method](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderMethod/Method.cs)
        功能包含:
        輸入數字判斷奇術偶數
        判斷陣列的奇數與偶數的數量
        判斷陣列內最長的字串
        判斷陣列的最大值與最小值
        判斷陣列的值是否包含某個字母
        創造二維陣列外顯示1內顯示0
        創造二維陣列外顯示0內顯示1
        創造二維陣列0101與1010替換陣列
        使用函式Swap，Sum，Max，Min。
  + ### [MyClac](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderMyClac/MyClac.cs)
        小算盤 功能包含加減乘除。
  + ### [ForDoWhile](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderForDoWhile/ForDoWhile.cs)
        For、While、Do迴圈運作
        顯示直角三角形
        列印九九乘法表
        轉換100為二進位
        隨機產生六個數字不重複。
  + ### [XOGame](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderXoGame/XoGame.cs)
        OX遊戲 判斷目前的選項是否有符合連線的選項。
  + ### [ScreenSaver](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderScreenSaver/ScreenSaver.cs)
        螢幕保護程式 顯示黑頻為背景並有一個圖片四處移動碰到邊界改變移動方向
        滑鼠與鍵盤監聽，有任何感應將螢幕保護程式解除。
  + ### [Notepad](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderNotepad/Notepad.cs)
        筆記本功能包含:新增文件、開啟舊檔、保存文件、修改文字內容
        字體加粗、字體斜線、字體大小、字體字型。
  + ### [Painter](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderPainter/Painter.cs)
        小畫家功能包含:新增畫布、開啟舊檔、另存新檔
        設定畫筆粗細、畫筆顏色。
  + ### [PictureViewer](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderPictureViewer/PictureViewer.cs)
        圖片顯示，可以將本機的圖片顯示在View上。
  + ### [Guess](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderGuess/Guess.cs)
        猜數字遊戲，隨機產生一個數字，輸入數字會提示應該輸入的數字要大於還小於直到猜中數字。
  + ### [Alarm](https://github.com/skyhigh8591/MainConsole/tree/main/MainConsole/FolderAlarm/Alarm.cs)
        鬧鐘，左上會顯示現在的時間，下方可以設定鬧鐘時間，當兩者時間相同時會彈跳出視窗提醒時間到了。
---------------------------------------------------
## [MIT](https://opensource.org/licenses/MIT) License 授權協議
    MIT許可協議是許多軟件授權條款中，被廣泛使用的其中一種。與其他常見的軟件許可協議（如GPL、LGPL、BSD）相比，
    MIT是相對寬鬆的軟件許可協議。作者只想保留版權,而無任何其他了限制。也就是說,
    你必須在你的發行版裡包含原許可協議的聲明,無論你是以二進制發布的還是以源代碼發布的。
    MIT許可協議之名源自麻省理工學院Massachusetts Institute of Technology, MIT，又稱X許可協議
    （X License）或X11許可協議（X11 License） MIT內容與三條款BSD許可協議3-clause 
    BSD license內容頗為近似，但是賦予軟件被授權人更大的權利與更少的限制。


