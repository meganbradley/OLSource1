---
title: "CDumpContext::DumpAsHex"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - DumpAsHex
  - CDumpContext.DumpAsHex
  - CDumpContext::DumpAsHex
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDumpContext class, basic input/output
  - DumpAsHex method
ms.assetid: 2f7f1b45-d83f-44da-af7b-5d5356cadc50
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDumpContext::DumpAsHex
Dumps the specified type formatted as hexadecimal numbers.  
  
## Syntax  
  
```  
  
      CDumpContext& DumpAsHex(   
   BYTE b   
);  
CDumpContext& DumpAsHex(   
   DWORD dw   
);  
CDumpContext& DumpAsHex(   
   int n   
);  
CDumpContext& DumpAsHex(   
   LONG l   
);  
CDumpContext& DumpAsHex(   
   LONGLONG n   
);  
CDumpContext& DumpAsHex(   
   UINT u   
);  
CDumpContext& DumpAsHex(   
   ULONGLONG n   
);  
CDumpContext& DumpAsHex(   
   WORD w   
);  
```  
  
## Return Value  
 A reference to a `CDumpContext` object.  
  
## Remarks  
 Call this member function to dump the item of the specified type as a hexadecimal number. To dump an array, call [CDumpContext::HexDump](../vs140/cdumpcontext--hexdump.md).  
  
## Example  
 [!code[NVC_MFC_Utilities#13](../vs140/codesnippet/CPP/cdumpcontext--dumpashex_1.cpp)]
  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CDumpContext Class](../vs140/cdumpcontext-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDumpContext::operator <<](../vs140/cdumpcontext--operator---.md)