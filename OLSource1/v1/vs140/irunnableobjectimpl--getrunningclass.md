---
title: "IRunnableObjectImpl::GetRunningClass"
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
  - GetRunningClass
  - IRunnableObjectImpl.GetRunningClass
  - IRunnableObjectImpl::GetRunningClass
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetRunningClass method
ms.assetid: f98fd4ce-9ba1-4b3f-8f6f-faabd6e3654b
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IRunnableObjectImpl::GetRunningClass
Returns the CLSID of the running control.  
  
## Syntax  
  
```  
  
      HRESULT GetRunningClass(  
   LPCLSID lpClsid   
);  
```  
  
## Return Value  
 The ATL implementation sets \**lpClsid* to `GUID_NULL` and returns **E_UNEXPECTED**.  
  
## Remarks  
 See [IRunnableObject::GetRunningClass](http://msdn.microsoft.com/library/windows/desktop/ms693734) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IRunnableObjectImpl Class](../vs140/irunnableobjectimpl-class.md)