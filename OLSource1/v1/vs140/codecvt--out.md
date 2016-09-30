---
title: "codecvt::out"
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
  - "xlocale/std::codecvt::out"
  - "std::codecvt::out"
  - "std.codecvt.out"
  - "codecvt::out"
  - "out"
  - "codecvt.out"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "out method"
ms.assetid: 9eeb32e2-baed-47ac-a355-f484e314c770
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::out
Converts a sequence of internal **CharType**s to a sequence of external **Byte**s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Reference to a pointer to the first unconverted **CharType** after the last **CharType** converted.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the beginning of the converted sequence.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the end of the converted sequence.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Reference to a pointer to the first unconverted **Byte** after the last converted **Byte**.  
  
## Return Value  
 The member function returns [do_out](../vs140/codecvt--do_out.md)(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>).  
  
## Remarks  
 For more information, see [codecvt::do_out](../vs140/codecvt--do_out.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **It worked: The converted string is:**  
 **[This is the wchar_t string to be converted.]**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)