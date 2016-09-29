---
title: "SccGetUserOption Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "SccGetUserOption"
helpviewer_keywords: 
  - "SccGetUserOption function"
ms.assetid: 17863747-1901-4c53-a2b3-ed996085e120
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccGetUserOption Function
This function retrieves a variety of user-specific options.  
  
## Syntax  
  
```cpp  
SCCRTN SccGetUserOption(  
   LPVOID pContext,  
   LONG nOption,  
   LPLONG lpVal  
);  
```  
  
#### Parameters  
 pContext  
 [in] The source control plug-in context pointer.  
  
 nOption  
 [in] Option to retrieve (see Remarks for possible options).  
  
 lpVal  
 [out] Value associated with option.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Option was retrieved successfully.|  
|SCC_E_OPNOTSUPPORTED|Option is not supported.|  
|SCC_E_NONSPECIFICERROR|An unspecified error occurred.|  
  
## Remarks  
 The following options are supported by this command:  
  
|User Option|Description|  
|-----------------|-----------------|  
|`SCC_USEROPT_CHECKOUT_LOCALVER`|Determines whether the user wants to check out local version of files. `lpVal` is assigned `SCC_USEROPT_COLV_YES` (user wants to check out local files) or `SCC_USEROPT_COLV_NO`.|  
  
## See Also  
 [Source Control Plug-in API Functions](../VS_csharp/source-control-plug-in-api-functions.md)   
 [Error Codes](../VS_csharp/error-codes.md)