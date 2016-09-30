---
title: "CDockingManager::CalcExpectedDockedRect"
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
  - "CDockingManager.CalcExpectedDockedRect"
  - "CDockingManager::CalcExpectedDockedRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcExpectedDockedRect method"
ms.assetid: 82afad59-4791-46a9-9ef0-c45463659ad5
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::CalcExpectedDockedRect
Calculates the expected rectangle of a docked window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the window to dock.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The mouse location.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The calculated rectangle.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to draw a tab; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to a pointer to the target pane.  
  
## Remarks  
 This method calculates the rectangle that a window would occupy if a user dragged the window to the point specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and docked it there.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)