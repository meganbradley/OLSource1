---
title: "COleControl::PostModalDialog"
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
  - "COleControl::PostModalDialog"
  - "PostModalDialog"
  - "COleControl.PostModalDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PostModalDialog method"
ms.assetid: 641de8d1-4a75-4dd6-9a64-914c35402d90
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::PostModalDialog
Notifies the container that a modal dialog box has been closed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the parent window of the modal dialog box.  
  
## Remarks  
 Call this function after displaying any modal dialog box. You must call this function so that the container can enable any top-level windows disabled by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. This function should be paired with a call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::PreModalDialog](../vs140/colecontrol--premodaldialog.md)