---
title: "How to: Determine the String Associated with an Enumeration Value (Visual Basic)"
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
  - "enumerations [Visual Basic]"
  - "strings [Visual Basic], enumeration values"
  - "values, enumeration members"
ms.assetid: 9253e7c8-579c-49a2-8f26-392b20ea99eb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Determine the String Associated with an Enumeration Value (Visual Basic)
The \<xref:System.Enum.GetValues*> and \<xref:System.Enum.GetNames*> methods allow you to determine the strings and values associated with enumeration members.  
  
### To determine the string associated with an enumeration  
  
-   Use the \<xref:System.Enum.GetNames*> method to retrieve the strings associated with the enumeration members. This example declares an enumeration, `flavorEnum`, then uses the \<xref:System.Enum.GetNames*> method to display the strings associated with each member.  
  
     [!code[VbEnumsTask#2](../vs140/codesnippet/VisualBasic/how-to--determine-the-string-associated-with-an-enumeration-value--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:System.Enum.GetValues*>   
 \<xref:System.Enum.GetNames*>   
 \<xref:System.Enum*>   
 [How to: Declare Enumerations](../vs140/how-to--declare-enumerations--visual-basic-.md)   
 [How to: Refer to an Enumeration Member](../vs140/how-to--refer-to-an-enumeration-member--visual-basic-.md)   
 [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md)   
 [How to: Iterate Through An Enumeration in Visual Basic](../vs140/how-to--iterate-through-an-enumeration-in-visual-basic.md)   
 [When to Use an Enumeration](../vs140/when-to-use-an-enumeration--visual-basic-.md)   
 [Enum Statement (Visual Basic)](../vs140/enum-statement--visual-basic-.md)