---
title: "CDC::GetCurrentPalette"
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
  - "CDC.GetCurrentPalette"
  - "GetCurrentPalette"
  - "CDC::GetCurrentPalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCurrentPalette method"
  - "CDC class, initialization"
ms.assetid: 7afb12a8-dbfe-4f1c-955a-631f30fd6ab0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetCurrentPalette
Returns a pointer to the currently selected `CPalette` object.  
  
## Syntax  
  
```  
  
CPalette* GetCurrentPalette( ) const;  
```  
  
## Return Value  
 Pointer to a `CPalette` object, if successful; otherwise **NULL**.  
  
## Remarks  
 This member function may return temporary objects.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SelectObject](../vs140/cdc--selectobject.md)   
 [GetCurrentObject](http://msdn.microsoft.com/library/windows/desktop/dd144869)   
 [CDC::GetCurrentBitmap](../vs140/cdc--getcurrentbitmap.md)   
 [CDC::GetCurrentBrush](../vs140/cdc--getcurrentbrush.md)   
 [CDC::GetCurrentFont](../vs140/cdc--getcurrentfont.md)   
 [CDC::GetCurrentPen](../vs140/cdc--getcurrentpen.md)