---
title: "&lt;iomanip&gt; put_money"
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
  - "iomanip/std::put_money"
  - "std.put_money"
  - "std::put_money"
  - "put_money"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_money function"
ms.assetid: 720238c7-e736-4a28-b73d-41ffb4bdc091
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iomanip&gt; put_money
Inserts a monetary amount using the desired format into a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The monetary amount to insert into the stream.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if manipulator should use international format, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if it should not.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The manipulator returns an object that, when inserted into the stream <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, behaves as a formatted output function that calls the member function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for the locale facet <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> associated with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If successful, the call inserts <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> suitably formatted, using <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to indicate international format and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, as the fill element. The manipulator then returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must be of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or an instantiation of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with the same element and traits parameters as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<iomanip>  
  
 **Namespace:** std  
  
## See Also  
 [\<iomanip>](../vs140/-iomanip-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)