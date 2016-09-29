---
title: "CBindStatusCallback::GetBindInfo"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CBindStatusCallback.GetBindInfo"
  - "GetBindInfo"
  - "CBindStatusCallback::GetBindInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBindInfo method"
ms.assetid: 477098ed-10ba-4875-a797-657720d8fa75
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::GetBindInfo
Called to tell the moniker how to bind.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetBindInfo)(  
   DWORD* pgrfBSCF,  
   BINDINFO* pbindinfo   
);  
```  
  
#### Parameters  
 *pgrfBSCF*  
 [out] A pointer to **BINDF** enumeration values indicating how the bind operation should occur. By default, set with the following enumeration values:  
  
 **BINDF_ASYNCHRONOUS** Asynchronous download.  
  
 **BINDF_ASYNCSTORAGE** `OnDataAvailable` returns **E_PENDING** when data is not yet available rather than blocking until data is available.  
  
 **BINDF_GETNEWESTVERSION** The bind operation should retrieve the newest version of the data.  
  
 **BINDF_NOWRITECACHE** The bind operation should not store retrieved data in the disk cache.  
  
 *pbindinfo*  
 [in, out] A pointer to the **BINDINFO** structure giving more information about how the object wants binding to occur.  
  
## Return Value  
 One of the standard `HRESULT` values.  
  
## Remarks  
 The default implementation sets the binding to be asynchronous and to use the data-push model. In the data-push model, the moniker drives the asynchronous bind operation and continuously notifies the client whenever new data is available.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)