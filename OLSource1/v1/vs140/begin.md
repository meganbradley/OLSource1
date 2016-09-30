---
title: "begin"
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
  - "std.begin"
  - "begin"
  - "xutility/std::end"
  - "iterator/std:end"
  - "std::begin"
dev_langs: 
  - "C++"
ms.assetid: d49a71c1-13b5-495b-a469-c13a037acc71
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# begin
Retrieves an iterator to the first element in a specified container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A container.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An array of objects of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 The first two template functions return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The first function is non-constant; the second one is constant.  
  
 The third template function returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
 We recommend that you use this template function in place of container member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when more generic behavior is required.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> supports containers of any kind, in addition to regular arrays, because it calls the non-member version of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> were coded to use the container member <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Then sending an array to it would cause this compiler error:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [cbegin](../vs140/cbegin.md)   
 [cend](../vs140/cend.md)   
 [end](../vs140/end.md)