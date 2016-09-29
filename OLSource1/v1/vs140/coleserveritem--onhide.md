---
title: "COleServerItem::OnHide"
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
  - "COleServerItem.OnHide"
  - "COleServerItem::OnHide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, overridables"
  - "OnHide method"
ms.assetid: c325e9ef-b90a-4769-9743-de6eb1dc0366
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnHide
Called by the framework to hide the OLE item.  
  
## Syntax  
  
```  
  
virtual void OnHide( );  
```  
  
## Remarks  
 The default calls **COleServerDoc::OnShowDocument( FALSE )**. The function also notifies the container that the OLE item has been hidden. Override this function if you want to perform special processing when hiding an OLE item.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnOpen](../vs140/coleserveritem--onopen.md)   
 [COleServerItem::OnShow](../vs140/coleserveritem--onshow.md)   
 [COleServerDoc::OnShowDocument](../vs140/coleserverdoc--onshowdocument.md)