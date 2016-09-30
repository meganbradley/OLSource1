---
title: "switch Statement (C++)"
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
  - "default"
  - "default_cpp"
  - "switch"
  - "switch_cpp"
  - "case"
  - "case_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "switch keyword [C++]"
  - "case keyword [C++], in switch statements"
  - "default keyword [C++]"
ms.assetid: 6c3f3ed3-5593-463c-8f4b-b33742b455c6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# switch Statement (C++)
Allows selection among multiple sections of code, depending on the value of an integral expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The *expression* must be of an integral type or of a class type for which there is an unambiguous conversion to integral type. Integral promotion is performed as described in [Integral Promotions](../vs140/integral-promotions.md).  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement body consists of a series of **case** labels and an optional **default** label. No two constant expressions in **case** statements can evaluate to the same value. The **default** label can appear only once. The labeled statements are not syntactic requirements, but the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement is meaningless without them.   The default statement need not come at the end; it can appear anywhere in the body of the switch statement. A case or default label can only appear inside a switch statement.  
  
 The *constant-expression* in each **case** label is converted to the type of *expression* and compared with *expression* for equality. Control passes to the statement whose **case** *constant-expression* matches the value of *expression*. The resulting behavior is shown in the following table.  
  
### Switch Statement Behavior  
  
|Condition|Action|  
|---------------|------------|  
|Converted value matches that of the promoted controlling expression.|Control is transferred to the statement following that label.|  
|None of the constants match the constants in the **case** labels; a **default** label is present.|Control is transferred to the **default** label.|  
|None of the constants match the constants in the **case** labels; **default** label is not present.|Control is transferred to the statement after the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.|  
  
 If a matching expression is found, control is not impeded by subsequent **case** or **default** labels. The [break](../vs140/break-statement--c---.md) statement is used to stop execution and transfer control to the statement after the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement. Without a **break** statement, every statement from the matched **case** label to the end of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, including the **default**, is executed. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the above example, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is incremented if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is an uppercase <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement after <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> terminates execution of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement body and control passes to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> loop. Without the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> would also be incremented. A similar purpose is served by the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a lowercase <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is incremented and the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement terminates the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement body. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is not an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement is executed.  
  
 An inner block of a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> statement can contain definitions with initializations as long as they are reachable — that is, not bypassed by all possible execution paths. Names introduced using these declarations have local scope. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement can be nested. In such cases, **case** or **default** labels associate with the closest <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement that encloses them.  
  
## Microsoft Specific  
 Microsoft C does not limit the number of case values in a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement. The number is limited only by the available memory. ANSI C requires at least 257 case labels be allowed in a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement.  
  
 The default for Microsoft C is that the Microsoft extensions are enabled. Use the [/Za](../vs140/-za---ze--disable-language-extensions-.md) compiler option to disable these extensions.  
  
## END Microsoft Specific  
  
## See Also  
 [Selection Statements](../vs140/selection-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [(NOTINBUILD) Using Labels in the case Statement](assetId:///a6ff057d-1aee-42ed-a28d-ee6a565b3197)