---
title: "pow (&lt;valarray&gt;)"
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
  - "std.pow"
  - "std::pow"
  - "valarray/std::pow"
  - "pow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pow function"
ms.assetid: 0e86550b-0ef7-4be3-a4d5-342d02f8f647
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pow (&lt;valarray&gt;)
Operates on the elements of input valarrays and constants, returning a valarray whose elements are equal to a base specified either by the elements of an input valarray or a constant raised to an exponent specified either by the elements of an input valarray or a constant.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements supply the base for each element to be exponentiated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The input valarray whose elements supply the power for each element to be exponentiated.  
  
## Return Value  
 A valarray whose elements <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are equal to:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [ *I* ] raised to the power <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> [ *I* ] for the first template function.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> [ *I* ] raised to the power <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for the second template function.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> raised to the power <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> [ *I* ] for the third template function.  
  
## Remarks  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> have a different number of elements, the result is undefined.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray for the base is: ( 0 0 1 1 2 2 ).**  
**The initial valarray for the exponent is: ( 0 2 4 6 8 10 ).**  
**The power of (n/2) \* exp (2n) for n = 0 to n = 5 is:**  
**n = 0   gives 1**  
**n = 1   gives 0**  
**n = 2   gives 1**  
**n = 3   gives 1**  
**n = 4   gives 256**  
**n = 5   gives 1024**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [sqrt and pow](../vs140/sqrt-and-pow.md)