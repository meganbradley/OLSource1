---
title: "Overloaded Operators"
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
  - "operator overloading, in a CLR class"
  - "operators [C++], overloading"
ms.assetid: 30391426-afe7-4497-bf22-e4816c1e48c8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overloaded Operators
Operator overloading has changed significantly from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 In the declaration of a reference type, for example, rather than using the native <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> syntax, you explicitly write out the underlying internal name of the operator – in this case, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. In addition, the invocation of an operator has to be explicitly invoked through that name, thus precluding the two primary benefits of operator overloading: (a) the intuitive syntax, and (b) the ability to intermix new types with existing types. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the new syntax, the usual expectations of a native C++ programmer are restored, both in the declaration and use of the static operators. Here is the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class translated into the new syntax:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Member Declarations within a Class or Interface](../vs140/member-declarations-within-a-class-or-interface--c---cli-.md)