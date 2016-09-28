---
title: "COleClientItem::AttachDataObject"
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
  - "COleClientItem.AttachDataObject"
  - "AttachDataObject"
  - "COleClientItem::AttachDataObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AttachDataObject method"
  - "COleClientItem class, data access"
ms.assetid: 23256df7-0cbc-4dca-a352-66d8c057df97
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::AttachDataObject
Call this function to initialize a [COleDataObject](../vs140/coledataobject-class.md) for accessing the data in the OLE item.  
  
## Syntax  
  
```  
  
      void AttachDataObject(  
   COleDataObject& rDataObject   
) const;  
```  
  
#### Parameters  
 *rDataObject*  
 Reference to a `COleDataObject` object that will be initialized to allow access to the data in the OLE item.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject Class](../vs140/coledataobject-class.md)