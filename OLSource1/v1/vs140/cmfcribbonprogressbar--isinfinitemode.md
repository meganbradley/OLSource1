---
title: "CMFCRibbonProgressBar::IsInfiniteMode"
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
  - "IsInfiniteMode"
  - "CMFCRibbonProgressBar.IsInfiniteMode"
  - "CMFCRibbonProgressBar::IsInfiniteMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsInfiniteMode method"
ms.assetid: 1f989b77-6c46-497c-9ba9-c8775c273ee1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonProgressBar::IsInfiniteMode
Specifies whether the progress bar is working in infinite mode.  
  
## Syntax  
  
```  
BOOL IsInfiniteMode() const;  
```  
  
## Return Value  
 `TRUE` if the progress bar is in infinite mode; otherwise, `FALSE`.  
  
## Remarks  
 In infinite mode, the progress bar fills repeatedly from the minimum value to the maximum value. You might use infinite mode to indicate that an operation is ongoing, but that the completion time is unknown.  
  
## Requirements  
 **Header:** afxRibbonProgressBar.h  
  
## See Also  
 [CMFCRibbonProgressBar Class](../vs140/cmfcribbonprogressbar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)