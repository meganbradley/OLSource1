---
title: "CComObjectStack::CComObjectStack"
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
  - "ATL.CComObjectStack.CComObjectStack"
  - "CComObjectStack.CComObjectStack"
  - "ATL::CComObjectStack::CComObjectStack"
  - "CComObjectStack<Base>::CComObjectStack"
  - "ATL::CComObjectStack<Base>::CComObjectStack"
  - "CComObjectStack"
  - "CComObjectStack::CComObjectStack"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObjectStack class, constructor"
ms.assetid: bdb86124-114d-4e6d-9a19-2d5442ec79d5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectStack::CComObjectStack
The constructor.  
  
## Syntax  
  
```  
  
      CComObjectStack(  
   void* = NULL   
);  
```  
  
## Remarks  
 Calls `FinalConstruct` and then sets [m_hResFinalConstruct](../vs140/ccomobjectstack--m_hresfinalconstruct.md) to the `HRESULT` returned by `FinalConstruct`. If you have not derived your base class from [CComObjectRoot](../vs140/ccomobjectroot-class.md), you must supply your own `FinalConstruct` method. The destructor calls `FinalRelease`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectStack Class](../vs140/ccomobjectstack-class.md)   
 [CComObjectRootEx::FinalConstruct](../vs140/ccomobjectrootex--finalconstruct.md)