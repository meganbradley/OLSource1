---
title: "CButton::SetBitmap"
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
  - CButton::SetBitmap
  - CButton.SetBitmap
dev_langs: 
  - C++
helpviewer_keywords: 
  - button objects (CButton), bitmaps
  - bitmaps, button controls
  - SetBitmap method
ms.assetid: 1f03c1eb-31d3-488e-8fbf-a5ea81899ed5
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CButton::SetBitmap
Call this member function to associate a new bitmap with the button.  
  
## Syntax  
  
```  
  
      HBITMAP SetBitmap(  
   HBITMAP hBitmap   
);  
```  
  
#### Parameters  
 `hBitmap`  
 The handle of a bitmap.  
  
## Return Value  
 The handle of a bitmap previously associated with the button.  
  
## Remarks  
 The bitmap will be automatically placed on the face of the button, centered by default. If the bitmap is too large for the button, it will be clipped on either side. You can choose other alignment options, including the following:  
  
-   **BS_TOP**  
  
-   **BS_LEFT**  
  
-   **BS_RIGHT**  
  
-   **BS_CENTER**  
  
-   **BS_BOTTOM**  
  
-   **BS_VCENTER**  
  
 Unlike [CBitmapButton](../vs140/cbitmapbutton-class.md), which uses four bitmaps per button, `SetBitmap` uses only one bitmap per the button. When the button is pressed, the bitmap appears to shift down and to the right.  
  
 You are responsible for releasing the bitmap when you are done with it.  
  
## Example  
 [!code[NVC_MFC_CButton#4](../vs140/codesnippet/CPP/cbutton--setbitmap_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetBitmap](../vs140/cbutton--getbitmap.md)   
 [CBitmapButton Class](../vs140/cbitmapbutton-class.md)   
 [CBitmapButton::LoadBitmaps](../vs140/cbitmapbutton--loadbitmaps.md)   
 [Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183377)