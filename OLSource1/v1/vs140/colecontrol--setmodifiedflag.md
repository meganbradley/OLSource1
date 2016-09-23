---
title: "COleControl::SetModifiedFlag"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleControl::SetModifiedFlag
  - COleControl.SetModifiedFlag
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetModifiedFlag method
ms.assetid: b7cb244f-921e-4650-87d2-3864bef3e681
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::SetModifiedFlag
Changes the modified state of a control.  
  
## Syntax  
  
```  
  
      void SetModifiedFlag(  
   BOOL bModified = TRUE   
);  
```  
  
#### Parameters  
 `bModified`  
 The new value for the control's modified flag. **TRUE** indicates that the control's state has been modified; **FALSE** indicates that the control's state has just been saved.  
  
## Remarks  
 Call this function whenever a change occurs that would affect your control's persistent state. For example, if the value of a persistent property changes, call this function with `bModified` **TRUE**.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::IsModified](../vs140/colecontrol--ismodified.md)