---
title: "move"
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
  - "std::move"
  - "_Char_traits::move"
  - "std._Char_traits.move"
  - "_Char_traits.move"
  - "std.basic_ios.move"
  - "char_traits::move"
  - "utility/std::move"
  - "xutility/std::move"
  - "iosfwd/std::char_traits::move"
  - "std::_Char_traits::move"
  - "move"
  - "std.char_traits.move"
  - "std::char_traits::move"
  - "basic_ios.move"
  - "iosfwd/std::_Char_traits::move"
  - "basic_ios::move"
  - "std::basic_ios::move"
  - "ios/std::basic_ios::move"
  - "std.move"
  - "char_traits.move"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move method"
  - "move"
ms.assetid: e6d5bd4f-b2fb-4826-9541-018fac5996dd
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# move
Unconditionally casts its argument to an rvalue reference, and thereby signals that it can be moved if its type is move-enabled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A type deduced from the type of the argument passed in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, together with the reference collapsing rules.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The argument to cast. Although the type of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> appears to be specified as an rvalue reference, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> also accepts lvalue arguments because lvalue references can bind to rvalue references.|  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as an rvalue reference, whether or not its type is a reference type.  
  
## Remarks  
 The template argument <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not intended to be specified explicitly, but to be deduced from the type of the value passed in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The type of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is further adjusted according to the reference collapsing rules.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> does not move its argument. Instead, by unconditionally casting its argument—which might be an lvalue—to an rvalue reference, it enables the compiler to subsequently move, rather than copy, the value passed in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if its type is move-enabled. If its type is not move-enabled, it is copied instead.  
  
 If the value passed in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is an lvalue—that is, it has a name or its address can be taken—it's invalidated when the move occurs. Do not refer to the value passed in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> by its name or address after it's been moved.  
  
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std  
  
## See Also  
 [\<utility>](../vs140/-utility-.md)   
 [Lvalues and Rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)