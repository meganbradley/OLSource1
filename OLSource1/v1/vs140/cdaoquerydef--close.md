---
title: "CDaoQueryDef::Close"
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
  - "CDaoQueryDef::Close"
  - "CDaoQueryDef.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, releasing OLE interfaces"
  - "Close method"
  - "CDaoQueryDef class, closing"
  - "DAO objects, closing"
  - "DAO objects"
  - "QueryDef objects, closing"
ms.assetid: 6781bedf-f705-416b-80ac-cdc02f48caad
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::Close
Call this member function when you finish using the querydef object.  
  
## Syntax  
  
```  
  
virtual void Close( );  
  
```  
  
## Remarks  
 Closing the querydef releases the underlying DAO object but does not destroy the saved DAO querydef object or the C++ `CDaoQueryDef` object. This is not the same as [CDaoDatabase::DeleteQueryDef](../vs140/cdaodatabase--deletequerydef.md), which deletes the querydef from the database's QueryDefs collection in DAO (if not a temporary querydef).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::Open](../vs140/cdaoquerydef--open.md)   
 [CDaoQueryDef::Create](../vs140/cdaoquerydef--create.md)   
 [CDaoQueryDef::CDaoQueryDef](../vs140/cdaoquerydef--cdaoquerydef.md)