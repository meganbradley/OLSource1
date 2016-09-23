---
title: "CDC::SetBkColor"
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
  - CDC.SetBkColor
  - CDC::SetBkColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, drawing-attribute functions
  - SetBkColor method
ms.assetid: a553f8ad-83f8-4bbc-ab89-438597421c47
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::SetBkColor
Sets the current background color to the specified color.  
  
## Syntax  
  
```  
  
      virtual COLORREF SetBkColor(  
   COLORREF crColor   
);  
```  
  
#### Parameters  
 `crColor`  
 Specifies the new background color.  
  
## Return Value  
 The previous background color as an RGB color value. If an error occurs, the return value is 0x80000000.  
  
## Remarks  
 If the background mode is **OPAQUE**, the system uses the background color to fill the gaps in styled lines, the gaps between hatched lines in brushes, and the background in character cells. The system also uses the background color when converting bitmaps between color and monochrome device contexts.  
  
 If the device cannot display the specified color, the system sets the background color to the nearest physical color.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BitBlt](../vs140/cdc--bitblt.md)   
 [CDC::GetBkColor](../vs140/cdc--getbkcolor.md)   
 [CDC::GetBkMode](../vs140/cdc--getbkmode.md)   
 [CDC::SetBkMode](../vs140/cdc--setbkmode.md)   
 [CDC::StretchBlt](../vs140/cdc--stretchblt.md)   
 [SetBkColor](http://msdn.microsoft.com/library/windows/desktop/dd162964)