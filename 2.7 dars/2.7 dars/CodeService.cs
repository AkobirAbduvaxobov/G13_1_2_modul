namespace _2._7_dars;

public class CodeService
{
    private List<Code> Codes;
    public CodeService()
    {
        Codes = new List<Code>();
    }

    public Guid AddCode(Code code)
    {
        code.CodeId = Guid.NewGuid();
        Codes.Add(code);
        return code.CodeId;
    }

    public List<Code> GetAllCodes()
    {
        return Codes;
    }
}
