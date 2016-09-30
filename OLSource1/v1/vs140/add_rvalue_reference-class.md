---
title: "add_rvalue_reference Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "type_traits/std::add_rvalue_reference"
  - "std::add_rvalue_reference"
  - "add_rvalue_reference"
  - "std.add_rvalue_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "add_rvalue_reference Class"
ms.assetid: 76b0cb7c-1031-45d0-b409-f03ab0297580
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# add_rvalue_reference Class
Creates an rvalue reference type of the template parameter, if it is an object or function type. Otherwise, because of the semantics of reference collapsing, the type is the same as the template parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 T  
 The type to modify.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class has a member named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which is an alias for the type of an rvalue reference to the template parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The semantics of reference collapsing imply that, for non-object and non-function types <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For example, when <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is an lvalue reference type, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the lvalue reference type, not an rvalue reference .  
  
 For convenience, \<type_traits> defines a helper template, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, that aliases the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Example  
 This code example uses static_assert to show how rvalue reference types are created by using <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and how the result of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> on an lvalue reference type is not an rvalue reference, but collapses to the lvalue reference type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: \<type_traits> Namespace: std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [add_lvalue_reference](../vs140/add_lvalue_reference-class.md)   
 [is_rvalue_reference](../vs140/is_rvalue_reference-class.md)