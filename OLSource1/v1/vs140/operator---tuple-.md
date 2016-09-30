---
title: "operator&lt; &lt;tuple&gt;"
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
  - "tuple::operator<"
  - "tuple.operator<"
  - "std::tr1::tuple::operator<"
  - "std.tr1.tuple.operator<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator< operator [TR1]"
ms.assetid: 2f5fba34-d6c5-4f08-9a9a-2ea6aafcb369
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; &lt;tuple&gt;
Compare <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects for less.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the Nth tuple element.  
  
## Remarks  
 The function returns true when <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is greater than 0 and the first differing value in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> compares less than the corresponding value in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, otherwise it returns false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **0 1 2 3**  
 **0 1 2 3**  
 **false**  
 **true**   
## Requirements  
 **Header:** \<tuple>  
  
 **Namespace:** std  
  
## See Also  
 [\<tuple>](../vs140/-tuple-.md)   
 [operator==](../vs140/operator==--tuple-.md)   
 [operator!==](../vs140/operator!=--tuple-.md)   
 [operator\<=](../vs140/operator-=--tuple-.md)   
 [operator>](../vs140/operator---tuple-.md)   
 [operator>=](../vs140/operator-=--tuple-.md)