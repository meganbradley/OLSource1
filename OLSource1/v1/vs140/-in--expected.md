---
title: "&#39;In&#39; expected"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc36607"
  - "vbc36607"
helpviewer_keywords: 
  - "BC36607"
ms.assetid: f390bca5-12fe-4fe1-bd86-7f8ab66dfbd8
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;In&#39; expected
A `From` or `Aggregate` clause has been specified without an `In` operator. You use the `In` operator to identify the collection to query.  
  
 **Error ID:** BC36607  
  
### To correct this error  
  
1.  Add the `In` operator and key fields to the `From` or `Aggregate` clause. The following is an example:  
  
    ```vb#  
    Dim names = From pers In people   
                Select pers.FirstName, pers.LastName  
    ```  
  
## See Also  
 [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md)   
 [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)