---
title: "MSBuild Conditions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, conditions"
  - "conditions [MSBuild]"
ms.assetid: 9d7aa308-b667-48ed-b4c9-a61e49eb0a85
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Conditions
[!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] supports a specific set of conditions that can be applied wherever a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> attribute is allowed. The following table explains those conditions.  
  
|Condition|Description|  
|---------------|-----------------|  
|'<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>' == '<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>'|Evaluates to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.\<br />\<br /> For example:\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>\<br />\<br /> Single quotes are not required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values.|  
|'<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>' != '<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>'|Evaluates to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not equal to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.\<br />\<br /> For example:\<br />\<br /> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>\<br />\<br /> Single quotes are not required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values.|  
|\<, >, \<=, >=|Evaluates the numeric values of the operands. Returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if the relational evaluation is true. Operands must evaluate to a decimal or hexadecimal number. Hexadecimal numbers must begin with "0x". **Note:**  In XML, the characters <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must be escaped. The symbol <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is represented as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The symbol <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is represented as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|Exists('<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>')|Evaluates to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if a file or folder with the name <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> exists.\<br />\<br /> For example:\<br />\<br /> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>\<br />\<br /> Single quotes are not required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values.|  
|HasTrailingSlash('<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>')|Evaluates to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if the specified string contains either a trailing backward slash (\\) or forward slash (/) character.\<br />\<br /> For example:\<br />\<br /> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>\<br />\<br /> Single quotes are not required for simple alphanumeric strings or boolean values. However, single quotes are required for empty values.|  
|!|Evaluates to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if the operand evaluates to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
|And|Evaluates to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if both operands evaluate to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
|Or|Evaluates to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if at least one of the operands evaluates to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|  
|()|Grouping mechanism that evaluates to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> if expressions contained inside evaluate to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
|$if$ ( %expression% ), $else$, $endif$|Checks whether the specified <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> matches the string value of the passed custom template parameter. If the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> condition evaluates to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, then its statements are run; otherwise, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> condition is checked. If the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> condition is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, then its statements are run; otherwise, the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> condition ends expression evaluation.\<br />\<br /> For examples of usage, see [Visual Studio Project/Item Template Parameter Logic](http://stackoverflow.com/questions/6709057/visual-studio-project-item-template-parameter-logic).|  
  
## See Also  
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild Conditional Constructs](../vs140/msbuild-conditional-constructs.md)   
 [Walkthrough: Creating an MSBuild Project File from Scratch](../vs140/walkthrough--creating-an-msbuild-project-file-from-scratch.md)