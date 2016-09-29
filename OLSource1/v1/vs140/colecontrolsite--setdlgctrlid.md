---
title: "COleControlSite::SetDlgCtrlID"
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
  - "COleControlSite.SetDlgCtrlID"
  - "COleControlSite::SetDlgCtrlID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDlgCtrlID method"
  - "COleControlSite class, operations"
ms.assetid: d71f9661-6a7f-4f88-b378-bdec21066135
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::SetDlgCtrlID
Changes the value of the control's dialog item identifier.  
  
## Syntax  
  
```  
  
      virtual int SetDlgCtrlID(  
   int nID   
);  
```  
  
#### Parameters  
 `nID`  
 The new identifier value.  
  
## Return Value  
 If successful, the previous dialog item identifier of the window; otherwise 0.  
  
## Remarks  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)