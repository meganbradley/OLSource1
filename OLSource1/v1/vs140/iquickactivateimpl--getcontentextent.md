---
title: "IQuickActivateImpl::GetContentExtent"
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
  - ATL::IQuickActivateImpl::GetContentExtent
  - IQuickActivateImpl::GetContentExtent
  - ATL.IQuickActivateImpl.GetContentExtent
  - IQuickActivateImpl.GetContentExtent
  - GetContentExtent
  - ATL::IQuickActivateImpl<T>::GetContentExtent
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetContentExtent method
ms.assetid: c1407176-1844-4f97-b367-e0f68126e0e6
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IQuickActivateImpl::GetContentExtent
Retrieves the current display size for a running control.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetContentExtent)(  
   LPSIZEL pSize   
);  
```  
  
## Remarks  
 The size is for a full rendering of the control and is specified in HIMETRIC units.  
  
 See [IQuickActivate::GetContentExtent](http://msdn.microsoft.com/library/windows/desktop/ms693792) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IQuickActivateImpl Class](../vs140/iquickactivateimpl-class.md)   
 [IQuickActivateImpl::SetContentExtent](../vs140/iquickactivateimpl--setcontentextent.md)