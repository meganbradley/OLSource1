---
title: "AfxAbort"
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
  - "AfxAbort"
  - "AFX/AfxAbort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "termination functions"
  - "AfxAbort function"
ms.assetid: c995759d-2326-4779-88e1-348d2b0bcecb
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxAbort
The default termination function supplied by MFC.  
  
## Syntax  
  
```  
  
void AfxAbort( );   
```  
  
## Remarks  
 `AfxAbort` is called internally by MFC member functions when there is a fatal error, such as an uncaught exception that cannot be handled. You can call `AfxAbort` in the rare case when you encounter a catastrophic error from which you cannot recover.  
  
## Example  
 See the example for [CATCH](../vs140/catch.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)