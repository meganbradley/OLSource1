---
title: "basic_string::push_back"
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
  - "std.basic_string.push_back"
  - "basic_string::push_back"
  - "basic_string.push_back"
  - "push_back"
  - "std::basic_string::push_back"
  - "xstring/std::basic_string::push_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_back method"
ms.assetid: a17682ac-623b-499a-bded-03364bd0ec01
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::push_back
Adds an element to the end of the string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character to be added to the end of the string.  
  
## Remarks  
 The member function effectively calls [insert](../vs140/basic_string--insert.md)( [end](../vs140/basic_string--end.md), _*Ch* ).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string str1 is: abc**  
**The last character-letter of the modified str1 is now: c**  
**The modified string str1 is: abc**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)