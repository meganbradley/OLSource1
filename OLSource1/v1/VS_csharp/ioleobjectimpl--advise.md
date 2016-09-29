---
title: "IOleObjectImpl::Advise"
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
  - "IOleObjectImpl<T>::Advise"
  - "ATL.IOleObjectImpl<T>.Advise"
  - "IOleObjectImpl<T>.Advise"
  - "ATL::IOleObjectImpl::Advise"
  - "Advise"
  - "ATL::IOleObjectImpl<T>::Advise"
  - "IOleObjectImpl.Advise"
  - "IOleObjectImpl::Advise"
  - "ATL.IOleObjectImpl.Advise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Advise method [ATL]"
ms.assetid: 1ec2fb1a-741e-4cca-8eb7-cd7e322102cd
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::Advise
Establishes an advisory connection with the control.  
  
## Syntax  
  
```  
  
      STDMETHOD(Advise)(  
   IAdviseSink* pAdvSink,  
   DWORD* pdwConnection   
);  
```  
  
## Remarks  
 See [IOleObject::Advise](http://msdn.microsoft.com/library/windows/desktop/ms686573) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)   
 [CComControlBase::m_spOleAdviseHolder](../Topic/CComControlBase::m_spOleAdviseHolder.md)   
 [IOleObjectImpl::Unadvise](../VS_csharp/ioleobjectimpl--unadvise.md)