---
title: "Anonymous Type Definition (Visual Basic)"
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
  - "anonymous types [Visual Basic], type definition"
ms.assetid: 7a8a0ddc-55ba-4d67-869e-87a84d938bac
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Anonymous Type Definition (Visual Basic)
In response to the declaration of an instance of an anonymous type, the compiler creates a new class definition that contains the specified properties for the type.  
  
## Compiler-Generated Code  
 For the following definition of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the compiler creates a new class definition that contains properties <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrAnonymousTypes#25](../vs140/codesnippet/VisualBasic/anonymous-type-definition--visual-basic-_1.vb)]  
  
 The class definition contains property definitions similar to the following. Notice that there is no <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method for the key properties. The values of key properties are read-only.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In addition, anonymous type definitions contain a default constructor. Constructors that require parameters are not permitted.  
  
 If an anonymous type declaration contains at least one key property, the type definition overrides three members inherited from \<xref:System.Object*>: \<xref:System.Object.Equals*>, \<xref:System.Object.GetHashCode*>, and \<xref:System.Object.ToString*>. If no key properties are declared, only \<xref:System.Object.ToString*> is overridden. The overrides provide the following functionality:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if two anonymous type instances are the same instance, or if they meet the following conditions:  
  
    -   They have the same number of properties.  
  
    -   The properties are declared in the same order, with the same names and the same inferred types. Name comparisons are not case-sensitive.  
  
    -   At least one of the properties is a key property, and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword is applied to the same properties.  
  
    -   Comparison of each corresponding pair of key properties returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
     For example, in the following examples, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> only for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The comment before each line specifies the reason why the new instance does not match <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrAnonymousTypes#24](../vs140/codesnippet/VisualBasic/anonymous-type-definition--visual-basic-_2.vb)]  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> provides an appropriately unique GetHashCode algorithm. The algorithm uses only the key properties to compute the hash code.  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> returns a string of concatenated property values, as shown in the following example. Both key and non-key properties are included.  
  
     [!code[VbVbalrAnonymousTypes#29](../vs140/codesnippet/VisualBasic/anonymous-type-definition--visual-basic-_3.vb)]  
  
 Explicitly named properties of an anonymous type cannot conflict with these generated methods. That is, you cannot use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to name a property.  
  
 Anonymous type definitions that include at least one key property also implement the <xref:System.IEquatable<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>T` is the type of the anonymous type.  
  
> [!NOTE]
>  Anonymous type declarations create the same anonymous type only if they occur in the same assembly, their properties have the same names and the same inferred types, the properties are declared in the same order, and the same properties are marked as key properties.  
  
## See Also  
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [How to: Infer Property Names and Types in Anonymous Type Declarations](../vs140/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md)