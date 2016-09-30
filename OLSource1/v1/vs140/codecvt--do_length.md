---
title: "codecvt::do_length"
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
  - "codecvt::do_length"
  - "codecvt.do_length"
  - "std.codecvt.do_length"
  - "do_length"
  - "xlocale/std::codecvt::do_length"
  - "std::codecvt::do_length"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_length method"
ms.assetid: f4533e3f-2e8c-4dfc-a3c9-5b8c3025ab10
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::do_length
A virtual function that determines how many **Byte**s from a given sequence of external **Byte**s produce not more than a given number of internal **CharType**s and returns that number of **Byte**s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the beginning of the external sequence.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the end of the external sequence.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum number of **Byte**s that can be returned by the member function.  
  
## Return Value  
 An integer that represents a count of the maximum number of conversions, not greater than <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, defined by the external source sequence at [<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Remarks  
 The protected virtual member function effectively calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (a copy of state), some buffer <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and pointers <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 It then returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> – **buf**. Thus, it counts the maximum number of conversions, not greater than <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, defined by the source sequence at [<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>).  
  
 The template version always returns the lesser of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [length](../vs140/codecvt--length.md), which calls **do_length**.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)