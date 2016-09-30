---
title: "COleControlSite::SetFocus"
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
  - "COleControlSite.SetFocus"
  - "COleControlSite::SetFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFocus method"
  - "COleControlSite class, overridables"
ms.assetid: fdbef03c-d449-41a0-a8b1-99aaf06508a8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::SetFocus
Sets focus to the control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpmsg*  
 A pointer to a [MSG](../vs140/msg-structure.md) structure. This structure contains the Windows message triggering the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> request for the control contained in the current control site.  
  
## Return Value  
 A pointer to the window that previously had focus.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)