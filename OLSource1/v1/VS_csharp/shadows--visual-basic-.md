---
title: "Shadows (Visual Basic)"
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
  - "vb.Shadows"
  - "shadows"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "shadowing"
  - "duplicate names"
  - "scope, shadowing"
  - "Shadows keyword"
  - "names, shadowing"
ms.assetid: 6bf687cd-0544-4797-b51b-911125ec57c6
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Shadows (Visual Basic)
Specifies that a declared programming element redeclares and hides an identically named element, or set of overloaded elements, in a base class.  
  
## Remarks  
 The main purpose of shadowing (which is also known as *hiding by name*) is to preserve the definition of your class members. The base class might undergo a change that creates an element with the same name as one you have already defined. If this happens, the `Shadows` modifier forces references through your class to be resolved to the member you defined, instead of to the new base class element.  
  
 Both shadowing and overriding redefine an inherited element, but there are significant differences between the two approaches. For more information, see [Shadowing in Visual Basic](../VS_csharp/shadowing-in-visual-basic.md).  
  
## Rules  
  
-   **Declaration Context.** You can use `Shadows` only at class level. This means the declaration context for a `Shadows` element must be a class, and cannot be a source file, namespace, interface, module, structure, or procedure.  
  
     You can declare only one shadowing element in a single declaration statement.  
  
-   **Combined Modifiers.** You cannot specify `Shadows` together with `Overloads`, `Overrides`, or `Static` in the same declaration.  
  
-   **Element Types.** You can shadow any kind of declared element with any other kind. If you shadow a property or procedure with another property or procedure, the parameters and the return type do not have to match those in the base class property or procedure.  
  
-   **Accessing.** The shadowed element in the base class is normally unavailable from within the derived class that shadows it. However, the following considerations apply.  
  
    -   If the shadowing element is not accessible from the code referring to it, the reference is resolved to the shadowed element. For example, if a `Private` element shadows a base class element, code that does not have permission to access the `Private` element accesses the base class element instead.  
  
    -   If you shadow an element, you can still access the shadowed element through an object declared with the type of the base class. You can also access it through `MyBase`.  
  
 The `Shadows` modifier can be used in these contexts:  
  
 [Class Statement](../VS_csharp/class-statement--visual-basic-.md)  
  
 [Const Statement](../VS_csharp/const-statement--visual-basic-.md)  
  
 [Declare Statement](../VS_csharp/declare-statement.md)  
  
 [Delegate Statement](../VS_csharp/delegate-statement.md)  
  
 [Dim Statement](../VS_csharp/dim-statement--visual-basic-.md)  
  
 [Enum Statement](../VS_csharp/enum-statement--visual-basic-.md)  
  
 [Event Statement](../VS_csharp/event-statement.md)  
  
 [Function Statement](../VS_csharp/function-statement--visual-basic-.md)  
  
 [Interface Statement](../VS_csharp/interface-statement--visual-basic-.md)  
  
 [Property Statement](../VS_csharp/property-statement.md)  
  
 [Structure Statement](../VS_csharp/structure-statement.md)  
  
 [Sub Statement](../VS_csharp/sub-statement--visual-basic-.md)  
  
## See Also  
 [Shared](../VS_csharp/shared--visual-basic-.md)   
 [Static](../VS_csharp/static--visual-basic-.md)   
 [Private](../VS_csharp/private--visual-basic-.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../VS_csharp/me--my--mybase--and-myclass-in-visual-basic.md)   
 [Inheritance Basics](../VS_csharp/inheritance-basics--visual-basic-.md)   
 [MustOverride](../VS_csharp/mustoverride--visual-basic-.md)   
 [NotOverridable](../VS_csharp/notoverridable--visual-basic-.md)   
 [Overloads](../VS_csharp/overloads--visual-basic-.md)   
 [Overridable](../VS_csharp/overridable--visual-basic-.md)   
 [Overrides](../VS_csharp/overrides--visual-basic-.md)   
 [Shadowing in Visual Basic](../VS_csharp/shadowing-in-visual-basic.md)