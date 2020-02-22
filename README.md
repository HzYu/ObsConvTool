# 觀測檔轉換小工具 (ObsConvTool)
觀測檔(.sdr)利用公式計算轉換為相關的數據，並輸出為.mac檔
# 環境
開發環境為`Visual Studio`<br>
語言`C#`
# 文件
### 文件
[專案說明.docx](doc/專案說明.docx "Title")
### 測試檔案
[0918.sdr](doc/0918.sdr "Title")<br>
[1114.sdr](doc/1114.sdr "Title")
### 輸出結果
[0918.mac](doc/0918.mac "Title")<br>
[1114.mac](doc/1114.mac "Title")
# 簡介
### 檔案讀取並整理.sdr檔，顯示在DataGridView
![](Pic/img1.png)
### <br>按下確認col3資料按鈕後，自動切割Col3欄位的數值，並讓使用者確認逗號是否有區隔正確
![](Pic/img2.png)
### <br>按下確定後，DataGridView Col3重新寫入
![](Pic/img3.png)
### <br>按下轉換成Mac按鈕，自動計算出相關數值
![](Pic/img4.png)
