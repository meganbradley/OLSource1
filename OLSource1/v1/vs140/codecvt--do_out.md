---
title: "codecvt::do_out"
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
  - "xlocale/std::codecvt::do_out"
  - "codecvt::do_out"
  - "do_out"
  - "std.codecvt.do_out"
  - "std::codecvt::do_out"
  - "codecvt.do_out"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_out method"
ms.assetid: bd19b79b-0f3f-4a03-9cdf-7be055c8c1c0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::do_out
A virtual function called to convert a sequence of internal **CharType**s to a sequence of external **Byte**s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Reference to a pointer to the first unconverted **CharType**, after the last **CharType** converted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the beginning of the converted sequence.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the end of the converted sequence.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Reference to a pointer to the first unconverted **Byte**, after the last **Byte** converted.  
  
## Return Value  
 The function returns:  
  
-   **codecvt_base::error** if the source sequence is ill formed.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the source is insufficient or if the destination is not large enough for the conversion to succeed.  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value as needed to reflect the current state of a successful conversion. Its stored value is otherwise unspecified.  
  
## Example  
 See the example for [out](../vs140/codecvt--out.md), which calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)