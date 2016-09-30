---
title: "COleControlSite::COleControlSite"
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
  - "COleControlSite.COleControlSite"
  - "COleControlSite::COleControlSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlSite class, constructor"
ms.assetid: 25b63af5-36d1-4569-af9d-c21577df6bfa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::COleControlSite
Constructs a new `COleControlSite` object.  
  
## Syntax  
  
```  
  
      explicit COleControlSite(  
   COleControlContainer* pCtrlCont   
);  
```  
  
#### Parameters  
 `pCtrlCont`  
 A pointer to the control's container (which represents the window that hosts the AtiveX control).  
  
## Remarks  
 This function is called by the [COccManager::CreateContainer](../vs140/coccmanager--createcontainer.md) function. For more information on customizing the creation of containers, see [COccManager::CreateSite](../vs140/coccmanager--createsite.md).  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite::CreateControl](../vs140/colecontrolsite--createcontrol.md)