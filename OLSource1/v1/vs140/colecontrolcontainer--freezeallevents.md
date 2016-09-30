---
title: "COleControlContainer::FreezeAllEvents"
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
  - "COleControlContainer.FreezeAllEvents"
  - "FreezeAllEvents"
  - "COleControlContainer::FreezeAllEvents"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FreezeAllEvents method"
  - "COleControlContainer class, operations"
ms.assetid: 1ffdf48b-2287-4bae-9076-f19b444413ff
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::FreezeAllEvents
Determines if the container will ignore events from the attached control sites or accept them.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Nonzero if events will be processed; otherwise 0.  
  
## Remarks  
  
> [!NOTE]
>  The control is not required to stop firing events if requested by the control container. It can continue firing but all subsequent events will be ignored by the control container.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)