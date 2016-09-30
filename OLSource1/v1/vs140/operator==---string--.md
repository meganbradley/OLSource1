---
title: "operator== (&lt;string&gt;)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "string/std::operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, strings"
  - "operator ==, strings"
  - "== operator, with specific standard C++ objects"
ms.assetid: 4cc4279d-e324-4e05-8aa5-69489e054591
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;string&gt;)
Tests if the string object on the left side of the operator is equal to the string object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be compared.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to be compared.  
  
## Return Value  
 **true** if the string object on the left side of the operator is lexicographically equal to the string object on the right side; otherwise **false**.  
  
## Remarks  
 The comparison between string objects is based on a pairwise lexicographical comparison of their characters. Two strings are equal if they have the same number of characters and their respective character values are the same. Otherwise, they are unequal.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The basic_string s1 = pluck.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = pluck.**  
**The strings s1 & s2 are not equal.**  
**The strings s1 & s3 are equal.**  
**The strings s3 & s2 are not equal.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string::operator==](../vs140/string--operator==.md)