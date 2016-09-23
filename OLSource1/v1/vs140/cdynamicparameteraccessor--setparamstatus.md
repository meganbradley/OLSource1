---
title: "CDynamicParameterAccessor::SetParamStatus"
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
  - CDynamicParameterAccessor::SetParamStatus
  - ATL.CDynamicParameterAccessor.SetParamStatus
  - ATL::CDynamicParameterAccessor::SetParamStatus
  - CDynamicParameterAccessor.SetParamStatus
  - SetParamStatus
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetParamStatus method
ms.assetid: 0c2271f6-457d-46ca-88b7-4590aadb20d7
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDynamicParameterAccessor::SetParamStatus
Sets the status of the specified parameter stored in the buffer.  
  
## Syntax  
  
```  
  
      bool SetParamStatus(  
   DBORDINAL nParam,  
   DBSTATUS status  
);  
```  
  
#### Parameters  
 `nParam`  
 [in] The parameter number (offset from 1). Parameter 0 is reserved for return values. The parameter number is the index of the parameter based on its order in the SQL or stored procedure call. See [SetParam](../vs140/cdynamicparameteraccessor--setparam.md) for an example.  
  
 *status*  
 [in] The `DBSTATUS` status of the specified parameter. For information on `DBSTATUS` values, see [Status](https://msdn.microsoft.com/en-us/library/ms722617.aspx) in the *OLE DB Programmer's Reference*, or search for `DBSTATUS` in oledb.h.  
  
## Remarks  
 Returns **true** on success or **false** on failure.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)