---
title: "CDC::GetCurrentFont"
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
  - "CDC.GetCurrentFont"
  - "CDC::GetCurrentFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCurrentFont method"
  - "CDC class, initialization"
ms.assetid: c4fbfc39-c081-499c-bc96-f34d7ec75dde
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetCurrentFont
Returns a pointer to the currently selected `CFont` object.  
  
## Syntax  
  
```  
  
CFont* GetCurrentFont( ) const;  
```  
  
## Return Value  
 Pointer to a `CFont` object, if successful; otherwise **NULL**.  
  
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
 [CDC::GetCurrentPalette](../vs140/cdc--getcurrentpalette.md)   
 [CDC::GetCurrentPen](../vs140/cdc--getcurrentpen.md)