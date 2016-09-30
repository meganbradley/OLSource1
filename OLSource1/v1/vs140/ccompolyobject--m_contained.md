---
title: "CComPolyObject::m_contained"
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
  - "ATL.CComPolyObject.m_contained"
  - "CComPolyObject<contained>::m_contained"
  - "CComPolyObject::m_contained"
  - "ATL::CComPolyObject<contained>::m_contained"
  - "ATL::CComPolyObject::m_contained"
  - "CComPolyObject.m_contained"
  - "m_contained"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_contained"
ms.assetid: 13cae859-302f-4e6d-8931-ec7f12e0c42f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPolyObject::m_contained
A [CComContainedObject](../vs140/ccomcontainedobject-class.md) object derived from your class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interfaces you want to support on the object.  
  
## Remarks  
 **IUnknown** calls through <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are delegated to the outer unknown if the object is aggregated, or to the **IUnknown** of this object if the object is not aggregated.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)