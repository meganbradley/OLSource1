---
title: "codecvt_base Class"
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
  - "codecvt_base"
  - "xlocale/std::codecvt_base"
  - "std.codecvt_base"
  - "std::codecvt_base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "codecvt_base class"
ms.assetid: 7e95c083-91b4-4b3f-8918-0d4ea244a040
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt_base Class
A base class for the codecvt class that is used to define an enumeration type referred to as **result**, used as the return type for the facet member functions to indicate the result of a conversion.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The class describes an enumeration common to all specializations of template class [codecvt](../vs140/codecvt-class.md). The enumeration result describes the possible return values from [do_in](../vs140/codecvt-class.md#codecvt__do_in) or [do_out](../vs140/codecvt-class.md#codecvt__do_out):  
  
-   **ok** if the conversion between internal and external character encodings succeeds.  
  
-   **partial** if the destination is not large enough for the conversion to succeed.  
  
-   **error** if the source sequence is ill formed.  
  
-   **noconv** if the function performs no conversion.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)