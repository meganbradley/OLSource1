---
title: "&#39;&lt;name1&gt;&#39; for the Imports &#39;&lt;name2&gt;&#39; does not refer to a Namespace, Class, Structure, Enum or Module"
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
  - vbc30467
  - bc30467
helpviewer_keywords: 
  - BC30467
ms.assetid: a4b8a23b-ba1b-44f7-9584-258dd2607581
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;&lt;name1&gt;&#39; for the Imports &#39;&lt;name2&gt;&#39; does not refer to a Namespace, Class, Structure, Enum or Module
You have attempted to use the `Imports` statement on something that is not a `Namespace`, `Class`, `Structure`, `Enum`, or `Module`. The `Imports` statement imports namespace names from referenced projects and assemblies, or it imports namespace names defined within the same project as the module in which the statement appears.  
  
 **Error ID:** BC30467  
  
### To correct this error  
  
-   Check the entity that you are trying to import, and make sure it is valid for use with an `Imports` statement.  
  
## See Also  
 [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md)   
 [References and the Imports Statement](../vs140/references-and-the-imports-statement--visual-basic-.md)   
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](assetId:///3bd75d61-f00c-47c0-86a2-dd1f20e231c9)