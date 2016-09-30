---
title: "Enumerations and Name Qualification (Visual Basic)"
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
  - "declarations, enumerations"
  - "Imports statement, namespace declarations"
  - "declaring namespaces, enumerations"
  - "name collisions"
  - "ambiguous names, enumerations"
  - "enumerations [Visual Basic], name qualification"
  - "names, avoiding conflicts"
  - "namespaces, declaring"
  - "naming conflicts, enumerations"
  - "naming conflicts, qualifying names"
  - "declaring enumerations"
  - "references, enumeration members"
  - "naming conventions, naming conflicts"
  - "declarations, namespaces"
ms.assetid: 08ba2738-df52-4140-bc55-f57c871c9b73
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Enumerations and Name Qualification (Visual Basic)
Normally, when referring to a member of an enumeration, you must qualify the member name with the enumeration name. For example, to refer to the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member of your <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> enumeration, you would use the following syntax:  
  
 [!code[VbEnumsTask#18](../vs140/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_1.vb)]  
  
## Using the Imports Statement  
 You can avoid using fully qualified names by adding an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement to the namespace declarations section of your code, as in the following example:  
  
 [!code[VbEnumsTask#22](../vs140/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_2.vb)]  
  
 An <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement imports namespace names from referenced projects and assemblies and from within the same project as the module in which the statement appears. Once this statement is added, you can refer to your enumeration members without qualification, as in the following example:  
  
 [!code[VbEnumsTask#24](../vs140/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_3.vb)]  
  
 By organizing sets of related constants in enumerations, you can use the same constant names in different contexts. For example, you can use the same names for the weekday constants in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> enumerations. If you use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement with your enumerations, you must be careful to avoid ambiguous references. Consider the following example:  
  
 [!code[VbEnumsTask#22](../vs140/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_2.vb)]  
  
 [!code[VbEnumsTask#25](../vs140/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_4.vb)]  
  
 Assuming that <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a member of both the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> enumeration and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> enumeration, this code generates a compiler error. To avoid ambiguous references when referring to an individual constant, qualify the constant name with its enumeration. The following code refers to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> constants in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> enumerations.  
  
 [!code[VbEnumsTask#32](../vs140/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_5.vb)]  
  
## See Also  
 [Constants and Enumerations (Visual Basic)](../vs140/constants-and-enumerations--visual-basic-.md)   
 [How to: Declare an Enumeration](../vs140/how-to--declare-enumerations--visual-basic-.md)   
 [How to: Refer to an Enumeration Member](../vs140/how-to--refer-to-an-enumeration-member--visual-basic-.md)   
 [How to: Iterate Through An Enumeration in Visual Basic](../vs140/how-to--iterate-through-an-enumeration-in-visual-basic.md)   
 [How to: Determine the String Associated with an Enumeration Value](../vs140/how-to--determine-the-string-associated-with-an-enumeration-value--visual-basic-.md)   
 [When to Use an Enumeration](../vs140/when-to-use-an-enumeration--visual-basic-.md)   
 [Constant and Literal Data Types](../vs140/constant-and-literal-data-types--visual-basic-.md)   
 [Enum Statement](../vs140/enum-statement--visual-basic-.md)   
 [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md)   
 [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md)