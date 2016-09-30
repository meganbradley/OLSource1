---
title: "operator&lt; (&lt;stack&gt;)"
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
  - "std::operator<"
  - "operator<"
  - "std.<"
  - "<"
  - "std.operator<"
  - "std::<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<, stack class"
  - "< operator, comparing specific objects"
  - "< operator"
  - "operator <, stack class"
ms.assetid: c444c3fd-97c2-41a7-9480-4b94f77342e3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; (&lt;stack&gt;)
Tests if the stack object on the left side of the operator is less than the stack object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type **stack**.  
  
## Return Value  
 **true** if the stack on the left side of the operator is less than and not equal to the stack on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between stack objects is based on a pairwise comparison of their elements. The less-than relationship between two stack objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The stack s1 is less than the stack s2.**  
**The stack s1 is greater than or equal to the stack s3.**  
**The stack s1 from the top down is: ( 8 6 4 2 ).**   
## Requirements  
 **Header:** \<stack>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)