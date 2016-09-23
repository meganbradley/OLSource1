---
title: "IErrorRecordsImpl::GetBasicErrorInfo"
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
  - ATL::IErrorRecordsImpl::GetBasicErrorInfo
  - IErrorRecordsImpl::GetBasicErrorInfo
  - GetBasicErrorInfo
  - ATL.IErrorRecordsImpl.GetBasicErrorInfo
  - IErrorRecordsImpl.GetBasicErrorInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetBasicErrorInfo method
ms.assetid: d0b4dec3-f32a-4aaa-8365-524f2e7c8395
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IErrorRecordsImpl::GetBasicErrorInfo
Returns basic information about the error, such as the return code and provider-specific error number.  
  
## Syntax  
  
```  
  
      STDMETHOD( GetBasicErrorInfo )(  
   ULONG ulRecordNum,  
   ERRORINFO *pErrorInfo   
);  
```  
  
#### Parameters  
 See [IErrorRecords::GetBasicErrorInfo](https://msdn.microsoft.com/en-us/library/ms723907.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IErrorRecordsImpl Class](../vs140/ierrorrecordsimpl-class.md)