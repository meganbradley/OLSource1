---
title: "CWnd::EndPaint"
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
  - "EndPaint"
  - "CWnd.EndPaint"
  - "CWnd::EndPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EndPaint method"
ms.assetid: 9e485268-c9b9-4772-8960-58fe5f502057
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::EndPaint
Marks the end of painting in the given window.  
  
## Syntax  
  
```  
  
      void EndPaint(  
   LPPAINTSTRUCT lpPaint   
);  
```  
  
#### Parameters  
 `lpPaint`  
 Points to a [PAINTSTRUCT](../vs140/paintstruct-structure.md) structure that contains the painting information retrieved by the [BeginPaint](../vs140/cwnd--beginpaint.md) member function.  
  
## Remarks  
 The `EndPaint` member function is required for each call to the `BeginPaint` member function, but only after painting is complete.  
  
 If the caret was hidden by the `BeginPaint` member function, `EndPaint` restores the caret to the screen.  
  
## Example  
 See the example for [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md)   
 [EndPaint](http://msdn.microsoft.com/library/windows/desktop/dd162598)   
 [CPaintDC Class](../vs140/cpaintdc-class.md)