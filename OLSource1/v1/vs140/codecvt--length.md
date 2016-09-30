---
title: "codecvt::length"
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
  - "codecvt.length"
  - "length"
  - "codecvt::length"
  - "xlocale/std::codecvt::length"
  - "std::codecvt::length"
  - "std.codecvt.length"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "length method"
ms.assetid: 368dad1a-c151-4c3d-9a02-537d74a7f8c0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::length
Determines how many **Byte**s from a given sequence of external **Byte**s produce not more than a given number of internal **CharType**s and returns that number of **Byte**s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the beginning of the external sequence.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the end of the external sequence.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The maximum number of Bytes that can be returned by the member function.  
  
## Return Value  
 An integer that represents a count of the maximum number of conversions, not greater than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, defined by the external source sequence at [<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
## Remarks  
 The member function returns [do_length](../vs140/codecvt--do_length.md)(*_State, _First1*, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The length of the string is: 50.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)