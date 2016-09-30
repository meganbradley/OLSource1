---
title: "CButton::SetCursor"
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
  - "CButton.SetCursor"
  - "CButton::SetCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cursors [C++], cursor image on buttons"
  - "button objects (CButton), images"
  - "images [C++], button objects"
  - "SetCursor method"
ms.assetid: 5cb6c748-e81d-4ecf-8d31-cfa1f015b4e7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetCursor
Call this member function to associate a new cursor with the button.  
  
## Syntax  
  
```  
  
      HCURSOR SetCursor(  
   HCURSOR hCursor   
);  
```  
  
#### Parameters  
 `hCursor`  
 The handle of a cursor.  
  
## Return Value  
 The handle of a cursor previously associated with the button.  
  
## Remarks  
 The cursor will be automatically placed on the face of the button, centered by default. If the cursor is too large for the button, it will be clipped on either side. You can choose other alignment options, including the following:  
  
-   **BS_TOP**  
  
-   **BS_LEFT**  
  
-   **BS_RIGHT**  
  
-   **BS_CENTER**  
  
-   **BS_BOTTOM**  
  
-   **BS_VCENTER**  
  
 Unlike [CBitmapButton](../vs140/cbitmapbutton-class.md), which uses four bitmaps per button, `SetCursor` uses only one cursor per the button. When the button is pressed, the cursor appears to shift down and to the right.  
  
## Example  
 [!code[NVC_MFC_CButton#7](../vs140/codesnippet/CPP/cbutton--setcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetCursor](../vs140/cbutton--getcursor.md)   
 [CBitmapButton::LoadBitmaps](../vs140/cbitmapbutton--loadbitmaps.md)   
 [Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183377)