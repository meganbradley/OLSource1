---
title: "IOleObjectImpl::Unadvise"
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
  - "IOleObjectImpl.Unadvise"
  - "ATL.IOleObjectImpl.Unadvise"
  - "IOleObjectImpl<T>.Unadvise"
  - "ATL.IOleObjectImpl<T>.Unadvise"
  - "IOleObjectImpl<T>::Unadvise"
  - "ATL::IOleObjectImpl<T>::Unadvise"
  - "IOleObjectImpl::Unadvise"
  - "Unadvise"
  - "ATL::IOleObjectImpl::Unadvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unadvise method"
ms.assetid: fb01b56c-7a81-42e2-8865-d6c8bd8dcf36
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::Unadvise
Deletes the advisory connection stored in the control class's `m_spOleAdviseHolder` data member.  
  
## Syntax  
  
```  
  
      STDMETHOD(Unadvise)(  
   DWORD dwConnection   
);  
```  
  
## Remarks  
 See [IOleObject::Unadvise](http://msdn.microsoft.com/library/windows/desktop/ms693749) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [CComControlBase::m_spOleAdviseHolder](../vs140/ccomcontrolbase--m_spoleadviseholder.md)   
 [IOleObjectImpl::Advise](../vs140/ioleobjectimpl--advise.md)