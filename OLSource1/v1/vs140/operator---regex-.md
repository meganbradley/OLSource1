---
title: "operator&lt; &lt;regex&gt;"
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
  - "regex::operator<"
  - "std::tr1::regex::operator<"
  - "regex.operator<"
  - "std.tr1.regex.operator<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator< operator [TR1]"
ms.assetid: 667bed76-46bd-47ea-8857-c6c6898a583e
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; &lt;regex&gt;
Less than comparison for various objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The left object to compare.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The right object to compare.  
  
## Remarks  
 Each template operator converts its arguments to a string type and returns true only if the converted value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> compares less than the converted value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sub == aaa**  
**sub < sub == false**  
**string("aab") < sub == false**  
**sub < string("aab") == true**  
**"aab" < sub == false**  
**sub < "aab" == true**  
**'a' < sub == true**  
**sub < 'a' == false**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [operator==](../vs140/operator==--regex-.md)   
 [operator!==](../vs140/operator!=--regex-.md)   
 [operator\<=](../vs140/operator-=--regex-.md)   
 [operator>](../vs140/operator---regex-.md)   
 [operator>=](../vs140/operator-=--regex-.md)