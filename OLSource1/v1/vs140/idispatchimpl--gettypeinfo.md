---
title: "IDispatchImpl::GetTypeInfo"
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
  - IDispatchImpl.GetTypeInfo
  - ATL::IDispatchImpl::GetTypeInfo
  - GetTypeInfo
  - IDispatchImpl::GetTypeInfo
  - ATL.IDispatchImpl.GetTypeInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTypeInfo method
ms.assetid: 92bb9558-9f30-408a-8a9c-687013f5abd6
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDispatchImpl::GetTypeInfo
Retrieves the type information for the dual interface.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetTypeInfo)(  
   UINT itinfo,  
   LCID lcid,  
   ITypeInfo** pptinfo   
);  
```  
  
## Remarks  
 See [IDispatch::GetTypeInfo](assetId:///cc1ec9aa-6c40-4e70-819c-a7c6dd6b8c99) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispatchImpl Class](../vs140/idispatchimpl-class.md)   
 [IDispatchImpl::GetTypeInfoCount](../vs140/idispatchimpl--gettypeinfocount.md)