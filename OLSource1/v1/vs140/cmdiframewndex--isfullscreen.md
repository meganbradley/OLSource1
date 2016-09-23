---
title: "CMDIFrameWndEx::IsFullScreen"
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
  - IsFullScreen
  - CMDIFrameWndEx::IsFullScreen
  - CMDIFrameWndEx.IsFullScreen
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsFullScreen method
ms.assetid: 2a72e0f4-7823-4d80-b82c-fd9cda07158f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::IsFullScreen
Determines whether the frame window is in full-screen mode.  
  
## Syntax  
  
```  
BOOL IsFullScreen() const;  
```  
  
## Return Value  
 `TRUE` if the frame window is in full screen mode; otherwise `FALSE`.  
  
## Remarks  
 You can set the full screen mode by calling the [CMDIFrameWndEx::EnableFullScreenMode](../vs140/cmdiframewndex--enablefullscreenmode.md) method.  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)