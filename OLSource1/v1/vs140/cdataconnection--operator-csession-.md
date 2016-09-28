---
title: "CDataConnection::operator CSession*"
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
  - "CDataConnection.operatorCSession*"
  - "CDataConnection::operatorCSession*"
  - "operatorCSession*"
  - "CSession*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator CSession*"
  - "CSession* operator"
ms.assetid: 0b0feede-5c3e-4835-be5b-03651597014d
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataConnection::operator CSession*
Returns a pointer to the contained `CSession` object.  
  
## Syntax  
  
```  
  
operator const CSession*() throw( );  
  
```  
  
## Remarks  
 This operator returns a pointer to the contained `CSession` object, allowing you to pass a `CDataConnection` object where a `CSession` pointer is expected.  
  
## Example  
 See [operator CSession&](../vs140/cdataconnection--operator-csession-.md) for a usage example.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataConnection Class](../vs140/cdataconnection-class.md)   
 [CDataConnection::operator CSession&](../vs140/cdataconnection--operator-csession-.md)