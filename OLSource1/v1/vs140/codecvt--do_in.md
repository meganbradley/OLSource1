---
title: "codecvt::do_in"
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
  - "codecvt::do_in"
  - "std.codecvt.do_in"
  - "xlocale/std::codecvt::do_in"
  - "do_in"
  - "std::codecvt::do_in"
  - "codecvt.do_in"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_in method"
ms.assetid: 573eec3e-1639-4d12-99c2-c10ccc8f7328
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::do_in
A virtual function called to convert a sequence of external **Byte**s to a sequence of internal **CharType**s.  
  
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
 Pointer beyond the end of the converted sequence, to the first unconverted character.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the beginning of the converted sequence.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the end of the converted sequence.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the **CharType** that comes after the last converted **CharType**, to the first unaltered character in the destination sequence.  
  
## Return Value  
 A return that indicates the success, partial success, or failure of the operation. The function returns:  
  
-   **codecvt_base::error** if the source sequence is ill formed.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the source is insufficient or if the destination is not large enough, for the conversion to succeed.  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value as needed to reflect the current state of a successful conversion. Its stored value is otherwise unspecified.  
  
## Example  
 See the example for [in](../vs140/codecvt--in.md), which calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)