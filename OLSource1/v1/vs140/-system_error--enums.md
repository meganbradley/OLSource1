---
title: "&lt;system_error&gt; enums"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b21321b7-404a-40de-8777-a85b77c6fa58
caps.latest.revision: 14
---
# &lt;system_error&gt; enums
|||  
|-|-|  
|[errc Enumeration](#errc_enumeration)|[io_errc Enumeration](#io_errc_enumeration)|  
  
##  \<a name="errc_enumeration">\</a>  errc Enumeration  
 Provides symbolic names for all the error-code macros defined by Posix in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="io_errc_enumeration">\</a>  io_errc Enumeration  
 Provides symbolic names for the error conditions in \<iostream>. Can be used to create [error_condition](../vs140/error_condition-class.md) objects to be compared with the value that's returned by the [ios_base::failure](../vs140/ios_base-class.md#ios_base__failure)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Both [std::make_error_code()](../vs140/-system_error--functions.md#make_error_code) and [std::make_error_condition()](../vs140/-system_error--functions.md#make_error_condition) are overloaded for this enum.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can contain categories of error codes other than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [&lt;system_error&gt;](../vs140/-system_error-.md)