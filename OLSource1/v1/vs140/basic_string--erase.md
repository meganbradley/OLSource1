---
title: "basic_string::erase"
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
  - "std.basic_string.erase"
  - "erase"
  - "xstring/std::basic_string::erase"
  - "basic_string::erase"
  - "std::basic_string::erase"
  - "Erase"
  - "basic_string.erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: f5dda847-81b9-4c21-b68a-c97ab5ba46ad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::erase
Removes an element or a range of elements in a string from a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An iterator addressing the position of the first element in the range to be erased.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An iterator addressing the position one past the last element in the range to be erased.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An iterator addressing the position of the element in the string to be erased.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The index of the first character in the string to be removed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The number of elements that will be removed if there are as many in the range of the string beginning with *_Pos*.  
  
## Return Value  
 For the first two member functions, an iterator addressing the first character after the last character removed by the member function. For the third member function, a reference to the string object from which the elements have been erased.  
  
## Remarks  
 The third member function returns **\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string object str1 is: Hello world.**  
**The first element after those removed is: d.**  
**The modified string object str1 is: Held.**  
**The original string object str2 is: Hello World.**  
**The first element after those removed is: W.**  
**The modified string object str2 is: HelloWorld.**  
**The original string object str3 is: Hello computer.**  
**The modified string object str3m is: Hello .**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)