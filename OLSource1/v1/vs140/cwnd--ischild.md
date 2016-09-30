---
title: "CWnd::IsChild"
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
  - "IsChild"
  - "CWnd::IsChild"
  - "CWnd.IsChild"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsChild method"
ms.assetid: c02e4a30-446d-433d-a03f-64239bf1f8cd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::IsChild
Indicates whether the window specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a child window or other direct descendant of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Identifies the window to be tested.  
  
## Return Value  
 Specifies the outcome of the function. The value is nonzero if the window identified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a child window of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise 0.  
  
## Remarks  
 A child window is the direct descendant of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is in the chain of parent windows that leads from the original pop-up window to the child window.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IsChild](http://msdn.microsoft.com/library/windows/desktop/ms633524)