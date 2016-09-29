---
title: "CComContainedObject::CComContainedObject"
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
  - "ATL::CComContainedObject::CComContainedObject"
  - "CComContainedObject::CComContainedObject"
  - "ATL::CComContainedObject<Base>::CComContainedObject"
  - "ATL.CComContainedObject.CComContainedObject"
  - "CComContainedObject"
  - "CComContainedObject.CComContainedObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComContainedObject constructor"
  - "CComContainedObject class, constructor"
ms.assetid: 5a007860-4b8f-49ea-8c77-dea5610b197a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComContainedObject::CComContainedObject
The constructor.  
  
## Syntax  
  
```  
  
      CComContainedObject(  
   void* pv   
);  
```  
  
#### Parameters  
 `pv`  
 [in] The owner object's **IUnknown**.  
  
## Remarks  
 Sets the `m_pOuterUnknown` member pointer (inherited through the `Base` class) to `pv`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComContainedObject Class](../vs140/ccomcontainedobject-class.md)   
 [CComObjectRootEx::m_pOuterUnknown](../vs140/ccomobjectrootex--m_pouterunknown.md)