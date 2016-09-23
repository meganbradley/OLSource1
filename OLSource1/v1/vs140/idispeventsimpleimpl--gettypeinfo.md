---
title: "IDispEventSimpleImpl::GetTypeInfo"
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
  - ATL.IDispEventSimpleImpl.GetTypeInfo
  - IDispEventSimpleImpl.GetTypeInfo
  - IDispEventSimpleImpl::GetTypeInfo
  - GetTypeInfo
  - ATL::IDispEventSimpleImpl::GetTypeInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTypeInfo method
ms.assetid: f695603a-6289-4c3e-8d28-c9c00865a33a
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDispEventSimpleImpl::GetTypeInfo
This implementation of **IDispatch::GetTypeInfo** returns **E_NOTIMPL**.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetTypeInfo)(  
   UINT /* itinfo */,  
   LCID /* lcid */,  
   ITypeInfo** /* pptinfo */   
);  
```  
  
## Remarks  
 See [IDispatch::GetTypeInfo](assetId:///cc1ec9aa-6c40-4e70-819c-a7c6dd6b8c99) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispEventSimpleImpl Class](../vs140/idispeventsimpleimpl-class.md)