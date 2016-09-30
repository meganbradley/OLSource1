---
title: "Union Declarations"
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
  - "unions"
  - "union keyword [C], declarations"
  - "variant records"
ms.assetid: 978c6165-e0ae-4196-afa7-6d94e24f62f7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Union Declarations
A "union declaration" specifies a set of variable values and, optionally, a tag naming the union. The variable values are called "members" of the union and can have different types. Unions are similar to "variant records" in other languages.  
  
## Syntax  
 *struct-or-union-specifier*:  
 *struct-or-union identifier* opt**{** *struct-declaration-list* **}**  
  
 *struct-or-union identifier*  
  
 *struct-or-union*:  
 **struct**  
  
 **union**  
  
 *struct-declaration-list*:  
 *struct-declaration*  
  
 *struct-declaration-list struct-declaration*  
  
 The union content is defined to be  
  
 *struct-declaration*:  
 *specifier-qualifier-list struct-declarator-list*  **;**  
  
 *specifier-qualifier-list*:  
 *type-specifier specifier-qualifier-list* opt  
  
 *type-qualifier specifier-qualifier-list* opt  
  
 *struct-declarator-list*:  
 *struct-declarator*  
  
 *struct-declarator-list*  **,**  *struct-declarator*  
  
 A variable with **union** type stores one of the values defined by that type. The same rules govern structure and union declarations. Unions can also have bit fields.  
  
 Members of unions cannot have an incomplete type, type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or function type. Therefore members cannot be an instance of the union but can be pointers to the union type being declared.  
  
 A union type declaration is a template only. Memory is not reserved until the variable is declared.  
  
> [!NOTE]
>  If a union of two types is declared and one value is stored, but the union is accessed with the other type, the results are unreliable. For example, a union of **float** and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is declared. A **float** value is stored, but the program later accesses the value as an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. In such a situation, the value would depend on the internal storage of **float** values. The integer value would not be reliable.  
  
## Examples  
 The following are examples of unions:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example defines a union variable with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type and declares a variable named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that has two members: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, a signed integer, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, an unsigned integer. This declaration allows the current value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to be stored as either a signed or an unsigned value. The tag associated with this union type is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> array contains 2,000 elements. Each element of the array is an individual union with two members: <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member is a structure with two bit-field members, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member is an <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. At any given time, each union element holds either the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> represented by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or the structure represented by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 **Microsoft Specific**  
  
 Nested unions can be declared anonymously when they are members of another structure or union. This is an example of a nameless union:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Unions are often nested within a structure that includes a field giving the type of data contained in the union at any particular time. This is an example of a declaration for such a union:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 See [Structure and Union Members](../vs140/structure-and-union-members.md) for information about referencing unions.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Declarators and Variable Declarations](../vs140/declarators-and-variable-declarations.md)