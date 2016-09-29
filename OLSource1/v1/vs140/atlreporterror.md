---
title: "AtlReportError"
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
  - "ATL.AtlReportError"
  - "ATL::AtlReportError"
  - "AtlReportError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlReportError function"
ms.assetid: 86b046a5-ea18-4ecf-9aab-40fc1eab847c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlReportError
Sets up the `IErrorInfo` interface to provide error information to clients of the object.  
  
## Syntax  
  
```  
  
      HRESULT WINAPI AtlReportError(  
   const CLSID& clsid,  
   LPCOLESTR lpszDesc,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0   
);  
HRESULT WINAPI AtlReportError(  
   const CLSID& clsid,  
   LPCOLESTR lpszDesc,  
   DWORD dwHelpID,  
   LPCOLESTR lpszHelpFile,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0   
);  
HRESULT WINAPI AtlReportError(  
   const CLSID& clsid,  
   LPCSTR lpszDesc,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0   
);  
HRESULT WINAPI AtlReportError(  
   const CLSID& clsid,  
   LPCSTR lpszDesc,  
   DWORD dwHelpID,  
   LPCSTR lpszHelpFile,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0   
);  
HRESULT WINAPI AtlReportError(  
   const CLSID& clsid,  
   UINT nID,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0,  
   HINSTANCE hInst = _AtlBaseModule.GetResourceInstance( )  
);  
HRESULT WINAPI AtlReportError(  
   const CLSID& clsid,  
   UINT nID,  
   DWORD dwHelpID,  
   LPCOLESTR lpszHelpFile,  
   const IID& iid = GUID_NULL,  
   HRESULT hRes = 0,  
   HINSTANCE hInst = _AtlBaseModule.GetResourceInstance( )  
);  
```  
  
#### Parameters  
 `clsid`  
 [in] The CLSID of the object reporting the error.  
  
 `lpszDesc`  
 [in] The string describing the error. The Unicode versions specify that `lpszDesc` is of type **LPCOLESTR**; the ANSI version specifies a type of `LPCSTR`.  
  
 `iid`  
 [in] The IID of the interface defining the error or `GUID_NULL` if the error is defined by the operating system.  
  
 `hRes`  
 [in] The `HRESULT` you want returned to the caller.  
  
 `nID`  
 [in] The resource identifier where the error description string is stored. This value should lie between 0x0200 and 0xFFFF, inclusively. In debug builds, an **ASSERT** will result if `nID` does not index a valid string. In release builds, the error description string will be set to "Unknown Error."  
  
 `dwHelpID`  
 [in] The help context identifier for the error.  
  
 `lpszHelpFile`  
 [in] The path and name of the help file describing the error.  
  
 `hInst`  
 [in] The handle to the resource. By default, this parameter is **__AtlBaseModuleModule::GetResourceInstance**, where **__AtlBaseModuleModule** is the global instance of [CAtlBaseModule](../vs140/catlbasemodule-class.md) or a class derived from it.  
  
## Return Value  
 If the `hRes` parameter is nonzero, returns the value of `hRes`. If `hRes` is zero, then the first four versions of `AtlReportError` return `DISP_E_EXCEPTION`. The last two versions return the result of the macro **MAKE_HRESULT( 1, FACILITY_ITF,** `nID` **)**.  
  
## Remarks  
 The string *lpszDesc* is used as the text description of the error. When the client receives the `hRes` you return from `AtlReportError`, the client can access the **IErrorInfo** structure for details about the error.  
  
## Example  
 [!code[NVC_ATL_COM#52](../vs140/codesnippet/CPP/atlreporterror_1.cpp)]  
  
> [!CAUTION]
>  Do not use `AtlReportError` in C++ catch handlers. Some overrides of these functions use the ATL string conversion macros internally, which in turn use the `_alloca` function internally. Using `AtlReportError` in a C++ catch handler can cause exceptions in C++ catch handlers.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Debugging and Error Reporting Global Functions](../vs140/debugging-and-error-reporting-global-functions.md)   
 [MAKE_HRESULT](http://msdn.microsoft.com/library/windows/desktop/ms694497)