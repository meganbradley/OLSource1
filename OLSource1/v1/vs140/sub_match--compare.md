---
title: "sub_match::compare"
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
  - "sub_match::compare"
  - "std::tr1::sub_match::compare"
  - "sub_match.compare"
  - "std.tr1.sub_match.compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compare method [TR1]"
ms.assetid: de1bd73d-66a2-4417-9b5d-cfc35bda3743
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sub_match::compare
Compare submatch against a sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The submatch to compare to.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The string to compare to.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The nul-terminated sequence to compare to.  
  
## Remarks  
 The first member function compares the matched sequence <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to the matched sequence <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The second member function compares the matched sequence <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to the character sequence <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The third member function compares the matched sequence <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the character sequence <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 Each function returns:  
  
 a negative value if the first differing value in the matched sequence compares less than the corresponding element in the operand sequence (as determined by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>), or if the two have a common prefix but the target sequence is longer  
  
 zero if the two compare equal element by element and have the same length  
  
 a positive value otherwise  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [sub_match](../vs140/sub_match-class.md)