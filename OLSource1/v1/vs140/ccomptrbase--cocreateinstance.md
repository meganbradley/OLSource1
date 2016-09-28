---
title: "CComPtrBase::CoCreateInstance"
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
  - "ATL::CComPtrBase<T>::CoCreateInstance"
  - "CComPtrBase<T>::CoCreateInstance"
  - "CComPtrBase::CoCreateInstance"
  - "CoCreateInstance"
  - "ATL::CComPtrBase::CoCreateInstance"
  - "ATL.CComPtrBase.CoCreateInstance"
  - "CComPtrBase.CoCreateInstance"
  - "ATL.CComPtrBase<T>.CoCreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CoCreateInstance method"
ms.assetid: c0965041-6cb6-40c5-b272-2b99f02668a6
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtrBase::CoCreateInstance
Call this method to create an object of the class associated with a specified Class ID or Program ID.  
  
## Syntax  
  
```  
  
      HRESULT CoCreateInstance(  
   LPCOLESTR szProgID,  
   LPUNKNOWN pUnkOuter = NULL,  
   DWORD dwClsContext = CLSCTX_ALL   
) throw( );  
HRESULT CoCreateInstance(  
   REFCLSID rclsid,  
   LPUNKNOWN pUnkOuter = NULL,  
   DWORD dwClsContext = CLSCTX_ALL   
) throw( );  
```  
  
#### Parameters  
 `szProgID`  
 Pointer to a ProgID, used to recover the CLSID.  
  
 `pUnkOuter`  
 If **NULL**, indicates that the object is not being created as part of an aggregate. If non-**NULL**, is a pointer to the aggregate object's **IUnknown** interface (the controlling **IUnknown**).  
  
 `dwClsContext`  
 Context in which the code that manages the newly created object will run.  
  
 `rclsid`  
 CLSID associated with the data and code that will be used to create the object.  
  
## Return Value  
 Returns S_OK on success, or REGDB_E_CLASSNOTREG, CLASS_E_NOAGGREGATION, CO_E_CLASSSTRING or E_NOINTERFACE on failure. See [CoCreateClassInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615) and [CLSIDFromProgID](http://msdn.microsoft.com/library/windows/desktop/ms688386) for a description of these errors.  
  
## Remarks  
 If the first form of the method is called, [CLSIDFromProgID](http://msdn.microsoft.com/library/windows/desktop/ms688386) is used to recover the CLSID. Both forms then call [CoCreateClassInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615).  
  
 In debug builds, an assertion error will occur if [CComPtrBase::p](../vs140/ccomptrbase--p.md) is not equal to NULL.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)