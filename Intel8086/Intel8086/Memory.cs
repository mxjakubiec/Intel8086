using System.Globalization;

namespace Intel8086;

public class Memory
{
    private short AX, BX, CX, DX = 0;
    
    public Memory()
    {
        AX = BX = CX = DX = 0;
    }

    public bool MOV(string addressFROM, string addressTO)
    {
        ref short registry = ref AX;
        if (addressFROM.ToLower().Contains("ax"))
        {
            registry = ref AX;
        }else if (addressFROM.ToLower().Contains("bx"))
        {
            registry = ref BX;
        }else if (addressFROM.ToLower().Contains("cx"))
        {
            registry = ref CX;
        }else if (addressFROM.ToLower().Contains("dx"))
        {
            registry = ref DX;
        }
        else
        {
            return false;
        }
        
        if (addressTO.ToLower().Contains("ax"))
        {
            registry = AX;
        }else if (addressTO.ToLower().Contains("bx"))
        {
            registry = BX;
        }else if (addressTO.ToLower().Contains("cx"))
        {
            registry = CX;
        }else if (addressTO.ToLower().Contains("dx"))
        {
            registry = DX;
        }
        else
        {
            return false;
        }

        return true;
    }

    public bool ADD(string address, string value)
    {
        short val;
        val = short.Parse(value);
        if (address.ToLower().Contains("ax"))
        {
            AX = val;
        }
        else if (address.ToLower().Contains("bx"))
        {
            BX = val;
        }
        else if (address.ToLower().Contains("cx"))
        {
            CX = val;
        }
        else if (address.ToLower().Contains("dx"))
        {
            DX = val;
        }
        else
        {
            return false;
        }

        return true;
    }

    public short AND()
    {
        AX &= BX;
        return AX;
    }
}