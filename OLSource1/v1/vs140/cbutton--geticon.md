---
title: "CButton::GetIcon"
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
  - "CButton.GetIcon"
  - "CButton::GetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIcon method"
  - "button objects (CButton), images"
  - "images [C++], button objects"
ms.assetid: 3b183f4c-ae8d-46a5-b45e-77a02786033e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::GetIcon
Call this member function to get the handle of an icon, previously set with [SetIcon](../vs140/cbutton--seticon.md), that is associated with a button.  
  
## Syntax  
  
```  
  
HICON GetIcon( ) const;  
  
```  
  
## Return Value  
 A handle to an icon. **NULL** if no icon is previously specified.  
  
## Example  
 [!code[NVC_MFC_CButton#8](../vs140/codesnippet/CPP/cbutton--geticon_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetIcon](../vs140/cbutton--seticon.md)   
 [CBitmapButton::LoadBitmaps](../vs140/cbitmapbutton--loadbitmaps.md)   
 [Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183377)