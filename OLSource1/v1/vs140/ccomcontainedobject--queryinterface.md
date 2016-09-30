---
title: "CComContainedObject::QueryInterface"
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
  - "CComContainedObject::QueryInterface"
  - "CComContainedObject.QueryInterface"
  - "ATL::CComContainedObject<Base>::QueryInterface"
  - "ATL::CComContainedObject<Base>::QueryInterface<Q>"
  - "CComContainedObject<Base>::QueryInterface"
  - "ATL::CComContainedObject::QueryInterface"
  - "ATL.CComContainedObject.QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: a0e0bfa5-8b6c-408c-a26d-3b40fe817356
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComContainedObject::QueryInterface
Retrieves a pointer to the interface requested on the owner object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The identifier of the interface being requested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to **NULL**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to **NULL**.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComContainedObject Class](../vs140/ccomcontainedobject-class.md)