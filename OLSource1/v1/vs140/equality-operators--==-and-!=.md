---
title: "Equality Operators: == and !="
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "not_eq"
  - "!="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "equality operator"
  - "not equal to comparison operator"
  - "equality operator, syntax"
  - "== operator"
  - "not_eq operator"
  - "equal to operator"
ms.assetid: ba4e9659-2392-4fb4-be5a-910a2a6df45a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Equality Operators: == and !=
## Syntax  
  
```  
  
      expression == expression  
expression != expression  
```  
  
## Remarks  
 The binary equality operators compare their operands for strict equality or inequality.  
  
 The equality operators, equal to (`==`) and not equal to (`!=`), have lower precedence than the relational operators, but they behave similarly. The result type for these operators is `bool`.  
  
 The equal-to operator (`==`) returns **true** (1) if both operands have the same value; otherwise, it returns **false** (0). The not-equal-to operator (`!=`) returns **true** if the operands do not have the same value; otherwise, it returns **false**.  
  
## Operator Keyword for !=  
 The `not_eq` operator is the text equivalent of `!=`. There are two ways to access the `not_eq` operator in your programs: include the header file `iso646.h`, or compile with the [/Za](../vs140/-za---ze--disable-language-extensions-.md) (Disable language extensions) compiler option.  
  
## Example  
  
```  
// expre_Equality_Operators.cpp  
// compile with: /EHsc  
#include <iostream>  
  
using namespace std;  
  
int main() {  
   cout  << boolalpha  
         << "The true expression 3 != 2 yields: "  
         << (3 != 2) << endl  
         << "The false expression 20 == 10 yields: "  
         << (20 == 10) << endl;  
}  
```  
  
 Equality operators can compare pointers to members of the same type. In such a comparison, pointer-to-member conversions, as discussed in [Pointer-to-Member Conversions](../vs140/pointer-to-member-conversions.md) are performed. Pointers to members can also be compared to a constant expression that evaluates to 0.  
  
## See Also  
 [Expressions with Binary Operators](../vs140/expressions-with-binary-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [C Relational and Equality Operators](../vs140/c-relational-and-equality-operators.md)