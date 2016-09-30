---
title: "CButton::SetState"
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
  - "CButton::SetState"
  - "CButton.SetState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "button objects (CButton), button states"
  - "SetState method"
ms.assetid: f8187e26-5906-425b-b566-a55d44944a62
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetState
Sets whether a button control is highlighted or not.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *bHighlight*  
 Specifies whether the button is to be highlighted. A nonzero value highlights the button; a 0 value removes any highlighting.  
  
## Remarks  
 Highlighting affects the exterior of a button control. It has no effect on the check state of a radio button or check box.  
  
 A button control is automatically highlighted when the user clicks and holds the left mouse button. The highlighting is removed when the user releases the mouse button.  
  
## Example  
 [!code[NVC_MFC_CButton#9](../vs140/codesnippet/CPP/cbutton--setstate_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetState](../vs140/cbutton--getstate.md)   
 [CButton::SetCheck](../vs140/cbutton--setcheck.md)   
 [CButton::GetCheck](../vs140/cbutton--getcheck.md)   
 [BM_SETSTATE](http://msdn.microsoft.com/library/windows/desktop/bb761823)