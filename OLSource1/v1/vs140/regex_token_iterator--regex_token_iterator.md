---
title: "regex_token_iterator::regex_token_iterator"
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
  - "regex_token_iterator::regex_token_iterator"
  - "std::tr1::regex_token_iterator::regex_token_iterator"
  - "std.tr1.regex_token_iterator.regex_token_iterator"
  - "regex_token_iterator.regex_token_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_token_iterator constructor [TR1]"
ms.assetid: 560c5b79-54dc-4641-8c78-c361f7405131
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_token_iterator::regex_token_iterator
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
 The first constructor constructs an end-of-sequence iterator.  
  
 The second constructor constructs an object whose stored iterator <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is initialized to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, whose stored vector <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> holds exactly one integer, with value <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and whose stored value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is zero. Note: the resulting object extracts the submatch identified by the index value <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for each successful regular expression match.  
  
 The third constructor constructs an object whose stored iterator <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is initialized to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, whose stored vector <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> holds a copy of the constructor argument <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and whose stored value <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is zero.  
  
 The fourth constructor constructs an object whose stored iterator <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is initialized to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, whose stored vector <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> holds the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> values pointed to by the constructor argument <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and whose stored value <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is zero.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_token_iterator](../vs140/regex_token_iterator-class.md)