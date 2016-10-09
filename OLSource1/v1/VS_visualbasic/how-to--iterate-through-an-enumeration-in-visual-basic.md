---
title: "How to: Iterate Through An Enumeration in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "arrays [Visual Basic], iterating"
  - "enumerations [Visual Basic], iterating"
  - "ListBox control [Windows Forms], populating from an enumeration"
ms.assetid: e5aa10eb-cfcd-4a3b-8e76-f06b8f2002be
caps.latest.revision: 20
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Iterate Through An Enumeration in Visual Basic
Enumerations provide a convenient way to work with sets of related constants, and to associate constant values with names. To iterate through an enumeration, you can move it into an array using the \<xref:System.Enum.GetValues*> method. You could also iterate through an enumeration using a `For...Each` statement, using the \<xref:System.Enum.GetNames*> or \<xref:System.Enum.GetValues*> method to extract the string or numeric value.  
  
### To iterate through an enumeration  
  
-   Declare an array and convert the enumeration to it with the \<xref:System.Enum.GetValues*> method before passing the array as you would any other variable. The following example displays each member of the enumeration \<xref:Microsoft.VisualBasic.FirstDayOfWeek> as it iterates through the enumeration.  
  
     [!code[VbEnumsTask#7](../VS_visualbasic/codesnippet/VisualBasic/how-to--iterate-through-an-enumeration-in-visual-basic_1.vb)]  
  
## See Also  
 [Enumerations Overview](../VS_visualbasic/enumerations-overview--visual-basic-.md)   
 [How to: Declare an Enumeration](../VS_visualbasic/how-to--declare-enumerations--visual-basic-.md)   
 [When to Use an Enumeration](../VS_visualbasic/when-to-use-an-enumeration--visual-basic-.md)   
 [How to: Determine the String Associated with an Enumeration Value](../VS_visualbasic/how-to--determine-the-string-associated-with-an-enumeration-value--visual-basic-.md)   
 [How to: Refer to an Enumeration Member](../VS_visualbasic/how-to--refer-to-an-enumeration-member--visual-basic-.md)   
 [Enumerations and Name Qualification](../VS_visualbasic/enumerations-and-name-qualification--visual-basic-.md)   
 [Arrays](../VS_visualbasic/arrays-in-visual-basic.md)