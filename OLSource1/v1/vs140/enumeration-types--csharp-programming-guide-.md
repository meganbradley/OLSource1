---
title: "Enumeration Types (C# Programming Guide)"
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
  - "enumerations [C#]"
  - "enums [C#]"
  - "C# Language, enums"
  - "bit flags [C#]"
ms.assetid: 64a9b731-9e3c-4336-8a09-018db2aa10b7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Enumeration Types (C# Programming Guide)
An enumeration type (also named an enumeration or an enum) provides an efficient way to define a set of named integral constants that may be assigned to a variable. For example, assume that you have to define a variable whose value will represent a day of the week. There are only seven meaningful values which that variable will ever store. To define those values, you can use an enumeration type, which is declared by using the [enum](../vs140/enum--csharp-reference-.md) keyword.  
  
 [!code[csProgGuideEnums#1](../vs140/codesnippet/CSharp/enumeration-types--csharp-programming-guide-_1.cs)]  
  
 By default the underlying type of each element in the enum is [int](../vs140/int--csharp-reference-.md). You can specify another integral numeric type by using a colon, as shown in the previous example. For a full list of possible types, see [enum (C# Reference)](../vs140/enum--csharp-reference-.md).  
  
 You can verify the underlying numeric values by casting  to the underlying type, as the following example shows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following are advantages of using an enum instead of a numeric type:  
  
-   You clearly specify for client code which values are valid for the variable.  
  
-   In [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], IntelliSense lists the defined values.  
  
 When you do not specify values for the elements in the enumerator list, the values are automatically incremented by 1. In the previous example, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> has a value of 0, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has a value of 1, and so on. When you create a new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, it will have a default value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (0) if you do not explicitly assign it a value. When you create an enum, select the most logical default value and give it a value of zero. That will cause all enums to have that default value if they are not explicitly assigned a value when they are created.  
  
 If the variable <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then (without an explicit cast) you can only assign it one of the values defined by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. And if the meeting day changes, you can assign a new value from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>:  
  
 [!code[csProgGuideEnums#4](../vs140/codesnippet/CSharp/enumeration-types--csharp-programming-guide-_2.cs)]  
  
> [!NOTE]
>  It is possible to assign any arbitrary integer value to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For example, this line of code does not produce an error: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. However, you should not do this because the implicit expectation is that an enum variable will only hold one of the values defined by the enum. To assign an arbitrary value to a variable of an enumeration type is to introduce a high risk for errors.  
  
 You can assign any values to the elements in the enumerator list of an enumeration type, and you can also use computed values:  
  
 [!code[csProgGuideEnums#3](../vs140/codesnippet/CSharp/enumeration-types--csharp-programming-guide-_3.cs)]  
  
## Enumeration Types as Bit Flags  
 You can use an enumeration type to define bit flags, which enables an instance of the enumeration type to store any combination of the values that are defined in the enumerator list. (Of course, some combinations may not be meaningful or allowed in your program code.)  
  
 You create a bit flags enum by applying the \<xref:System.FlagsAttribute*?displayProperty=fullName> attribute and defining the values appropriately so that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bitwise operations can be performed on them. In a bit flags enum, include a named constant with a value of zero that means "no flags are set." Do not give a flag a value of zero if it does not mean "no flags are set".  
  
 In the following example, another version of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> enum, which is named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, is defined. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> has the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute and each value is assigned the next greater power of 2. This enables you to create a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> variable whose value is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 [!code[csProgGuideEnums#2](../vs140/codesnippet/CSharp/enumeration-types--csharp-programming-guide-_4.cs)]  
  
 To set a flag on an enum, use the bitwise <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> operator as shown in the following example:  
  
 [!code[csProgGuideEnums#6](../vs140/codesnippet/CSharp/enumeration-types--csharp-programming-guide-_5.cs)]  
  
 To determine whether a specific flag is set, use a bitwise <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> operation, as shown in the following example:  
  
 [!code[csProgGuideEnums#7](../vs140/codesnippet/CSharp/enumeration-types--csharp-programming-guide-_6.cs)]  
  
 For more information about what to consider when you define enumeration types with the \<xref:System.FlagsAttribute*?displayProperty=fullName> attribute, see \<xref:System.Enum*?displayProperty=fullName>.  
  
## Using the System.Enum Methods to Discover and Manipulate Enum Values  
 All enums are instances of the \<xref:System.Enum*?displayProperty=fullName> type. You cannot derive new classes from \<xref:System.Enum*?displayProperty=fullName>, but you can use its methods to discover information about and manipulate values in an enum instance.  
  
 [!code[csProgGuideEnums#5](../vs140/codesnippet/CSharp/enumeration-types--csharp-programming-guide-_7.cs)]  
  
 For more information, see \<xref:System.Enum*?displayProperty=fullName>.  
  
 You can also create a new method for an enum by using an extension method. For more information, see [How to: Create a New Method for an Enumeration (C# Programming Guide)](../vs140/how-to--create-a-new-method-for-an-enumeration--csharp-programming-guide-.md).  
  
## Featured Book Chapter  
 [More About Variables](http://go.microsoft.com/fwlink/?LinkId=221230) in [Beginning Visual C# 2010](http://go.microsoft.com/fwlink/?LinkId=221214)  
  
## See Also  
 \<xref:System.Enum*?displayProperty=fullName>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [enum (C# Reference)](../vs140/enum--csharp-reference-.md)