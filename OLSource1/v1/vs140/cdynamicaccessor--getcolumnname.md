---
title: "CDynamicAccessor::GetColumnName"
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
  - ATL::CDynamicAccessor::GetColumnName
  - GetColumnName
  - ATL.CDynamicAccessor.GetColumnName
  - CDynamicAccessor::GetColumnName
  - CDynamicAccessor.GetColumnName
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetColumnName method
ms.assetid: 96a7452a-1f5b-41e9-ab37-88dac026f961
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDynamicAccessor::GetColumnName
Retrieves the name of the specified column.  
  
## Syntax  
  
```  
  
      LPOLESTR GetColumnName(   
   DBORDINAL nColumn    
) const throw( );  
```  
  
#### Parameters  
 `nColumn`  
 [in] The column number. Column numbers start with 1. A value of 0 refers to the bookmark column, if any.  
  
## Return Value  
 The name of the specified column.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)