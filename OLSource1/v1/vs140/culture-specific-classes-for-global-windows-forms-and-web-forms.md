---
title: "Culture-Specific Classes for Global Windows Forms and Web Forms"
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
  - "globalization [Windows Forms], classes"
  - "Web applications [.NET Framework], globalization"
  - "culture, culture-specific classes"
  - "numbers, international"
  - "localization [Windows Forms], classes"
  - "globalization [Visual Studio], culture-specific classes"
  - "Windows Forms, localization"
  - "international applications [Visual Studio], data formats"
  - "time [Visual Studio], international"
  - "dates [Visual Studio], international"
  - "culture"
  - "international characters"
  - "currency formats"
  - "ASP.NET, globalization"
  - "classes [Visual Studio], culture-specific"
  - "localization [Visual Studio], culture-specific classes"
ms.assetid: 0d06a0a4-f887-4f7c-bde7-1d543c06f803
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Culture-Specific Classes for Global Windows Forms and Web Forms
Each culture has different conventions for displaying dates, time, numbers, currency, and other information. The \<xref:System.Globalization*> namespace contains classes that can be used to modify how culture-specific values are displayed, such as \<xref:System.Globalization.DateTimeFormatInfo*>, **Calendar**, and \<xref:System.Globalization.NumberFormatInfo*>.  
  
## Using the Culture Setting  
 But most of the time you will use the culture setting, stored either in the application or in the **Regional Options** control panel, to automatically determine the conventions at run time and format the information accordingly. For more information on setting the culture, see [How to: Set the Culture and UI Culture for Windows Forms Globalization](assetId:///694e049f-0b91-474a-9789-d35124f248f0) or [How to: Set the Culture and UI Culture for ASP.NET Web Page Globalization](assetId:///76091f86-f967-4687-a40f-de87bd8cc9a0). Classes that automatically format information according to the culture setting are called culture-specific. Some culture-specific methods are \<xref:System.IFormattable.ToString*?displayProperty=fullName>, \<xref:System.Console.WriteLine*?displayProperty=fullName>, and \<xref:System.String.Format*?displayProperty=fullName>. Some culture-specific functions (in the Visual Basic language) are <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 For example, the following code shows how you can use the \<xref:System.IFormattable.ToString*> method to format currency for the current culture:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If the culture is set to "fr-FR", you will see this in the output window:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 If the culture is set to "en-US", you will see this in the output window:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## See Also  
 \<xref:System.IFormattable.ToString*?displayProperty=fullName>   
 \<xref:System.Globalization.DateTimeFormatInfo*>   
 \<xref:System.Globalization.NumberFormatInfo*>   
 \<xref:System.Globalization.Calendar*>   
 \<xref:System.Console.WriteLine*?displayProperty=fullName>   
 \<xref:System.String.Format*?displayProperty=fullName>   
 [Globalizing and Localizing Applications](../vs140/globalizing-and-localizing-applications.md)