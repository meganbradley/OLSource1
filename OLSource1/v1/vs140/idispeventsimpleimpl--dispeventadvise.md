---
title: "IDispEventSimpleImpl::DispEventAdvise"
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
  - IDispEventSimpleImpl.DispEventAdvise
  - IDispEventSimpleImpl::DispEventAdvise
  - DispEventAdvise
dev_langs: 
  - C++
helpviewer_keywords: 
  - DispEventAdvise method
ms.assetid: ae1a44dd-f7cb-4ad0-90b7-bacb865076bf
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDispEventSimpleImpl::DispEventAdvise
Call this method to establish a connection with the event source represented by *pUnk*.  
  
## Syntax  
  
```  
  
      HRESULT DispEventAdvise(  
   IUnknown* pUnk   
   const IID* piid   
);  
```  
  
#### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
 `piid`  
 A pointer to the IID of the event source object.  
  
## Return Value  
 `S_OK` or any failure `HRESULT` value.  
  
## Remarks  
 Subsequently, events fired from *pUnk* will be routed to handlers in your class by way of the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple `IDispEventSimpleImpl` classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 `DispEventAdvise` establishes a connection with the event source specified in `pdiid`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispEventSimpleImpl Class](../vs140/idispeventsimpleimpl-class.md)   
 [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md)