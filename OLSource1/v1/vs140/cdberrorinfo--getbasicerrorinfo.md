---
title: "CDBErrorInfo::GetBasicErrorInfo"
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
  - "CDBErrorInfo::GetBasicErrorInfo"
  - "ATL.CDBErrorInfo.GetBasicErrorInfo"
  - "CDBErrorInfo.GetBasicErrorInfo"
  - "ATL::CDBErrorInfo::GetBasicErrorInfo"
  - "GetBasicErrorInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBasicErrorInfo method"
ms.assetid: 263cec53-63f6-48fe-b46e-31d20251863e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBErrorInfo::GetBasicErrorInfo
Calls [IErrorRecords::GetBasicErrorInfo](https://msdn.microsoft.com/en-us/library/ms723907.aspx) to return basic information about the error, such as the return code and provider-specific error number.  
  
## Syntax  
  
```  
  
      HRESULT GetBasicErrorInfo(   
   ULONG ulRecordNum,   
   ERRORINFO* pErrorInfo    
) const throw( );  
```  
  
#### Parameters  
 See [IErrorRecords::GetBasicErrorInfo](https://msdn.microsoft.com/en-us/library/ms723907.aspx) in the *OLE DB Programmer's Reference*.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDBErrorInfo Class](../vs140/cdberrorinfo-class.md)