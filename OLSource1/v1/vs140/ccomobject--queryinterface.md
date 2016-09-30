---
title: "CComObject::QueryInterface"
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
  - "CComObject::QueryInterface"
  - "CComObject.QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: 09272404-347b-4880-9d07-8330b130e841
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObject::QueryInterface
Retrieves a pointer to the requested interface.  
  
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
 [CComObject Class](../vs140/ccomobject-class.md)