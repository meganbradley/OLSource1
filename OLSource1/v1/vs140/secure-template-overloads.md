---
title: "Secure Template Overloads"
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
  - "_CRT_SECURE_CPP_OVERLOAD_STANDARD_NAMES"
  - "_CRT_SECURE_CPP_OVERLOAD_SECURE_NAMES"
  - "_CRT_SECURE_CPP_OVERLOAD_STANDARD_NAMES_COUNT"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CRT_SECURE_CPP_OVERLOAD_STANDARD_NAMES"
  - "_CRT_SECURE_CPP_OVERLOAD_SECURE_NAMES"
  - "_CRT_SECURE_CPP_OVERLOAD_STANDARD_NAMES_COUNT"
  - "secure template overloads"
ms.assetid: 562741d0-39c0-485e-8529-73d740f29f8f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Secure Template Overloads
Many CRT functions have been deprecated in favor of newer, security-enhanced versions (for example, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is the more secure replacement for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>). The CRT provides template overloads to help ease the transition to the more secure variants.  
  
 For example, this code generates a warning because <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is deprecated:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 You can ignore the warning. Define the symbol <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to suppress the warning, or update the code to use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 The template overloads provide additional choices. Defining <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to 1 enables template overloads of standard CRT functions that call the more secure variants automatically. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is 1, then no changes to the code are necessary. Behind the scenes, the call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> will be changed to a call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with the size argument supplied automatically.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> does not affect the functions that take a count, such as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. To enable template overloads for the count functions, define <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to 1. Before doing so, however, make sure that your code passes the count of characters, not the size of the buffer (a common mistake). Also, code that explicitly writes a null terminator at the end of the buffer after the function call is unnecessary if the secure variant is called. If you need truncation behavior, see [_TRUNCATE](../vs140/_truncate.md).  
  
> [!NOTE]
>  The macro <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> requires that <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is also defined as 1. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is defined as 1 and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is defined as 0, the application will not perform any template overloads.  
  
 Defining <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to 1 enables template overloads of the secure variants (names ending in "_s"). In this case, if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is 1, then one small change must be made to the original code:  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 Only the name of the function needs to be changed (by adding "_s"); the template overload will take care of providing the size argument.  
  
 By default, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are defined as 0 (disabled) and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is defined as 1 (enabled).  
  
 Note that these template overloads only work for static arrays. Dynamically allocated buffers require additional source code changes. Revisiting the above examples:  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 And this:  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
## See Also  
 [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md)   
 [CRT Library Features](../vs140/crt-library-features.md)