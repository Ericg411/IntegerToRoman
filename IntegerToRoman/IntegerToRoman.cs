namespace IntegerToRoman;
public class IntegerToRoman
{
    public string IntToRoman(int num)
    {
        int placehold = num;
        int remainder;
        List<int> numList = new List<int>();
        string result = "";

        while (placehold > 0)
        {
            remainder = placehold % 10;
            numList.Add(remainder);
            placehold = placehold / 10;
        }

        for (int i = numList.Count - 1; i >= 0; i--)
        {
            if (i == 3)
            {
                for (int i2 = numList[i]; i2 > 0; i2--)
                {
                    result += "M";
                }
            }
            else if (i == 2)
            {
                switch (numList[i])
                {
                    case 1:
                        result += "C";
                        break;
                    case 2:
                        result += "CC";
                        break;
                    case 3:
                        result += "CCC";
                        break;
                    case 4:
                        result += "CD";
                        break;
                    case 5:
                        result += "D";
                        break;
                    case 6:
                        result += "DC";
                        break;
                    case 7:
                        result += "DCC";
                        break;
                    case 8:
                        result += "DCCC";
                        break;
                    case 9:
                        result += "CM";
                        break;
                    default:
                        break;
                }
            }
            else if (i == 1)
            {
                switch (numList[i])
                {
                    case 1:
                        result += "X";
                        break;
                    case 2:
                        result += "XX";
                        break;
                    case 3:
                        result += "XXX";
                        break;
                    case 4:
                        result += "XL";
                        break;
                    case 5:
                        result += "L";
                        break;
                    case 6:
                        result += "LX";
                        break;
                    case 7:
                        result += "LXX";
                        break;
                    case 8:
                        result += "LXXX";
                        break;
                    case 9:
                        result += "XC";
                        break;
                    default:
                        break;
                }
            }
            else if (i == 0)
            {
                switch (numList[i])
                {
                    case 1:
                        result += "I";
                        break;
                    case 2:
                        result += "II";
                        break;
                    case 3:
                        result += "III";
                        break;
                    case 4:
                        result += "IV";
                        break;
                    case 5:
                        result += "V";
                        break;
                    case 6:
                        result += "VI";
                        break;
                    case 7:
                        result += "VII";
                        break;
                    case 8:
                        result += "VIII";
                        break;
                    case 9:
                        result += "IX";
                        break;
                    default:
                        break;
                }
            }

        }

        return result;
    }
}
