---
title: "How to: Create a Nullable Type (Class Designer)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "nullable types, Class Designer"
  - "Class Designer [Visual Studio], nullable types"
ms.assetid: 84673a89-3f6d-4668-919e-1c0f56182fe5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Nullable Type (Class Designer)
Certain value types do not always have (or need) a defined value. This is common practice in databases, where some fields might not be assigned any value. For example, you might assign a null value to a database field to signify that it has not yet been assigned a value.  
  
 A *nullable type* is a value type that you extend so that it takes the typical range of values for that type and also a null value. For example, a nullable of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, also denoted as Nullable\<Int32>, can be assigned any value from -2147483648 to 2147483647, or it can be assigned a null value. A Nullable\<bool> can be assigned the values <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or null (no value at all).  
  
 Nullable types are instances of the <xref:System.Nullable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>HasValue<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Value<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>HasValue<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>bool<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>if (x.HasValue)<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>if (y != null)<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Value<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>HasValue<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Value<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>HasValue<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>False<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Value<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>HasValue<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>False<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>1*>   
 [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md)   
 [Using Nullable Types (C# Programming Guide)](../vs140/using-nullable-types--csharp-programming-guide-.md)   
 [How To: Identify a Nullable Type (C# Programming Guide)](../vs140/how-to--identify-a-nullable-type--csharp-programming-guide-.md)   
 [Value Types that Might Not Have a Defined Value](../vs140/nullable-value-types--visual-basic-.md)