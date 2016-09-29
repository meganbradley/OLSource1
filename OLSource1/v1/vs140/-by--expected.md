---
title: "&#39;By&#39; expected"
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
  - "vbc36605"
  - "bc36605"
helpviewer_keywords: 
  - "BC36605"
ms.assetid: d0397b6e-bfc2-400c-92fc-efe82036cfdb
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;By&#39; expected
An `Order By` or `Group By` clause has been specified without the `By` keyword.  
  
 **Error ID:** BC36605  
  
### To correct this error  
  
1.  Add the `By` keyword to the `Order By` or `Group By` clause. The following is an example:  
  
    ```vb#  
    Dim customersByCountry = From cust In customers _  
                             Order By cust.Country, cust.City _  
                             Group By CountryName = cust.Country _  
                             Into RegionalCustomers = Group, Count() _  
                             Order By CountryName  
    ```  
  
## See Also  
 [How To: Sort a Collection by Using LINQ (Visual Basic)](../vs140/how-to--sort-query-results-by-using-linq--visual-basic-.md)   
 [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md)   
 [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)