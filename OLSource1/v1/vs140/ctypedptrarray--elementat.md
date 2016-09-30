---
title: "CTypedPtrArray::ElementAt"
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
  - "CTypedPtrArray::ElementAt"
  - "CTypedPtrArray.ElementAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ElementAt method"
ms.assetid: 9f3c8b16-86e0-4c4e-8409-dd985c8a287a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrArray::ElementAt
This inline function calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>**::ElementAt**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in this array.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>**::GetUpperBound**.  
  
## Return Value  
 A temporary reference to the element at the location specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This element is of the type specified by the template parameter *TYPE*.  
  
## Remarks  
 For more detailed remarks, see [CObArray::ElementAt](../vs140/cobarray--elementat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrArray Class](../vs140/ctypedptrarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::ElementAt](../vs140/cobarray--elementat.md)   
 [CObArray::GetUpperBound](../vs140/cobarray--getupperbound.md)