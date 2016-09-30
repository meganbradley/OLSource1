---
title: "Debugging Expression Trees in Visual Studio (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 1369fa25-0fbd-4b92-98d0-8df79c49c27a
caps.latest.revision: 8
---
# Debugging Expression Trees in Visual Studio (C#)
You can analyze the structure and content of expression trees when you debug your applications. To get a quick overview of the expression tree structure, you can use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property, which is available only in debug mode. For more information about debugging, see [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md).  
  
 To better represent the content of expression trees, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property uses Visual Studio visualizers. For more information, see [Visualizers](../vs140/create-custom-visualizers-of-data.md).  
  
### To open a visualizer for an expression tree  
  
1.  Click the magnifying glass icon that appears next to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> property of an expression tree in **DataTips**, a **Watch** window, the **Autos** window, or the **Locals** window.  
  
     A list of visualizers is displayed.  
  
2.  Click the visualizer you want to use.  
  
 Each expression type is displayed in the visualizer as described in the following sections.  
  
## ParameterExpressions  
 \<xref:System.Linq.Expressions.ParameterExpression*> variable names are displayed with a "$" symbol at the beginning.  
  
 If a parameter does not have a name, it is assigned an automatically generated name, such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
### Examples  
  
|Expression|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> property|  
|----------------|--------------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
  
## ConstantExpressions  
 For \<xref:System.Linq.Expressions.ConstantExpression*> objects that represent integer values, strings, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the value of the constant is displayed.  
  
 For numeric types that have standard suffixes as C# literals, the suffix is added to the value. The following table shows the suffixes associated with various numeric types.  
  
|Type|Suffix|  
|----------|------------|  
|\<xref:System.UInt32*>|U|  
|\<xref:System.Int64*>|L|  
|\<xref:System.UInt64*>|UL|  
|\<xref:System.Double*>|D|  
|\<xref:System.Single*>|F|  
|\<xref:System.Decimal*>|M|  
  
### Examples  
  
|Expression|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> property|  
|----------------|--------------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|10|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|10D|  
  
## BlockExpression  
 If the type of a \<xref:System.Linq.Expressions.BlockExpression*> object differs from the type of the last expression in the block, the type is displayed in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property in angle brackets (\< and >). Otherwise, the type of the \<xref:System.Linq.Expressions.BlockExpression*> object is not displayed.  
  
### Examples  
  
|Expression|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> property|  
|----------------|--------------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
  
## LambdaExpression  
 \<xref:System.Linq.Expressions.LambdaExpression*> objects are displayed together with their delegate types.  
  
 If a lambda expression does not have a name, it is assigned an automatically generated name, such as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Examples  
  
|Expression|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> property|  
|----------------|--------------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
## LabelExpression  
 If you specify a default value for the \<xref:System.Linq.Expressions.LabelExpression*> object, this value is displayed before the \<xref:System.Linq.Expressions.LabelTarget*> object.  
  
 The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> token indicates the start of the label. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> token indicates the destination of the target to jump to.  
  
 If a label does not have a name, it is assigned an automatically generated name, such as <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Examples  
  
|Expression|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder> property|  
|----------------|--------------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
  
## Checked Operators  
 Checked operators are displayed with the "#" symbol in front of the operator. For example, the checked addition operator is displayed as <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
### Examples  
  
|Expression|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder> property|  
|----------------|--------------------------|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
  
## See Also  
 [Expression Trees (C#)](../vs140/expression-trees--csharp-.md)   
 [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md)   
 [Visualizers](../vs140/create-custom-visualizers-of-data.md)