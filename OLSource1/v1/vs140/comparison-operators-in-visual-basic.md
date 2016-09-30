---
title: "Comparison Operators in Visual Basic"
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
  - "comparison operators, comparing strings"
  - "comparison operators, comparing objects"
  - "strings [Visual Basic], comparing"
  - "comparison operators"
  - "string comparison [Visual Basic], operators"
  - "objects [Visual Basic], comparing"
  - "numbers, comparing"
  - "Visual Basic code, operators"
  - "string comparison [Visual Basic]"
  - "numeric values, comparing"
  - "comparison operators, comparing numeric values"
  - "operators [Visual Basic], comparison"
ms.assetid: 0b570339-5407-474f-8421-e183a8b303ee
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Comparison Operators in Visual Basic
Comparison operators compare two expressions and return a `Boolean` value that represents the relationship of their values. There are operators for comparing numeric values, operators for comparing strings, and operators for comparing objects. All three types of operators are discussed herein.  
  
## Comparing Numeric Values  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compares numeric values using six numeric comparison operators. Each operator takes as operands two expressions that evaluate to numeric values. The following table lists the operators and shows examples of each.  
  
|Operator|Condition tested|Examples|  
|--------------|----------------------|--------------|  
|`=` (Equality)|Is the value of the first expression equal to the value of the second?|`23`   `=`   `33    ' False`<br /><br /> `23`   `=`   `23    ' True`<br /><br /> `23`   `=`   `12    ' False`|  
|`<>` (Inequality)|Is the value of the first expression unequal to the value of the second?|`23`   `<>`   `33    ' True`<br /><br /> `23`   `<>`   `23    ' False`<br /><br /> `23`   `<>`   `12    ' True`|  
|`<` (Less than)|Is the value of the first expression less than the value of the second?|`23`   `<`   `33    ' True`<br /><br /> `23`   `<`   `23    ' False`<br /><br /> `23`   `<`   `12    ' False`|  
|`>` (Greater than)|Is the value of the first expression greater than the value of the second?|`23`   `>`   `33    ' False`<br /><br /> `23`   `>`   `23    ' False`<br /><br /> `23`   `>`   `12    ' True`|  
|`<=` (Less than or equal to)|Is the value of the first expression less than or equal to the value of the second?|`23`   `<=`   `33    ' True`<br /><br /> `23`   `<=`   `23    ' True`<br /><br /> `23`   `<=`   `12    ' False`|  
|`>=` (Greater than or equal to)|Is the value of the first expression greater than or equal to the value of the second?|`23`   `>=`   `33    ' False`<br /><br /> `23`   `>=`   `23    ' True`<br /><br /> `23`   `>=`   `12    ' True`|  
  
## Comparing Strings  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compares strings using the [Like Operator](../vs140/like-operator--visual-basic-.md) as well as the numeric comparison operators. The `Like` operator allows you to specify a pattern. The string is then compared against the pattern, and if it matches, the result is `True`. Otherwise, the result is `False`. The numeric operators allow you to compare `String` values based on their sort order, as the following example shows.  
  
 `"73" < "9"`  
  
 `' The result of the preceding comparison is True.`  
  
 The result in the preceding example is `True` because the first character in the first string sorts before the first character in the second string. If the first characters were equal, the comparison would continue to the next character in both strings, and so on. You can also test equality of strings using the equality operator, as the following example shows.  
  
 `"734" = "734"`  
  
 `' The result of the preceding comparison is True.`  
  
 If one string is a prefix of another, such as "aa" and "aaa", the longer string is considered to be greater than the shorter string. The following example illustrates this.  
  
 `"aaa" > "aa"`  
  
 `' The result of the preceding comparison is True.`  
  
 The sort order is based on either a binary comparison or a textual comparison depending on the setting of `Option Compare`. For more information see [Option Compare Statement](../vs140/option-compare-statement.md).  
  
## Comparing Objects  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compares two object reference variables with the [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md) and the [IsNot Operator](../vs140/isnot-operator--visual-basic-.md). You can use either of these operators to determine if two reference variables refer to the same object instance. The following example illustrates this.  
  
 [!code[VbVbalrOperators#65](../vs140/codesnippet/VisualBasic/comparison-operators-in-visual-basic_1.vb)]  
  
 In the preceding example, `x Is y` evaluates to `True`, because both variables refer to the same instance. Contrast this result with the following example.  
  
 [!code[VbVbalrOperators#66](../vs140/codesnippet/VisualBasic/comparison-operators-in-visual-basic_2.vb)]  
  
 In the preceding example, `x Is y` evaluates to `False`, because although the variables refer to objects of the same type, they refer to different instances of that type.  
  
 When you want to test for two objects not pointing to the same instance, the `IsNot` operator lets you avoid a grammatically clumsy combination of `Not` and `Is`. The following example illustrates this.  
  
 [!code[VbVbalrOperators#67](../vs140/codesnippet/VisualBasic/comparison-operators-in-visual-basic_3.vb)]  
  
 In the preceding example, `If a IsNot b` is equivalent to `If Not a Is b`.  
  
### Comparing Object Type  
 You can test whether an object is of a particular type with the `TypeOf`...`Is` expression. The syntax is as follows:  
  
 `TypeOf <objectexpression> Is <typename>`  
  
 When `typename` specifies an interface type, then the `TypeOf`...`Is` expression returns `True` if the object implements the interface type. When `typename` is a class type, then the expression returns `True` if the object is an instance of the specified class or of a class that derives from the specified class. The following example illustrates this.  
  
 [!code[VbVbalrOperators#68](../vs140/codesnippet/VisualBasic/comparison-operators-in-visual-basic_4.vb)]  
  
 In the preceding example, the `TypeOf x Is Control` expression evaluates to `True` because the type of `x` is `Button`, which inherits from `Control`.  
  
 For more information, see [TypeOf Operator (Visual Basic)](../vs140/typeof-operator--visual-basic-.md).  
  
## See Also  
 [Value Comparisons](../vs140/value-comparisons--visual-basic-.md)   
 [Comparison Operators](../vs140/comparison-operators--visual-basic-.md)   
 [Operators](../vs140/operators--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)   
 [Concatenation Operators in Visual Basic](../vs140/concatenation-operators-in-visual-basic.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)