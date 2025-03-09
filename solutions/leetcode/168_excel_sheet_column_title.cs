public class ExcelSheetColTite168{
    public string ConvertToTitle(int columnNumber){
        string result ="";
        while(columnNumber > 0){
            columnNumber--;
            result =(char)('A' + columnNumber % 26) + result;
            columnNumber /= 26;
        }
        return result;
    }
}