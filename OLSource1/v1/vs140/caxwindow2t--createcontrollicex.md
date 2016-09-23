---
title: "CAxWindow2T::CreateControlLicEx"
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
  - ATL.CAxWindow2T.CreateControlLicEx
  - ATL::CAxWindow2T::CreateControlLicEx
  - CAxWindow2T.CreateControlLicEx
  - CAxWindow2T<TBase>::CreateControlLicEx
  - CAxWindow2T::CreateControlLicEx
  - CreateControlLicEx
  - ATL::CAxWindow2T<TBase>::CreateControlLicEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateControlLicEx method
ms.assetid: 0159b4d5-0a96-4a30-bd1c-b8387a8c6ce9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAxWindow2T::CreateControlLicEx
Creates a licensed ActiveX control, initializes it, hosts it in the specified window, and retrieves an interface pointer (or pointers) from the control.  
  
## Syntax  
  
```  
  
      HRESULT CreateControlLicEx(  
   LPCOLESTR lpszName,   
   IStream* pStream = NULL,  
   IUnknown** ppUnkContainer = NULL,   
   IUnknown** ppUnkControl = NULL,  
   REFIID iidSink = IID_NULL,   
   IUnknown* punkSink = NULL,   
   BSTR bstrLicKey = NULL  
);  
HRESULT CreateControlLicEx(  
   DWORD dwResID,  
   IStream* pStream = NULL,  
   IUnknown** ppUnkContainer = NULL,  
   IUnknown** ppUnkControl = NULL,  
   REFIID iidSink = IID_NULL,   
   IUnknown* punkSink = NULL,   
   BSTR bstrLickey = NULL  
);  
```  
  
#### Parameters  
 `bstrLicKey`  
 The license key for the control; NULL if creating a nonlicensed control.  
  
## Remarks  
 See [CAxWindow::CreateControlEx](../vs140/caxwindow--createcontrolex.md) for a description of the remaining parameters and return value.  
  
## Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses `CAxWindow2T::CreateControlLicEx`.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxWindow2T Class](../vs140/caxwindow2t-class.md)