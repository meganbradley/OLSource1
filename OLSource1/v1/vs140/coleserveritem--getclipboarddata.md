---
title: "COleServerItem::GetClipboardData"
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
  - "COleServerItem::GetClipboardData"
  - "COleServerItem.GetClipboardData"
  - "GetClipboardData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClipboardData method"
  - "COleServerItem class, operations"
ms.assetid: dae8b8f5-8eac-4b40-9616-1e3138a99c3d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::GetClipboardData
Call this function to fill the specified [COleDataSource](../vs140/coledatasource-class.md) object with all the data that would be copied to the Clipboard if you called [CopyToClipboard](../vs140/coleserveritem--copytoclipboard.md) (the same data would also be transferred if you called [DoDragDrop](../vs140/coleserveritem--dodragdrop.md)).  
  
## Syntax  
  
```  
  
      void GetClipboardData(  
   COleDataSource* pDataSource,  
   BOOL bIncludeLink = FALSE,  
   LPPOINT lpOffset = NULL,  
   LPSIZE lpSize = NULL   
);  
```  
  
#### Parameters  
 `pDataSource`  
 Pointer to the `COleDataSource` object that will receive the OLE item's data in all supported formats.  
  
 `bIncludeLink`  
 **TRUE** if link data should be copied to the Clipboard. **FALSE** if your server application does not support links.  
  
 `lpOffset`  
 The offset, in pixels, of the mouse cursor from the origin of the object.  
  
 `lpSize`  
 The size of the object in pixels.  
  
## Remarks  
 This function calls the [GetEmbedSourceData](../vs140/coleserveritem--getembedsourcedata.md) member function to get the native data for the OLE item and calls the [AddOtherClipboardData](../vs140/coleserveritem--addotherclipboarddata.md) member function to get the presentation format and any supported conversion formats. If `bIncludeLink` is **TRUE**, the function also calls [GetLinkSourceData](../vs140/coleserveritem--getlinksourcedata.md) to get the link data for the item.  
  
 Override this function if you want to put formats in a `COleDataSource` object before or after those formats supplied by `CopyToClipboard`.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [COleServerItem::AddOtherClipboardData](../vs140/coleserveritem--addotherclipboarddata.md)   
 [COleServerItem::CopyToClipboard](../vs140/coleserveritem--copytoclipboard.md)   
 [COleServerItem::DoDragDrop](../vs140/coleserveritem--dodragdrop.md)   
 [COleServerItem::GetEmbedSourceData](../vs140/coleserveritem--getembedsourcedata.md)   
 [COleServerItem::GetLinkSourceData](../vs140/coleserveritem--getlinksourcedata.md)