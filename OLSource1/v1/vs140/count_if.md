---
title: "count_if"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.count_if"
  - "count_if"
  - "algorithm/std::count_if"
  - "std::count_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count_if"
  - "count_if function"
ms.assetid: b785887c-83cd-4099-becc-3284dee05295
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# count_if
Returns the number of elements in a range whose values satisfy a specified condition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if an element is to be counted. A predicate takes single argument and returns **true** or **false**.  
  
## Return Value  
 The number of elements that satisfy the condition specified by the predicate.  
  
## Remarks  
 This template function is a generalization of the algorithm [count](../vs140/count.md), replacing the predicate "equals a specific value" with any predicate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **v1 = ( 10 20 10 40 10 )**  
**The number of elements in v1 greater than 10 is: 2.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [count_if](../vs140/count_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)