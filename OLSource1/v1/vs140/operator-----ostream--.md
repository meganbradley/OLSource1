---
title: "operator&lt;&lt; (&lt;ostream&gt;)"
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
  - "std.operator<<"
  - "std.<<"
  - "ostream/std::operator<<"
  - "<<"
  - "std::<<"
  - "std::operator<<"
  - "operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<< operator"
  - "<< operator, with specific objects"
  - "operator<<, streams"
  - "operator <<, streams"
ms.assetid: 7d3fecab-2158-4759-8dbf-5587aaf076f0
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;&lt; (&lt;ostream&gt;)
Writes various types to the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A character.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The element type.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A character string.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Character traits.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The type  
  
## Return Value  
 The stream.  
  
## Remarks  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class also defines several insertion operators. For more information, see [basic_ostream::operator<<](../vs140/basic_ostream--operator--.md).  
  
 The template function  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 determines the length N = <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>[length](../vs140/char_traits--length.md)(<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>) of the sequence beginning at <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and inserts the sequence. If N < <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>[width](../vs140/ios_base--width.md), then the function also inserts a repetition of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> - N fill characters. The repetition precedes the sequence if (<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.[flags](../vs140/ios_base--flags.md) & <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> != [left](../vs140/left.md). Otherwise, the repetition follows the sequence. The function returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 The template function  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 inserts the element <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. If 1 < <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, then the function also inserts a repetition of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> - 1 fill characters. The repetition precedes the sequence if <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. Otherwise, the repetition follows the sequence. It returns <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 The template function  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 behaves the same as  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 except that each element <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> of the sequence beginning at <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is converted to an object of type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>[put](../vs140/basic_ostream--put.md)(<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>[widen](../vs140/basic_ios--widen.md)(<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>)).  
  
 The template function  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 behaves the same as  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 except that <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is converted to an object of type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>)).  
  
 The template function  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 behaves the same as  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 (It does not have to widen the elements before inserting them.)  
  
 The template function  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 behaves the same as  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 (It does not have to widen <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> before inserting it.)  
  
 The template function  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> << (<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>)<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 The template function  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> << (<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>)<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> << (<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>)<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> << (<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>)<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> (and converts a [RValue Reference](../vs140/rvalue-reference-declarator----.md) to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to an lvalue in the process).  
  
## Example  
 See [flush](../vs140/flush--standard-c---library-.md) for an example using <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostream::operator<<](../vs140/basic_ostream--operator--.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)