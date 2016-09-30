---
title: "Nested Class Declarations"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "classes [C++], declaring"
  - "declarations, class"
  - "nested classes"
  - "nested classes, declaring"
  - "declaring classes"
  - "declarations, nested classes"
ms.assetid: c02e471d-b7f9-41b8-8ef6-2323f006dbd5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nested Class Declarations
A class can be declared within the scope of another class. Such a class is called a "nested class." Nested classes are considered to be within the scope of the enclosing class and are available for use within that scope. To refer to a nested class from a scope other than its immediate enclosing scope, you must use a fully qualified name.  
  
 The following example shows how to declare nested classes:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are declared within <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. These class names are not visible outside the scope of class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. However, an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> does not contain any objects of types <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 Nested classes can directly use names, type names, names of static members, and enumerators only from the enclosing class. To use names of other class members, you must use pointers, references, or object names.  
  
 In the preceding <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> example, the enumeration <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can be accessed directly by member functions in the nested classes, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, as shown in function <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Nested classes declare only types within class scope. They do not cause contained objects of the nested class to be created. The preceding example declares two nested classes but does not declare any objects of these class types.  
  
 An exception to the scope visibility of a nested class declaration is when a type name is declared together with a forward declaration.  In this case, the class name declared by the forward declaration is visible outside the enclosing class, with its scope defined to be the smallest enclosing non-class scope.  For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Access privilege in nested classes  
 Nesting a class within another class does not give special access privileges to member functions of the nested class. Similarly, member functions of the enclosing class have no special access to members of the nested class.  
  
## Member functions in nested classes  
 Member functions declared in nested classes can be defined in file scope. The preceding example could have been written:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the preceding example, the *qualified-type-name* syntax is used to declare the function name. The declaration:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 means "the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function that is a member of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class that is in the scope of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class." Because this declaration uses the *qualified-type-name* syntax, constructs of the following form are possible:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The preceding declaration is equivalent to the previous one, but it uses a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> name in place of the class names.  
  
## Friend functions in nested classes  
 Friend functions declared in a nested class are considered to be in the scope of the nested class, not the enclosing class. Therefore, the friend functions gain no special access privileges to members or member functions of the enclosing class. If you want to use a name that is declared in a nested class in a friend function and the friend function is defined in file scope, use qualified type names as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The following code shows the function <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> declared as a friend function. In the function, which is defined in file scope, a message is copied from a static array into a class member. Note that a better implementation of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is to declare it as:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 With the preceding interface, several classes can use the services of this function by passing a memory location where they want the error message copied.  
  
## See Also  
 [Classes and Structs](../vs140/classes-and-structs--c---.md)