      CAge a(21);  // Must use IMPLEMENT_DYNAMIC, IMPLEMENT _DYNCREATE, or
                   // IMPLEMENT_SERIAL
      ASSERT(a.IsKindOf(RUNTIME_CLASS(CAge)));
      ASSERT(a.IsKindOf(RUNTIME_CLASS(CObject)));   