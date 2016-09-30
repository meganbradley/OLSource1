---
title: "Nullable Value Types (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Nullable"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "nullable types [Visual Basic]"
  - "? [Visual Basic]"
  - "types [Visual Basic], nullable"
  - "nullable types"
  - "data types [Visual Basic], nullable"
ms.assetid: 9ac3b602-6f96-4e6d-96f7-cd4e81c468a6
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable Value Types (Visual Basic)
Sometimes you work with a value type that does not have a defined value in certain circumstances. For example, a field in a database might have to distinguish between having an assigned value that is meaningful and not having an assigned value. Value types can be extended to take either their normal values or a null value. Such an extension is called a *nullable type*.  
  
 Each nullable type is constructed from the generic <xref:System.Nullable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>Boolean<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>ridesBusToWork<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>False<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>False<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Function<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>String<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1.HasValue*> and <xref:System.Nullable<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>1.HasValue*> tells you whether the variable contains a defined value. If <xref:System.Nullable<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>1.Value*>. Note that both <xref:System.Nullable<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1.Value*> are <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> properties.  
  
### Default Values  
 When you declare a variable with a nullable type, its <xref:System.Nullable<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>False<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>numberOfChildren<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Integer<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>numberOfChildren<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>Integer<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>numberOfChildren<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>Nothing<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>Nothing<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>Nothing<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>someVar = Nothing<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>Nothing<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>1.HasValue*> property for <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, or test by using the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> operator.  
  
### Retrieving Values  
 To retrieve the value of a variable of a nullable type, you should first test its <xref:System.Nullable<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>1.HasValue*> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] throws an \<xref:System.InvalidOperationException*> exception. The following example shows the recommended way to read the variable <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> of the previous examples.  
  
 [!code[VbVbalrNullableValue#5](../vs140/codesnippet/VisualBasic/nullable-value-types--visual-basic-_5.vb)]  
  
## Comparing Nullable Types  
 When nullable <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> variables are used in Boolean expressions, the result can be <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The following is the truth table for <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. Because <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> now have three possible values, there are nine combinations to evaluate.  
  
|b1|b2|b1 And b2|b1 Or b2|  
|--------|--------|---------------|--------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|  
  
 When the value of a Boolean variable or expression is <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, it is neither <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>. Consider the following example.  
  
 [!code[VbVbalrNullableValue#6](../vs140/codesnippet/VisualBasic/nullable-value-types--visual-basic-_6.vb)]  
  
 In this example, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. As a result, the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> clause is executed in each <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> statement, and the output is as follows:  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
> [!NOTE]
>  <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, which use short-circuit evaluation, must evaluate their second operands when the first evaluates to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
## Propagation  
 If one or both of the operands of an arithmetic, comparison, shift, or type operation is nullable, the result of the operation is also nullable. If both operands have values that are not <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, the operation is performed on the underlying values of the operands, as if neither were a nullable type. In the following example, variables <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> are implicitly typed. If you rest the mouse pointer over them, you will see that the compiler infers nullable types for both of them.  
  
 [!code[VbVbalrNullableValue#7](../vs140/codesnippet/VisualBasic/nullable-value-types--visual-basic-_7.vb)]  
  
 If one or both operands have a value of <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, the result will be <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrNullableValue#8](../vs140/codesnippet/VisualBasic/nullable-value-types--visual-basic-_8.vb)]  
  
## Using Nullable Types with Data  
 A database is one of the most important places to use nullable types. Not all database objects currently support nullable types, but the designer-generated table adapters do. See "TableAdapter Support for Nullable Types" in [TableAdapter Overview](assetId:///a87c46a0-52ab-432a-a864-9ba55069f9eb).  
  
## See Also  
 \<xref:System.InvalidOperationException*>   
 \<xref:System.Nullable`1.HasValue*>   
 [Using Nullable Types (C# Programming Guide)](../vs140/using-nullable-types--csharp-programming-guide-.md)   
 [Data Types in Visual Basic](../vs140/data-types-in-visual-basic.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [TableAdapter Overview](assetId:///a87c46a0-52ab-432a-a864-9ba55069f9eb)   
 [If Operator](../vs140/if-operator--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md)   
 [IsNot Operator](../vs140/isnot-operator--visual-basic-.md)