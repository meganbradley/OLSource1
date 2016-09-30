---
title: "C Enumeration Declarations"
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
  - "C"
helpviewer_keywords: 
  - "declarations, enumerations"
  - "define directive (#define), alternative to"
  - "enumerators, declaring"
  - "#define directive, alternative to"
  - "named constants, enumeration declarations"
  - "declaring enumerations"
ms.assetid: bd18f673-4dda-4bc1-92fd-d1ce10074910
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Enumeration Declarations
An enumeration consists of a set of named integer constants. An enumeration type declaration gives the name of the (optional) enumeration tag and defines the set of named integer identifiers (called the "enumeration set," "enumerator constants," "enumerators," or "members"). A variable with enumeration type stores one of the values of the enumeration set defined by that type.  
  
 Variables of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type can be used in indexing expressions and as operands of all arithmetic and relational operators. Enumerations provide an alternative to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> preprocessor directive with the advantages that the values can be generated for you and obey normal scoping rules.  
  
 In ANSI C, the expressions that define the value of an enumerator constant always have <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> type; thus, the storage associated with an enumeration variable is the storage required for a single <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value. An enumeration constant or a value of enumerated type can be used anywhere the C language permits an integer expression.  
  
## Syntax  
 *enum-specifier*:  
 **enum**  *identifier* opt**{** *enumerator-list* **}**  
  
 **enum**  *identifier*  
  
 The optional *identifier* names the enumeration type defined by *enumerator-list*. This identifier is often called the "tag" of the enumeration specified by the list. A type specifier of the form  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 declares *identifier* to be the tag of the enumeration specified by the *enumerator-list* nonterminal. The *enumerator-list* defines the "enumerator content." The *enumerator-list* is described in detail below.  
  
 If the declaration of a tag is visible, subsequent declarations that use the tag but omit *enumerator-list* specify the previously declared enumerated type. The tag must refer to a defined enumeration type, and that enumeration type must be in current scope. Since the enumeration type is defined elsewhere, the *enumerator-list* does not appear in this declaration. Declarations of types derived from enumerations and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> declarations for enumeration types can use the enumeration tag before the enumeration type is defined.  
  
## Syntax  
 *enumerator-list*:  
 *enumerator*  
  
 *enumerator-list* **,**  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>:  
 *enumeration-constant*  
  
 *enumeration-constant*  **=**  *constant-expression*  
  
 *enumeration-constant*:  
 *identifier*  
  
 Each *enumeration-constant* in an *enumeration-list* names a value of the enumeration set. By default, the first *enumeration-constant* is associated with the value 0. The next *enumeration-constant* in the list is associated with the value of ( *constant-expression* + 1 ), unless you explicitly associate it with another value. The name of an *enumeration-constant* is equivalent to its value.  
  
 You can use *enumeration-constant = constant-expression* to override the default sequence of values. Thus, if *enumeration-constant = constant-expression* appears in the *enumerator-list*, the *enumeration-constant* is associated with the value given by *constant-expression*. The *constant-expression* must have <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> type and can be negative.  
  
 The following rules apply to the members of an enumeration set:  
  
-   An enumeration set can contain duplicate constant values. For example, you could associate the value 0 with two different identifiers, perhaps named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, in the same set.  
  
-   The identifiers in the enumeration list must be distinct from other identifiers in the same scope with the same visibility, including ordinary variable names and identifiers in other enumeration lists.  
  
-   Enumeration tags obey the normal scoping rules. They must be distinct from other enumeration, structure, and union tags with the same visibility.  
  
## Examples  
 These examples illustrate enumeration declarations:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value 0 is associated with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> by default. The identifier <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is explicitly set to 0. The remaining identifiers are given the values 1 through 5 by default.  
  
 In this example, a value from the set <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is assigned to the variable <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Note that the name of the enumeration constant is used to assign the value. Since the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> enumeration type was previously declared, only the enumeration tag <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is necessary.  
  
 To explicitly assign an integer value to a variable of an enumerated data type, use a type cast:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This cast is recommended in C but is not required.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This declaration can also be specified as  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 or as  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An example that uses these variables might look like this:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Unnamed enumerator data types can also be declared. The name of the data type is omitted, but variables can be declared. The variable <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a variable of the type defined:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [Enumerations](../vs140/enumerations--c---.md)