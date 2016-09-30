---
title: "COleClientItem::CanCreateLinkFromData"
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
  - "COleClientItem.CanCreateLinkFromData"
  - "COleClientItem::CanCreateLinkFromData"
  - "CanCreateLinkFromData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanCreateLinkFromData method"
ms.assetid: 823e6261-424e-40a2-b1cb-904da2305df7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::CanCreateLinkFromData
Checks whether a container application can create a linked object from the given <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the [COleDataObject](../vs140/coledataobject-class.md) object from which the OLE item is to be created.  
  
## Return Value  
 Nonzero if the container can create a linked object from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class is used in data transfers for retrieving data in various formats from the Clipboard, through drag and drop, or from an embedded OLE item.  
  
 Containers can use this function to decide to enable or disable their Edit Paste Special and Edit Paste Link commands.  
  
 For more information, see the article [Data Objects and Data Sources (OLE)](../vs140/data-objects-and-data-sources--ole-.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject Class](../vs140/coledataobject-class.md)