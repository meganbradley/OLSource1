---
title: "Inheritance Basics (Visual Basic)"
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
  - "derived classes, inheritance"
  - "MyClass keyword, using"
  - "MyBase keyword, using"
  - "Inherits statement, inheritance"
  - "overriding, Overridable keyword"
  - "MustInherit keyword, using"
  - "Overrides keyword, using"
  - "inheritance"
  - "MustInherit classes"
  - "MustOverride keyword, using"
  - "classes [Visual Basic], derived"
  - "NotInheritable keyword, using"
  - "base classes, extending properties and methods"
  - "NotOverridable keyword, using"
  - "base classes, inheritance"
  - "abstract classes, inheritance"
  - "overriding, Overrides keyword"
ms.assetid: dfc8deba-f5b3-4d1d-a937-7cb826446fc5
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Inheritance Basics (Visual Basic)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement is used to declare a new class, called a *derived class*, based on an existing class, known as a *base class*. Derived classes inherit, and can extend, the properties, methods, events, fields, and constants defined in the base class. The following section describes some of the rules for inheritance, and the modifiers you can use to change the way classes inherit or are inherited:  
  
-   By default, all classes are inheritable unless marked with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword. Classes can inherit from other classes in your project or from classes in other assemblies that your project references.  
  
-   Unlike languages that allow multiple inheritance, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] allows only single inheritance in classes; that is, derived classes can have only one base class. Although multiple inheritance is not allowed in classes, classes can implement multiple interfaces, which can effectively accomplish the same ends.  
  
-   To prevent exposing restricted items in a base class, the access type of a derived class must be equal to or more restrictive than its base class. For example, a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class cannot inherit a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class, and a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class cannot inherit a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class.  
  
## Inheritance Modifiers  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] introduces the following class-level statements and modifiers to support inheritance:  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement — Specifies the base class.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> modifier — Prevents programmers from using the class as a base class.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> modifier — Specifies that the class is intended for use as a base class only. Instances of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> classes cannot be created directly; they can only be created as base class instances of a derived class. (Other programming languages, such as C++ and C#, use the term *abstract class* to describe such a class.)  
  
## Overriding Properties and Methods in Derived Classes  
 By default, a derived class inherits properties and methods from its base class. If an inherited property or method has to behave differently in the derived class it can be *overridden*. That is, you can define a new implementation of the method in the derived class. The following modifiers are used to control how properties and methods are overridden:  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> — Allows a property or method in a class to be overridden in a derived class.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> — Overrides an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property or method defined in the base class.  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> — Prevents a property or method from being overridden in an inheriting class. By default, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> methods are <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> — Requires that a derived class override the property or method. When the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keyword is used, the method definition consists of just the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement. No other statements are allowed, and specifically there is no <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> methods must be declared in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> classes.  
  
 Suppose you want to define classes to handle payroll. You could define a generic <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> class that contains a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method that calculates payroll for a typical week. You could then use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> as a base class for a more specialized <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class, which could be used when distributing employee bonuses.  
  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class can inherit, and override, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method defined in the base <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> class.  
  
 The following example defines a base class, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and a derived class, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, which overrides an inherited method, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. A procedure, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, creates and then passes a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object and a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object to a function, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, that executes the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method of both objects.  
  
 [!code[VbVbalrOOP#28](../vs140/codesnippet/VisualBasic/inheritance-basics--visual-basic-_1.vb)]  
  
## The MyBase Keyword  
 The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> keyword behaves like an object variable that refers to the base class of the current instance of a class. <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is frequently used to access base class members that are overridden or shadowed in a derived class. In particular, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is used to explicitly call a base class constructor from a derived class constructor.  
  
 For example, suppose you are designing a derived class that overrides a method inherited from the base class. The overridden method can call the method in the base class and modify the return value as shown in the following code fragment:  
  
 [!code[VbVbalrOOP#109](../vs140/codesnippet/VisualBasic/inheritance-basics--visual-basic-_2.vb)]  
  
 The following list describes restrictions on using <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>:  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> refers to the immediate base class and its inherited members. It cannot be used to access <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> members in the class.  
  
-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is a keyword, not a real object. <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> cannot be assigned to a variable, passed to procedures, or used in an <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> comparison.  
  
-   The method that <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> qualifies does not have to be defined in the immediate base class; it may instead be defined in an indirectly inherited base class. In order for a reference qualified by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to compile correctly, some base class must contain a method matching the name and types of parameters that appear in the call.  
  
-   You cannot use <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to call <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> base class methods.  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> cannot be used to qualify itself. Therefore, the following code is not valid:  
  
     <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> cannot be used in modules.  
  
-   <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> cannot be used to access base class members that are marked as <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> if the base class is in a different assembly.  
  
 For more information and another example, see [How to: Access a Variable Hidden by a Derived Class](../vs140/how-to--access-a-variable-hidden-by-a-derived-class--visual-basic-.md).  
  
## The MyClass Keyword  
 The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> keyword behaves like an object variable that refers to the current instance of a class as originally implemented. <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> resembles <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, but every method and property call on <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> is treated as if the method or property were [NotOverridable](../vs140/notoverridable--visual-basic-.md). Therefore, the method or property is not affected by overriding in a derived class.  
  
-   <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is a keyword, not a real object. <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> cannot be assigned to a variable, passed to procedures, or used in an <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> comparison.  
  
-   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> refers to the containing class and its inherited members.  
  
-   <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> can be used as a qualifier for <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> members.  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> cannot be used inside a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> method, but can be used inside an instance method to access a shared member of a class.  
  
-   <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> cannot be used in standard modules.  
  
-   <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> can be used to qualify a method that is defined in a base class and that has no implementation of the method provided in that class. Such a reference has the same meaning as <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>*Method*.  
  
 The following example compares <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Even though <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> overrides <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> keyword in <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> nullifies the effects of overriding, and the compiler resolves the call to the base class version of <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
## See Also  
 [Inherits Statement](../vs140/inherits-statement.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../vs140/me--my--mybase--and-myclass-in-visual-basic.md)