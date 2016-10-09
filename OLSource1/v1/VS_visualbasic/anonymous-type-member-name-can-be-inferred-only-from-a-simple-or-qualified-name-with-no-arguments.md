---
title: "Anonymous type member name can be inferred only from a simple or qualified name with no arguments"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc36556"
  - "bc36556"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC36556"
ms.assetid: e3ba1f33-3a71-4f03-9b04-ed5ec17de17c
caps.latest.revision: 8
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
# Anonymous type member name can be inferred only from a simple or qualified name with no arguments
You cannot infer an anonymous type member name from a complex expression.  
  
```vb#  
Dim numbers() As Integer = {1, 2, 3, 4, 5}  
' Not valid.  
' Dim instanceName1 = New With {numbers(3)}  
```  
  
 For more information about sources from which anonymous types can and cannot infer member names and types, see [How to: Infer Property Names and Types in Anonymous Type Declarations](../VS_visualbasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md).  
  
 **Error ID:** BC36556  
  
### To correct this error  
  
-   Assign the expression to a member name, as shown in the following code:  
  
    ```  
    Dim instanceName2 = New With {.number = numbers(3)}  
    ```  
  
## See Also  
 [Anonymous Types](../VS_visualbasic/anonymous-types--visual-basic-.md)   
 [How to: Infer Property Names and Types in Anonymous Type Declarations](../VS_visualbasic/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md)