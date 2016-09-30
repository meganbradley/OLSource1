---
title: "COleServerItem::OnGetClipboardData"
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
  - "OnGetClipboardData"
  - "COleServerItem.OnGetClipboardData"
  - "COleServerItem::OnGetClipboardData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, overridables"
  - "OnGetClipboardData method"
ms.assetid: bd26d0ed-c9a8-4dc8-b996-67fde63f5ed1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnGetClipboardData
Called by the framework to get a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object containing all the data that would be placed on the Clipboard by a call to the [CopyToClipboard](../vs140/coleserveritem--copytoclipboard.md) member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Set this to **TRUE** if link data should be copied to the Clipboard. Set this to **FALSE** if your server application does not support links.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The offset of the mouse cursor from the origin of the object in pixels.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of the object in pixels.  
  
## Return Value  
 A pointer to a [COleDataSource](../vs140/coledatasource-class.md) object containing the Clipboard data.  
  
## Remarks  
 The default implementation of this function calls [GetClipboardData](../vs140/coleserveritem--getclipboarddata.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md)   
 [COleServerItem::CopyToClipboard](../vs140/coleserveritem--copytoclipboard.md)   
 [COleServerItem::GetClipboardData](../vs140/coleserveritem--getclipboarddata.md)