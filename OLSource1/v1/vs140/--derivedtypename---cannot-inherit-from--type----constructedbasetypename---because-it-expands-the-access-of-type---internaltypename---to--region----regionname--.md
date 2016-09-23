---
title: "&#39;&lt;derivedtypename&gt;&#39; cannot inherit from &lt;type&gt; &#39;&lt;constructedbasetypename&gt;&#39; because it expands the access of type &#39;&lt;internaltypename&gt;&#39; to &lt;region&gt; &#39;&lt;regionname&gt;&#39;"
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
  - vbc30921
  - BC30921
helpviewer_keywords: 
  - BC30921
ms.assetid: b0dd971a-80e2-4d37-925b-854d17411546
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;&lt;derivedtypename&gt;&#39; cannot inherit from &lt;type&gt; &#39;&lt;constructedbasetypename&gt;&#39; because it expands the access of type &#39;&lt;internaltypename&gt;&#39; to &lt;region&gt; &#39;&lt;regionname&gt;&#39;
A derived class or interface attempts to expand the access level of an internal type by using it as a type argument to a base class or interface.  
  
 The following code can generate this error.  
  
```  
Public Class containingClass  
    Public Class baseClass(Of t)  
    End Class  
    Friend Class derivedClass  
        Inherits baseClass(Of internalStructure)  
    End Class  
    Private Structure internalStructure  
        Dim firstMember As Integer  
    End Structure  
End Class  
```  
  
 Code outside `containingClass` is not allowed to access `internalStructure`. However, `derivedClass` can be accessed from any code in the same assembly. Therefore, `derivedClass` cannot inherit `baseClass` if it uses `internalStructure` as a type argument, because that could expose `internalStructure` throughout the defining code region.  
  
 **Error ID:** BC30921  
  
### To correct this error  
  
-   Adjust the access levels of the classes or interfaces so that the derived type does not expand the access level of the internal type.  
  
     -or-  
  
-   If you cannot adjust the access levels, then do not use the internal type as a type argument when constructing the base class or interface.  
  
## See Also  
 [Inherits Statement](../vs140/inherits-statement.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)