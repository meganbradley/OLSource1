---
title: "CTypedPtrArray::InsertAt"
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
  - "CTypedPtrArray.InsertAt"
  - "CTypedPtrArray::InsertAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertAt method"
  - "CTypedPtrArray class, operations"
ms.assetid: 2eeb07ce-ffba-4cd2-8676-89f99d621610
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrArray::InsertAt
This member function calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>**::InsertAt**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by [CObArray::GetUpperBound](../vs140/cobarray--getupperbound.md).  
  
 *TYPE*  
 Type of the elements stored in the base-class array.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object pointer to be placed in this array. A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of value **NULL** is allowed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of times this element should be inserted (defaults to 1).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Base class of the typed pointer array class; must be an array class ([CObArray](../vs140/cobarray-class.md) or [CPtrArray](../vs140/cptrarray-class.md)).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Another array that contains elements to be added to this array.  
  
## Remarks  
 For more detailed remarks, see [CObArray::InsertAt](../vs140/cobarray--insertat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrArray Class](../vs140/ctypedptrarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)