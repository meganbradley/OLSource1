---
title: "Enumerations and Name Qualification (Visual Basic)"
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
# Enumerations and Name Qualification (Visual Basic)
Normally, when referring to a member of an enumeration, you must qualify the member name with the enumeration name. For example, to refer to the `Sunday` member of your `Days` enumeration, you would use the following syntax:  
  
 [!code[VbEnumsTask#18](../VS_visualbasic/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_1.vb)]  
  
## Using the Imports Statement  
 You can avoid using fully qualified names by adding an `Imports` statement to the namespace declarations section of your code, as in the following example:  
  
 [!code[VbEnumsTask#22](../VS_visualbasic/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_2.vb)]  
  
 An `Imports` statement imports namespace names from referenced projects and assemblies and from within the same project as the module in which the statement appears. Once this statement is added, you can refer to your enumeration members without qualification, as in the following example:  
  
 [!code[VbEnumsTask#24](../VS_visualbasic/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_3.vb)]  
  
 By organizing sets of related constants in enumerations, you can use the same constant names in different contexts. For example, you can use the same names for the weekday constants in the `Days` and `WorkDays` enumerations. If you use the `Imports` statement with your enumerations, you must be careful to avoid ambiguous references. Consider the following example:  
  
 [!code[VbEnumsTask#22](../VS_visualbasic/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_2.vb)]  
  
 [!code[VbEnumsTask#25](../VS_visualbasic/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_4.vb)]  
  
 Assuming that `Monday` is a member of both the `Days` enumeration and the `Workdays` enumeration, this code generates a compiler error. To avoid ambiguous references when referring to an individual constant, qualify the constant name with its enumeration. The following code refers to the `Saturday` constants in the `Days` and `WorkDays` enumerations.  
  
 [!code[VbEnumsTask#32](../VS_visualbasic/codesnippet/VisualBasic/enumerations-and-name-qualification--visual-basic-_5.vb)]  
  
## See Also  
 [Constants and Enumerations](../VS_visualbasic/constants-and-enumerations--visual-basic-.md)   
 [How to: Declare an Enumeration](../VS_visualbasic/how-to--declare-enumerations--visual-basic-.md)   
 [How to: Refer to an Enumeration Member](../VS_visualbasic/how-to--refer-to-an-enumeration-member--visual-basic-.md)   
 [How to: Iterate Through An Enumeration in Visual Basic](../VS_visualbasic/how-to--iterate-through-an-enumeration-in-visual-basic.md)   
 [How to: Determine the String Associated with an Enumeration Value](../VS_visualbasic/how-to--determine-the-string-associated-with-an-enumeration-value--visual-basic-.md)   
 [When to Use an Enumeration](../VS_visualbasic/when-to-use-an-enumeration--visual-basic-.md)   
 [Constant and Literal Data Types](../VS_visualbasic/constant-and-literal-data-types--visual-basic-.md)   
 [Enum Statement](../VS_visualbasic/enum-statement--visual-basic-.md)   
 [Imports Statement (.NET Namespace and Type)](../VS_visualbasic/imports-statement--.net-namespace-and-type-.md)   
 [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md)