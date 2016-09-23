---
title: "COleControlSite::SetDefaultButton"
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
  - COleControlSite.SetDefaultButton
  - SetDefaultButton
  - COleControlSite::SetDefaultButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDefaultButton method
  - COleControlSite class, operations
ms.assetid: 0ccd85fc-0926-4856-bbe9-330e258ec10d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControlSite::SetDefaultButton
Sets the control as the default button.  
  
## Syntax  
  
```  
  
      void SetDefaultButton(  
   BOOL bDefault   
);  
```  
  
#### Parameters  
 `bDefault`  
 Nonzero if the control should become the default button; otherwise zero.  
  
## Remarks  
  
> [!NOTE]
>  The control must have the **OLEMISC_ACTSLIKEBUTTON** status bit set.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite::IsDefaultButton](../vs140/colecontrolsite--isdefaultbutton.md)   
 [DECLARE_OLECTLTYPE](../vs140/declare_olectltype.md)