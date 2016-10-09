---
title: "Access Levels in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "members, accessing in Visual Basic"
  - "Friend access modifier"
  - "access levels, declared elements"
  - "access levels"
  - "access modifiers"
  - "Public access modifier"
  - "Protected access modifier"
  - "Protected Friend access modifier"
  - "Private access modifier"
  - "declared elements, access level"
ms.assetid: 6e06c1ab-fd78-47f0-83a8-1152780b5e1a
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
# Access Levels in Visual Basic
The *access level* of a declared element is the extent of the ability to access it, that is, what code has permission to read it or write to it. This is determined not only by how you declare the element itself, but also by the access level of the element's container. Code that cannot access a containing element cannot access any of its contained elements, even those declared as `Public`. For example, a `Public` variable in a `Private` structure can be accessed from inside the class that contains the structure, but not from outside that class.  
  
## Public  
 The [Public](../VS_visualbasic/public--visual-basic-.md) keyword in the declaration statement specifies that the elements can be accessed from code anywhere in the same project, from other projects that reference the project, and from any assembly built from the project. The following code shows a sample `Public` declaration.  
  
```  
Public Class classForEverybody  
```  
  
 You can use `Public` only at module, interface, or namespace level. This means you can declare a public element at the level of a source file or namespace, or inside an interface, module, class, or structure, but not in a procedure.  
  
## Protected  
 The [Protected](../VS_visualbasic/protected--visual-basic-.md) keyword in the declaration statement specifies that the elements can be accessed only from within the same class, or from a class derived from this class. The following code shows a sample `Protected` declaration.  
  
```  
Protected Class classForMyHeirs  
```  
  
 You can use `Protected` only at class level, and only when you declare a member of a class. This means you can declare a protected element in a class, but not at the level of a source file or namespace, or inside an interface, module, structure, or procedure.  
  
## Friend  
 The [Friend](../VS_visualbasic/friend--visual-basic-.md) keyword in the declaration statement specifies that the elements can be accessed from within the same assembly, but not from outside the assembly. The following code shows a sample `Friend` declaration.  
  
```  
Friend stringForThisProject As String  
```  
  
 You can use `Friend` only at module, interface, or namespace level. This means you can declare a friend element at the level of a source file or namespace, or inside an interface, module, class, or structure, but not in a procedure.  
  
## Protected Friend  
 The `Protected` and `Friend` keywords together in the declaration statement specify that the elements can be accessed either from derived classes or from within the same assembly, or both. The following code shows a sample `Protected``Friend` declaration.  
  
```  
Protected Friend stringForProjectAndHeirs As String  
```  
  
 You can use `Protected``Friend` only at class level, and only when you declare a member of a class. This means you can declare a protected friend element in a class, but not at the level of a source file or namespace, or inside an interface, module, structure, or procedure.  
  
## Private  
 The [Private](../VS_visualbasic/private--visual-basic-.md) keyword in the declaration statement specifies that the elements can be accessed only from within the same module, class, or structure. The following code shows a sample `Private` declaration.  
  
```  
Private numberForMeOnly As Integer  
```  
  
 You can use `Private` only at module level. This means you can declare a private element inside a module, class, or structure, but not at the level of a source file or namespace, inside an interface, or in a procedure.  
  
 At the module level, the `Dim` statement without any access level keywords is equivalent to a `Private` declaration. However, you might want to use the `Private` keyword to make your code easier to read and interpret.  
  
## Access Modifiers  
 The keywords that specify access level are called *access modifiers*. The following table compares the access modifiers.  
  
|Access modifier|Access level granted|Elements you can declare with this access level|Declaration context within which you can use this modifier|  
|---------------------|--------------------------|-----------------------------------------------------|----------------------------------------------------------------|  
|`Public`|Unrestricted:<br /><br /> Any code that can see a public element can access it|Interfaces<br /><br /> Modules<br /><br /> Classes<br /><br /> Structures<br /><br /> Structure members<br /><br /> Procedures<br /><br /> Properties<br /><br /> Member variables<br /><br /> Constants<br /><br /> Enumerations<br /><br /> Events<br /><br /> External declarations<br /><br /> Delegates|Source file<br /><br /> Namespace<br /><br /> Interface<br /><br /> Module<br /><br /> Class<br /><br /> Structure|  
|`Protected`|Derivational:<br /><br /> Code in the class that declares a protected element, or a class derived from it, can access the element|Interfaces<br /><br /> Classes<br /><br /> Structures<br /><br /> Procedures<br /><br /> Properties<br /><br /> Member variables<br /><br /> Constants<br /><br /> Enumerations<br /><br /> Events<br /><br /> External declarations<br /><br /> Delegates|Class|  
|`Friend`|Assembly:<br /><br /> Code in the assembly that declares a friend element can access it|Interfaces<br /><br /> Modules<br /><br /> Classes<br /><br /> Structures<br /><br /> Structure members<br /><br /> Procedures<br /><br /> Properties<br /><br /> Member variables<br /><br /> Constants<br /><br /> Enumerations<br /><br /> Events<br /><br /> External declarations<br /><br /> Delegates|Source file<br /><br /> Namespace<br /><br /> Interface<br /><br /> Module<br /><br /> Class<br /><br /> Structure|  
|`Protected` `Friend`|Union of `Protected` and `Friend`:<br /><br /> Code in the same class or the same assembly as a protected friend element, or within any class derived from the element's class, can access it|Interfaces<br /><br /> Classes<br /><br /> Structures<br /><br /> Procedures<br /><br /> Properties<br /><br /> Member variables<br /><br /> Constants<br /><br /> Enumerations<br /><br /> Events<br /><br /> External declarations<br /><br /> Delegates|Class|  
|`Private`|Declaration context:<br /><br /> Code in the type that declares a private element, including code within contained types, can access the element|Interfaces<br /><br /> Classes<br /><br /> Structures<br /><br /> Structure members<br /><br /> Procedures<br /><br /> Properties<br /><br /> Member variables<br /><br /> Constants<br /><br /> Enumerations<br /><br /> Events<br /><br /> External declarations<br /><br /> Delegates|Module<br /><br /> Class<br /><br /> Structure|  
  
## See Also  
 [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)   
 [Static](../VS_visualbasic/static--visual-basic-.md)   
 [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md)   
 [References to Declared Elements](../VS_visualbasic/references-to-declared-elements--visual-basic-.md)   
 [Declared Element Characteristics](../VS_visualbasic/declared-element-characteristics--visual-basic-.md)   
 [Lifetime in Visual Basic](../VS_visualbasic/lifetime-in-visual-basic.md)   
 [Scope in Visual Basic](../VS_visualbasic/scope-in-visual-basic.md)   
 [How to: Control the Availability of a Variable](../VS_visualbasic/how-to--control-the-availability-of-a-variable--visual-basic-.md)   
 [Variables](../VS_visualbasic/variables-in-visual-basic.md)   
 [Variable Declaration](../VS_visualbasic/variable-declaration-in-visual-basic.md)