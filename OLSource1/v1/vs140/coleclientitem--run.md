---
title: "COleClientItem::Run"
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
  - "COleClientItem::Run"
  - "COleClientItem.Run"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Run method"
  - "COleClientItem class, general operations"
ms.assetid: 1ff40232-bb2c-464f-84b5-9896d739e7b2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::Run
Runs the application associated with this item.  
  
## Syntax  
  
```  
  
void Run( );  
```  
  
## Remarks  
 Call the **Run** member function to launch the server application before activating the item. This is done automatically by [Activate](../vs140/coleclientitem--activate.md) and [DoVerb](../vs140/coleclientitem--doverb.md), so it is usually not necessary to call this function. Call this function if it is necessary to run the server in order to set an item attribute, such as [SetExtent](../vs140/coleclientitem--setextent.md), before executing [DoVerb](../vs140/coleclientitem--doverb.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::IsRunning](../vs140/coleclientitem--isrunning.md)