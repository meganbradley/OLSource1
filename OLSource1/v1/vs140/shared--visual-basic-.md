---
title: "Shared (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Shared"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Shared keyword"
  - "members, shared"
  - "shared members"
  - "nonshared"
  - "shared elements"
  - "elements, shared"
ms.assetid: 2bf7cf2c-b0dd-485e-8749-b5d674dab4cd
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Shared (Visual Basic)
Specifies that one or more declared programming elements are associated with a class or structure at large, and not with a specific instance of the class or structure.  
  
## Remarks  
  
## When to Use Shared  
 Sharing a member of a class or structure makes it available to every instance, rather than *nonshared*, where each instance keeps its own copy. This is useful, for example, if the value of a variable applies to the entire application. If you declare that variable to be <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then all instances access the same storage location, and if one instance changes the variable's value, all instances access the updated value.  
  
 Sharing does not alter the access level of a member. For example, a class member can be shared and private (accessible only from within the class), or nonshared and public. For more information, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
## Rules  
  
-   **Declaration Context.** You can use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> only at module level. This means the declaration context for a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element must be a class or structure, and cannot be a source file, namespace, or procedure.  
  
-   **Combined Modifiers.** You cannot specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> together with [Overrides](../vs140/overrides--visual-basic-.md), [Overridable](../vs140/overridable--visual-basic-.md), [NotOverridable](../vs140/notoverridable--visual-basic-.md), [MustOverride](../vs140/mustoverride--visual-basic-.md), or [Static (Visual Basic)](../vs140/static--visual-basic-.md) in the same declaration.  
  
-   **Accessing.** You access a shared element by qualifying it with its class or structure name, not with the variable name of a specific instance of its class or structure. You do not even have to create an instance of a class or structure to access its shared members.  
  
     The following example calls the shared procedure \<xref:System.Double.IsNaN*> exposed by the \<xref:System.Double*> structure.  
  
     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
-   **Implicit Sharing.** You cannot use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> modifier in a [Const Statement (Visual Basic)](../vs140/const-statement--visual-basic-.md), but constants are implicitly shared. Similarly, you cannot declare a member of a module or an interface to be <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, but they are implicitly shared.  
  
## Behavior  
  
-   **Storage.** A shared variable or event is stored in memory only once, no matter how many or few instances you create of its class or structure. Similarly, a shared procedure or property holds only one set of local variables.  
  
-   **Accessing through an Instance Variable.** It is possible to access a shared element by qualifying it with the name of a variable that contains a specific instance of its class or structure. Although this usually works as expected, the compiler generates a warning message and makes the access through the class or structure name instead of the variable.  
  
-   **Accessing through an Instance Expression.** If you access a shared element through an expression that returns an instance of its class or structure, the compiler makes the access through the class or structure name instead of evaluating the expression. This produces unexpected results if you intended the expression to perform other actions as well as returning the instance. The following example illustrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     In the preceding example, the compiler generates a warning message both times the code accesses the shared variable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> through an instance. In each case it makes the access directly through the class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and does not make use of any instance. In the case of the intended call to the procedure <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, this means it does not even generate a call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, so the additional action of displaying "Function returnClass() called" is not performed.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> modifier can be used in these contexts:  
  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)  
  
 [Event Statement](../vs140/event-statement.md)  
  
 [Function Statement](../vs140/function-statement--visual-basic-.md)  
  
 [Operator Statement](../vs140/operator-statement.md)  
  
 [Property Statement](../vs140/property-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 [Shadows](../vs140/shadows--visual-basic-.md)   
 [Static](../vs140/static--visual-basic-.md)   
 [Lifetime in Visual Basic](../vs140/lifetime-in-visual-basic.md)   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)