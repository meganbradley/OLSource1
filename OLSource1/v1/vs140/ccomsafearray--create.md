---
title: "CComSafeArray::Create"
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
  - "ATL::CComSafeArray::Create"
  - "ATL.CComSafeArray.Create"
  - "CComSafeArray::Create"
  - "CComSafeArray.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 8b19c3c6-e323-4f3c-af8e-5ccfe4ab9383
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::Create
Creates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAYBOUND** object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of dimensions in the array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of elements in the array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The lower bound value; that is, the index of the first element in the array.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object can be created from an existing **SAFEARRAYBOUND** structure and the number of dimensions, or by specifying the number of elements in the array and the lower bound. If the array is to be accessed from Visual C++, the lower bound should be 0. Other languages may allow other values for the lower bound (for example, Visual Basic supports arrays with elements with a range such as -10 to 10).  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::Destroy](../vs140/ccomsafearray--destroy.md)