---
title: "basic_string::insert"
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
  - "std::basic_string::insert"
  - "Insert"
  - "insert"
  - "basic_string::insert"
  - "xstring/std::basic_string::insert"
  - "basic_string.insert"
  - "std.basic_string.insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: c71e5a6f-e26a-4d8f-a56e-526be4276e5a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::insert
Inserts an element or a number of elements or a range of elements into the string at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *_P0*  
 The index of the position behind the point of insertion the new characters.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The C-string to be wholly or partly inserted into the string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of characters to be inserted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The string to be wholly or partly inserted into the target string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The index of the part of the source string supplying the characters to be appended.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The character value of the elements to be inserted.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An iterator addressing the position behind which a character is to be inserted.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the first element in the source range to be inserted.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the source range to be inserted.  
  
## Return Value  
 Either a reference to the string object that is being assigned new characters by the member function or, in the case of individual character insertions, an iterator addressing the position of the character inserted, or none, depending on the particular member function.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The string with a C-string inserted at position 0 is: away.**  
**The string with a C-string inserted at the end is: GoodBye.**  
**The string with a string inserted at position 0 is: GoodBye.**  
**The string with part of a string inserted at position 4 is: Good Baby.**  
**The string with characters inserted is: The number is: 333.**  
**The string with a character inserted is: ABCDeFG**  
**The string with a character inserted from a range is: ABCDefgHIJ**  
**The string with a character inserted from a range is: ABCDeeeHIJ**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)