---
title: "codecvt::in"
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
  - "xlocale/std::codecvt::in"
  - "std::codecvt::in"
  - "in"
  - "codecvt::in"
  - "std.codecvt.in"
  - "codecvt.in"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "in method"
ms.assetid: 7ae58847-76f0-4b65-8616-289c48d74699
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::in
Converts an external representation of a sequence of **Byte**s to an internal representation of a sequence of **CharType**s.  
  
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
 Pointer beyond the end of the converted sequence to the first unconverted character.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the beginning of the converted sequence.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the end of the converted sequence.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Pointer to the **CharType** that comes after the last converted **Chartype** to the first unaltered character in the destination sequence.  
  
## Return Value  
 A return that indicates the success, partial success or failure of the operation. The function returns:  
  
-   **codecvt_base::error** if the source sequence is ill formed.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the source is insufficient or if the destination is not large enough for the conversion to succeed.  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value, as needed, to reflect the current state of a successful conversion. After a partial conversion, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> must be set so as to allow the conversion to resume when new characters arrive.  
  
 The member function returns [do_in](../vs140/codecvt--do_in.md)(<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, _*First1, _Last1, _Next1, First2, _Llast2, _Next2*).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **It worked! The converted string is:**  
 **[This is the string to be converted!]**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)