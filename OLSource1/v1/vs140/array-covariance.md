---
title: "Array Covariance"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "arrays [C++], covariance"
ms.assetid: 889fdde3-85fe-44d5-bf2d-d3d4aa14e746
caps.latest.revision: 10
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Array Covariance
Given reference class D with direct or indirect base class B, an array of type D can be assigned to an array variable of type B.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An assignment to an array element shall be assignment-compatible with the dynamic type of the array. An assignment to an array element with incompatible type will cause System::ArrayTypeMismatchException to be thrown.  
  
 Array covariance does not apply to arrays of value class type. For example, arrays of Int32 cannot be converted to Object^ arrays, even via boxing.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [array](../vs140/arrays--c---component-extensions-.md)