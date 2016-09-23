---
title: "IViewObjectExImpl::Freeze"
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
  - Freeze
  - IViewObjectExImpl::Freeze
  - IViewObjectExImpl.Freeze
dev_langs: 
  - C++
helpviewer_keywords: 
  - Freeze method
ms.assetid: 3d6565a7-c23c-43eb-b0cc-af747afc1c19
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IViewObjectExImpl::Freeze
Freezes the drawn representation of a control so it won't change until an `Unfreeze`. The ATL implementation returns **E_NOTIMPL**.  
  
## Syntax  
  
```  
  
      STDMETHOD(Freeze)(  
   DWORD /* dwAspect */,  
   LONG /* lindex */,  
   void* /* pvAspect */,  
   DWORD* /* pdwFreeze */  
);  
```  
  
## Remarks  
 See [IViewObject::Freeze](http://msdn.microsoft.com/library/windows/desktop/ms688728) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../vs140/iviewobjecteximpl-class.md)