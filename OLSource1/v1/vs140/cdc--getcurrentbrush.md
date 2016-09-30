---
title: "CDC::GetCurrentBrush"
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
  - "GetCurrentBrush"
  - "CDC.GetCurrentBrush"
  - "CDC::GetCurrentBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, initialization"
  - "GetCurrentBrush method"
ms.assetid: d5fb2b6d-b197-48cf-8167-2b6641c08eaa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetCurrentBrush
Returns a pointer to the currently selected `CBrush` object.  
  
## Syntax  
  
```  
  
CBrush* GetCurrentBrush( ) const;  
```  
  
## Return Value  
 Pointer to a `CBrush` object, if successful; otherwise **NULL**.  
  
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
 [CDC::GetCurrentFont](../vs140/cdc--getcurrentfont.md)   
 [CDC::GetCurrentPalette](../vs140/cdc--getcurrentpalette.md)   
 [CDC::GetCurrentPen](../vs140/cdc--getcurrentpen.md)