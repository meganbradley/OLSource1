---
title: "IViewObjectExImpl::GetRect"
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
  - "ATL::IViewObjectExImpl<T>::GetRect"
  - "IViewObjectExImpl.GetRect"
  - "ATL.IViewObjectExImpl<T>.GetRect"
  - "IViewObjectExImpl<T>.GetRect"
  - "ATL::IViewObjectExImpl::GetRect"
  - "IViewObjectExImpl<T>::GetRect"
  - "ATL.IViewObjectExImpl.GetRect"
  - "IViewObjectExImpl::GetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRect method"
ms.assetid: 5cbb965e-ead7-4476-8660-85d2804f06fc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IViewObjectExImpl::GetRect
Returns a rectangle describing a requested drawing aspect. The ATL implementation returns **E_NOTIMPL**.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetRect)(  
   DWORD /* dwAspect */,  
   LPRECTL /* pRect */  
);  
```  
  
## Remarks  
 See [IViewObjectEx::GetRect](http://msdn.microsoft.com/library/windows/desktop/ms695246) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../VS_csharp/iviewobjecteximpl-class.md)