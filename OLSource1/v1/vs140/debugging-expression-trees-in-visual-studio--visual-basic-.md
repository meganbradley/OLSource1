---
title: "Debugging Expression Trees in Visual Studio (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 492cc28f-b7a2-4c47-b582-b3c437b8a5d5
caps.latest.revision: 7
---
# Debugging Expression Trees in Visual Studio (Visual Basic)
You can analyze the structure and content of expression trees when you debug your applications. To get a quick overview of the expression tree structure, you can use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> property, which is available only in debug mode. For more information about debugging, see [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md).  
  
 To better represent the content of expression trees, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> property uses Visual Studio visualizers. For more information, see [Visualizers](../vs140/create-custom-visualizers-of-data.md).  
  
### To open a visualizer for an expression tree  
  
1.  Click the magnifying glass icon that appears next to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property of an expression tree in **DataTips**, a **Watch** window, the **Autos** window, or the **Locals** window.  
  
     A list of visualizers is displayed.  
  
2.  Click the visualizer you want to use.  
  
 Each expression type is displayed in the visualizer as described in the following sections.  
  
## ParameterExpressions  
 \<xref:System.Linq.Expressions.ParameterExpression*> variable names are displayed with a "$" symbol at the beginning.  
  
 If a parameter does not have a name, it is assigned an automatically generated name, such as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Examples  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## ConstantExpressions  
 For \<xref:System.Linq.Expressions.ConstantExpression*> objects that represent integer values, strings, and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the value of the constant is displayed.  
  
### Examples  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> property  
  
     10  
  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> property  
  
     10D  
  
## BlockExpression  
 If the type of a \<xref:System.Linq.Expressions.BlockExpression*> object differs from the type of the last expression in the block, the type is displayed in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> property in angle brackets (\< and >). Otherwise, the type of the \<xref:System.Linq.Expressions.BlockExpression*> object is not displayed.  
  
### Examples  
  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
## LambdaExpression  
 \<xref:System.Linq.Expressions.LambdaExpression*> objects are displayed together with their delegate types.  
  
 If a lambda expression does not have a name, it is assigned an automatically generated name, such as <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Examples  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
## LabelExpression  
 If you specify a default value for the \<xref:System.Linq.Expressions.LabelExpression*> object, this value is displayed before the \<xref:System.Linq.Expressions.LabelTarget*> object.  
  
 The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> token indicates the start of the label. The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> token indicates the destination of the target to jump to.  
  
 If a label does not have a name, it is assigned an automatically generated name, such as <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
### Examples  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
## Checked Operators  
 Checked operators are displayed with the "#" symbol in front of the operator. For example, the checked addition operator is displayed as <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Examples  
  
-   <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> property  
  
     <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
## See Also  
 [Expression Trees (Visual Basic)](../vs140/expression-trees--visual-basic-.md)   
 [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md)   
 [Visualizers](../vs140/create-custom-visualizers-of-data.md)