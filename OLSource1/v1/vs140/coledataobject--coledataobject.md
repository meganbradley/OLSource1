---
title: "COleDataObject::COleDataObject"
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
  - "COleDataObject::COleDataObject"
  - "COleDataObject.COleDataObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataObject class, constructor"
ms.assetid: f795147f-9385-406d-838a-3efe3620b1e4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::COleDataObject
Constructs a `COleDataObject` object.  
  
## Syntax  
  
```  
  
COleDataObject( );  
```  
  
## Remarks  
 A call to [COleDataObject::Attach](../vs140/coledataobject--attach.md) or [COleDataObject::AttachClipboard](../vs140/coledataobject--attachclipboard.md) must be made before calling other `COleDataObject` functions.  
  
> [!NOTE]
>  Since one of the parameters to the drag-and-drop handlers is a pointer to a `COleDataObject`, there is no need to call this constructor to support drag and drop.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::Attach](../vs140/coledataobject--attach.md)   
 [COleDataObject::AttachClipboard](../vs140/coledataobject--attachclipboard.md)   
 [COleDataObject::Release](../vs140/coledataobject--release.md)