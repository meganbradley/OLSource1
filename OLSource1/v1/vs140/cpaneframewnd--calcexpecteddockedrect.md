---
title: "CPaneFrameWnd::CalcExpectedDockedRect"
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
  - "CalcExpectedDockedRect"
  - "CPaneFrameWnd.CalcExpectedDockedRect"
  - "CPaneFrameWnd::CalcExpectedDockedRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcExpectedDockedRect method"
ms.assetid: 821a698a-8f80-435e-a135-7bf52a05fd7d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::CalcExpectedDockedRect
Calculate the expected rectangle of a docked window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the window to dock.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The mouse location.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The calculated rectangle.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, draw a tab. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, do not draw a tab.  
  
 [out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the target pane.  
  
## Remarks  
 This method calculates the rectangle that a window would occupy if a user dragged the window to the point specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and docked it there.  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)