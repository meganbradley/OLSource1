---
title: "COleControl::IsModified"
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
  - "COleControl::IsModified"
  - "IsModified"
  - "COleControl.IsModified"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsModified method"
ms.assetid: 6d1c701b-21cc-48f2-a172-17903531dfac
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::IsModified
Determines if the control's state has been modified.  
  
## Syntax  
  
```  
  
BOOL IsModified( );  
```  
  
## Return Value  
 Nonzero if the control's state has been modified since it was last saved; otherwise 0.  
  
## Remarks  
 The state of a control is modified when a property changes value.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetModifiedFlag](../vs140/colecontrol--setmodifiedflag.md)