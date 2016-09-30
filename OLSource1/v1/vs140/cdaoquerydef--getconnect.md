---
title: "CDaoQueryDef::GetConnect"
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
  - "CDaoQueryDef.GetConnect"
  - "CDaoQueryDef::GetConnect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetConnect method"
  - "CDaoQueryDef class, getting information"
  - "QueryDef objects, getting connection strings"
  - "DAO (Data Access Objects), getting connection information"
  - "connection strings [C++], getting"
ms.assetid: 250200d8-3530-4492-9b99-1b5ed2ad2fc0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetConnect
Call this member function to get the connection string associated with the querydef's data source.  
  
## Syntax  
  
```  
  
CString GetConnect( );  
  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) containing the connection string for the querydef.  
  
## Remarks  
 This function is used only with ODBC data sources and certain ISAM drivers. It is not used with Microsoft Jet (.MDB) databases; in this case, `GetConnect` returns an empty string. For more information, see [SetConnect](../vs140/cdaoquerydef--setconnect.md).  
  
> [!TIP]
>  The preferred way to work with ODBC tables is to attach them to an .MDB database. For more information, see the topic "Accessing External Databases with DAO" in DAO Help.  
  
 For information about connection strings, see the topic "Connect Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)