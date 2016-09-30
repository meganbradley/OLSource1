---
title: "operator== (&lt;utility&gt;)"
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
  - "std.=="
  - "utility/std::operator=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "== operator, with specific standard C++ objects"
  - "operator==, pair objects"
  - "operator ==, pair objects"
ms.assetid: b36c75a9-8f53-4c98-8534-c09f169febec
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;utility&gt;)
Tests if the pair object on the left side of the operator is equal to the pair object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type **pair.**  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 **true** if the pairs are equal; **false** if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>s are not equal.  
  
## Remarks  
 One pair is equal to another pair if each of their respective elements is equal. The function returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.**first** == <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.**first** && <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.**second** == <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.**second**. Two pairs are unequal if either the first or the second element of one is not equal to the corresponding element of the other pair.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std