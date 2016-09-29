---
title: "&lt;type1&gt; &#39;&lt;membername&gt;&#39; shadows an overloadable member declared in the base &lt;type2&gt; &#39;&lt;classname&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc40003"
  - "vbc40003"
helpviewer_keywords: 
  - "BC40003"
ms.assetid: 1e0d2061-0ad9-4915-b946-d55cb5d5ee80
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;type1&gt; &#39;&lt;membername&gt;&#39; shadows an overloadable member declared in the base &lt;type2&gt; &#39;&lt;classname&gt;&#39;
<type1\> '<membername\>' shadows an overloadable member declared in the base <type2\> '<classname\>. If you want to overload the base method, this method must be declared 'Overloads'.  
  
 A derived class defines a `Function` or `Sub` procedure or a `Property` with the same name as a procedure or property defined in the base class. Because procedures and properties are overloadable members, the derived class can either overload or shadow the base class member. However, the derived class code does not specify either [Overloads](../vs140/overloads--visual-basic-.md) or [Shadows](../vs140/shadows--visual-basic-.md) in the declaration. In the absence of either keyword, the compiler assumes `Shadows`.  
  
 It is good programming practice to specify either `Overloads` or `Shadows`. This makes your code easier to read and understand.  
  
 By default, this message is a warning. For more information about hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40003  
  
### To correct this error  
  
-   If you want to overload the base class method or property, include the `Overloads` keyword in the declaration.  
  
-   If you want to shadow the base class method or property, include the `Shadows` keyword instead of `Overloads`.  
  
-   If you do not want to either overload or shadow the base class member, change the name of the derived class member.  
  
## See Also  
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Overloads](../vs140/overloads--visual-basic-.md)   
 [Shadows](../vs140/shadows--visual-basic-.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)   
 [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)