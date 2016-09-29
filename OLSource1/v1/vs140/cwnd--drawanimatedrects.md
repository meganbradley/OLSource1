---
title: "CWnd::DrawAnimatedRects"
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
  - "CWnd::DrawAnimatedRects"
  - "DrawAnimatedRects"
  - "CWnd.DrawAnimatedRects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawAnimatedRects method"
ms.assetid: 55d701a7-5667-4fb1-b99a-0f1d5c772cad
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::DrawAnimatedRects
Draws a wire-frame rectangle and animates it to indicate the opening of an icon or the minimizing or maximizing of a window.  
  
## Syntax  
  
```  
  
      BOOL DrawAnimatedRects(  
   int idAni,  
   CONST RECT *lprcFrom,  
   CONST RECT *lprcTo  
);  
```  
  
#### Parameters  
 *idAni*  
 Specifies the type of animation. If you specify **IDANI_CAPTION**, the window caption will animate from the position specified by `lprcFrom` to the position specified by `lprcTo`. The effect is similar to minimizing or maximizing a window.  
  
 `lprcFrom`  
 Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the location and size of the icon or minimized window.  
  
 `lprcTo`  
 Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the location and size of the restored window  
  
## Return Value  
 Nonzero if the function succeeds; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [DrawAnimatedRects](http://msdn.microsoft.com/library/windows/desktop/dd162475), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)