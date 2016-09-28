---
title: "Troubleshooting Exceptions: System.FormatException"
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
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "FormatException class"
ms.assetid: b2a4f55e-da87-4915-a053-59eb1595993d
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.FormatException
A <xref:System.FormatException*> exception is thrown by a method that parses or formats a type when the format of an argument does not meet the parameter specifications of the method.  
  
## In this article  
  
## Causing Format Exceptions  
  
### Formatting  
 *Formatting* is the process of converting an instance of a class, structure, or enumeration value to its string representation, often so that the resulting string can be displayed to users or be used to save the state of the object.  
  
 For example, <xref:System.Int32.ToString(System.String)?displayProperty=fullName> takes a string parameter that identifies a standard or custom *format string* and returns the string representation of the number. The method throws a <xref:System.FormatException*> If the format string is invalid or not supported, a  is thrown.  
  
### Composite Formatting  
 *Composite formatting* takes a list of objects and a composite format string as input. A composite format string consists of fixed text intermixed with indexed placeholders, called format items, that correspond to the objects in the list. The formatting operation yields a result string that consists of the original fixed text intermixed with the string representation of the objects in the list.  
  
 <xref:System.String.Format*?displayProperty=fullName> and <xref:System.Console.WriteLine*?displayProperty=fullName> are examples of methods that do composite formatting. Methods that use composite formatting throw a <xref:System.FormatException*> if the format string is invalid or the index of a format item is less than zero, or greater than or equal to the number of arguments.  
  
### Parsing  
 *Parsing* is the process of converting a string that represents a .NET Framework base type into that base type. For example, a parsing operation is used to convert a string to a floating-point number or to a date and time value.  
  
 For example, <xref:System.Int32.Parse(System.String)?displayProperty=fullName>[Parse](assetId:///M:System.DateTime.Parse(System.String,System.IFormatProvider)?qualifyHint=False&autoUpgrade=True) converts the string representation of a date and time to its <xref:System.DateTime*> equivalent by using culture-specific format information specified in the <xref:System.IformatProvider*> parameter. If the string is not in the correct format, <xref:System.FormatException*> is thrown.  
  
## Avoiding FormatExceptions  
 The <xref:System.FormatException*> class reference article includes the common causes and solutions of <xref:System.FormatException*> errors.  
  
 The MSDN Library sections [Formatting Types in the .NET Framework](assetId:///0d1364da-5b30-4d42-8e6b-03378343343f) and [Parsing Strings in the .NET Framework](assetId:///5e758b41-db93-456b-8999-99b7304b090d) contain information about correctly formatting and parsing types.  
  
 **Composite formatting**  
  
 [Composite Formatting](assetId:///87b7d528-73f6-43c6-b71a-f23043039a49)  
  
 **Numeric types**  
  
|||  
|-|-|  
|[Standard Numeric Format Strings](assetId:///580e57eb-ac47-4ffd-bccd-3a1637c2f467)|[Custom Numeric Format Strings](assetId:///6f74fd32-6c6b-48ed-8241-3c2b86dea5f4)|  
|[Parsing Numeric Strings in the .NET Framework](assetId:///e39324ee-72e5-42d4-a80d-bf3ee7fc6c59)||  
  
 **Date and Time and Timespan types**  
  
|||  
|-|-|  
|[Standard Date and Time Format Strings](assetId:///bb79761a-ca08-44ee-b142-b06b3e2fc22b)|[Custom Date and Time Format Strings](assetId:///98b374e3-0cc2-4c78-ab44-efb671d71984)|  
|[Standard TimeSpan Format Strings](assetId:///9f6c95eb-63ae-4dcc-9c32-f81985c75794)|[Custom TimeSpan Format Strings](assetId:///a63ebf55-7269-416b-b4f5-286f6c03bf0e)|  
|[Parsing Date and Time Strings in the .NET Framework](assetId:///43bae51e-9b1d-41a6-a187-772c0d096d90)||  
  
 **Other types**  
  
|||  
|-|-|  
|[Enumeration Format Strings](assetId:///dd1ff672-1052-42cf-8666-4924fb6cd1a1)|[Parsing Other Strings in the .NET Framework](assetId:///d139bc00-3c4e-4d78-ac9a-5c951b258d28)|