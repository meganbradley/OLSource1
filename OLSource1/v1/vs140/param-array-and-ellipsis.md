---
title: "Param Array and Ellipsis"
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
  - "function overloading, argument matching"
ms.assetid: 492e3f6c-1c4c-4e0c-a358-72f2d39c30be
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Param Array and Ellipsis
Precedence of the param array for resolving overloaded function calls has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 In both Managed Extensions and the new syntax, there is no explicit support for the param array that C# and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] support. Instead, one flags an ordinary array with an attribute, as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 While these both look the same, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute tags this for C# or other CLR languages as an array taking a variable number of elements with each invocation. The change in behavior in programs between Managed Extensions and the new syntax is in the resolution of an overloaded function set in which one instance declares an ellipsis and a second declares a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute, as in the following example provided by Artur Laksberg.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In Managed Extensions, the ellipsis was given precedence over the attribute which is reasonable since the attribute is not a formal aspect of the language. However, in the new syntax, the param array is now supported directly within the language, and it is given precedence over the ellipsis because it is more strongly typed. Thus, in Managed Extensions, the call  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 resolves to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> while in the new syntax, it resolves to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> instance. On the off chance that your program behavior depends on the invocation of the ellipsis instance over that of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you will need to modify either the signature or the call.  
  
## See Also  
 [General Language Changes](../vs140/general-language-changes--c---cli-.md)