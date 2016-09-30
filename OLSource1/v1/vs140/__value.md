---
title: "__value"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "__value_cpp"
  - "__value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__value keyword"
  - "value types, declaring"
  - "__value keyword, syntax"
ms.assetid: b14b64f7-5db6-4e92-a144-fcbf67572b49
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# __value
> [!NOTE]
>  This topic applies only to version 1 of Managed Extensions for C++. This syntax should only be used to maintain version 1 code. See [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md) for information on using the equivalent functionality in the new syntax.  
  
 Declares a class to be a __value type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type differs from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> types in that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type variables directly contain their data, whereas managed variables point to their data, which is stored on the common language runtime heap.  
  
 The following conditions apply to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> types:  
  
-   The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword cannot be applied to an interface.  
  
-   A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type can inherit from any number of interfaces and cannot inherit from other types or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> types.  
  
-   A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type is sealed by definition. For more information, see [__sealed](../vs140/__sealed.md).  
  
-   It is valid to use a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type anywhere a managed type is allowed.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword is not allowed when used with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword.  
  
 A <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type can be explicitly connected to a **System::Object** pointer. This is known as boxing.  
  
 The following guidelines apply to embedding a value type inside a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> type:  
  
-   The value type must have **LayoutSequential** or **LayoutExplicit**.  
  
-   The value type can not have gc pointer members.  
  
-   The value type can not have private data members.  
  
 In Managed Extensions for C++, the equivalents to a C# class and a C# struct are as follows:  
  
|Managed Extensions for C++|C#|For more information|  
|----------------------------------|---------|--------------------------|  
|__gc struct\<br />\<br /> -or-\<br />\<br /> \__gc class|class|[class](../vs140/class--csharp-reference-.md) keyword|  
|__value struct\<br />\<br /> -or-\<br />\<br /> \__value class|struct|[struct](../vs140/struct--csharp-reference-.md) keyword|  
  
## Example  
 In the following example, a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> type (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) is declared and then two instances of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> type are manipulated:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>