---
title: "IViewObjectExImpl::GetAdvise"
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
  - "IViewObjectExImpl.GetAdvise"
  - "GetAdvise"
  - "IViewObjectExImpl::GetAdvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAdvise method"
ms.assetid: 2fd650fb-7907-44d9-a31a-36d4bafa9f4e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IViewObjectExImpl::GetAdvise
Retrieves an existing advisory sink connection on the control, if there is one.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetAdvise)(  
   DWORD* /* pAspects */,  
   DWORD* /* pAdvf */,  
   IAdviseSink** /* ppAdvSink */  
);  
```  
  
## Remarks  
 The advisory sink is stored in the control class data member [CComControlBase::m_spAdviseSink](../Topic/CComControlBase::m_spAdviseSink.md).  
  
 See [IViewObject::GetAdvise](http://msdn.microsoft.com/library/windows/desktop/ms692772) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../VS_csharp/iviewobjecteximpl-class.md)   
 [IViewObjectExImpl::SetAdvise](../VS_csharp/iviewobjecteximpl--setadvise.md)