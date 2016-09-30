---
title: "COleServerItem::OnDrawEx"
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
  - "OnDrawEx"
  - "COleServerItem::OnDrawEx"
  - "COleServerItem.OnDrawEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, overridables"
  - "OnDrawEx method"
ms.assetid: 39fa9d17-4a1e-4a37-b8f8-747bf62d4a40
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnDrawEx
Called by the framework for all drawing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the [CDC](../vs140/cdc-class.md) object on which to draw the item. The DC is automatically connected to the attribute DC so you can call attribute functions, although doing so would make the metafile device-specific.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> enumeration. This parameter can have any of the following values:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Size of the item in **HIMETRIC** units.  
  
## Return Value  
 Nonzero if the item was successfully drawn; otherwise 0.  
  
## Remarks  
 The default implementation calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise it fails.  
  
 Override this function to provide presentation data for aspects other than <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnDraw](../vs140/coleserveritem--ondraw.md)