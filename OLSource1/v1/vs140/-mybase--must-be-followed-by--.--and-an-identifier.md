---
title: "&#39;MyBase&#39; must be followed by &#39;.&#39; and an identifier"
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
  - "bc32027"
  - "vbc32027"
helpviewer_keywords: 
  - "BC32027"
ms.assetid: 39e5512c-ef1e-46a3-a96c-277ea24bfee2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;MyBase&#39; must be followed by &#39;.&#39; and an identifier
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is not a true object variable, and it cannot appear alone. You use it only to access a member of the base class of the current instance.  
  
 **Error ID:** BC32027  
  
### To correct this error  
  
-   If you intend member access, specify the member access operator (.) and a member of the base class after <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
-   If you do not intend member access, declare and initialize an instance of the base class, or remove the reference to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## See Also  
 [MyBase - delete](assetId:///52491d06-6451-4f6f-9aa6-8fab59bbc2b9)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)