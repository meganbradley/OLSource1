---
title: "COleControlContainer::FindItem"
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
  - "COleControlContainer::FindItem"
  - "COleControlContainer.FindItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "FindItem method"
ms.assetid: 3bb9e8ca-eb26-4109-9aa0-c86b248938df
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::FindItem
Finds the custom site that hosts the specified item.  
  
## Syntax  
  
```  
  
      virtual COleControlSite* FindItem(  
   UINT nID   
) const;  
```  
  
#### Parameters  
 `nID`  
 The identifier of the item to be found.  
  
## Return Value  
 A pointer to the custom site of the specified item.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)