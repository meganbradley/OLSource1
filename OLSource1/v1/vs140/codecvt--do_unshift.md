---
title: "codecvt::do_unshift"
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
  - "xlocale/std::codecvt::do_unshift"
  - "std.codecvt.do_unshift"
  - "codecvt.do_unshift"
  - "codecvt::do_unshift"
  - "do_unshift"
  - "std::codecvt::do_unshift"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_unshift method"
ms.assetid: c14a4392-c3a9-4f23-880a-4cc88f9a8681
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::do_unshift
A virtual function called to provide the **Byte**s needed in a state-dependent conversion to complete the last character in a sequence of **Byte**s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the first position in the destination range.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the last position in the destination range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the first unaltered element in the destination sequence.  
  
## Return Value  
 The function returns:  
  
-   **codecvt_base::error** if _*State* represents an invalid state  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the function performs no conversion  
  
-   **codecvt_base::ok** if the conversion succeeds  
  
-   **codecvt_base::partial** if the destination is not large enough for the conversion to succeed  
  
## Remarks  
 The protected virtual member function tries to convert the source element **CharType**(0) to a destination sequence that it stores within [<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), except for the terminating element **Byte**(0). It always stores in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> a pointer to the first unaltered element in the destination sequence.  
  
 _*State* must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value as needed to reflect the current state of a successful conversion. Typically, converting the source element **CharType**(0) leaves the current state in the initial conversion state.  
  
## Example  
 See the example for [unshift](../vs140/codecvt--unshift.md), which calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)