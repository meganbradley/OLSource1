---
title: "CDaoQueryDef::GetName"
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
  - "GetName"
  - "CDaoQueryDef.GetName"
  - "CDaoQueryDef::GetName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, getting information"
  - "names [C++], querydef object"
  - "GetName method"
  - "QueryDef objects, getting names"
ms.assetid: 29fa5581-12ff-491b-91e2-3cbf99fa3577
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetName
Call this member function to retrieve the name of the query represented by the querydef.  
  
## Syntax  
  
```  
  
CString GetName( );  
  
```  
  
## Return Value  
 The name of the query.  
  
## Remarks  
 Querydef names are unique user-defined names. For more information about querydef names, see the topic "Name Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::SetName](../vs140/cdaoquerydef--setname.md)   
 [CDaoQueryDef::GetSQL](../vs140/cdaoquerydef--getsql.md)   
 [CDaoQueryDef::GetReturnsRecords](../vs140/cdaoquerydef--getreturnsrecords.md)   
 [CDaoQueryDef::GetODBCTimeout](../vs140/cdaoquerydef--getodbctimeout.md)