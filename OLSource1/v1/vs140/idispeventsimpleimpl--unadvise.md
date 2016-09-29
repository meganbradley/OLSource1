---
title: "IDispEventSimpleImpl::Unadvise"
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
  - "IDispEventSimpleImpl.Unadvise"
  - "Unadvise"
  - "IDispEventSimpleImpl::Unadvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unadvise method"
ms.assetid: f3138b01-95d2-42e4-8d15-205185358030
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventSimpleImpl::Unadvise
Breaks the connection with the event source represented by *pUnk*.  
  
## Syntax  
  
```  
  
      HRESULT Unadvise(  
   IUnknown* pUnk   
);  
```  
  
#### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
## Return Value  
 `S_OK` or any failure `HRESULT` value.  
  
## Remarks  
 Once the connection is broken, events will no longer be routed to the handler functions listed in the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple `IDispEventSimpleImpl` classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 `Unadvise` breaks a connection that was established with the default event source specified in `pdiid`.  
  
 **Unavise** breaks a connection with the default event source, it gets the IID of the default event source of the object as determined by [AtlGetObjectSourceInterface](../vs140/atlgetobjectsourceinterface.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispEventSimpleImpl Class](../vs140/idispeventsimpleimpl-class.md)   
 [IDispEventSimpleImpl::DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md)   
 [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md)