---
title: "MINMAXINFO Structure"
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
  - "MINMAXINFO"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MINMAXINFO structure"
ms.assetid: be6fb578-f98a-4581-9ada-be9df308ed2f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MINMAXINFO Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about a window's maximized size and position and its minimum and maximum tracking size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *ptReserved*  
 Reserved for internal use.  
  
 *ptMaxSize*  
 Specifies the maximized width (point.x) and the maximized height (point.y) of the window.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the position of the left side of the maximized window (point.x) and the position of the top of the maximized window (point.y).  
  
 *ptMinTrackSize*  
 Specifies the minimum tracking width (point.x) and the minimum tracking height (point.y) of the window.  
  
 *ptMaxTrackSize*  
 Specifies the maximum tracking width (point.x) and the maximum tracking height (point.y) of the window.  
  
## Requirements  
 **Header:** winuser.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CWnd::OnGetMinMaxInfo](../vs140/cwnd--ongetminmaxinfo.md)