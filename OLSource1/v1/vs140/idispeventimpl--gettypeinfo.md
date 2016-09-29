---
title: "IDispEventImpl::GetTypeInfo"
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
  - "IDispEventImpl::GetTypeInfo"
  - "ATL::IDispEventImpl::GetTypeInfo"
  - "ATL.IDispEventImpl.GetTypeInfo"
  - "IDispEventImpl.GetTypeInfo"
  - "GetTypeInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTypeInfo method"
ms.assetid: 44be61fa-739c-411f-995c-55c3f339d9f8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventImpl::GetTypeInfo
Retrieves the type information for an object, which can then be used to get the type information for an interface.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetTypeInfo)(  
   UINT itinfo,  
   LCID lcid,  
   ITypeInfo** pptinfo   
);  
```  
  
## Remarks  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispEventImpl Class](../vs140/idispeventimpl-class.md)   
 [IDispEventImpl::GetTypeInfoCount](../vs140/idispeventimpl--gettypeinfocount.md)   
 [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md)