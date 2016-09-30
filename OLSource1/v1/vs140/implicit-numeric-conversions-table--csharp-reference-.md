---
title: "Implicit Numeric Conversions Table (C# Reference)"
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
  - "conversions [C#], implicit numeric"
  - "implicit numeric conversions [C#]"
  - "numeric conversions [C#], implicit"
  - "types [C#], implicit numeric conversions"
ms.assetid: 72eb5a94-0491-48bf-8032-d7ebfdfeb8d8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implicit Numeric Conversions Table (C# Reference)
The following table shows the predefined implicit numeric conversions. Implicit conversions might occur in many situations, including method invoking and assignment statements.  
  
|From|To|  
|----------|--------|  
|[sbyte](../vs140/sbyte--csharp-reference-.md)|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|[byte](../vs140/byte--csharp-reference-.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|[short](../vs140/short--csharp-reference-.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|[ushort](../vs140/ushort--csharp-reference-.md)|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|[int](../vs140/int--csharp-reference-.md)|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|[uint](../vs140/uint--csharp-reference-.md)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|[long](../vs140/long--csharp-reference-.md)|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|[char](../vs140/char--csharp-reference-.md)|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|[float](../vs140/float--csharp-reference-.md)|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|[ulong](../vs140/ulong--csharp-reference-.md)|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
  
## Remarks  
  
-   Precision but not magnitude might be lost in the conversions from <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> and from <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
-   There are no implicit conversions to the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> type.  
  
-   There are no implicit conversions between floating-point types and the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> type.  
  
-   A constant expression of type <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> can be converted to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, provided the value of the constant expression is within the range of the destination type.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)   
 [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md)