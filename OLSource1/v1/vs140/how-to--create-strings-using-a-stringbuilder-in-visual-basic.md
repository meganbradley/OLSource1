---
title: "How to: Create Strings Using a StringBuilder in Visual Basic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - StringBuilder class
  - strings [Visual Basic], using StringBuilder
ms.assetid: 9c042880-aa16-432e-9ccb-cd00abda9ae3
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Create Strings Using a StringBuilder in Visual Basic
This example constructs a long string from many smaller strings using the <xref:System.Text.StringBuilder?qualifyHint=False> class. The <xref:System.Text.StringBuilder?qualifyHint=False> class is more efficient than the `&=` operator for concatenating many strings.  
  
## Example  
 The following example creates an instance of the <xref:System.Text.StringBuilder?qualifyHint=False> class, appends 1,000 strings to that instance, and then returns its string representation.  
  
 [!code[VbVbalrStrings#70](../vs140/codesnippet/VisualBasic/how-to--create-strings-using-a-stringbuilder-in-visual-basic_1.vb)]
  
  
## See Also  
 [Using the StringBuilder Class](assetId:///5c14867c-9a99-45bc-ae7f-2686700d377a)   
 [&= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-.md)   
 [Strings in Visual Basic](../vs140/strings-in-visual-basic.md)   
 [Creating New Strings](assetId:///06fdf123-2fac-4459-8904-eb48ab908a30)   
 [Manipulating Strings](assetId:///d4568ff3-9f83-4549-acd8-47aec2194ac0)   
 [Strings Sample](assetId:///be9e82a3-dc95-4aaa-9396-61b66e467e02)