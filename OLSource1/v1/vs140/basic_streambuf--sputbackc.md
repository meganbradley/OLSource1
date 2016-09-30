---
title: "basic_streambuf::sputbackc"
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
  - "std::basic_streambuf::sputbackc"
  - "sputbackc"
  - "basic_streambuf.sputbackc"
  - "std.basic_streambuf.sputbackc"
  - "streambuf/std::basic_streambuf::sputbackc"
  - "basic_streambuf::sputbackc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sputbackc method"
ms.assetid: 04455fa6-893a-4937-9dcd-b759828f03ef
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sputbackc
Puts a char_type in the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The character.  
  
## Return Value  
 Returns the character or failure.  
  
## Remarks  
 If a putback position is available and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> compares equal to the character stored in that position, the member function decrements the next pointer for the input buffer and returns **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). Otherwise, it returns [pbackfail](../vs140/basic_streambuf--pbackfail.md)(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: basic_streambuf_sputbackc.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)