---
title: "CStatusBarCtrl::GetTextLength"
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
  - "CStatusBarCtrl::GetTextLength"
  - "SBT_NOBORDERS"
  - "GetTextLength"
  - "SBT_OWNERDRAW"
  - "CStatusBarCtrl.GetTextLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "status bar controls, text"
  - "SBT_NOBORDERS"
  - "SBT_POPOUT"
  - "SBT_OWNERDRAW"
  - "GetTextLength method"
  - "CStatusBarCtrl class, attributes"
ms.assetid: d9e0b7c5-1180-45a1-b660-2b56a67be4a8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::GetTextLength
Retrieves the length, in characters, of the text from the given part of a status bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of the part from which to retrieve text.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to an integer that receives the type information. The type can be one of these values:  
  
-   **0** The text is drawn with a border to appear lower than the plane of the status bar.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> The text is drawn without borders.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> The text is drawn by the parent window.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> The text is drawn with a border to appear higher than the plane of the status bar.  
  
## Return Value  
 The length, in characters, of the text.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#6](../vs140/codesnippet/CPP/cstatusbarctrl--gettextlength_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::GetText](../vs140/cstatusbarctrl--gettext.md)   
 [CStatusBarCtrl::SetText](../vs140/cstatusbarctrl--settext.md)