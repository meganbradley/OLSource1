---
title: "basic_filebuf::underflow"
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
  - "underflow"
  - "std::basic_filebuf::underflow"
  - "basic_filebuf::underflow"
  - "fstream/std::basic_filebuf::underflow"
  - "std.basic_filebuf.underflow"
  - "basic_filebuf.underflow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "underflow method"
ms.assetid: d790e110-a616-41d6-bb1d-b04360e0bd60
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf::underflow
Extracts the current element from the input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the function cannot succeed, it returns **traits_type::**[eof](../vs140/char_traits--eof.md). Otherwise, it returns **ch**, converted as described in the Remarks section.  
  
## Remarks  
 The protected virtual member function endeavors to extract the current element **ch** from the input stream, and return the element as **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)(**ch**). It can do so in various ways:  
  
-   If a read position is available, it takes **ch** as the element stored in the read position and advances the next pointer for the input buffer.  
  
-   It can read one or more elements of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>*,* as if by successive calls of the form <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>(**fp**), and convert them to an element **ch** of type **Elem** by using the file conversion facet fac to call **fac.in** as needed. If any read or conversion fails, the function does not succeed.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)