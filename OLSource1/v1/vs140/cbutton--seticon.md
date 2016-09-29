---
title: "CButton::SetIcon"
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
  - "CButton::SetIcon"
  - "CButton.SetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "icons [C++], buttons"
  - "SetIcon method"
  - "button objects (CButton), images"
  - "images [C++], button objects"
ms.assetid: b8a91ece-ff51-492a-a978-a4d4acba813a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetIcon
Call this member function to associate a new icon with the button.  
  
## Syntax  
  
```  
  
      HICON SetIcon(  
   HICON hIcon   
);  
```  
  
#### Parameters  
 `hIcon`  
 The handle of an icon.  
  
## Return Value  
 The handle of an icon previously associated with the button.  
  
## Remarks  
 The icon will be automatically placed on the face of the button, centered by default. If the icon is too large for the button, it will be clipped on either side. You can choose other alignment options, including the following:  
  
-   **BS_TOP**  
  
-   **BS_LEFT**  
  
-   **BS_RIGHT**  
  
-   **BS_CENTER**  
  
-   **BS_BOTTOM**  
  
-   **BS_VCENTER**  
  
 Unlike [CBitmapButton](../vs140/cbitmapbutton-class.md), which uses four bitmaps per button, `SetIcon` uses only one icon per the button. When the button is pressed, the icon appears to shift down and to the right.  
  
## Example  
 [!code[NVC_MFC_CButton#8](../vs140/codesnippet/CPP/cbutton--seticon_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetIcon](../vs140/cbutton--geticon.md)   
 [CBitmapButton::LoadBitmaps](../vs140/cbitmapbutton--loadbitmaps.md)   
 [Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183377)