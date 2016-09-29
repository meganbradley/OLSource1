---
title: "CStatic::GetCursor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CStatic::GetCursor"
  - "GetCursor"
  - "CStatic.GetCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStatic class, operations"
  - "GetCursor method"
ms.assetid: 72c46838-adf5-43bf-b23f-326b512fb56e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatic::GetCursor
Gets the handle of the cursor, previously set with [SetCursor](../vs140/cstatic--setcursor.md), that is associated with `CStatic`.  
  
## Syntax  
  
```  
  
HCURSOR GetCursor( );  
  
```  
  
## Return Value  
 A handle to the current cursor, or **NULL** if no cursor has been set.  
  
## Example  
 [!code[NVC_MFC_CStatic#4](../vs140/codesnippet/CPP/cstatic--getcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::SetCursor](../vs140/cstatic--setcursor.md)   
 [STM_GETIMAGE](http://msdn.microsoft.com/library/windows/desktop/bb760778)   
 [Cursors](http://msdn.microsoft.com/library/windows/desktop/ms646970)