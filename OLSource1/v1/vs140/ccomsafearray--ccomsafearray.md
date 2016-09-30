---
title: "CComSafeArray::CComSafeArray"
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
  - "ATL.CComSafeArray.CComSafeArray"
  - "CComSafeArray::CComSafeArray"
  - "ATL::CComSafeArray::CComSafeArray"
  - "CComSafeArray.CComSafeArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComSafeArray class, constructor"
  - "CComSafeArray constructor"
ms.assetid: 1e509c71-2263-45d2-88e2-7b863fd476a7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::CComSafeArray
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A **SAFEARRAYBOUND** structure.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements in the array.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The lower bound value; that is, the index of the first element in the array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAYBOUND** structure.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The count of dimensions in the array.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A reference to a **SAFEARRAY** structure or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. In either case the constructor uses this reference to make a copy of the array, so the array is not referenced after construction.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAY** structure. The constructor uses this address to make a copy of the array, so the array is not referenced after construction.  
  
## Remarks  
 Creates a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::~CComSafeArray](../vs140/ccomsafearray--~ccomsafearray.md)