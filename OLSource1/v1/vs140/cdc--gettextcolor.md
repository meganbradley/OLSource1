---
title: "CDC::GetTextColor"
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
  - "GetTextColor"
  - "CDC.GetTextColor"
  - "CDC::GetTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "GetTextColor method"
ms.assetid: 13b1e59e-a246-49e4-8e4b-c1b100d34e3f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetTextColor
Retrieves the current text color.  
  
## Syntax  
  
```  
  
COLORREF GetTextColor( ) const;  
```  
  
## Return Value  
 The current text color as an RGB color value.  
  
## Remarks  
 The text color is the foreground color of characters drawn by using the GDI text-output member functions [TextOut](../vs140/cdc--textout.md), [ExtTextOut](../vs140/cdc--exttextout.md), and [TabbedTextOut](../vs140/cdc--tabbedtextout.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetBkColor](../vs140/cdc--getbkcolor.md)   
 [CDC::GetBkMode](../vs140/cdc--getbkmode.md)   
 [CDC::SetBkMode](../vs140/cdc--setbkmode.md)   
 [CDC::SetTextColor](../vs140/cdc--settextcolor.md)   
 [GetTextColor](http://msdn.microsoft.com/library/windows/desktop/dd144934)