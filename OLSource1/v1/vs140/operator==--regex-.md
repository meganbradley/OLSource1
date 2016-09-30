---
title: "operator== &lt;regex&gt;"
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
  - "regex::operator=="
  - "regex.operator=="
  - "std.tr1.regex.operator=="
  - "std::tr1::regex::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== operator [TR1]"
ms.assetid: 68803e0d-6c82-4a85-91e7-f000aa3f6079
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== &lt;regex&gt;
Equal comparison for various objects.  
  
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
 Each template operator converts each of its arguments to a string type and returns the result of comparing the converted objects for equality.  
  
 When a template operator converts its arguments to a string type it uses the first of the following transformations that applies:  
  
 arguments whose types are a specialization of template class <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are converted by calling the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member function;  
  
 arguments whose types are a specialization of the template class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are unchanged;  
  
 all other argument types are converted by passing the argument value to the constructor for an appropriate specialization of the template class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match == caaa**  
**sub == aaa**  
**match == match == true**  
**sub == sub == true**  
**string("aab") == sub == false**  
**sub == string("aab") == false**  
**"aab" == sub == false**  
**sub == "aab" == false**  
**'a' == sub == false**  
**sub == 'a' == false**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [operator!==](../vs140/operator!=--regex-.md)   
 [operator<](../vs140/operator---regex-.md)   
 [operator\<=](../vs140/operator-=--regex-.md)   
 [operator>](../vs140/operator---regex-.md)   
 [operator>=](../vs140/operator-=--regex-.md)