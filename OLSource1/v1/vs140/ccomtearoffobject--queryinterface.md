---
title: "CComTearOffObject::QueryInterface"
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
  - "ATL::CComTearOffObject::QueryInterface"
  - "CComTearOffObject<Base>::QueryInterface"
  - "ATL.CComTearOffObject.QueryInterface"
  - "ATL::CComTearOffObject<Base>::QueryInterface"
  - "CComTearOffObject.QueryInterface"
  - "CComTearOffObject::QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: c8b538ec-d37e-439f-b899-938aed66b044
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComTearOffObject::QueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The IID of the interface being requested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or **NULL** if the interface is not found.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value.  
  
## Remarks  
 Queries first for interfaces on your tear-off class. If the interface is not there, queries for the interface on the owner object. If the requested interface is **IUnknown**, returns the **IUnknown** of the owner.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComTearOffObject Class](../vs140/ccomtearoffobject-class.md)   
 [CComTearOffObject::AddRef](../vs140/ccomtearoffobject--addref.md)   
 [CComTearOffObject::Release](../vs140/ccomtearoffobject--release.md)