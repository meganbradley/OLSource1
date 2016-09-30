---
title: "CComAggObject::m_contained"
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
  - "ATL.CComAggObject<contained>.m_contained"
  - "CComAggObject::m_contained"
  - "ATL.CComAggObject.m_contained"
  - "ATL::CComAggObject<contained>::m_contained"
  - "CComAggObject.m_contained"
  - "CComAggObject<contained>::m_contained"
  - "ATL::CComAggObject::m_contained"
  - "m_contained"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_contained"
ms.assetid: fc4bef4b-d0b8-4034-abb9-00e50bf6a33c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAggObject::m_contained
A [CComContainedObject](../vs140/ccomcontainedobject-class.md) object derived from your class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interfaces you want to support on the object.  
  
## Remarks  
 All **IUnknown** calls through <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are delegated to the outer unknown.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)