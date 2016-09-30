---
title: "CDC::GetWindow"
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
  - "CDC::GetWindow"
  - "CDC.GetWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, initialization"
  - "GetWindow method"
ms.assetid: b22663fe-81a0-4145-a4c1-87b6939c81e6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetWindow
Returns the window associated with the display device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
## Remarks  
 This is an advanced function. For example, this member function may not return the view window when printing or in print preview. It always returns the window associated with output. Output functions that use the given DC draw into this window.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDC](../vs140/cwnd--getdc.md)   
 [CWnd::GetWindowDC](../vs140/cwnd--getwindowdc.md)   
 [GetWindow](http://msdn.microsoft.com/library/windows/desktop/ms633515)