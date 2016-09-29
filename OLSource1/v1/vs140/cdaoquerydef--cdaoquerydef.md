---
title: "CDaoQueryDef::CDaoQueryDef"
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
  - "CDaoQueryDef.CDaoQueryDef"
  - "CDaoQueryDef::CDaoQueryDef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryDef construction"
  - "CDaoQueryDef class, other members to call during construction"
  - "DAO (Data Access Objects), constructors"
  - "CDaoQueryDef class, constructor"
  - "QueryDef objects, constructing"
ms.assetid: 54597e10-2af6-4b3a-86a3-ad3d85c68554
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::CDaoQueryDef
Constructs a **CDaoQueryDef** object.  
  
## Syntax  
  
```  
  
      CDaoQueryDef(  
   CDaoDatabase* pDatabase   
);  
```  
  
#### Parameters  
 `pDatabase`  
 A pointer to an open [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
## Remarks  
 The object can represent an existing querydef stored in the database's QueryDefs collection, a new query to be stored in the collection, or a temporary query, not to be stored. Your next step depends on the type of querydef:  
  
-   If the object represents an existing querydef, call the object's [Open](../vs140/cdaoquerydef--open.md) member function to initialize it.  
  
-   If the object represents a new querydef to be saved, call the object's [Create](../vs140/cdaoquerydef--create.md) member function. This adds the object to the database's QueryDefs collection. Then call `CDaoQueryDef` member functions to set the object's attributes. Finally, call [Append](../vs140/cdaoquerydef--append.md).  
  
-   If the object represents a temporary querydef (not to be saved in the database), call **Create**, passing an empty string for the query's name. After calling **Create**, initialize the querydef by directly setting its attributes. Do not call **Append**.  
  
 To set the attributes of the querydef, you can use the [SetName](../vs140/cdaoquerydef--setname.md), [SetSQL](../vs140/cdaoquerydef--setsql.md), [SetConnect](../vs140/cdaoquerydef--setconnect.md), [SetODBCTimeout](../vs140/cdaoquerydef--setodbctimeout.md), and [SetReturnsRecords](../vs140/cdaoquerydef--setreturnsrecords.md) member functions.  
  
 When you finish with the querydef object, call its [Close](../vs140/cdaoquerydef--close.md) member function. If you have a pointer to the querydef, use the **delete** operator to destroy the C++ object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetConnect](../vs140/cdaoquerydef--getconnect.md)   
 [CDaoQueryDef::GetDateCreated](../vs140/cdaoquerydef--getdatecreated.md)   
 [CDaoQueryDef::GetDateLastUpdated](../vs140/cdaoquerydef--getdatelastupdated.md)   
 [CDaoQueryDef::GetName](../vs140/cdaoquerydef--getname.md)   
 [CDaoQueryDef::GetODBCTimeout](../vs140/cdaoquerydef--getodbctimeout.md)   
 [CDaoQueryDef::GetReturnsRecords](../vs140/cdaoquerydef--getreturnsrecords.md)   
 [CDaoQueryDef::GetSQL](../vs140/cdaoquerydef--getsql.md)