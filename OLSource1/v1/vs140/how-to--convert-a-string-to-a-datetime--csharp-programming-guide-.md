---
title: "How to: Convert a String to a DateTime (C# Programming Guide)"
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
  - "strings [C#], converting to DateTIme"
ms.assetid: 88abef11-3a06-4b49-8dd2-61ed0e876fc3
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert a String to a DateTime (C# Programming Guide)
It is common for programs to enable users to enter dates as string values. To convert a string-based date to a \<xref:System.DateTime*?displayProperty=fullName> object, you can use the \<xref:System.Convert.ToDateTime(System.String)?displayProperty=fullName> method or the \<xref:System.DateTime.Parse(System.String)?displayProperty=fullName> static method, as shown in the following example.  
  
 **Culture**.  Different cultures in the world write date strings in different ways.  For example, in the US 01/20/2008 is January 20th, 2008.  In France this will throw an InvalidFormatException. This is because France reads date-times as Day/Month/Year, and in the US it is Month/Day/Year.  
  
 Consequently, a string like 20/01/2008 will parse to January 20th, 2008 in France, and then throw an InvalidFormatException in the US.  
  
 To determine your current culture settings, you can use System.Globalization.CultureInfo.CurrentCulture.  
  
 See the example below for a simple example of converting a string to dateTime.  
  
 For more examples of date strings, see \<xref:System.Convert.ToDateTime(System.String)?displayProperty=fullName>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 [!code[csProgGuideStrings#13](../vs140/codesnippet/CSharp/how-to--convert-a-string-to-a-datetime--csharp-programming-guide-_1.cs)]  
  
## See Also  
 [Strings Overview (C# Programming Guide)](../vs140/strings--csharp-programming-guide-.md)