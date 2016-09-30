---
title: "main: Program Startup"
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
  - "vc.main.startup"
  - "_tmain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "program startup [C++]"
  - "entry points, program"
  - "wmain function"
  - "_tmain function"
  - "startup code, main function"
  - "main function, program startup"
ms.assetid: f9581cd6-93f7-4bcd-99ec-d07c3c107dd4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# main: Program Startup
A special function named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the starting point of execution for all C and [!INCLUDE[TLA#tla_cpp](../vs140/includes/tlasharptla_cpp_md.md)] programs. If you are writing code that adheres to the [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)] programming model, you can use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which is the wide-character version of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function is not predefined by the compiler. It must be supplied in the program text.  
  
 The declaration syntax for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 or, optionally,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Microsoft Specific  
 The declaration syntax for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 or, optionally,  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can also use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which is defined in TCHAR.h. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> resolves to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> unless _UNICODE is defined. In that case, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> resolves to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 Alternatively, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions can be declared as returning <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (no return value). If you declare <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> as returning <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, you cannot return an exit code to the parent process or operating system by using a [return](../vs140/return-statement-in-program-termination--c---.md) statement. To return an exit code when <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is declared as <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, you must use the [exit](../vs140/exit-function.md) function.  
  
## END Microsoft Specific  
 The types for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> are defined by the language. The names <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> are traditional, but are not required by the compiler. For more information and an example, see [Argument Definitions](../vs140/argument-definitions.md).  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Using wmain Instead of main](../vs140/using-wmain-instead-of-main.md)   
 [main Function Restrictions](../vs140/main-function-restrictions.md)