---
title: "How to: Iterate Through An Enumeration in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Iterate Through An Enumeration in Visual Basic
Enumerations provide a convenient way to work with sets of related constants, and to associate constant values with names. To iterate through an enumeration, you can move it into an array using the <xref:System.Enum.GetValues*> method. You could also iterate through an enumeration using a `For...Each` statement, using the <xref:System.Enum.GetNames*> or <xref:System.Enum.GetValues*> method to extract the string or numeric value.  
  
### To iterate through an enumeration  
  
-   Declare an array and convert the enumeration to it with the <xref:System.Enum.GetValues*> method before passing the array as you would any other variable. The following example displays each member of the enumeration <xref:Microsoft.VisualBasic.FirstDayOfWeek*> as it iterates through the enumeration.  
  
     [!code[VbEnumsTask#7](../vs140/codesnippet/VisualBasic/how-to--iterate-through-an-enumeration-in-visual-basic_1.vb)]  
  
## See Also  
 [Enumerations Overview](../vs140/enumerations-overview--visual-basic-.md)   
 [How to: Declare Enumerations](../vs140/how-to--declare-enumerations--visual-basic-.md)   
 [When to Use an Enumeration](../vs140/when-to-use-an-enumeration--visual-basic-.md)   
 [How to: Determine the String Associated with an Enumeration Value](../vs140/how-to--determine-the-string-associated-with-an-enumeration-value--visual-basic-.md)   
 [How to: Refer to an Enumeration Member](../vs140/how-to--refer-to-an-enumeration-member--visual-basic-.md)   
 [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md)   
 [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md)