---
title: "CDBErrorInfo::GetErrorInfo"
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
  - GetErrorInfo
  - ATL.CDBErrorInfo.GetErrorInfo
  - CDBErrorInfo.GetErrorInfo
  - ATL::CDBErrorInfo::GetErrorInfo
  - CDBErrorInfo::GetErrorInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetErrorInfo method
ms.assetid: 234e1f02-c307-4666-b3ce-2a4d62407fa1
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDBErrorInfo::GetErrorInfo
Calls [IErrorRecords::GetErrorInfo](https://msdn.microsoft.com/en-us/library/ms711230.aspx) to return an [IErrorInfo](https://msdn.microsoft.com/en-us/library/ms718112.aspx) interface pointer to the specified record.  
  
## Syntax  
  
```  
  
      HRESULT GetErrorInfo(   
   ULONG ulRecordNum,   
   LCID lcid,   
   IErrorInfo** ppErrorInfo    
) const throw( );  
```  
  
#### Parameters  
 See [IErrorRecords::GetErrorInfo](https://msdn.microsoft.com/en-us/library/ms711230.aspx) in the *OLE DB Programmer's Reference*.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDBErrorInfo Class](../vs140/cdberrorinfo-class.md)