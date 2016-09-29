---
title: "CWnd::OnNcPaint"
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
  - "WM_NCPAINT"
  - "CWnd.OnNcPaint"
  - "OnNcPaint"
  - "CWnd::OnNcPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_NCPAINT"
  - "OnNcPaint method"
ms.assetid: e455bef7-f47f-43d7-8289-d6ea3ad75019
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcPaint
The framework calls this member function when the nonclient area needs to be painted.  
  
## Syntax  
  
```  
  
afx_msg void OnNcPaint( );  
```  
  
## Remarks  
 The default implementation paints the window frame.  
  
 An application can override this call and paint its own custom window frame. The clipping region is always rectangular, even if the shape of the frame is altered.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnNcPaint](../vs140/cwnd--onncpaint.md)