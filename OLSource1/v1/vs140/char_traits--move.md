---
title: "char_traits::move"
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
  - "Move"
  - "char_traits::move"
  - "iosfwd/std::char_traits::move"
  - "move"
  - "std.char_traits.move"
  - "std::char_traits::move"
  - "char_traits.move"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move method"
ms.assetid: b6db1aca-c38e-4ad3-a95f-a05f83e67afc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::move
Copies a specified number of characters in a sequence to another, possibly overlapping sequence.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct. Consider using [char_traits::_Move_s](../vs140/char_traits--_move_s.md) instead.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element at the beginning of the string or character array targeted to receive the copied sequence of characters.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The element at the beginning of the source string or character array to be copied.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of elements to be copied from the source string.  
  
## Return Value  
 The first element <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> copied into the string or character array targeted to receive the copied sequence of characters.  
  
## Remarks  
 The source and destination may overlap.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The source string sFrom1 is: abcd-1234-abcd**  
**The destination stringsTo1 is: ABCD-1234**  
**The result1 = move ( sTo1 , sFrom1 , 4 ) is: abcd-1234**  
**The source/destination string sToFrom2 is: abcd-1234-ABCD**  
**The result2 = move ( sToFrom2 , findc , 8 ) is: cd-1234-4-ABCD**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)