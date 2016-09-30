---
title: "CDaoQueryDef::Open"
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
  - "CDaoQueryDef::Open"
  - "CDaoQueryDef.Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryDef objects, opening"
  - "stored queries, opening"
  - "queries [C++], saved queries"
  - "opening querydefs"
  - "Open method"
  - "saved queries, opening"
  - "stored queries"
  - "CDaoQueryDef class, opening"
ms.assetid: 35518f9d-7927-4ac1-9f90-7043ff81ed28
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::Open
Call this member function to open a querydef previously saved in the database's QueryDefs collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the name of the saved querydef to open. You can use a [CString](../vs140/cstringt-class.md).  
  
## Remarks  
 Once the querydef is open, you can call its [Execute](../vs140/cdaoquerydef--execute.md) member function or use the querydef to create a [CDaoRecordset](../vs140/cdaorecordset-class.md) object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::IsOpen](../vs140/cdaoquerydef--isopen.md)   
 [CDaoQueryDef::Close](../vs140/cdaoquerydef--close.md)   
 [CDaoQueryDef::SetName](../vs140/cdaoquerydef--setname.md)   
 [CDaoQueryDef::Create](../vs140/cdaoquerydef--create.md)