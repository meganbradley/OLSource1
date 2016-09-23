---
title: "CDC::GetCurrentBitmap"
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
  - CDC::GetCurrentBitmap
  - GetCurrentBitmap
  - CDC.GetCurrentBitmap
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, initialization
  - GetCurrentBitmap method
ms.assetid: 7039f57f-ca41-46b0-a3ca-f4d44bfba0bd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetCurrentBitmap
Returns a pointer to the currently selected `CBitmap` object.  
  
## Syntax  
  
```  
  
CBitmap* GetCurrentBitmap( ) const;  
```  
  
## Return Value  
 Pointer to a `CBitmap` object, if successful; otherwise **NULL**.  
  
## Remarks  
 This member function may return temporary objects.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SelectObject](../vs140/cdc--selectobject.md)   
 [GetCurrentObject](http://msdn.microsoft.com/library/windows/desktop/dd144869)   
 [CDC::GetCurrentBrush](../vs140/cdc--getcurrentbrush.md)   
 [CDC::GetCurrentFont](../vs140/cdc--getcurrentfont.md)   
 [CDC::GetCurrentPalette](../vs140/cdc--getcurrentpalette.md)   
 [CDC::GetCurrentPen](../vs140/cdc--getcurrentpen.md)