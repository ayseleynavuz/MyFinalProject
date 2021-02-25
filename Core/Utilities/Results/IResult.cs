using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için
    public interface IResult
    {
        bool Success { get; }  //işlem başarılı mı? başarısız mı?
        string Message { get; } //işlem başarılı ya da başarısız bilgilendirmesi

    }
}
