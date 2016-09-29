---
title: "COleControlSite::FreezeEvents"
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
  - "COleControlSite.FreezeEvents"
  - "COleControlSite::FreezeEvents"
  - "FreezeEvents"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FreezeEvents method"
  - "COleControlSite class, operations"
ms.assetid: 2b97e604-0943-4045-ae65-212ef27aa4eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::FreezeEvents
Specifies whether the control site will handle or ignore events fired from a control.  
  
## Syntax  
  
```  
  
      void FreezeEvents(  
   BOOL bFreeze   
);  
```  
  
#### Parameters  
 `bFreeze`  
 Specifies whether the control site wishes to stop accepting events. Nonzero if the control is not accepting events; otherwise zero.  
  
## Remarks  
 If `bFreeze` is **TRUE**, the control site requests the control to stop fring events. If `bFreeze` is **FALSE**, the control site requests the control to continue firing events.  
  
> [!NOTE]
>  The control is not required to stop firing events if requested by the control site. It can continue firing but all subsequent events will be ignored by the control site.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)