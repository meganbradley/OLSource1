---
title: "COleServerDoc::IsEmbedded"
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
  - "COleServerDoc.IsEmbedded"
  - "IsEmbedded"
  - "COleServerDoc::IsEmbedded"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEmbedded method"
  - "COleServerDoc class, attributes"
ms.assetid: c1cb4d62-dd70-4f83-b1d6-827d916877db
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::IsEmbedded
Call the `IsEmbedded` member function to determine whether the document represents an object embedded in a container.  
  
## Syntax  
  
```  
  
BOOL IsEmbedded( ) const;  
```  
  
## Return Value  
 Nonzero if the `COleServerDoc` object is a document that represents an object embedded in a container; otherwise 0.  
  
## Remarks  
 A document loaded from a file is not embedded although it may be manipulated by a container application as a link. A document that is embedded in a container document is considered to be embedded.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)