﻿using System;

class Except
{
    public static void ThrowMsg(string msg)
    {
        throw new Exception(string.Format(msg));
    }
}
