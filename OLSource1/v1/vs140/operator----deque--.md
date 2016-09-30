---
title: "operator&gt; (&lt;deque&gt;)"
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
  - "std::operator>"
  - "std.>"
  - "std.operator>"
  - "operator>"
  - "deque/std::operator>"
  - "std::>"
  - ">"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >, deque objects"
  - "> operator, comparing specific objects"
ms.assetid: 1a61cd9c-3a67-4267-8c6b-3678b2a932a1
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (&lt;deque&gt;)
Tests if the deque object on the left side of the operator is greater than the deque object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 **true** if the deque on the left side of the operator is greater than the deque on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between deque objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Deque c1 is greater than deque c2.**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)