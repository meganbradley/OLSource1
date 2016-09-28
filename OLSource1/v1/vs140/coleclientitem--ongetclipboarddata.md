---
title: "COleClientItem::OnGetClipboardData"
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
  - "COleClientItem::OnGetClipboardData"
  - "OnGetClipboardData"
  - "COleClientItem.OnGetClipboardData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetClipboardData method"
  - "COleClientItem class, overridables"
ms.assetid: f5f04aa5-2fd2-4647-8242-ef3ee9232c42
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnGetClipboardData
Called by the framework to get a `COleDataSource` object containing all the data that would be placed on the Clipboard by a call to either the [CopyToClipboard](../vs140/coleclientitem--copytoclipboard.md) or the [DoDragDrop](../vs140/coleclientitem--dodragdrop.md) member function.  
  
## Syntax  
  
```  
  
      virtual COleDataSource* OnGetClipboardData(  
   BOOL bIncludeLink,  
   LPPOINT lpOffset,  
   LPSIZE lpSize   
);  
```  
  
#### Parameters  
 `bIncludeLink`  
 Set this to **TRUE** if link data should be copied to the Clipboard. Set this to **FALSE** if your server application does not support links.  
  
 `lpOffset`  
 Pointer to the offset of the mouse cursor from the origin of the object in pixels.  
  
 `lpSize`  
 Pointer to the size of the object in pixels.  
  
## Return Value  
 A pointer to a [COleDataSource](../vs140/coledatasource-class.md) object containing the Clipboard data.  
  
## Remarks  
 The default implementation of this function calls [GetClipboardData](../vs140/coleclientitem--getclipboarddata.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [COleClientItem::CopyToClipboard](../vs140/coleclientitem--copytoclipboard.md)   
 [COleClientItem::GetClipboardData](../vs140/coleclientitem--getclipboarddata.md)   
 [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md)