---
title: "Using C++ Library Headers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "headers, naming in C++ include directive"
  - "standard header in C++"
  - "headers"
  - "INCLUDE directive"
  - "headers, Standard C++ Library"
  - "library headers"
  - "Standard C++ Library, headers"
ms.assetid: a36e889e-1af2-4cd9-a211-bfc7a3fd8e85
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using C++ Library Headers
You include the contents of a standard header by naming it in an include directive.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can include the standard headers in any order, a standard header more than once, or two or more standard headers that define the same macro or the same type. Do not include a standard header within a declaration. Do not define macros that have the same names as keywords before you include a standard header.  
  
 A C++ library header includes any other C++ library headers it needs to define needed types. (Always include explicitly any C++ library headers needed in a translation unit, however, lest you guess wrong about its actual dependencies.) A Standard C header never includes another standard header. A standard header declares or defines only the entities described for it in this document.  
  
 Every function in the library is declared in a standard header. Unlike in Standard C, the standard header never provides a masking macro with the same name as the function that masks the function declaration and achieves the same effect. For more information on masking macros, see [C++ Library Conventions](../vs140/c---library-conventions.md).  
  
 All names other than <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the C++ library headers are defined in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace, or in a namespace nested within the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> namespace. You refer to the name <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, for example, as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Note, however, that macro names are not subject to namespace qualification, so you always write <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> without a namespace qualifier.  
  
 In some translation environments, including a C++ library header may hoist external names declared in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> namespace into the global namespace as well, with individual <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> declarations for each of the names. Otherwise, the header does *not* introduce any library names into the current namespace.  
  
 The C++ Standard requires that the C Standard headers declare all external names in namespace <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, then hoist them into the global namespace with individual <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> declarations for each of the names. But in some translation environments the C Standard headers include no namespace declarations, declaring all names directly in the global namespace. Thus, the most portable way to deal with namespaces is to follow two rules:  
  
-   To assuredly declare in namespace <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> an external name that is traditionally declared in \<stdlib.h>, for example, include the header \<cstdlib>. Know that the name might also be declared in the global namespace.  
  
-   To assuredly declare in the global namespace an external name declared in \<stdlib.h>, include the header \<stdlib.h> directly. Know that the name might also be declared in namespace <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 Thus, if you want to call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to cause abnormal termination, you should include \<cstdlib>. If you want to call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, you should include \<stdlib.h>.  
  
 Alternatively, you can write the declaration:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 which brings all library names into the current namespace. If you write this declaration immediately after all include directives, you hoist the names into the global namespace. You can subsequently ignore namespace considerations in the remainder of the translation unit. You also avoid most differences across different translation environments.  
  
 Unless specifically indicated otherwise, you may not define names in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> namespace, or in a namespace nested within the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> namespace, within your program.  
  
## See Also  
 [STL Overview](../vs140/c---standard-library-overview.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)