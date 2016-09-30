---
title: "CStatusBarCtrl::SetText"
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
  - "CStatusBarCtrl.SetText"
  - "CStatusBarCtrl::SetText"
  - "SBT_POPOUT"
  - "SBT_NOBORDERS"
  - "SBT_OWNERDRAW"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SBT_NOBORDERS"
  - "text, status bar"
  - "SBT_POPOUT"
  - "SBT_OWNERDRAW"
  - "SetText method"
  - "CStatusBarCtrl class, attributes"
ms.assetid: 92ece860-8cfd-467a-9213-fc59dff5ed14
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::SetText
Sets the text in the given part of a status bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Address of a null-terminated string specifying the text to set. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> represents 32 bits of data.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Zero-based index of the part to set. If this value is 255, the status bar control is assumed to be a simple control having only one part.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Type of drawing operation. See [SB_SETTEXT message](http://msdn.microsoft.com/library/bb760758\(VS.85\).aspx) for a list of possible values.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The message invalidates the portion of the control that has changed, causing it to display the new text when the control next receives the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> message.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#11](../vs140/codesnippet/CPP/cstatusbarctrl--settext_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::GetText](../vs140/cstatusbarctrl--gettext.md)   
 [CStatusBarCtrl::GetTextLength](../vs140/cstatusbarctrl--gettextlength.md)