---
title: "IDispEventSimpleImpl::Invoke"
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
  - "IDispEventSimpleImpl.Invoke"
  - "IDispEventSimpleImpl::Invoke"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Invoke method"
ms.assetid: 91441c1f-356d-4b89-9988-fe52b4b4a642
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventSimpleImpl::Invoke
This implementation of **IDispatch::Invoke** calls the event handlers listed in the event sink map.  
  
## Syntax  
  
```  
  
      STDMETHOD(Invoke)(  
   DISPID dispidMember,  
   REFIID /* riid */,  
   LCID lcid,  
   WORD /* wFlags */,  
   DISPPARMS* pdispparams,  
   VARIANT* pvarResult,  
   EXCEPINFO* /* pexcepinfo */,  
   UINT* /* puArgErr */   
);  
```  
  
## Remarks  
 See [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispEventSimpleImpl Class](../VS_csharp/idispeventsimpleimpl-class.md)