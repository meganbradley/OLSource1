---
title: "Inappropriate use of &lt;keyword&gt; keyword in a module"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc42028
  - BC42028
helpviewer_keywords: 
  - BC42028
ms.assetid: a9bc1e9d-ba2c-4a71-b147-0fb66f670316
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Inappropriate use of &lt;keyword&gt; keyword in a module
Modules do not have instances, support inheritance, or implement interfaces. Therefore, the following keywords do not apply to a module declaration:  
  
-   [MustInherit](../vs140/mustinherit--visual-basic-.md)  
  
-   [NotInheritable](../vs140/notinheritable--visual-basic-.md)  
  
-   [Overloads](../vs140/overloads--visual-basic-.md)  
  
-   [Private (Visual Basic)](../vs140/private--visual-basic-.md)  
  
-   [Protected (Visual Basic)](../vs140/protected--visual-basic-.md)  
  
-   [Shadows](../vs140/shadows--visual-basic-.md)  
  
-   [Shared (Visual Basic)](../vs140/shared--visual-basic-.md)  
  
-   [Static (Visual Basic)](../vs140/static--visual-basic-.md)  
  
 The only keywords supported in a [Module Statement](../vs140/module-statement.md) are [Public (Visual Basic)](../vs140/public--visual-basic-.md) and [Friend (Visual Basic)](../vs140/friend--visual-basic-.md).  
  
 In addition, you cannot use the [Implements (Visual Basic)](../vs140/implements-clause--visual-basic-.md) statement or the [Inherits Statement](../vs140/inherits-statement.md) in the statement block of the module.  
  
 By default, this message is a warning. For more information about how to hide warnings or treat warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42028  
  
### To correct this error  
  
-   If you intend this programming element to be a module, use only the `Public` or `Friend` keyword in its declaration. By default, a module uses to `Friend` if you do not specify its access level.  
  
-   If you intend to create instances of this programming element, declare it as a class. You can then use the keywords that apply to a class declaration.  
  
## See Also  
 [Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md)