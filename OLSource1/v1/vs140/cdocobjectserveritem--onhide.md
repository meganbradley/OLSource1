---
title: "CDocObjectServerItem::OnHide"
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
  - "OnHide"
  - "CDocObjectServerItem::OnHide"
  - "CDocObjectServerItem.OnHide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHide method"
ms.assetid: 67d2ef14-343e-4055-8166-7aa3630378aa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServerItem::OnHide
Called by the framework to hide the item.  
  
## Syntax  
  
```  
  
virtual void OnHide( );  
```  
  
## Remarks  
 The default implementation throws an exception if the item is a DocObject. You cannot hide an active DocObject item because it takes the whole view. You must deactivate the DocObject item to make it disappear. If the item is not a DocObject, the default implementation calls [COleServerItem::OnHide](../vs140/coleserveritem--onhide.md).  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [CDocObjectServerItem Class](../vs140/cdocobjectserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServerItem::OnOpen](assetId:///7a9b1363-6ad8-4732-9959-4e35c07644fd)   
 [CDocObjectServerItem::OnShow](../vs140/cdocobjectserveritem--onshow.md)