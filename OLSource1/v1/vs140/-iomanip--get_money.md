---
title: "&lt;iomanip&gt; get_money"
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
  - "std.get_money"
  - "get_money"
  - "std::get_money"
  - "iomanip/std::get_money"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_money function"
ms.assetid: ee47e488-689e-4c74-9167-957e600cc810
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iomanip&gt; get_money
Extracts a monetary value from a stream using the desired format, and returns the value in a parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 _Amount  
 The extracted monetary value.  
  
 _Intl  
 If <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, use international format. The default value is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Property Value/Return Value  
 Returns the stream <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Exceptions  
  
## Remarks  
 The manipulator returns an object that, when extracted from the stream <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, behaves as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that calls the member function <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for the locale facet <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> associated with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to indicate international format. If successful, the call stores in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> the extracted monetary value. The manipulator then returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must be of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or an instantiation of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> with the same element and traits parameters as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<iomanip>  
  
 **Namespace:** std  
  
## See Also  
 [\<iomanip>](../vs140/-iomanip-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)