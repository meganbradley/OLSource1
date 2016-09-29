---
title: "CDBErrorInfo Class"
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
  - "CDBErrorInfo"
  - "ATL::CDBErrorInfo"
  - "ATL.CDBErrorInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDBErrorInfo class"
ms.assetid: 9a5c18a2-ee3e-40f5-ab4c-581288d7f737
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBErrorInfo Class
Provides support for OLE DB error processing using the OLE DB [IErrorRecords](https://msdn.microsoft.com/en-us/library/ms718112.aspx) interface.  
  
## Syntax  
  
```  
class CDBErrorInfo  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[GetAllErrorInfo](../vs140/cdberrorinfo--getallerrorinfo.md)|Returns all error information contained in an error record.|  
|[GetBasicErrorInfo](../vs140/cdberrorinfo--getbasicerrorinfo.md)|Calls [IErrorRecords::GetBasicErrorInfo](https://msdn.microsoft.com/en-us/library/ms723907.aspx) to return basic information about the specified error.|  
|[GetCustomErrorObject](../vs140/cdberrorinfo--getcustomerrorobject.md)|Calls [IErrorRecords::GetCustomErrorObject](https://msdn.microsoft.com/en-us/library/ms725417.aspx) to return a pointer to an interface on a custom error object.|  
|[GetErrorInfo](../vs140/cdberrorinfo--geterrorinfo.md)|Calls [IErrorRecords::GetErrorInfo](https://msdn.microsoft.com/en-us/library/ms711230.aspx) to return an **IErrorInfo** interface pointer to the specified record.|  
|[GetErrorParameters](../vs140/cdberrorinfo--geterrorparameters.md)|Calls [IErrorRecords::GetErrorParameters](https://msdn.microsoft.com/en-us/library/ms715793.aspx) to return the error parameters.|  
|[GetErrorRecords](../vs140/cdberrorinfo--geterrorrecords.md)|Gets error records for the specified object.|  
  
## Remarks  
 This interface returns one or more error records to the user. Call [CDBErrorInfo::GetErrorRecords](../vs140/cdberrorinfo--geterrorrecords.md) first, to get a count of error records. Then call one of the access functions, such as [CDBErrorInfo::GetAllErrorInfo](../vs140/cdberrorinfo--getallerrorinfo.md), to retrieve error information for each record.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [DBViewer](../vs140/visual-c---samples.md)   
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)