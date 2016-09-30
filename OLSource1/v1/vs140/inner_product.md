---
title: "inner_product"
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
  - "inner_product"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inner_product function"
ms.assetid: 5b14ed8f-a284-442e-863c-7106e670fa5a
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# inner_product
Computes the sum of the element-wise product of two ranges and adds it to a specified initial value or computes the result of a generalized procedure where the sum and product binary operations are replaced by other specified binary operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the first range whose inner product or generalized inner product with the second range is to be computed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the first range whose inner product or generalized inner product with the second range is to be computed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the second range whose inner product or generalized inner product with the first range is to be computed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An initial value to which the inner product or generalized inner product between the ranges is to be added.  
  
 *_Binary_op1*  
 The binary operation that replaces the inner product operation of sum applied to the element-wise products in the generalization of the inner product.  
  
 *_Binary_op2*  
 The binary operation that replaces the inner product element-wise operation of multiply in the generalization of the inner product.  
  
## Return Value  
 The first member function returns the sum of the element-wise products and adds to it the specified initial value. So for ranges of values *a*i and *b*i, it returns:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> + ( *a*1 \* *b*1 ) + ( *a*2 \* *b*2 ) +  
  
 by iteratively replacing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> + (\**a*i \* **b*i ).  
  
 The second member function returns:  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> _*Binary_op1* ( *a*1 \_*Binary_op2* *b*1 ) \_*Binary_op1* ( *a*2 \_*Binary_op2* *b*2 ) \_*Binary_op1*  
  
 by iteratively replacing <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> _*Binary_op1* (\**a*i \_*Binary_op2* **b*i ).  
  
## Remarks  
 The initial value ensures that there will be a well-defined result when the range is empty, in which case <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is returned. The binary operations do not need to be associative or commutative. The range must be valid and the complexity is linear with the size of the range. The return type of the binary operator must be convertible to **Type** to ensure closure during the iteration.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<numeric>  
  
 **Namespace:** std  
  
## See Also  
 [inner_product](../vs140/inner_product--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)