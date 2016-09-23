---
title: "CComCoClass::Error"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CComCoClass.Error
  - ATL::CComCoClass::Error
  - ATL.CComCoClass.Error
  - Error
  - CComCoClass::Error
dev_langs: 
  - C++
helpviewer_keywords: 
  - Error method
ms.assetid: 4de82384-550c-43fc-81ea-c5f19e65739d
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComCoClass::Error
This static function sets up the `IErrorInfo` interface to provide error information to the client.  
  
## Syntax  
  
```  
  
      static HRESULT WINAPI Error(  
   LPCOLESTR lpszDesc,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0   
);  
static HRESULT WINAPI Error(  
   LPCOLESTR lpszDesc,  
   DWORD dwHelpID,  
   LPCOLESTR lpszHelpFile,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0   
);  
static HRESULT WINAPI Error(  
   LPCSTR lpszDesc,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0   
);  
static HRESULT WINAPI Error(  
   LPCSTR lpszDesc,  
   DWORD dwHelpID,  
   LPCSTR lpszHelpFile,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0   
);  
static HRESULT WINAPI Error(  
   UINT nID,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0,  
   HINSTANCE hInst = _AtlBaseModule.GetResourceInstance ()  
);  
static HRESULT Error(  
   UINT nID,  
   DWORD dwHelpID,  
   LPCOLESTR lpszHelpFile,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0,  
   HINSTANCE hInst = _AtlBaseModule.GetResourceInstance()   
);  
```  
  
#### Parameters  
 `lpszDesc`  
 [in] The string describing the error. The Unicode version of `Error` specifies that `lpszDesc` is of type **LPCOLESTR**; the ANSI version specifies a type of `LPCSTR`.  
  
 `iid`  
 [in] The IID of the interface defining the error or `GUID_NULL` (the default value) if the error is defined by the operating system.  
  
 `hRes`  
 [in] The `HRESULT` you want returned to the caller. The default value is 0. For more details about `hRes`, see Remarks.  
  
 `nID`  
 [in] The resource identifier where the error description string is stored. This value should lie between 0x0200 and 0xFFFF, inclusively. In debug builds, an **ASSERT** will result if `nID` does not index a valid string. In release builds, the error description string will be set to "Unknown Error."  
  
 `dwHelpID`  
 [in] The help context identifier for the error.  
  
 `lpszHelpFile`  
 [in] The path and name of the help file describing the error.  
  
 `hInst`  
 [in] The handle to the resource. By default, this parameter is **_AtlModule::GetResourceInstance**, where **_AtlModule** is the global instance of [CAtlModule](../vs140/catlmodule-class.md).  
  
## Return Value  
 A standard `HRESULT` value. For details, see Remarks.  
  
## Remarks  
 To call `Error`, your object must implement the `ISupportErrorInfo Interface` interface.  
  
 If the `hRes` parameter is nonzero, then `Error` returns the value of `hRes`. If `hRes` is zero, then the first four versions of `Error` return `DISP_E_EXCEPTION`. The last two versions return the result of the macro **MAKE_HRESULT( 1, FACILITY_ITF,** `nID` **)**.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCoClass Class](../vs140/ccomcoclass-class.md)   
 [ISupportErrorInfoImpl Class](../vs140/isupporterrorinfoimpl-class.md)   
 [MAKE_HRESULT](http://msdn.microsoft.com/library/windows/desktop/ms694497)