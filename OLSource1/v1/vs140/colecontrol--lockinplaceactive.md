---
title: "COleControl::LockInPlaceActive"
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
  - "COleControl.LockInPlaceActive"
  - "COleControl::LockInPlaceActive"
  - "LockInPlaceActive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LockInPlaceActive method"
ms.assetid: 5be99786-c715-43c0-8634-a5d128226882
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::LockInPlaceActive
Prevents the container from deactivating your control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **TRUE** if the in-place active state of the control is to be locked; **FALSE** if it is to be unlocked.  
  
## Return Value  
 Nonzero if the lock was successful; otherwise 0.  
  
## Remarks  
 Note that every locking of the control must be paired with an unlocking of the control when finished. You should only lock your control for short periods, such as while firing an event.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)