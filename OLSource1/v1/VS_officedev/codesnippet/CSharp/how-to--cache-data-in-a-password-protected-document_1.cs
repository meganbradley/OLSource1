        [CachedAttribute]
        public string CachedString = "This string is cached in the document.";

        private Word.WdProtectionType protectionTypeValue;

        protected override void UnprotectDocument()
        {
            if (this.ProtectionType != Word.WdProtectionType.wdNoProtection)
            {
                protectionTypeValue = this.ProtectionType;
                this.Unprotect(ref securelyStoredPassword);
            }
        }

        protected override void ProtectDocument()
        {
            this.Protect(protectionTypeValue, ref missing,
                ref securelyStoredPassword, ref missing, ref missing);
        }