---
title: "CWnd::OnMove"
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
  - OnMove
  - CWnd.OnMove
  - CWnd::OnMove
  - WM_MOVE
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnMove method
  - WM_MOVE
ms.assetid: 77752bf7-0e92-4591-a81e-f53ac6d0b097
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnMove
The framework calls this member function after the `CWnd` object has been moved.  
  
## Syntax  
  
```  
  
      afx_msg void OnMove(  
   int x,  
   int y   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the new x-coordinate location of the upper-left corner of the client area. This new location is given in screen coordinates for overlapped and pop-up windows, and parent-client coordinates for child windows.  
  
 *y*  
 Specifies the new y-coordinate location of the upper-left corner of the client area. This new location is given in screen coordinates for overlapped and pop-up windows, and parent-client coordinates for child windows.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnMoving](../vs140/cwnd--onmoving.md)   
 [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md)