---
title: "COleServerItem::OnShow"
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
  - "OnShow"
  - "COleServerItem::OnShow"
  - "COleServerItem.OnShow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, overridables"
  - "OnShow method"
ms.assetid: 24845599-530d-41cd-82eb-1b6622ea51ba
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnShow
Called by the framework to instruct the server application to display the OLE item in place.  
  
## Syntax  
  
```  
  
virtual void OnShow( );  
```  
  
## Remarks  
 This function is typically called when the user of the container application creates an item or executes a verb, such as Edit, that requires the item to be shown. The default implementation attempts in-place activation. If this fails, the function calls the `OnOpen` member function to display the OLE item in a separate window.  
  
 Override this function if you want to perform special processing when an OLE item is shown.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnOpen](../vs140/coleserveritem--onopen.md)   
 [COleClientItem::Activate](../vs140/coleclientitem--activate.md)