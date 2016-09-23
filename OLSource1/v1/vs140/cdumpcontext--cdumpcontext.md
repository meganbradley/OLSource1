---
title: "CDumpContext::CDumpContext"
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
  - CDumpContext::CDumpContext
  - CDumpContext.CDumpContext
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDumpContext class, construction/destruction
  - CDumpContext class, constructor
ms.assetid: 6cb7f7a1-3b67-4cdb-b27e-3f1453772eb7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDumpContext::CDumpContext
Constructs an object of class `CDumpContext`.  
  
## Syntax  
  
```  
  
      CDumpContext(  
   CFile* pFile = NULL  
);  
```  
  
#### Parameters  
 `pFile`  
 A pointer to the `CFile` object that is the dump destination.  
  
## Remarks  
 The `afxDump` object is constructed automatically.  
  
 Do not write to the underlying `CFile` while the dump context is active; otherwise, you will interfere with the dump. Under the Windows environment, the output is routed to the debugger via the Windows function **OutputDebugString**.  
  
## Example  
 [!code[NVC_MFC_Utilities#12](../vs140/codesnippet/CPP/cdumpcontext--cdumpcontext_1.cpp)]
  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CDumpContext Class](../vs140/cdumpcontext-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)