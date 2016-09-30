---
title: "CStatusBar::SetPaneText"
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
  - "CStatusBar::SetPaneText"
  - "CStatusBar.SetPaneText"
  - "SetPaneText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "status bars, text"
  - "text, status bar"
  - "CStatusBar class, attributes"
  - "SetPaneText method"
ms.assetid: 55337683-8804-4ff9-849e-e4c336d264b1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBar::SetPaneText
Call this member function to set the pane text to the string pointed to by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Index of the pane whose text is to be set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the new pane text.  
  
 *bUpdate*  
 If **TRUE**, the pane is invalidated after the text is set.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 After you call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you must add a UI update handler to display the new text in the status bar.  
  
## Example  
 [!code[NVC_MFCDocView#176](../vs140/codesnippet/CPP/cstatusbar--setpanetext_1.cpp)]  
  
 [!code[NVC_MFCDocView#177](../vs140/codesnippet/CPP/cstatusbar--setpanetext_2.cpp)]  
  
 [!code[NVC_MFCDocView#178](../vs140/codesnippet/CPP/cstatusbar--setpanetext_3.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBar::GetPaneText](../vs140/cstatusbar--getpanetext.md)