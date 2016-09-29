---
title: "COleServerItem::AddOtherClipboardData"
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
  - "COleServerItem::AddOtherClipboardData"
  - "COleServerItem.AddOtherClipboardData"
  - "AddOtherClipboardData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddOtherClipboardData method"
  - "COleServerItem class, operations"
ms.assetid: dbfd884f-bea3-4179-b7eb-c47678bf1c63
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::AddOtherClipboardData
Call this function to place the presentation and conversion formats for the OLE item in the specified `COleDataSource` object.  
  
## Syntax  
  
```  
  
      void AddOtherClipboardData(  
   COleDataSource* pDataSource   
);  
```  
  
#### Parameters  
 `pDataSource`  
 Pointer to the `COleDataSource` object in which the data should be placed.  
  
## Remarks  
 You must have implemented the [OnDraw](../vs140/coleserveritem--ondraw.md) member function to provide the presentation format (a metafile picture) for the item. To support other conversion formats, register them using the [COleDataSource](../vs140/coledatasource-class.md) object returned by [GetDataSource](../vs140/coleserveritem--getdatasource.md) and override the [OnRenderData](../vs140/coleserveritem--onrenderdata.md) member function to provide data in the formats you want to support.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [COleServerItem::GetDataSource](../vs140/coleserveritem--getdatasource.md)   
 [COleServerItem::GetEmbedSourceData](../vs140/coleserveritem--getembedsourcedata.md)   
 [COleServerItem::OnDraw](../vs140/coleserveritem--ondraw.md)