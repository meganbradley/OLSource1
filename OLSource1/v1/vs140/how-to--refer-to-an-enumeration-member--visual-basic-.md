---
title: "How to: Refer to an Enumeration Member (Visual Basic)"
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
  - "enumerations [Visual Basic], referring to"
  - "values, associating constant values with names"
  - "enumeration members"
  - "constants, enumerated"
ms.assetid: bbb5c3cc-7cdb-4814-8d6a-a6d91546ed1e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Refer to an Enumeration Member (Visual Basic)
Enumerations provide a convenient way to work with sets of related constants and to associate constant values with names. For example, you can declare an enumeration for a set of integer constants associated with the days of the week, and then use the names of the days rather than their integer values in your code.  
  
 You can avoid using fully qualified names with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement. For more information, see [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md).  
  
### To refer to an enumeration member  
  
-   Qualify the member name with the enumeration. For example, the following example assigns the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> enumeration to the variable <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
     [!code[VbEnumsTask#19](../vs140/codesnippet/VisualBasic/how-to--refer-to-an-enumeration-member--visual-basic-_1.vb)]  
  
## See Also  
 [How to: Declare Enumerations](../vs140/how-to--declare-enumerations--visual-basic-.md)   
 [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md)   
 [How to: Iterate Through An Enumeration in Visual Basic](../vs140/how-to--iterate-through-an-enumeration-in-visual-basic.md)   
 [How to: Determine the String Associated with an Enumeration Value](../vs140/how-to--determine-the-string-associated-with-an-enumeration-value--visual-basic-.md)   
 [When to Use an Enumeration](../vs140/when-to-use-an-enumeration--visual-basic-.md)