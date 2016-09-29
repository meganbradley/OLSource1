---
title: "CDataConnection::operator CDataSource*"
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
  - "CDataSource*"
  - "CDataConnection::operatorCDataSource*"
  - "CDataConnection.operatorCDataSource*"
  - "operatorCDataSource*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDataSource* operator"
  - "operator * (CDataSource)"
ms.assetid: 9118e324-e68d-45c5-a791-03f041d420ed
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataConnection::operator CDataSource*
Returns a pointer to the contained `CDataSource` object.  
  
## Syntax  
  
```  
  
operator const CDataSource*() throw( );  
  
```  
  
## Remarks  
 This operator returns a pointer to the contained `CDataSource` object, allowing you to pass a `CDataConnection` object where a `CDataSource` pointer is expected.  
  
 See [operator CDataSource&](../vs140/cdataconnection--operator-cdatasource-.md) for a usage example.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataConnection Class](../vs140/cdataconnection-class.md)   
 [CDataConnection::operator CDataSource&](../vs140/cdataconnection--operator-cdatasource-.md)