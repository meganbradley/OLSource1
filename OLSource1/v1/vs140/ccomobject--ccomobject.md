---
title: "CComObject::CComObject"
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
  - "CComObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObject class, constructor"
  - "CComObject constructor"
ms.assetid: f5a88bf9-0dd9-4bd4-a860-2bc9aa342476
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObject::CComObject
The constructor increments the module lock count.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 **void\***  
 [in] This unnamed parameter is not used. It exists for symmetry with other **CCom***XXX*<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>*XXX* constructors.  
  
## Remarks  
 The destructor decrements it.  
  
 If a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived object is successfully constructed using the **new** operator, the initial reference count is 0. To set the reference count to the proper value (1), make a call to the [AddRef](../vs140/ccomobject--addref.md) function.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObject Class](../vs140/ccomobject-class.md)