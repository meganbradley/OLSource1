---
title: "COleServerItem::CopyToClipboard"
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
  - "COleServerItem::CopyToClipboard"
  - "CopyToClipboard"
  - "COleServerItem.CopyToClipboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyToClipboard method"
  - "COleServerItem class, operations"
ms.assetid: ed7b33a0-ab33-43e1-9881-5a75f039d7fe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::CopyToClipboard
Call this function to copy the OLE item to the Clipboard.  
  
## Syntax  
  
```  
  
      void CopyToClipboard(  
   BOOL bIncludeLink = FALSE   
);   
```  
  
#### Parameters  
 `bIncludeLink`  
 Set this to **TRUE** if link data should be copied to the Clipboard. Set this to **FALSE** if your server application does not support links.  
  
## Remarks  
 The function uses the [OnGetClipboardData](../vs140/coleserveritem--ongetclipboarddata.md) member function to create a [COleDataSource](../vs140/coledatasource-class.md) object containing the OLE item's data in the formats supported. The function then places the `COleDataSource` object on the Clipboard by using the [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md) function. The `COleDataSource` object includes the item's native data and its representation in `CF_METAFILEPICT` format, as well as data in any conversion formats you choose to support. You must have implemented [Serialize](../vs140/cobject--serialize.md) and [OnDraw](../vs140/coleserveritem--ondraw.md) for this member function to work.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md)   
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [COleServerItem::AddOtherClipboardData](../vs140/coleserveritem--addotherclipboarddata.md)   
 [COleServerItem::GetClipboardData](../vs140/coleserveritem--getclipboarddata.md)   
 [COleServerItem::OnDraw](../vs140/coleserveritem--ondraw.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)