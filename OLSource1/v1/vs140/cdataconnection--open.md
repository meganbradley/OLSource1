---
title: "CDataConnection::Open"
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
  - CDataConnection.Open
  - ATL.CDataConnection.Open
  - CDataConnection::Open
  - ATL::CDataConnection::Open
dev_langs: 
  - C++
helpviewer_keywords: 
  - Open method
ms.assetid: 2c6f0c01-4954-43ba-973e-861ac8e82892
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDataConnection::Open
Opens a connection to a data source using an initialization string.  
  
## Syntax  
  
```  
  
      HRESULT Open(   
   LPCOLESTR szInitString    
) throw( );  
```  
  
#### Parameters  
 *szInitString*  
 [in] The initialization string for the data source.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataConnection Class](../vs140/cdataconnection-class.md)