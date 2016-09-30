---
title: "__if_exists Statement"
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
  - "__if_exists_cpp"
  - "__if_exists"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "identifiers, testing for existence"
  - "symbols, testing for existence"
  - "__if_exists keyword [C++]"
ms.assetid: d3eb34b6-f3a9-4063-a286-b62a28c0c7fa
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __if_exists Statement
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement tests whether the specified identifier exists. If the identifier exists, the specified statement block is executed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The identifier whose existence you want to test.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|One or more statements to execute if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> exists.|  
  
## Remarks  
  
> [!CAUTION]
>  To achieve the most reliable results, use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement under the following constraints.  
  
-   Apply the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement to only simple types, not templates.  
  
-   Apply the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement to identifiers both inside or outside a class. Do not apply the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement to local variables.  
  
-   Use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement only in the body of a function. Outside of the body of a function, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement can test only fully defined types.  
  
-   When you test for overloaded functions, you cannot test for a specific form of the overload.  
  
 The complement to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement is the [__if_not_exists](../vs140/__if_not_exists-statement.md) statement.  
  
## Example  
 Notice that this example uses templates, which is not advised.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Selection Statements](../vs140/selection-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [The __if_not_exists Statement](../vs140/__if_not_exists-statement.md)