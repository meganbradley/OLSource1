---
title: "CDC::GetBkColor"
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
  - "CDC.GetBkColor"
  - "CDC::GetBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "GetBkColor method"
ms.assetid: d5511e3b-5a2f-4c92-b506-b13f0fb00695
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetBkColor
Returns the current background color.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An RGB color value.  
  
## Remarks  
 If the background mode is **OPAQUE**, the system uses the background color to fill the gaps in styled lines, the gaps between hatched lines in brushes, and the background in character cells. The system also uses the background color when converting bitmaps between color and monochrome device contexts.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetBkMode](../vs140/cdc--getbkmode.md)   
 [CDC::SetBkColor](../vs140/cdc--setbkcolor.md)   
 [CDC::SetBkMode](../vs140/cdc--setbkmode.md)   
 [GetBkColor](http://msdn.microsoft.com/library/windows/desktop/dd144852)