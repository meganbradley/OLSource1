---
title: "logic_error Class"
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
  - "stdexcept/std::logic_error"
  - "std::logic_error"
  - "logic_error"
  - "std.logic_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "logic_error class"
ms.assetid: b290d73d-94e1-4288-af86-2bb5d71f677a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# logic_error Class
The class serves as the base class for all exceptions thrown to report errors presumably detectable before the program executes, such as violations of logical preconditions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The value returned by [what](../vs140/exception-class.md) is a copy of **message**<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[data](../vs140/basic_string-class.md#basic_string__data).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<stdexcept>  
  
 **Namespace:** std  
  
## See Also  
 [exception Class](../vs140/exception-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)