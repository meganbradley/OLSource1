---
title: "CDC::GetStretchBltMode"
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
  - "CDC.GetStretchBltMode"
  - "CDC::GetStretchBltMode"
  - "GetStretchBltMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStretchBltMode method"
  - "CDC class, drawing-attribute functions"
ms.assetid: 30ccb298-b518-405a-8b7e-fdc3fe5520fc
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetStretchBltMode
Retrieves the current bitmap-stretching mode.  
  
## Syntax  
  
```  
  
int GetStretchBltMode( ) const;  
```  
  
## Return Value  
 The return value specifies the current bitmap-stretching mode — **STRETCH_ANDSCANS**, **STRETCH_DELETESCANS**, or **STRETCH_ORSCANS** — if the function is successful.  
  
## Remarks  
 The bitmap-stretching mode defines how information is removed from bitmaps that are stretched or compressed by the `StretchBlt` member function.  
  
 The **STRETCH_ANDSCANS** and **STRETCH_ORSCANS** modes are typically used to preserve foreground pixels in monochrome bitmaps. The **STRETCH_DELETESCANS** mode is typically used to preserve color in color bitmaps.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::StretchBlt](../vs140/cdc--stretchblt.md)   
 [CDC::SetStretchBltMode](../vs140/cdc--setstretchbltmode.md)   
 [GetStretchBltMode](http://msdn.microsoft.com/library/windows/desktop/dd144926)