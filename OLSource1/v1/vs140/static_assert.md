---
title: "static_assert"
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
  - "C2338"
  - "static_assert_cpp"
  - "static_assert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C++ keywords, static_assert"
  - "C2338"
  - "assertions [C++], static_assert"
  - "static_assert"
ms.assetid: 28dd3668-e78c-4de8-ba68-552084743426
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# static_assert
Tests a software assertion at compile time. If the specified constant expression is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the compiler displays the specified message and the compilation fails with error C2338; otherwise, the declaration has no effect.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|An integral constant expression that can be converted to a Boolean.\<br />\<br /> If the evaluated expression is zero (false), the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is displayed and the compilation fails with an error. If the expression is nonzero (true), the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> declaration has no effect.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|An message that is displayed if the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter is zero. The message is a string of characters in the [base character set](../vs140/ascii-character-set.md) of the compiler; that is, not [multibyte or wide characters](../vs140/multibyte-and-wide-characters.md).|  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter of a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> declaration represents a *software assertion*. A software assertion specifies a condition that you expect to be true at a particular point in your program. If the condition is true, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> declaration has no effect. If the condition is false, the assertion fails, the compiler displays the message in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter, and the compilation fails with an error.  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> declaration tests a software assertion at compile time. In contrast, the [assert (CRT)](../vs140/assert-macro--_assert--_wassert.md) macro tests a software assertion at run time and incurs a run time cost in space or time. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> declaration is especially useful for debugging templates because template arguments can be included in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter.  
  
 The compiler examines the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> declaration for syntax errors when the declaration is encountered. The compiler evaluates the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter immediately if it does not depend on a template parameter. Otherwise, the compiler evaluates the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter when the template is instantiated. Consequently, the compiler might issue a diagnostic message once when the declaration is encountered, and again when the template is instantiated.  
  
 You can use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keyword at namespace, class, or block scope. (The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> keyword is technically a declaration, even though it does not introduce new name into your program, because it can be used at namespace scope.)  
  
## Description  
 In the following example, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> declaration has namespace scope. Because the compiler knows the size of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the expression is evaluated immediately.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Description  
 In the following example, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> declaration has class scope. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> verifies that a template parameter is a *plain old data* (POD) type. The compiler examines the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> declaration when it is declared, but does not evaluate the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameter until the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class template is instantiated in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Description  
 In the following example, the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> declaration has block scope. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> verifies that the size of the VMPage structure is equal to the virtual memory pagesize of the system.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Error Handling (C++)](../vs140/assertion-and-user-supplied-messages--c---.md)   
 [The #error Directive](../vs140/sharperror-directive--c-c---.md)   
 [assert (CRT)](../vs140/assert-macro--_assert--_wassert.md)   
 [Templates](../vs140/templates--c---.md)   
 [The ASCII Character Set](../vs140/ascii-character-set.md)   
 [Declarations](../vs140/declarations.md)