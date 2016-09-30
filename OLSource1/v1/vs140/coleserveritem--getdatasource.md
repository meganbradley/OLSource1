---
title: "COleServerItem::GetDataSource"
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
  - "GetDataSource"
  - "COleServerItem::GetDataSource"
  - "COleServerItem.GetDataSource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, construction/destruction"
  - "GetDataSource method"
ms.assetid: 8bc35ff6-aece-4c01-9721-dcc62d750cdc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::GetDataSource
Call this function to get the [COleDataSource](../vs140/coledatasource-class.md) object used to store the conversion formats that the server application supports.  
  
## Syntax  
  
```  
  
COleDataSource* GetDataSource( );   
```  
  
## Return Value  
 A pointer to the `COleDataSource` object used to store the conversion formats.  
  
## Remarks  
 If you want your server application to offer data in a variety of formats during data transfer operations, register those formats with the `COleDataSource` object returned by this function. For example, if you want to supply a **CF_TEXT** representation of the OLE item for Clipboard or drag-and-drop operations, you would register the format with the `COleDataSource` object this function returns, and then override the **OnRenderXxxData** member function to provide the data.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [COleDataSource::DelayRenderData](../vs140/coledatasource--delayrenderdata.md)   
 [COleServerItem::CopyToClipboard](../vs140/coleserveritem--copytoclipboard.md)   
 [COleServerItem::DoDragDrop](../vs140/coleserveritem--dodragdrop.md)   
 [COleServerItem::OnRenderData](../vs140/coleserveritem--onrenderdata.md)   
 [COleServerItem::OnRenderFileData](../vs140/coleserveritem--onrenderfiledata.md)   
 [COleServerItem::OnRenderGlobalData](../vs140/coleserveritem--onrenderglobaldata.md)