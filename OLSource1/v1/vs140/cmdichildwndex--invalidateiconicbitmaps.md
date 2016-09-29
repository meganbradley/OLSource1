---
title: "CMDIChildWndEx::InvalidateIconicBitmaps"
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
  - "InvalidateIconicBitmaps"
  - "afxmdichildwndex/CMDIChildWndEx::InvalidateIconicBitmaps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InvalidateIconicBitmaps"
ms.assetid: 374ea16a-ced4-4ccf-b50c-7d1df43069d7
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::InvalidateIconicBitmaps
Invalidates an iconic bitmap representation of a MDI child.  
  
## Syntax  
  
```  
BOOL InvalidateIconicBitmaps();  
```  
  
## Return Value  
 Returns `FALSE` if Windows 7 taskbar support is disabled or the MDI child is not registered with Windows 7 taskbar tabs; otherwise returns `TRUE`.  
  
## Remarks  
 Should be called when the live content or size of a MDI child has changed.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)