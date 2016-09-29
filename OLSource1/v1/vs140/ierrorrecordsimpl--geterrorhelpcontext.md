---
title: "IErrorRecordsImpl::GetErrorHelpContext"
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
  - "GetErrorHelpContext"
  - "IErrorRecordsImpl::GetErrorHelpContext"
  - "IErrorRecordsImpl.GetErrorHelpContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetErrorHelpContext method"
ms.assetid: 53d70239-0d64-482e-9ad4-4e1f4f02d5a3
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IErrorRecordsImpl::GetErrorHelpContext
Gets the help context ID from an error record.  
  
## Syntax  
  
```  
  
      DWORD GetErrorHelpContext(  
   ERRORINFO& rCurError   
);  
```  
  
#### Parameters  
 `rCurError`  
 An `ERRORINFO` record in an **IErrorInfo** interface.  
  
## Return Value  
 The help context ID for the error.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IErrorRecordsImpl Class](../vs140/ierrorrecordsimpl-class.md)