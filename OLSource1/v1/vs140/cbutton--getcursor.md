---
title: "CButton::GetCursor"
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
  - "GetCursor"
  - "CButton::GetCursor"
  - "CButton.GetCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "button objects (CButton), images"
  - "images [C++], button objects"
  - "GetCursor method"
ms.assetid: 1ec82c5e-a2f9-4321-b4f6-33cdf605bdcc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::GetCursor
Call this member function to get the handle of a cursor, previously set with [SetCursor](../vs140/cbutton--setcursor.md), that is associated with a button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A handle to a cursor image. **NULL** if no cursor is previously specified.  
  
## Example  
 [!code[NVC_MFC_CButton#7](../vs140/codesnippet/CPP/cbutton--getcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetCursor](../vs140/cbutton--setcursor.md)   
 [CBitmapButton::LoadBitmaps](../vs140/cbitmapbutton--loadbitmaps.md)   
 [Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183377)