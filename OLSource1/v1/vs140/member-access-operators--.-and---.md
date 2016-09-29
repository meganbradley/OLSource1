---
title: "Member Access Operators: . and -&gt;"
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
  - "."
  - "->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "member access, expressions"
  - "operators [C++], member access"
  - "dot operator (.)"
  - "-> operator"
  - "member access, operators"
  - "postfix operators"
  - ". operator"
  - "member access"
ms.assetid: f8fc3df9-d728-40c5-b384-276927f5f1b3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Member Access Operators: . and -&gt;
## Syntax  
  
```  
  
      postfix-expression   
      . name  
postfix-expression –> name  
```  
  
## Remarks  
 The member access operators **.** and **->** are used to refer to members of structures, unions, and classes. Member access expressions have the value and type of the selected member.  
  
 There are two forms of member access expressions:  
  
1.  In the first form, *postfix-expression* represents a value of struct, class, or union type, and *name* names a member of the specified structure, union, or class. The value of the operation is that of *name* and is an l-value if *postfix-expression* is an l-value.  
  
2.  In the second form, *postfix-expression* represents a pointer to a structure, union, or class, and *name* names a member of the specified structure, union, or class. The value is that of *name* and is an l-value. The **–>** operator dereferences the pointer. Therefore, the expressions *e***–>**`member` and **(\****e***)**.`member` (where *e* represents a pointer) yield identical results (except when the operators **–>** or **\*** are overloaded).  
  
## Example  
 The following example demonstrates both forms of the member access operator.  
  
```  
// expre_Selection_Operator.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
struct Date {  
   Date(int i, int j, int k) : day(i), month(j), year(k){}  
   int month;  
   int day;  
   int year;  
};  
  
int main() {  
   Date mydate(1,1,1900);  
   mydate.month = 2;     
   cout  << mydate.month << "/" << mydate.day  
         << "/" << mydate.year << endl;  
  
   Date *mydate2 = new Date(1,1,2000);  
   mydate2->month = 2;  
   cout  << mydate2->month << "/" << mydate2->day  
         << "/" << mydate2->year << endl;  
   delete mydate2;  
}  
```  
  
 **2/1/1900**  
**2/1/2000**   
## See Also  
 [Postfix Expressions](../vs140/postfix-expressions.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [Classes and Structs](../vs140/classes-and-structs--c---.md)   
 [Structure and Union Members](../vs140/structure-and-union-members.md)