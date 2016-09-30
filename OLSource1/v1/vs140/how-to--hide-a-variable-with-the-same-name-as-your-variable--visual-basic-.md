---
title: "How to: Hide a Variable with the Same Name as Your Variable (Visual Basic)"
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
  - "declarations, elements"
  - "element names, qualification"
  - "references, declared elements"
  - "declaration statements, declared elements"
  - "declaring elements"
  - "referencing declared elements"
  - "declared elements, referencing"
  - "declared elements, about declared elements"
ms.assetid: e39c0752-f19f-4d2e-a453-00df1b5fc7ee
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Hide a Variable with the Same Name as Your Variable (Visual Basic)
You can hide a variable by *shadowing* it, that is, by redefining it with a variable of the same name. You can shadow the variable you want to hide in two ways:  
  
-   **Shadowing Through Scope.** You can shadow it through scope by redeclaring it inside a subregion of the region containing the variable you want to hide.  
  
-   **Shadowing Through Inheritance.** If the variable you want to hide is defined at class level, you can shadow it through inheritance by redeclaring it with the [Shadows](../vs140/shadows--visual-basic-.md) keyword in a derived class.  
  
## Two Ways to Hide a Variable  
  
#### To hide a variable by shadowing it through scope  
  
1.  Determine the region defining the variable you want to hide, and determine a subregion in which to redefine it with your variable.  
  
    |Variable's region|Allowable subregion for redefining it|  
    |-----------------------|-------------------------------------------|  
    |Module|A class within the module|  
    |Class|A subclass within the class\<br />\<br /> A procedure within the class|  
  
     You cannot redefine a procedure variable in a block within that procedure, for example in an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> construction or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop.  
  
2.  Create the subregion if it does not already exist.  
  
3.  Within the subregion, write a [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md) declaring the shadowing variable.  
  
     When code inside the subregion refers to the variable name, the compiler resolves the reference to the shadowing variable.  
  
     The following example illustrates shadowing through scope, as well as a reference that bypasses the shadowing.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The preceding example declares the variable <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> both at module level and at procedure level (in the procedure <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). The local variable <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> shadows the module-level variable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> within <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, so the local variable is set to 2. However, there is no local variable to shadow <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> procedure. Therefore, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> sets the value of the module-level variable to 1.  
  
     The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> call inside <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> bypasses the shadowing mechanism by qualifying <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> with the module name. Therefore, it displays the module-level variable instead of the local variable.  
  
#### To hide a variable by shadowing it through inheritance  
  
1.  Be sure the variable you want to hide is declared in a class, and at class level (outside any procedure). Otherwise you cannot shadow it through inheritance.  
  
2.  Define a class derived from the variable's class if one does not already exist.  
  
3.  Inside the derived class, write a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement declaring your variable. Include the [Shadows](../vs140/shadows--visual-basic-.md) keyword in the declaration.  
  
     When code in the derived class refers to the variable name, the compiler resolves the reference to your variable.  
  
     The following example illustrates shadowing through inheritance. It makes two references, one that accesses the shadowing variable and one that bypasses the shadowing.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The preceding example declares the variable <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in the base class and shadows it in the derived class. The procedure <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in the derived class displays the shadowing version of the string when the name <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is not qualified. It then displays the shadowed version when <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is qualified with the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>keyword.  
  
## Robust Programming  
 Shadowing introduces more than one version of a variable with the same name. When a code statement refers to the variable name, the version to which the compiler resolves the reference depends on factors such as the location of the code statement and the presence of a qualifying string. This can increase the risk of referring to an unintended version of a shadowed variable. You can lower that risk by fully qualifying all references to a shadowed variable.  
  
## See Also  
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)   
 [Differences Between Shadowing and Overriding](../vs140/differences-between-shadowing-and-overriding--visual-basic-.md)   
 [How to: Hide an Inherited Variable](../vs140/how-to--hide-an-inherited-variable--visual-basic-.md)   
 [How to: Access a Variable Hidden by a Derived Class](../vs140/how-to--access-a-variable-hidden-by-a-derived-class--visual-basic-.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../vs140/me--my--mybase--and-myclass-in-visual-basic.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)