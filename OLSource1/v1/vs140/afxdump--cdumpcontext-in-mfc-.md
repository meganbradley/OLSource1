---
title: "afxDump (CDumpContext in MFC)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - afxDump
  - AFX/afxDump
dev_langs: 
  - C++
helpviewer_keywords: 
  - afxDump function
ms.assetid: 4b3cfa3f-fb75-456a-9d99-a5601acbcb11
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# afxDump (CDumpContext in MFC)
Provides basic object-dumping capability in your application.  
  
## Syntax  
  
```  
  
CDumpContext afxDump;  
```  
  
## Remarks  
 `afxDump` is a predefined [CDumpContext](../vs140/cdumpcontext-class.md) object that allows you to send `CDumpContext` information to the debugger output window or to a debug terminal. Typically, you supply `afxDump` as a parameter to `CObject::Dump`.  
  
 Under Windows NT and all versions of Windows, `afxDump` output is sent to the Output-Debug window of Visual C++ when you debug your application.  
  
 This variable is defined only in the Debug version of MFC. For more information on `afxDump`, see [Debugging MFC Applications](../vs140/mfc-debugging-techniques.md).  
  
## Example  
 [!code[NVC_MFC_Utilities#23](../vs140/codesnippet/CPP/afxdump--cdumpcontext-in-mfc-_1.cpp)]
  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CObject::Dump](../vs140/cobject--dump.md)   
 [AfxDump](../vs140/afxdump--mfc-.md)