---
title: "AfxOleGetUserCtrl"
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
  - AfxOleGetUserCtrl
  - AFXWIN/AfxOleGetUserCtrl
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxOleGetUserCtrl function
  - application control
ms.assetid: 229a018d-d10b-4693-8331-6994d3b81c7b
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxOleGetUserCtrl
Retrieves the current user-control flag.  
  
## Syntax  
  
```  
  
BOOL AFXAPI AfxOleGetUserCtrl( );  
```  
  
## Return Value  
 Nonzero if the user is in control of the application; otherwise 0.  
  
## Remarks  
 The user is in control of the application when the user has explicitly opened or created a new document. The user is also in control if the application was not launched by the OLE system DLLs — in other words, if the user launched the application with the system shell.  
  
## Requirements  
 **Header**: <afxdisp.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxOleSetUserCtrl](../vs140/afxolesetuserctrl.md)