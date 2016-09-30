---
title: "operator!= &lt;functional&gt;"
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
  - "std.tr1.operator!="
  - "std::tr1::operator!="
  - "operator!="
  - "functional/std::tr1::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= operator [TR1]"
ms.assetid: 00b16342-6462-4d98-98ff-3f870486ad27
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= &lt;functional&gt;
Tests if callable object is not empty.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function type to wrap.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The function object  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A null pointer.  
  
## Remarks  
 The operators both take an argument that is a reference to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object and an argument that is a null pointer constant. Both return true only if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is not empty.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **not empty == false**  
**not empty == true**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [operator_eq](../vs140/operator==--functional-.md)