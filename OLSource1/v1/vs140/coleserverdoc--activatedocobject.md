---
title: "COleServerDoc::ActivateDocObject"
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
  - "ActivateDocObject"
  - "COleServerDoc.ActivateDocObject"
  - "COleServerDoc::ActivateDocObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActivateDocObject method"
ms.assetid: c8eb7edd-807c-4cc0-935b-6a7837bd7f25
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::ActivateDocObject
Activates the associated DocObject document.  
  
## Syntax  
  
```  
  
void ActivateDocObject( );  
  
```  
  
## Remarks  
 By default, `COleServerDoc` does not support Active documents (also referred to as DocObjects). To enable this support, see [GetDocObjectServer](../vs140/coleserverdoc--getdocobjectserver.md) and class [CDocObjectServer](../vs140/cdocobjectserver-class.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::IsDocObject](../vs140/coleserverdoc--isdocobject.md)