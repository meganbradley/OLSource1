---
title: "CDocObjectServerItem::OnShow"
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
  - "CDocObjectServerItem::OnShow"
  - "OnShow"
  - "CDocObjectServerItem.OnShow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShow method"
ms.assetid: c156e330-aaa8-49ca-b419-1459d219840b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServerItem::OnShow
Called by the framework to instruct the server application to make the DocObject item in-place active.  
  
## Syntax  
  
```  
  
virtual void OnShow( );  
```  
  
## Remarks  
 If the item is not a DocObject, the default implementation calls [COleServerItem::OnShow](../vs140/coleserveritem--onopen.md). Override this function if you want to perform special processing when opening a DocObject item.  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [CDocObjectServerItem Class](../vs140/cdocobjectserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServerItem::OnHide](../vs140/cdocobjectserveritem--onhide.md)   
 [CDocObjectServerItem::OnOpen](assetId:///7a9b1363-6ad8-4732-9959-4e35c07644fd)