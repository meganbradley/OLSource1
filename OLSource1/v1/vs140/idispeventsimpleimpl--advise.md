---
title: "IDispEventSimpleImpl::Advise"
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
  - "IDispEventSimpleImpl.Advise"
  - "Advise"
  - "IDispEventSimpleImpl::Advise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Advise method [ATL]"
ms.assetid: c883c0b3-4c05-4ef9-82cc-bb924f6432ca
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventSimpleImpl::Advise
Call this method to establish a connection with the event source represented by *pUnk*.  
  
## Syntax  
  
```  
  
      HRESULT Advise(  
   IUnknown* pUnk   
);  
```  
  
#### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
## Return Value  
 `S_OK` or any failure `HRESULT` value.  
  
## Remarks  
 Once the connection is established, events fired from *pUnk* will be routed to handlers in your class by way of the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple `IDispEventSimpleImpl` classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 `Advise` establishes a connection with the default event source, it gets the IID of the default event source of the object as determined by [AtlGetObjectSourceInterface](../vs140/atlgetobjectsourceinterface.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispEventSimpleImpl Class](../vs140/idispeventsimpleimpl-class.md)   
 [IDispEventSimpleImpl::DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md)   
 [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md)