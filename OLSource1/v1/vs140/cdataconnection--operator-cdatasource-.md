---
title: "CDataConnection::operator CDataSource&amp;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CDataSource&
  - CDataConnection.operatorCDataSource&
  - operatorCDataSource&
  - CDataConnection::operatorCDataSource&
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDataSource& operator
  - operator & (CDataSource)
ms.assetid: 852faeee-f1b1-4465-9828-b261d1edf022
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDataConnection::operator CDataSource&amp;
Returns a reference to the contained `CDataSource` object.  
  
## Syntax  
  
```  
  
operator const CDataSource&() throw( );  
  
```  
  
## Remarks  
 This operator returns a reference to the contained `CDataSource` object, allowing you to pass a `CDataConnection` object where a `CDataSource` reference is expected.  
  
## Example  
 If you have a function (such as `func` below) that takes a `CDataSource` reference, you can use **CDataSource&** to pass a `CDataConnection` object instead.  
  
 [!code[NVC_OLEDB_Consumer#3](../vs140/codesnippet/CPP/cdataconnection--operator-cdatasource-_1.cpp)]
  
  
 [!code[NVC_OLEDB_Consumer#4](../vs140/codesnippet/CPP/cdataconnection--operator-cdatasource-_2.cpp)]
  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataConnection Class](../vs140/cdataconnection-class.md)   
 [CDataConnection::operator CDataSource*](../vs140/cdataconnection--operator-cdatasource-.md)