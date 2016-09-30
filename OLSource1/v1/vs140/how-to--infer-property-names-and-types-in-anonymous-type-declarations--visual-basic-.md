---
title: "How to: Infer Property Names and Types in Anonymous Type Declarations (Visual Basic)"
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
  - "inferring property names [Visual Basic]"
  - "anonymous types [Visual Basic], inferring property names and types"
  - "inferring property types [Visual Basic]"
ms.assetid: 7c748b22-913f-4d9d-b747-6b7bf296a0bc
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Infer Property Names and Types in Anonymous Type Declarations (Visual Basic)
Anonymous types provide no mechanism for directly specifying the data types of properties. Types of all properties are inferred. In the following example, the types of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are inferred directly from the values that are used to initialize them.  
  
 [!code[VbVbalrAnonymousTypes#1](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_1.vb)]  
  
 Anonymous types can also infer property names and types from other sources. The sections that follow provide a list of the circumstances where inference is possible, and examples of situations where it is not.  
  
## Successful Inference  
  
#### Anonymous types can infer property names and types from the following sources:  
  
-   From variable names. Anonymous type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will have two properties, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Their data types will be those of the original variables, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, respectively.  
  
     [!code[VbVbalrAnonymousTypes#11](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_2.vb)]  
  
-   From property or field names of other objects. For example, consider a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object of a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type that includes <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> properties. To create a new anonymous type instance, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> properties that are initialized with the values from the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object, you can write the following:  
  
     [!code[VbVbalrAnonymousTypes#34](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_3.vb)]  
  
     The previous declaration is equivalent to the longer line of code that defines anonymous type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrAnonymousTypes#35](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_4.vb)]  
  
-   From XML member names.  
  
     [!code[VbVbalrAnonymousTypes#12](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_5.vb)]  
  
     The resulting type for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> would have one property, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, of type \<xref:System.Collections.IEnumerable*>(Of XElement).  
  
-   From a function that has no parameters, such as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> in the following example.  
  
     <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
     The variable <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> in the following code is an anonymous type that has one property, a character named <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. This code will display a letter "E," the letter that is returned by function \<xref:System.Linq.Enumerable.First*>.  
  
     [!code[VbVbalrAnonymousTypes#13](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_6.vb)]  
  
## Inference Failures  
  
#### Name inference will fail in many circumstances, including the following:  
  
-   The inference derives from the invocation of a method, a constructor, or a parameterized property that requires arguments. The previous declaration of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> fails if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> has one or more arguments.  
  
     <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
     Assignment to a new property name solves the problem.  
  
     <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
-   The inference derives from a complex expression.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The error can be resolved by assigning the result of the expression to a property name.  
  
     [!code[VbVbalrAnonymousTypes#14](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_7.vb)]  
  
-   Inference for multiple properties produces two or more properties that have the same name. Referring back to declarations in earlier examples, you cannot list both <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> as properties of the same anonymous type. This is because the inferred identifier for each of these would be <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
     <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
     The problem can be solved by assigning the values to distinct property names.  
  
     [!code[VbVbalrAnonymousTypes#36](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_8.vb)]  
  
     Note that changes in case (changes between uppercase and lowercase letters) do not make two names distinct.  
  
     <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
-   The initial type and value of one property depends on another property that is not yet established. For example, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is not valid in an anonymous type declaration unless <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is already initialized.  
  
     <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
     In this example, you can fix the problem by reversing the order in which the properties are declared.  
  
     [!code[VbVbalrAnonymousTypes#15](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_9.vb)]  
  
-   A property name of the anonymous type is the same as the name of a member of \<xref:System.Object*>. For example, the following declaration fails because <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is a method of \<xref:System.Object*>.  
  
     <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
     You can fix the problem by changing the property name:  
  
     [!code[VbVbalrAnonymousTypes#16](../vs140/codesnippet/VisualBasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-_10.vb)]  
  
## See Also  
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [Key](../vs140/key--visual-basic-.md)