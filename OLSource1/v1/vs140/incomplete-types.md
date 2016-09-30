---
title: "Incomplete Types"
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
  - "void keyword [C], incomplete"
  - "types [C], incomplete"
  - "incomplete types"
  - "unions, incomplete"
  - "arrays [C], incomplete types"
  - "void keyword [C]"
  - "structures, incomplete"
ms.assetid: 01bc0cf6-9fa7-458c-9371-ecbe54ea6aee
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Incomplete Types
An incomplete type is a type that describes an identifier but lacks information needed to determine the size of the identifier. An "incomplete type" can be:  
  
-   A structure type whose members you have not yet specified.  
  
-   A union type whose members you have not yet specified.  
  
-   An array type whose dimension you have not yet specified.  
  
 The void type is an incomplete type that cannot be completed. To complete an incomplete type, specify the missing information. The following examples show how to create and complete the incomplete types.  
  
-   To create an incomplete structure type, declare a structure type without specifying its members. In this example, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer points to an incomplete structure type called <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   To complete an incomplete structure type, declare the same structure type later in the same scope with its members specified, as in  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   To create an incomplete array type, declare an array type without specifying its repetition count. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   To complete an incomplete array type, declare the same name later in the same scope with its repetition count specified, as in  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Declarations and Types](../vs140/declarations-and-types.md)