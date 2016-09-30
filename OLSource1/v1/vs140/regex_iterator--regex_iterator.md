---
title: "regex_iterator::regex_iterator"
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
  - "regex_iterator::regex_iterator"
  - "regex_iterator.regex_iterator"
  - "std::tr1::regex_iterator::regex_iterator"
  - "std.tr1.regex_iterator.regex_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_iterator constructor [TR1]"
ms.assetid: 0dd4d584-0a3c-43f3-8f55-a1bdd6b3d10e
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_iterator::regex_iterator
Constructs the iterator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Beginning of sequence to match.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 End of sequence to match.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Regular expression for matches.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Flags for matches.  
  
## Remarks  
 The first constructor constructs an end-of-sequence iterator. The second constructor initializes the stored value <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the stored value <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the stored value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and the stored value <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. It then calls <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If the search fails, the constructor sets the object to an end-of-sequence iterator.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match == a**  
**match == a**  
**match == a**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)