---
title: "CBookmark Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL.CBookmark"
  - "ATL::CBookmark<nSize>"
  - "CBookmark"
  - "ATL.CBookmark<nSize>"
  - "ATL::CBookmark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CBookmark class"
ms.assetid: bc942f95-6f93-41d9-bb6e-bcdae4ae0b7a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBookmark Class
Holds a bookmark value in its buffer.  
  
## Syntax  
  
```  
template < DBLENGTH nSize = 0 >  
class CBookmark : public CBookmarkBase  
template < >  
class CBookmark< 0 > : public CBookmarkBase  
```  
  
#### Parameters  
 `nSize`  
 The size of the bookmark buffer in bytes. When `nSize` is zero, the bookmark buffer will be dynamically created at run time.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CBookmark](../vs140/cbookmark-class.md)|The constructor|  
|[GetBuffer](../vs140/cbookmark--getbuffer.md)|Retrieves the pointer to the buffer.|  
|[GetSize](../vs140/cbookmark--getsize.md)|Retrieves the size of the buffer in bytes.|  
|[SetBookmark](../vs140/cbookmark--setbookmark.md)|Sets the bookmark value.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](../vs140/cbookmark--operator-=.md)|Assigns one `CBookmark` class to another.|  
  
## Remarks  
 **CBookmark<0>** is a template specialization of `CBookmark`; its buffer is dynamically created at run time.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)