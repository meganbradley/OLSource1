---
title: "basic_string::copy"
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
  - "std::basic_string::copy"
  - "basic_string::copy"
  - "xstring/std::basic_string::copy"
  - "std.basic_string.copy"
  - "basic_string.copy"
  - "copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy method"
ms.assetid: 0099269b-fc6c-44ad-a0cb-4d42d0ffee13
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::copy
Copies at most a specified number of characters from an indexed position in a source string to a target character array.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct. Consider using [basic_string::_Copy_s](../vs140/basic_string--_copy_s.md) instead.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The target character array to which the elements are to be copied.  
  
 _ <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of characters to be copied, at most, from the source string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The beginning position in the source string from which copies are to be made.  
  
## Return Value  
 The number of characters actually copied.  
  
## Remarks  
 A null character is not appended to the end of the copy.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string str1 is: Hello World**  
**The number of copied characters in array1 is: 11**  
**The copied characters array1 is: Hello World**  
**The number of copied characters in array2 is: 5**  
**The copied characters array2 is: World**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)