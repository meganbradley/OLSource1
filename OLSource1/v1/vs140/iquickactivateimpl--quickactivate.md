---
title: "IQuickActivateImpl::QuickActivate"
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
  - "IQuickActivateImpl<T>::QuickActivate"
  - "QuickActivate"
  - "ATL::IQuickActivateImpl::QuickActivate"
  - "IQuickActivateImpl.QuickActivate"
  - "ATL::IQuickActivateImpl<T>::QuickActivate"
  - "ATL.IQuickActivateImpl.QuickActivate"
  - "IQuickActivateImpl::QuickActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QuickActivate method"
ms.assetid: ea4af25a-8b19-4610-baa2-cff975931279
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IQuickActivateImpl::QuickActivate
Performs quick initialization of controls being loaded.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The structure contains pointers to interfaces needed by the control and the values of some ambient properties. Upon return, the control passes a pointer to a [QACONTROL](http://msdn.microsoft.com/library/windows/desktop/ms693721) structure that contains pointers to its own interfaces that the container requires, and additional status information.  
  
 See [IQuickActivate::QuickActivate](http://msdn.microsoft.com/library/windows/desktop/ms682421) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IQuickActivateImpl Class](../vs140/iquickactivateimpl-class.md)