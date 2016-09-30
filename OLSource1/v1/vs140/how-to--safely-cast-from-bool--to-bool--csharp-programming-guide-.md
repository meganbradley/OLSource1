---
title: "How to: Safely Cast from bool? to bool (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "casting [C#], nullable types"
  - "nullable types [C#], casting bool? to bool"
ms.assetid: e06e4274-a443-422d-8ef1-9dbf9df55237
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Safely Cast from bool? to bool (C# Programming Guide)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> nullable type can contain three different values: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Therefore, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type cannot be used in conditionals such as with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For example, the following code causes a compiler error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This is not allowed because it is unclear what <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> means in the context of a conditional. To use a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in a conditional statement, first check its <xref:System.Nullable<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>bool<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>bool?<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>bool?<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>bool`:  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Literal Keywords](../vs140/literal-keywords--csharp-reference-.md)   
 [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md)   
 [?? Operator (C# Reference)](../vs140/---operator--csharp-reference-.md)