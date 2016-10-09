            object noReset = false;
            object password = System.String.Empty;
            object useIRM = false;
            object enforceStyleLock = false;

            this.Protect(Word.WdProtectionType.wdAllowOnlyReading, 
                ref noReset, ref password, ref useIRM, ref enforceStyleLock);