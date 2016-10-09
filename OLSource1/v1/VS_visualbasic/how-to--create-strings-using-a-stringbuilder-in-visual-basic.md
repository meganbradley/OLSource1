---
title: "How to: Create Strings Using a StringBuilder in Visual Basic"
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
  - "StringBuilder class"
  - "strings [Visual Basic], using StringBuilder"
ms.assetid: 9c042880-aa16-432e-9ccb-cd00abda9ae3
caps.latest.revision: 9
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
# How to: Create Strings Using a StringBuilder in Visual Basic
This example constructs a long string from many smaller strings using the \<xref:System.Text.StringBuilder> class. The \<xref:System.Text.StringBuilder> class is more efficient than the `&=` operator for concatenating many strings.  
  
## Example  
 The following example creates an instance of the \<xref:System.Text.StringBuilder> class, appends 1,000 strings to that instance, and then returns its string representation.  
  
 [!code[VbVbalrStrings#70](../VS_visualbasic/codesnippet/VisualBasic/how-to--create-strings-using-a-stringbuilder-in-visual-basic_1.vb)]  
  
## See Also  
 [Using the StringBuilder Class](../Topic/Using%20the%20StringBuilder%20Class%20in%20the%20.NET%20Framework.md)   
 [&= Operator](../VS_visualbasic/-=-operator--visual-basic-.md)   
 [Strings](../VS_visualbasic/strings-in-visual-basic.md)   
 [Creating New Strings](../Topic/Creating%20New%20Strings%20in%20the%20.NET%20Framework.md)   
 [Manipulating Strings](../Topic/Manipulating%20Strings%20in%20the%20.NET%20Framework.md)   
 [Strings Sample](assetId:///be9e82a3-dc95-4aaa-9396-61b66e467e02)