---
title: "Shadows (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 16
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Shadows (Visual Basic)
Specifies that a declared programming element redeclares and hides an identically named element, or set of overloaded elements, in a base class.  
  
## Remarks  
 The main purpose of shadowing (which is also known as *hiding by name*) is to preserve the definition of your class members. The base class might undergo a change that creates an element with the same name as one you have already defined. If this happens, the `Shadows` modifier forces references through your class to be resolved to the member you defined, instead of to the new base class element.  
  
 Both shadowing and overriding redefine an inherited element, but there are significant differences between the two approaches. For more information, see [Shadowing in Visual Basic](../VS_visualbasic/shadowing-in-visual-basic.md).  
  
## Rules  
  
-   **Declaration Context.** You can use `Shadows` only at class level. This means the declaration context for a `Shadows` element must be a class, and cannot be a source file, namespace, interface, module, structure, or procedure.  
  
     You can declare only one shadowing element in a single declaration statement.  
  
-   **Combined Modifiers.** You cannot specify `Shadows` together with `Overloads`, `Overrides`, or `Static` in the same declaration.  
  
-   **Element Types.** You can shadow any kind of declared element with any other kind. If you shadow a property or procedure with another property or procedure, the parameters and the return type do not have to match those in the base class property or procedure.  
  
-   **Accessing.** The shadowed element in the base class is normally unavailable from within the derived class that shadows it. However, the following considerations apply.  
  
    -   If the shadowing element is not accessible from the code referring to it, the reference is resolved to the shadowed element. For example, if a `Private` element shadows a base class element, code that does not have permission to access the `Private` element accesses the base class element instead.  
  
    -   If you shadow an element, you can still access the shadowed element through an object declared with the type of the base class. You can also access it through `MyBase`.  
  
 The `Shadows` modifier can be used in these contexts:  
  
 [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)  
  
 [Const Statement](../VS_visualbasic/const-statement--visual-basic-.md)  
  
 [Declare Statement](../VS_visualbasic/declare-statement.md)  
  
 [Delegate Statement](../VS_visualbasic/delegate-statement.md)  
  
 [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)  
  
 [Enum Statement](../VS_visualbasic/enum-statement--visual-basic-.md)  
  
 [Event Statement](../VS_visualbasic/event-statement.md)  
  
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)  
  
 [Interface Statement](../VS_visualbasic/interface-statement--visual-basic-.md)  
  
 [Property Statement](../VS_visualbasic/property-statement.md)  
  
 [Structure Statement](../VS_visualbasic/structure-statement.md)  
  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
## See Also  
 [Shared](../VS_visualbasic/shared--visual-basic-.md)   
 [Static](../VS_visualbasic/static--visual-basic-.md)   
 [Private](../VS_visualbasic/private--visual-basic-.md)   
 [Me, My, MyBase, and MyClass](../VS_visualbasic/me--my--mybase--and-myclass-in-visual-basic.md)   
 [Inheritance Basics](../VS_visualbasic/inheritance-basics--visual-basic-.md)   
 [MustOverride](../VS_visualbasic/mustoverride--visual-basic-.md)   
 [NotOverridable](../VS_visualbasic/notoverridable--visual-basic-.md)   
 [Overloads](../VS_visualbasic/overloads--visual-basic-.md)   
 [Overridable](../VS_visualbasic/overridable--visual-basic-.md)   
 [Overrides](../VS_visualbasic/overrides--visual-basic-.md)   
 [Shadowing in Visual Basic](../VS_visualbasic/shadowing-in-visual-basic.md)