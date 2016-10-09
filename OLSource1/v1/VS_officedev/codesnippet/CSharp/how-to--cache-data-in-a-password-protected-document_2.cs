        [CachedAttribute]
        public string CachedString = "This string is cached in the workbook.";

        private bool protectStructureValue;
        private bool protectWindowsValue;

        protected override void UnprotectDocument()
        {
            protectStructureValue = this.ProtectStructure;
            protectWindowsValue = this.ProtectWindows;

            this.Unprotect(securelyStoredPassword);
        }

        protected override void ProtectDocument()
        {
            this.Protect(securelyStoredPassword, protectStructureValue,
                protectWindowsValue);
        }