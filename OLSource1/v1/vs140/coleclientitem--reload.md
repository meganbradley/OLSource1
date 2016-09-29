---
title: "COleClientItem::Reload"
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
  - "Reload"
  - "COleClientItem::Reload"
  - "COleClientItem.Reload"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reload method"
  - "COleClientItem class, object conversion"
ms.assetid: ce6d9b68-2bbc-47ae-9335-33b58db568c8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::Reload
Closes and reloads the item.  
  
## Syntax  
  
```  
  
BOOL Reload( );  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Call the `Reload` function after activating the item as an item of another type by a call to [ActivateAs](../vs140/coleclientitem--activateas.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::ActivateAs](../vs140/coleclientitem--activateas.md)