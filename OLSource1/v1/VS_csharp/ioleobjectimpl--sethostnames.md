---
title: "IOleObjectImpl::SetHostNames"
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
  - "ATL::IOleObjectImpl<T>::SetHostNames"
  - "IOleObjectImpl<T>::SetHostNames"
  - "IOleObjectImpl.SetHostNames"
  - "ATL.IOleObjectImpl.SetHostNames"
  - "ATL.IOleObjectImpl<T>.SetHostNames"
  - "IOleObjectImpl::SetHostNames"
  - "SetHostNames"
  - "ATL::IOleObjectImpl::SetHostNames"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHostNames method"
ms.assetid: 6d71b539-8ca6-4613-942c-ae38157ed957
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::SetHostNames
Tells the control the names of the container application and container document.  
  
## Syntax  
  
```  
  
      STDMETHOD(SetHostNames)(  
   LPCOLESTR /* szContainerApp */,  
   LPCOLESTR /* szContainerObj */  
);  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 See [IOleObject::SetHostNames](http://msdn.microsoft.com/library/windows/desktop/ms680642) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)