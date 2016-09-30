---
title: "Shadowing in Visual Basic"
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
  - "inheritance, shadowing"
  - "overriding, and shadowing"
  - "shadowing"
  - "duplicate names"
  - "shadowing, by inheritance"
  - "declared elements, referencing"
  - "shadowing, by scope"
  - "declared elements, hiding"
  - "naming conflicts, shadowing"
  - "declared elements, shadowing"
  - "shadowing, and overriding"
  - "scope, shadowing"
  - "Shadows keyword, about"
  - "objects [Visual Basic], names"
  - "names, shadowing"
ms.assetid: 54bb4c25-12c4-4181-b4a0-93546053964e
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Shadowing in Visual Basic
When two programming elements share the same name, one of them can hide, or *shadow*, the other one. In such a situation, the shadowed element is not available for reference; instead, when your code uses the element name, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler resolves it to the shadowing element.  
  
## Purpose  
 The main purpose of shadowing is to protect the definition of your class members. The base class might undergo a change that creates an element with the same name as one you have already defined. If this happens, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier forces references through your class to be resolved to the member you defined, instead of to the new base class element.  
  
## Types of Shadowing  
 An element can shadow another element in two different ways. The shadowing element can be declared inside a subregion of the region containing the shadowed element, in which case the shadowing is accomplished *through scope*. Or a deriving class can redefine a member of a base class, in which case the shadowing is done *through inheritance*.  
  
### Shadowing Through Scope  
 It is possible for programming elements in the same module, class, or structure to have the same name but different scope. When two elements are declared in this manner and the code refers to the name they share, the element with the narrower scope shadows the other element (block scope is the narrowest).  
  
 For example, a module can define a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and a procedure within the module can declare a local variable also named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. References to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> from within the procedure access the local variable, while references to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from outside the procedure access the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variable. In this case, the procedure variable <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> shadows the module variable <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The following illustration shows two variables, both named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The local variable <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> shadows the member variable <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> when accessed from within its own procedure <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. However, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword bypasses the shadowing and accesses the member variable.  
  
 ![Graphic diagram of shadowing through scope](../vs140/media/shadowscope.gif "ShadowScope")  
Shadowing through scope  
  
 For an example of shadowing through scope, see [How to: Hide a Variable with the Same Name as Your Variable](../vs140/how-to--hide-a-variable-with-the-same-name-as-your-variable--visual-basic-.md).  
  
### Shadowing Through Inheritance  
 If a derived class redefines a programming element inherited from a base class, the redefining element shadows the original element. You can shadow any type of declared element, or set of overloaded elements, with any other type. For example, an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> variable can shadow a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> procedure. If you shadow a procedure with another procedure, you can use a different parameter list and a different return type.  
  
 The following illustration shows a base class <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and a derived class <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> that inherits from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The base class defines a procedure named <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and the derived class shadows it with another procedure of the same name. The first <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement accesses the shadowing <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> in the derived class. However, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> keyword bypasses the shadowing and accesses the shadowed procedure in the base class.  
  
 ![Graphic diagram of shadowing through inheritance](../vs140/media/shadowinherit.gif "ShadowInherit")  
Shadowing through inheritance  
  
 For an example of shadowing through inheritance, see [How to: Hide a Variable with the Same Name as Your Variable](../vs140/how-to--hide-a-variable-with-the-same-name-as-your-variable--visual-basic-.md) and [How to: Hide an Inherited Variable](../vs140/how-to--hide-an-inherited-variable--visual-basic-.md).  
  
#### Shadowing and Access Level  
 The shadowing element is not always accessible from the code using the derived class. For example, it might be declared <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. In such a case, shadowing is defeated and the compiler resolves any reference to the same element it would have if there had been no shadowing. This element is the accessible element the fewest derivational steps backward from the shadowing class. If the shadowed element is a procedure, the resolution is to the closest accessible version with the same name, parameter list, and return type.  
  
 The following example shows an inheritance hierarchy of three classes. Each class defines a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> procedure <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and each derived class shadows the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> procedure in its base class.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding example, the derived class <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> shadows <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> with a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> procedure. When module <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, the calling code is outside <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and therefore cannot access the private <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> procedure. Shadowing is defeated, and the compiler resolves the reference to the base class <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> procedure.  
  
 However, the further derived class <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> declares <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, so the code in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> can access it.  
  
## Shadowing and Overriding  
 Do not confuse shadowing with overriding. Both are used when a derived class inherits from a base class, and both redefine one declared element with another. But there are significant differences between the two. For a comparison, see [Differences Between Shadowing and Overriding](../vs140/differences-between-shadowing-and-overriding--visual-basic-.md).  
  
## Shadowing and Overloading  
 If you shadow the same base class element with more than one element in your derived class, the shadowing elements become overloaded versions of that element. For more information, see [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md).  
  
## Accessing a Shadowed Element  
 When you access an element from a derived class, you normally do so through the current instance of that derived class, by qualifying the element name with the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> keyword. If your derived class shadows the element in the base class, you can access the base class element by qualifying it with the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> keyword.  
  
 For an example of accessing a shadowed element, see [How to: Access a Variable Hidden by a Derived Class](../vs140/how-to--access-a-variable-hidden-by-a-derived-class--visual-basic-.md).  
  
### Declaration of the Object Variable  
 How you create the object variable can also affect whether the derived class accesses a shadowing element or the shadowed element. The following example creates two objects from a derived class, but one object is declared as the base class and the other as the derived class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the preceding example, the variable <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is declared as the base class. Assigning a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object to it constitutes a widening conversion and is therefore valid. However, the base class cannot access the shadowing version of the variable <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> in the derived class, so the compiler resolves <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to the original base class value.  
  
## See Also  
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)   
 [Scope in Visual Basic](../vs140/scope-in-visual-basic.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Shadows](../vs140/shadows--visual-basic-.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../vs140/me--my--mybase--and-myclass-in-visual-basic.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)