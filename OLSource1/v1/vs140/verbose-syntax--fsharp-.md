---
title: "Verbose Syntax (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "verbose syntax [F#]"
  - "lightweight syntax [F#]"
ms.assetid: 50c4da30-580d-4049-affa-bcc78d8c1029
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Verbose Syntax (F#)
There are two forms of syntax available for many constructs in the F# language: *verbose syntax* and *lightweight syntax*. The verbose syntax is not as commonly used, but has the advantage of being less sensitive to indentation. The lightweight syntax is shorter and uses indentation to signal the beginning and end of constructs, rather than additional keywords like <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and so on. The default syntax is the lightweight syntax. This topic describes the syntax for F# constructs when lightweight syntax is not enabled. Verbose syntax is always enabled, so even if you enable lightweight syntax, you can still use verbose syntax for some constructs. You can disable lightweight syntax by using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive.  
  
## Table of Constructs  
 The following table shows the lightweight and verbose syntax for F# language constructs in contexts where there is a difference between the two forms. In this table, angle brackets (<>) enclose user-supplied syntax elements. Refer to the documentation for each language construct for more detailed information about the syntax used within these constructs.  
  
|Language construct|Lightweight syntax|Verbose syntax|  
|------------------------|------------------------|--------------------|  
|compound expressions|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|nested <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> bindings|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|code block|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|record|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|class|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|structure|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|discriminated union|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|interface|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|object expression|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|interface implementation|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|type extension|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|module|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Compiler Directives](../vs140/compiler-directives--fsharp-.md)   
 [Code Formatting Guidelines](../vs140/code-formatting-guidelines--fsharp-.md)