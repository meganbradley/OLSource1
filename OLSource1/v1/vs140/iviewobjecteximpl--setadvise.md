---
title: "IViewObjectExImpl::SetAdvise"
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
  - "ATL::IViewObjectExImpl::SetAdvise"
  - "ATL.IViewObjectExImpl.SetAdvise"
  - "ATL::IViewObjectExImpl<T>::SetAdvise"
  - "IViewObjectExImpl<T>::SetAdvise"
  - "IViewObjectExImpl.SetAdvise"
  - "ATL.IViewObjectExImpl<T>.SetAdvise"
  - "IViewObjectExImpl::SetAdvise"
  - "SetAdvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAdvise method"
ms.assetid: dbf1f4ca-2471-4931-8c35-fc1d4cff995d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IViewObjectExImpl::SetAdvise
Sets up a connection between the control and an advise sink so the sink can be notified about changes in the control's view.  
  
## Syntax  
  
```  
  
      STDMETHOD(SetAdvise)(  
   DWORD /* aspects */,  
   DWORD /* advf */,  
   IAdviseSink* pAdvSink   
);  
```  
  
## Remarks  
 The pointer to the [IAdviseSink](http://msdn.microsoft.com/library/windows/desktop/ms692513) interface on the advise sink is stored in the control class data member [CComControlBase::m_spAdviseSink](../vs140/ccomcontrolbase--m_spadvisesink.md).  
  
 See [IViewObject::SetAdvise](http://msdn.microsoft.com/library/windows/desktop/ms683950) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../vs140/iviewobjecteximpl-class.md)   
 [IViewObjectExImpl::GetAdvise](../vs140/iviewobjecteximpl--getadvise.md)