---
title: "CComAggObject::CreateInstance"
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
  - "CComAggObject<contained>::CreateInstance"
  - "CComAggObject.CreateInstance"
  - "CComAggObject::CreateInstance"
  - "ATL::CComAggObject::CreateInstance"
  - "ATL::CComAggObject<contained>::CreateInstance"
  - "ATL.CComAggObject.CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: fd838b8c-0980-48e3-8b3a-1e94bedf435a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAggObject::CreateInstance
This static function allows you to create a new **CComAggObject<**<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> **>** object without the overhead of [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to a **CComAggObject\<***contained* **>** pointer. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is unsuccessful, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to **NULL**.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value.  
  
## Remarks  
 The object returned has a reference count of zero, so call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> immediately, then use **Release** to free the reference on the object pointer when you're done.  
  
 If you do not need direct access to the object, but still want to create a new object without the overhead of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, use [CComCoClass::CreateInstance](../vs140/ccomcoclass--createinstance.md) instead.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)