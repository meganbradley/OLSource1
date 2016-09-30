---
title: "COleClientItem::GetClipboardData"
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
  - "COleClientItem.GetClipboardData"
  - "GetClipboardData"
  - "COleClientItem::GetClipboardData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, clipboard operations"
  - "GetClipboardData method"
ms.assetid: 8bad19ca-281a-4fe0-aa62-2bdb593c38b8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetClipboardData
Call this function to get a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object containing all the data that would be placed on the Clipboard by a call to the [CopyToClipboard](../vs140/coleclientitem--copytoclipboard.md) member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a [COleDataSource](../vs140/coledatasource-class.md) object that will receive the data contained in the OLE item.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **TRUE** if link data should be included; otherwise **FALSE**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The offset of the mouse cursor from the origin of the object in pixels.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The size of the object in pixels.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called as the default implementation of [OnGetClipboardData](../vs140/coleclientitem--ongetclipboarddata.md). Override <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> only if you want to offer data formats in addition to those offered by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Place those formats in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object before or after calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and then pass the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object to the [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md) function. For example, if you want the OLE item's position in its container document to accompany it on the Clipboard, you would define your own format for passing that information and place it in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [COleClientItem::CopyToClipboard](../vs140/coleclientitem--copytoclipboard.md)   
 [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md)