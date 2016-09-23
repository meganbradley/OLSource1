---
title: "IOleObjectImpl::EnumVerbs"
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
  - ATL::IOleObjectImpl<T>::EnumVerbs
  - EnumVerbs
  - IOleObjectImpl.EnumVerbs
  - IOleObjectImpl<T>.EnumVerbs
  - ATL.IOleObjectImpl<T>.EnumVerbs
  - ATL::IOleObjectImpl::EnumVerbs
  - ATL.IOleObjectImpl.EnumVerbs
  - IOleObjectImpl<T>::EnumVerbs
  - IOleObjectImpl::EnumVerbs
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnumVerbs method
ms.assetid: a40c61f0-5b94-4d6b-9487-b4987846e059
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IOleObjectImpl::EnumVerbs
Supplies an enumeration of registered actions (verbs) for this control by calling **OleRegEnumVerbs**.  
  
## Syntax  
  
```  
  
      STDMETHOD(EnumVerbs)(  
   IEnumOLEVERB** ppEnumOleVerb   
);  
```  
  
## Remarks  
 You can add verbs to your project's .rgs file. For example, see CIRCCTL.RGS in the [CIRC](../vs140/visual-c---samples.md) sample.  
  
 See [IOleObject::EnumVerbs](http://msdn.microsoft.com/library/windows/desktop/ms692781) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [OleRegEnumVerbs](http://msdn.microsoft.com/library/windows/desktop/ms680061)   
 [IOleObjectImpl::EnumAdvise](../vs140/ioleobjectimpl--enumadvise.md)