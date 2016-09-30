---
title: "COleServerItem::OnGetExtent"
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
  - "COleServerItem.OnGetExtent"
  - "OnGetExtent"
  - "COleServerItem::OnGetExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetExtent method"
  - "COleServerItem class, overridables"
ms.assetid: ad5f8913-e1a7-40e2-9d55-3f8421f837db
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnGetExtent
Called by the framework to retrieve the size, in **HIMETRIC** units, of the OLE item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the aspect of the OLE item whose bounds are to be retrieved. This parameter can have any of the following values:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that will receive the size of the OLE item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If the container application was written with the Microsoft Foundation Class Library, this function is called when the [GetExtent](../vs140/coleclientitem--getextent.md) member function of the corresponding <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is called. The default implementation does nothing. You must implement it yourself. Override this function if you want to perform special processing when handling a request for the size of the OLE item.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::Draw](../vs140/coleclientitem--draw.md)   
 [COleClientItem::GetExtent](../vs140/coleclientitem--getextent.md)