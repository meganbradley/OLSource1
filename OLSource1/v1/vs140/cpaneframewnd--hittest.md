---
title: "CPaneFrameWnd::HitTest"
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
  - "HitTest"
  - "CPaneFrameWnd.HitTest"
  - "CPaneFrameWnd::HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: d9b6826c-9e4f-4e4e-9ce9-0188361bc0a2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::HitTest
Determines what part of a mini-frame window is at a given point.  
  
## Syntax  
  
```  
virtual LRESULT HitTest(  
   CPoint point,  
   BOOL bDetectCaption  
);  
```  
  
#### Parameters  
 [in] `point`  
 The point to test.  
  
 [in] `bDetectCaption`  
 If `TRUE`, check the point against the caption. If `FALSE`, ignore the caption.  
  
## Return Value  
 One of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|`HTNOWHERE`|The point is outside the mini-frame window.|  
|`HTCLIENT`|The point is in the client area.|  
|`HTCAPTION`|The point is on the caption.|  
|`HTTOP`|The point is at the top.|  
|`HTTOPLEFT`|The point is at the top left.|  
|`HTTOPRIGHT`|The point is at the top right.|  
|`HTLEFT`|The point is at the left.|  
|`HTRIGHT`|The point is at the right.|  
|`HTBOTTOM`|The point is at the bottom.|  
|`HTBOTTOMLEFT`|The point is at the bottom left.|  
|`HTBOTTOMRIGHT`|The point is at the bottom right.|  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)