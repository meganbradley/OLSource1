---
title: "COleControlContainer::SetDlgItemText"
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
  - "COleControlContainer.SetDlgItemText"
  - "COleControlContainer::SetDlgItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "SetDlgItemText method"
ms.assetid: 06b8494e-26bd-41a6-915f-5dec654a8caf
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::SetDlgItemText
Sets the text of the specified control, using the text contained in `lpszString`.  
  
## Syntax  
  
```  
  
      virtual void SetDlgItemText(  
   int nID,  
   LPCTSTR lpszString   
);  
```  
  
#### Parameters  
 `nID`  
 The identifier of the control.  
  
 `lpszString`  
 Pointer to the text of the control.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)