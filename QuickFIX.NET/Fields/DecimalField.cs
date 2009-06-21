﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFIX.NET
{
    class DecimalField : FieldBase<Decimal>
    {
        public DecimalField(int tag, Decimal val)
            : base(tag, val) { }

        // quickfix compat
        public Decimal getValue()
        { return Obj; }

        public void setValue(Decimal d)
        { Obj = d; }
    }
}