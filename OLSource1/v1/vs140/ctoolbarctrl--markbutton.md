---
title: "CToolBarCtrl::MarkButton"
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
  - "CToolBarCtrl.MarkButton"
  - "CToolBarCtrl::MarkButton"
  - "MarkButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MarkButton method"
ms.assetid: 7599854f-7769-407c-9d2e-c841bc53e1bb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::MarkButton
Sets the highlight state of a given button in a toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The button identifier.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the highlight state to be set. By default, **TRUE**. If set to **FALSE**, the button is set to its default state.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_MARKBUTTON](http://msdn.microsoft.com/library/windows/desktop/bb787385), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::IsButtonHighlighted](../vs140/ctoolbarctrl--isbuttonhighlighted.md)