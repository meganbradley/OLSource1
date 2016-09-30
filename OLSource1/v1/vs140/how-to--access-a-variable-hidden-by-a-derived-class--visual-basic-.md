---
title: "How to: Access a Variable Hidden by a Derived Class (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
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
  - "qualification, of element names"
  - "base classes, accessing elements"
  - "element names, qualification"
  - "references, declared elements"
  - "declared elements, referencing"
  - "variables [Visual Basic], accessing hidden"
ms.assetid: ae21a8ac-9cd4-4fba-a3ec-ecc4321ef93c
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access a Variable Hidden by a Derived Class (Visual Basic)
When code in a derived class accesses a variable, the compiler normally resolves the reference to the closest accessible version, that is, the accessible version the fewest derivational steps backward from the accessing class. If the variable is defined in the derived class, the code normally accesses that definition.  
  
 If the derived class variable shadows a variable in the base class, it hides the base class version. However, you can access the base class variable by qualifying it with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword.  
  
### To access a base class variable hidden by a derived class  
  
-   In an expression or assignment statement, precede the variable name with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword and a period (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
     The compiler resolves the reference to the base class version of the variable.  
  
     The following example illustrates shadowing through inheritance. It makes two references, one that accesses the shadowing variable and one that bypasses the shadowing.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The preceding example declares the variable <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the base class and shadows it in the derived class. The procedure <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the derived class displays the shadowing version of the string when the name <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not qualified. It then displays the shadowed version when <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is qualified with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  keyword.  
  
## Robust Programming  
 To lower the risk of referring to an unintended version of a shadowed variable, you can fully qualify all references to a shadowed variable. Shadowing introduces more than one version of a variable with the same name. When a code statement refers to the variable name, the version to which the compiler resolves the reference depends on factors such as the location of the code statement and the presence of a qualifying string. This can increase the risk of referring to the wrong version of the variable.  
  
## See Also  
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)   
 [Differences Between Shadowing and Overriding](../vs140/differences-between-shadowing-and-overriding--visual-basic-.md)   
 [How to: Hide a Variable with the Same Name as Your Variable](../vs140/how-to--hide-a-variable-with-the-same-name-as-your-variable--visual-basic-.md)   
 [How to: Hide an Inherited Variable](../vs140/how-to--hide-an-inherited-variable--visual-basic-.md)   
 [Shadows](../vs140/shadows--visual-basic-.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../vs140/me--my--mybase--and-myclass-in-visual-basic.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)