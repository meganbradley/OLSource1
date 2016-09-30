---
title: "operator!= &lt;regex&gt;"
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
  - "std::tr1::regex::operator!="
  - "regex::operator!="
  - "std.tr1.regex.operator!="
  - "regex.operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= operator [TR1]"
ms.assetid: 24cdee65-eac0-441c-beb8-352c53bcc9bf
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= &lt;regex&gt;
Not equal comparison for various objects.  
  
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
 Each template operator returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match == caaa**  
**sub == aaa**  
**match != match == false**  
**sub != sub == false**  
**string("aab") != sub == true**  
**sub != string("aab") == true**  
**"aab" != sub == true**  
**sub != "aab" == true**  
**'a' != sub == true**  
**sub != 'a' == true**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [operator==](../vs140/operator==--regex-.md)   
 [operator<](../vs140/operator---regex-.md)   
 [operator\<=](../vs140/operator-=--regex-.md)   
 [operator>](../vs140/operator---regex-.md)   
 [operator>=](../vs140/operator-=--regex-.md)