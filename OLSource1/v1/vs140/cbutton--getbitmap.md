---
title: "CButton::GetBitmap"
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
  - "CButton.GetBitmap"
  - "CButton::GetBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBitmap method"
  - "button objects (CButton), bitmaps"
  - "bitmaps, button controls"
ms.assetid: 76d3eb3e-0ee4-44bf-b9b7-534efa8bdead
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::GetBitmap
Call this member function to get the handle of a bitmap, previously set with [SetBitmap](../vs140/cbutton--setbitmap.md), that is associated with a button.  
  
## Syntax  
  
```  
  
HBITMAP GetBitmap( ) const;  
  
```  
  
## Return Value  
 A handle to a bitmap. **NULL** if no bitmap is previously specified.  
  
## Example  
 [!code[NVC_MFC_CButton#4](../vs140/codesnippet/CPP/cbutton--getbitmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetBitmap](../vs140/cbutton--setbitmap.md)   
 [CBitmapButton::LoadBitmaps](../vs140/cbitmapbutton--loadbitmaps.md)   
 [Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183377)