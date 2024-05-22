
public class IdValidator
{
    private bool CheckLength(string id)
    {
        if (id.Length != 10)
            return false;

        return true;
    }

    private bool IdValidation(string id)
    {
        int checkDigit = Convert.ToInt32(id.Substring(id.Length - 1, 1));
        string idWithoutCheckDigit = id.Substring(0, id.Length - 1);

        string reversedId = new string(idWithoutCheckDigit.Reverse().ToArray());

        Int64 sum = 0;
        int mulNumber = 2;
        for (int i = 0; i <= idWithoutCheckDigit.Length; i++)
        {
            sum += Convert.ToInt64(reversedId[i].ToString()) * mulNumber;
            mulNumber++;
            if (mulNumber > 10)
                break;
        }

        int residual = Convert.ToInt32(sum % 11);
        int res = 0;

        if (residual > 1)
        {

            res = Math.Abs(residual - 11);
            return res.Equals(checkDigit);
        }
        else
        {
            return res.Equals(checkDigit);
        }
    }

    public bool Validate(NationalId nationalId)
    {
        if (CheckLength(nationalId.Id) == true && IdValidation(nationalId.Id) == true)
            return true;
        else
            return false;
    }

}










