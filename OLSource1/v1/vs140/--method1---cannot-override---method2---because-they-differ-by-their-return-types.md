---
title: "&#39;&lt;method1&gt;&#39; cannot override &#39;&lt;method2&gt;&#39; because they differ by their return types"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30437"
  - "vbc30437"
helpviewer_keywords: 
  - "BC30437"
ms.assetid: e566ae72-c597-4b33-b70d-5d4ea879d644
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;method1&gt;&#39; cannot override &#39;&lt;method2&gt;&#39; because they differ by their return types
You have attempted to override a method with another method that differs by its return type. A type may override an inherited overridable method by declaring a method with the same name and signature, and marking the declaration with the `Overrides` modifier. The signatures of the two methods must match.  
  
 **Error ID:** BC30437  
  
### To correct this error  
  
-   Check the return types of the two methods and change them as necessary to match.  
  
## See Also  
 [NOT IN BUILD: Overriding Properties and Methods](assetId:///2167e8f5-1225-4b13-9ebd-02591ba90213)