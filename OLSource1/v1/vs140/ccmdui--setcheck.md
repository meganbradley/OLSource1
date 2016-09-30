---
title: "CCmdUI::SetCheck"
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
  - "CCmdUI::SetCheck"
  - "CCmdUI.SetCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdUI class, operations"
  - "SetCheck method"
ms.assetid: 74e103a7-5a7f-4e1b-a4c8-beaed5356d6a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdUI::SetCheck
Call this member function to set the user-interface item for this command to the appropriate check state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the check state to set. If 0, unchecks; if 1, checks; and if 2, sets indeterminate.  
  
## Remarks  
 This member function works for menu items and toolbar buttons. The indeterminate state applies only to toolbar buttons.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdUI Class](../vs140/ccmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdUI::SetRadio](../vs140/ccmdui--setradio.md)