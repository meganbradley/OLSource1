---
title: "CStatusBarCtrl::GetText"
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
  - "SBT_POPOUT"
  - "SBT_NOBORDERS"
  - "CStatusBarCtrl.GetText"
  - "CStatusBarCtrl::GetText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetText method"
  - "status bar controls, text"
  - "SBT_NOBORDERS"
  - "text, status bar"
  - "SBT_POPOUT"
  - "CStatusBarCtrl class, attributes"
ms.assetid: cce3c667-6541-49b8-9074-064d1b986c0e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::GetText
Retrieves the text from the given part of a status bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Address of the buffer that receives the text. This parameter is a null-terminated string.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Zero-based index of the part from which to retrieve text.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to an integer that receives the type information. The type can be one of these values:  
  
-   **0** The text is drawn with a border to appear lower than the plane of the status bar.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> The text is drawn without borders.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> The text is drawn with a border to appear higher than the plane of the status bar.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> If the text has the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> drawing type, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> receives this message and returns the 32-bit value associated with the text instead of the length and operation type.  
  
## Return Value  
 The length, in characters, of the text or a [CString](../vs140/cstringt-class.md) containing the current text.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#5](../vs140/codesnippet/CPP/cstatusbarctrl--gettext_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::SetText](../vs140/cstatusbarctrl--settext.md)   
 [CStatusBarCtrl::GetTextLength](../vs140/cstatusbarctrl--gettextlength.md)