---
title: "CComCachedTearOffObject::QueryInterface"
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
  - "CComCachedTearOffObject.QueryInterface"
  - "ATL.CComCachedTearOffObject.QueryInterface"
  - "ATL::CComCachedTearOffObject<contained>::QueryInterface"
  - "ATL::CComCachedTearOffObject::QueryInterface"
  - "CComCachedTearOffObject::QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: d44db5f6-305a-4ae5-a5bc-c0286d743b36
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCachedTearOffObject::QueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The GUID of the interface being requested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or **NULL** if the interface is not found.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value.  
  
## Remarks  
 If the requested interface is **IUnknown**, returns a pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>'s own **IUnknown** and increments the reference count. Otherwise, queries for the interface on your tear-off class using the [InternalQueryInterface](../vs140/ccomobjectrootex--internalqueryinterface.md) method inherited from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCachedTearOffObject Class](../vs140/ccomcachedtearoffobject-class.md)   
 [CComCachedTearOffObject::AddRef](../vs140/ccomcachedtearoffobject--addref.md)   
 [CComCachedTearOffObject::Release](../vs140/ccomcachedtearoffobject--release.md)