---
title: "Uniform Initialization and Delegating Constructors"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: aa4daa64-eaec-4a3c-ade4-d9325e31e9d4
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Uniform Initialization and Delegating Constructors
In modern C++, you can use *brace initialization* for any type, without the equals sign. Also, you can use delegating constructors to simplify your code when you have multiple constructors that perform similar work.  
  
## Brace Initialization  
 You can use brace initialization for any class, struct, or union. If a type has a default constructor, either implicitly or explicitly declared, you can use default brace initialization (with empty braces). For example, the following class may be initialized by using both default and non-default brace initialization:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If a class has non-default constructors, the order in which class members appear in the brace initializer is the order in which the corresponding parameters appear in the constructor, not the order in which the members are declared (as with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the previous example). Otherwise, if the type has no declared constructor, the order in which the members appear in the brace initializer is the same as the order in which they are declared; in this case, you can initialize as many of the public members as you wish, but you cannot skip any member. The following example shows the order that's used in brace initialization when there is no declared constructor:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If the default constructor is explicitly declared but marked as deleted, default brace initialization cannot be used:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can use brace initialization anywhere you would typically do initialization—for example, as a function parameter or a return value, or with the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## initializer_list Constructors  
 The [initializer_list](../vs140/initializer_list-class.md) represents a list of objects of a specified type that can be used in a constructor, and in other contexts. You can construct an initializer_list by using brace initialization:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
> [!IMPORTANT]
>  To use this class, you must include the [\<initializer_list>](../vs140/-initializer_list-.md) header.  
  
 An <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can be copied. In this case, the members of the new list are references to the members of the original list:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The standard library container classes, and also <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, have <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> constructors. The following examples show how to do brace initialization with these constructors:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Delegating Constructors  
 Many classes have multiple constructors that do similar things—for example, validate parameters:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 You could reduce the repetitive code by adding a function that does all of the validation, but the code for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> would be easier to understand and maintain if one constructor could delegate some of the work to another one. To add delegating constructors, use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> syntax:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 As you step through the previous example, notice that the constructor <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> first calls the constructor <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, which in turn calls <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Each of the constructors performs only the work that is not performed by the other constructors.  
  
 The first constructor that's called initializes the object so that all of its members are initialized at that point. You can’t do member initialization in a constructor that delegates to another constructor, as shown here:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The next example shows the use of non-static data-member initializers. Notice that if a constructor also initializes a given data member, the member initializer is overridden:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The constructor delegation syntax doesn't prevent the accidental creation of constructor recursion—Constructor1 calls Constructor2 which calls Constructor1—and no errors are thrown until there is a stack overflow. It's your responsibility to avoid cycles.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>