---
title: "CComPolyObject::CreateInstance"
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
  - "CComPolyObject<contained>::CreateInstance"
  - "ATL::CComPolyObject::CreateInstance"
  - "CComPolyObject.CreateInstance"
  - "CComPolyObject::CreateInstance"
  - "ATL::CComPolyObject<contained>::CreateInstance"
  - "ATL.CComPolyObject.CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: d469a5da-8677-498c-971d-bcf0c956728e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPolyObject::CreateInstance
Allows you to create a new **CComPolyObject<**<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> **>** object without the overhead of [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to a **CComPolyObject<** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>**>** pointer. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is unsuccessful, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to **NULL**.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value.  
  
## Remarks  
 The object returned has a reference count of zero, so call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> immediately, then use **Release** to free the reference on the object pointer when you're done.  
  
 If you don't need direct access to the object, but still want to create a new object without the overhead of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, use [CComCoClass::CreateInstance](../vs140/ccomcoclass--createinstance.md) instead.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)