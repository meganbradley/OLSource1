---
title: "codecvt::unshift"
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
  - "unshift"
  - "std.codecvt.unshift"
  - "codecvt::unshift"
  - "codecvt.unshift"
  - "std::codecvt::unshift"
  - "xlocale/std::codecvt::unshift"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unshift method"
ms.assetid: f0e7fd61-2488-42be-9539-a04e7f64c3bc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::unshift
Provides the **Byte**s needed in a state-dependent conversion to complete the last character in a sequence of **Byte**s.  
  
## Syntax  
  
```  
result unshift(  
    StateType& _State,  
    Byte* _First2,   
    Byte* _Last2,   
    Byte*& _Next2  
) const;  
```  
  
#### Parameters  
 `_State`  
 The conversion state that is maintained between calls to the member function.  
  
 `_First2`  
 Pointer to the first position in the destination range.  
  
 `_Last2`  
 Pointer to the last position in the destination range.  
  
 `_Next2`  
 Pointer to the first unaltered element in the destination sequence.  
  
## Return Value  
 The function returns:  
  
-   **codecvt_base::error** if state represents an invalid state.  
  
-   `codecvt_base::noconv` if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the destination is not large enough for the conversion to succeed.  
  
## Remarks  
 The protected virtual member function tries to convert the source element **CharType**(0) to a destination sequence that it stores within [`_First2`, `_Last2`), except for the terminating element **Byte**(0). It always stores in `_Next2` a pointer to the first unaltered element in the destination sequence.  
  
 `_State` must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value, as needed, to reflect the current state of a successful conversion. Typically, converting the source element **CharType**(0) leaves the current state in the initial conversion state.  
  
 The member function returns [do_unshift](../vs140/codecvt--do_unshift.md)(`_State`, `_First2`, `_Last2`, `_Next2` ).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)