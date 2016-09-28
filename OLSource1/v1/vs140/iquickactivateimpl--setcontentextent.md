---
title: "IQuickActivateImpl::SetContentExtent"
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
  - "IQuickActivateImpl.SetContentExtent"
  - "ATL::IQuickActivateImpl::SetContentExtent"
  - "ATL.IQuickActivateImpl.SetContentExtent"
  - "ATL::IQuickActivateImpl<T>::SetContentExtent"
  - "SetContentExtent"
  - "IQuickActivateImpl::SetContentExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetContentExtent method"
ms.assetid: 426c976a-fb49-4c9c-b389-bd4c29b40f5b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IQuickActivateImpl::SetContentExtent
Informs the control of how much display space the container has assigned to it.  
  
## Syntax  
  
```  
  
      STDMETHOD(SetContentExtent)(  
   LPSIZEL pSize   
);  
```  
  
## Remarks  
 The size is specified in HIMETRIC units.  
  
 See [IQuickActivate::SetContentExtent](http://msdn.microsoft.com/library/windows/desktop/ms678806) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IQuickActivateImpl Class](../vs140/iquickactivateimpl-class.md)   
 [IQuickActivateImpl::GetContentExtent](../vs140/iquickactivateimpl--getcontentextent.md)