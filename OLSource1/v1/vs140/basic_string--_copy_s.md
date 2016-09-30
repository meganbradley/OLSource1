---
title: "basic_string::_Copy_s"
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
  - "std::basic_string::_Copy_s"
  - "basic_string::_Copy_s"
  - "xstring/std::basic_string::_Copy_s"
  - "basic_string._Copy_s"
  - "std.basic_string._Copy_s"
  - "_Copy_s"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_Copy_s method"
ms.assetid: 79eaafb6-bf5b-4e5b-9956-944603166091
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::_Copy_s
Copies at most a specified number of characters from an indexed position in a source string to a target character array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The target character array to which the elements are to be copied.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 _<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of characters to be copied, at most, from the source string.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
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
 [Safe Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)