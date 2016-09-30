---
title: "operator&gt; (&lt;utility&gt;)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::operator>"
  - "std.>"
  - "std.operator>"
  - "operator>"
  - "std::>"
  - ">"
  - "utility/std::operator>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >, pair objects"
  - "> operator, comparing specific objects"
ms.assetid: d135eabc-f3f2-4bc3-bd85-fa89eef423fc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (&lt;utility&gt;)
Tests if the pair object on the left side of the operator is greater than the pair object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on the left side of the operator.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on the right side of the operator.  
  
## Return Value  
 **true** if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on the left side of the operator is strictly greater than the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is said to be strictly greater than the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is greater than and not equal <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 In a comparison of pairs, the values' first elements of the two pairs have the highest priority. If they differ, then the result of their comparison is taken as the result of the comparison of the pair. If the values of the first elements are not different, then the values of the second elements are compared and the result of their comparison is taken as the result of the comparison of the pair.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The pair p1 is: ( 10, 0.222 ).**  
**The pair p2 is: ( 100, 0.111 ).**  
**The pair p3 is: ( 10, 0.111 ).**  
**The pair p4 is: ( 10, 0.222 ).**  
**The pair p1 is not greater than the pair p2.**  
**The pair p1 is greater than the pair p3.**  
**The pair p1 is not greater than the pair p4.**   
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std