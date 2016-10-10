---
title: "How to: Create a New Variable (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
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
  - "Dim statement"
  - "variables [Visual Basic], creating"
ms.assetid: 35300be3-77b0-4bef-a156-034d3cdedde0
caps.latest.revision: 29
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
# How to: Create a New Variable (Visual Basic)
You create a variable with a [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md).  
  
### To create a new variable  
  
1.  Declare the variable in a `Dim` statement.  
  
    ```  
  
    Dim newCustomer  
    ```  
  
2.  Include specifications for the variable's characteristics, such as [Private](../VS_visualbasic/private--visual-basic-.md), [Static](../VS_visualbasic/static--visual-basic-.md), [Shadows](../VS_visualbasic/shadows--visual-basic-.md), or [WithEvents](../VS_visualbasic/withevents--visual-basic-.md). For more information, see [Declared Element Characteristics](../VS_visualbasic/declared-element-characteristics--visual-basic-.md).  
  
    ```  
    Public Static newCustomer  
    ```  
  
     You do not need the `Dim` keyword if you use other keywords in the declaration.  
  
3.  Follow the specifications with the variable's name, which must follow [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] rules and conventions. For more information, see [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md).  
  
    ```  
    Public Static newCustomer  
    ```  
  
4.  Follow the name with the [As](../VS_visualbasic/as-clause--visual-basic-.md) clause to specify the variable's data type.  
  
    ```  
    Public Static newCustomer As Customer  
    ```  
  
     If you do not specify the data type, it uses the default: `Object`.  
  
5.  Follow the `As` clause with an equal sign (`=`) and follow the equal sign with the variable's initial value.  
  
     [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] assigns the specified value to the variable every time it runs the `Dim` statement. If you do not specify an initial value, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] assigns the default initial value for the variable's data type when it first enters the code that contains the `Dim` statement.  
  
     If the variable is a reference type, you can create an instance of its class by including the [New Operator](../VS_visualbasic/new-operator--visual-basic-.md) keyword in the `As` clause. If you do not use `New`, the initial value of the variable is [Nothing](../VS_visualbasic/nothing--visual-basic-.md).  
  
    ```  
    Public Static newCustomer As New Customer  
    ```  
  
## See Also  
 [Variables](../VS_visualbasic/variables-in-visual-basic.md)   
 [Variable Declaration](../VS_visualbasic/variable-declaration-in-visual-basic.md)   
 [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md)   
 [Declared Element Characteristics](../VS_visualbasic/declared-element-characteristics--visual-basic-.md)   
 [Value Types and Reference Types](../VS_visualbasic/value-types-and-reference-types.md)   
 [Statements](../VS_visualbasic/statements--visual-basic-.md)   
 [Local Type Inference](../VS_visualbasic/local-type-inference--visual-basic-.md)   
 [Option Infer Statement](../VS_visualbasic/option-infer-statement.md)