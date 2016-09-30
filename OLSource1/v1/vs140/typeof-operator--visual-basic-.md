---
title: "TypeOf Operator (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "TypeOf"
  - "vb.TypeOf"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "types [Visual Basic], compatible"
  - "comparison operators"
  - "TypeOf...Is expression"
  - "data types [Visual Basic], compatible"
  - "TypeOf operator [Visual Basic]"
  - "compatible data types"
ms.assetid: 33f65296-659a-4b9a-9a29-c2a91cff68b2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TypeOf Operator (Visual Basic)
Compares an object reference variable to a data type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Returned. A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. Any expression that evaluates to a reference type.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Required. Any data type name.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator determines whether the run-time type of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is compatible with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The compatibility depends on the type category of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The following table shows how compatibility is determined.  
  
|Type category of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Compatibility criterion|  
|---------------------------------|-----------------------------|  
|Class|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or inherits from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|Structure|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|Interface|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> implements <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or inherits from a class that implements <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
  
 If the run-time type of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> satisfies the compatibility criterion, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Otherwise, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is null, then <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and ...<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is always used with the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> keyword to construct a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> expression, or with the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> keyword to construct a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> expression.  
  
## Example  
 The following example uses <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> expressions to test the type compatibility of two object reference variables with various data types.  
  
 [!code[VbVbalrOperators#39](../vs140/codesnippet/VisualBasic/typeof-operator--visual-basic-_1.vb)]  
  
 The variable <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> has a run-time type of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. It is compatible with <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> but not with <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. The variable <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> has a run-time type of \<xref:System.Windows.Forms.Form*>. It is compatible with \<xref:System.Windows.Forms.Form*> because that is its type, with \<xref:System.Windows.Forms.Control*> because \<xref:System.Windows.Forms.Form*> inherits from \<xref:System.Windows.Forms.Control*>, and with \<xref:System.ComponentModel.IComponent*> because \<xref:System.Windows.Forms.Form*> inherits from \<xref:System.ComponentModel.Component*>, which implements \<xref:System.ComponentModel.IComponent*>. However, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is not compatible with \<xref:System.Windows.Forms.Label*>.  
  
## See Also  
 [Is Operator](../vs140/is-operator--visual-basic-.md)   
 [IsNot Operator](../vs140/isnot-operator--visual-basic-.md)   
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Operators and Expressions](../vs140/operators-and-expressions-in-visual-basic.md)