---
title: "Pointers to Members"
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
  - "declarations, pointers"
  - "class members, pointers to"
  - "pointers, to members"
  - "members, pointers to"
  - "pointers, declarations"
ms.assetid: f42ddb79-9721-4e39-95b1-c56b55591f68
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Pointers to Members
Declarations of pointers to members are special cases of pointer declarations.  They are declared using the following sequence:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
1.  The declaration specifier:  
  
    -   An optional storage class specifier.  
  
    -   Optional **const** and/or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> specifiers.  
  
    -   The type specifier: the name of a type.  This is the type of the member to be pointed to, not the class.  
  
2.  The declarator:  
  
    -   An optional Microsoft specific modifier. For more information, see [Microsoft-Specific Modifiers](../vs140/microsoft-specific-modifiers.md).  
  
    -   The qualified name of the class containing the members to be pointed to.  See [Names and Qualified Names](../vs140/names-and-qualified-names.md).  
  
    -   The :: operator.  
  
    -   The **\*** operator.  
  
    -   Optional **const** and/or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> specifiers.  
  
    -   The identifier naming the pointer to member.  
  
    -   An optional initializer:  
  
 The **=** operator.  
  
 The **&** operator.  
  
 The qualified name of the class.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator.  
  
 The name of a nonstatic member of the class of the appropriate type.  
  
 As always, multiple declarators (and any associated initializers) are allowed in a single declaration.  
  
 A pointer to a member of a class differs from a normal pointer because it has type information for the type of the member and for the class to which the member belongs. A normal pointer identifies (has the address of) only a single object in memory. A pointer to a member of a class identifies that member in any instance of the class. The following example declares a class, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and some pointers to member data.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the preceding example, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a pointer to any member of class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that has type **char\***. The type of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The next code fragment declares pointers to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member functions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The pointers <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> point to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class, respectively. The code copies information to the window caption directly using the pointer to member <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The difference between the **.\*** and **–>\*** operators (the pointer-to-member operators) is that the **.\*** operator selects members given an object or object reference, while the **–>\*** operator selects members through a pointer. (For more about these operators, see [Expressions with Pointer-to-Member Operators](../vs140/pointer-to-member-operators--.--and----.md).)  
  
 The result of the pointer-to-member operators is the type of the member — in this case, **char \***.  
  
 The following code fragment invokes the member functions <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> using pointers to members:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Restrictions on Pointers to Members  
 The address of a static member is not a pointer to a member. It is a regular pointer to the one instance of the static member. Because only one instance of a static member exists for all objects of a given class, the ordinary address-of **(&)** and dereference **(\*)** operators can be used.  
  
## Pointers to Members and Virtual Functions  
 Invoking a virtual function through a pointer-to-member function works as if the function had been called directly; the correct function is looked up in the v-table and invoked.  
  
 The key to virtual functions working, as always, is invoking them through a pointer to a base class. (For more information about virtual functions, see [Virtual Functions](../vs140/virtual-functions.md).)  
  
 The following code shows how to invoke a virtual function through a pointer-to-member function:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [C++ Abstract Declarators](assetId:///e7e18c18-0cad-4450-942b-d27e1d4dd088)