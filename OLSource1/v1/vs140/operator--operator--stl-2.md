---
title: "operator- Operator (STL)2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "operator/ Operator (STL)"
f1_keywords: 
  - "chrono/std::chrono::operator/"
dev_langs: 
  - "C++"
ms.assetid: 587b6663-61d2-4028-8283-92a251820c1f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- Operator (STL)2
Division operator for [duration](../vs140/operator--operator--stl-.md) objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An integral value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Return Value  
 The first operator returns a duration object whose interval length is the length of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> divided by the value <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The second operator returns the ratio of the interval lengths of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Unless <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>*holds true*, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not an instantiation of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the first operator does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)