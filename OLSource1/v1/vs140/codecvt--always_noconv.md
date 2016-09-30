---
title: "codecvt::always_noconv"
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
  - "std::codecvt::always_noconv"
  - "locale/std::codecvt::always_noconv"
  - "codecvt.always_noconv"
  - "codecvt::always_noconv"
  - "always_noconv"
  - "std.codecvt.always_noconv"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "always_noconv function"
ms.assetid: 30363b06-009f-4c18-9e5f-35dc62e9b22e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::always_noconv
Tests whether no conversions need be done.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A Boolean value that is **true** if no conversions need be done; **false** is at least one needs to be done.  
  
## Remarks  
 The member function returns [do_always_noconv](../vs140/codecvt--do_always_noconv.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **No conversion is needed.**  
**At least one conversion is required.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)