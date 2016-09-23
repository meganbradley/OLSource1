---
title: "&#39;=&#39; expected (object initializer)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc30984
  - bc30984
helpviewer_keywords: 
  - BC30984
ms.assetid: 9cae8d32-775a-414f-9e51-0469974b6aab
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;=&#39; expected (object initializer)
To establish the initial value for a field or property in an object initializer declaration, you must use an equal sign. For example, the following declaration assigns "Microsoft" as the initial value for the `Name` property of `client`.  
  
```  
Dim client As New Customer { .Name = "Microsoft" }  
```  
  
 **Error ID:** BC30984  
  
### To correct this error  
  
-   Add an equal sign in the position shown in the previous example.  
  
## See Also  
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [NOT IN BUILD: Properties and Property Procedures](assetId:///23e2a1ec-7e9d-4109-8940-c703d981077b)   
 [NOT IN BUILD: Property Procedures vs. Fields](assetId:///da1c05c1-87c7-40fa-b92c-e9c7e4d170f7)