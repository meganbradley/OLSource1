---
title: "CDynamicAccessor::GetColumnFlags"
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
  - CDynamicAccessor.GetColumnFlags
  - ATL::CDynamicAccessor::GetColumnFlags
  - ATL.CDynamicAccessor.GetColumnFlags
  - CDynamicAccessor::GetColumnFlags
  - GetColumnFlags
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetColumnFlags method
ms.assetid: b2ba2f3a-2c61-4a49-abfb-75823908ccf4
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDynamicAccessor::GetColumnFlags
Retrieves the column characteristics.  
  
## Syntax  
  
```  
  
      bool GetColumnFlags(   
   DBORDINAL nColumn,   
   DBCOLUMNFLAGS* pFlags    
) const throw( );  
```  
  
#### Parameters  
 `nColumn`  
 [in] The column number. Column numbers start with 1. A value of 0 refers to the bookmark column, if any.  
  
 `pFlags`  
 [out] A pointer to a bitmask that describes column characteristics. See "DBCOLUMNFLAGS Enumerated Type" in [IColumnsInfo::GetColumnInfo](https://msdn.microsoft.com/en-us/library/ms722704.aspx) in the *OLE DB Programmer's Reference*.  
  
## Return Value  
 Returns **true** if the column characteristics are successfully retrieved. Otherwise, it returns **false**.  
  
## Remarks  
 The column number is offset from one. Column zero is a special case; it is the bookmark if available.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)