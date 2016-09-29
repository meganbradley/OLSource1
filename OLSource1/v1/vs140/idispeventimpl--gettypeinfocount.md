---
title: "IDispEventImpl::GetTypeInfoCount"
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
  - "ATL.IDispEventImpl.GetTypeInfoCount"
  - "IDispEventImpl::GetTypeInfoCount"
  - "IDispEventImpl.GetTypeInfoCount"
  - "GetTypeInfoCount"
  - "ATL::IDispEventImpl::GetTypeInfoCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTypeInfoCount method"
ms.assetid: e5166905-90a6-4038-88d4-6735ca5e42da
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventImpl::GetTypeInfoCount
Retrieves the number of type information interfaces that an object provides (either 0 or 1).  
  
## Syntax  
  
```  
  
      STDMETHOD(GetTypeInfoCount)(  
   UINT* pctinfo   
);  
```  
  
## Remarks  
 See [IDispatch::GetTypeInfoCount](assetId:///da876d53-cb8a-465c-a43e-c0eb272e2a12) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispEventImpl Class](../vs140/idispeventimpl-class.md)   
 [IDispEventImpl::GetTypeInfo](../vs140/idispeventimpl--gettypeinfo.md)   
 [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md)