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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::do_in
A virtual function called to convert a sequence of external **Byte**s to a sequence of internal **CharType**s.  
  
## Syntax  
  
```  
virtual result do_in(  
    StateType& _State,  
    const Byte* _First1,   
    const Byte* _Last1,   
    const Byte*& _Next1,  
    CharType* _First2,  
    CharType* _Last2,  
    CharType*& _Next2,  
) const;  
```  
  
#### Parameters  
 `_State`  
 The conversion state that is maintained between calls to the member function.  
  
 `_First1`  
 Pointer to the beginning of the sequence to be converted.  
  
 `_Last1`  
 Pointer to the end of the sequence to be converted.  
  
 `_Next1`  
 Pointer beyond the end of the converted sequence, to the first unconverted character.  
  
 `_First2`  
 Pointer to the beginning of the converted sequence.  
  
 `_Last2`  
 Pointer to the end of the converted sequence.  
  
 `_Next2`  
 Pointer to the **CharType** that comes after the last converted **CharType**, to the first unaltered character in the destination sequence.  
  
## Return Value  
 A return that indicates the success, partial success, or failure of the operation. The function returns:  
  
-   **codecvt_base::error** if the source sequence is ill formed.  
  
-   `codecvt_base::noconv` if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the source is insufficient or if the destination is not large enough, for the conversion to succeed.  
  
## Remarks  
 `_State` must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value as needed to reflect the current state of a successful conversion. Its stored value is otherwise unspecified.  
  
## Example  
 See the example for [in](../vs140/codecvt--in.md), which calls `do_in`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)