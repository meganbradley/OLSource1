---
title: "AfxDump (MFC)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "afxDump"
  - "AFX/afxDump"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "afxDump function"
ms.assetid: 9e7b5db1-c256-4968-8f13-db9d8019c3cb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxDump (MFC)
Call this function while in the debugger to dump the state of an object while debugging.  
  
## Syntax  
  
```  
  
      void AfxDump(  
   const CObject* pOb   
);   
```  
  
#### Parameters  
 `pOb`  
 A pointer to an object of a class derived from `CObject`.  
  
## Remarks  
 **AfxDump** calls an object's `Dump` member function and sends the information to the location specified by the `afxDump` variable. **AfxDump** is available only in the Debug version of MFC.  
  
 Your program code should not call **AfxDump**, but should instead call the `Dump` member function of the appropriate object.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CObject::Dump](../vs140/cobject--dump.md)   
 [afxDump](../vs140/afxdump--cdumpcontext-in-mfc-.md)