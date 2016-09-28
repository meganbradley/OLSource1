---
title: "IObjectSafetyImpl::GetInterfaceSafetyOptions"
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
  - "IObjectSafetyImpl.GetInterfaceSafetyOptions"
  - "IObjectSafetyImpl::GetInterfaceSafetyOptions"
  - "GetInterfaceSafetyOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInterfaceSafetyOptions method"
ms.assetid: c4b42e3e-d8e3-410a-9afe-5dece13cc69c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IObjectSafetyImpl::GetInterfaceSafetyOptions
Retrieves the safety options supported by the object, as well as the safety options currently set for the object.  
  
## Syntax  
  
```  
  
      HRESULT GetInterfaceSafetyOptions(  
   REFIID riid,  
   DWORD* pdwSupportedOptions,  
   DWORD* pdwEnabledOptions   
);  
```  
  
## Remarks  
 The implementation returns the appropriate values for any interface supported by the object's implementation of **IUnknown::QueryInterface**.  
  
> [!IMPORTANT]
>  Any object that supports `IObjectSafety` is responsible for its own security, and that of any object it delegates. The programmer must take into account issues arising from running code in the user's context, cross-site scripting and perform suitable zone checking.  
  
 See [IObjectSafety::GetInterfaceSafetyOptions](https://msdn.microsoft.com/en-us/library/aa768223.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IObjectSafetyImpl Class](../vs140/iobjectsafetyimpl-class.md)   
 [IObjectSafetyImpl::SetInterfaceSafetyOptions](../vs140/iobjectsafetyimpl--setinterfacesafetyoptions.md)