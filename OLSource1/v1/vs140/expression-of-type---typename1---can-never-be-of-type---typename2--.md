---
title: "Expression of type &#39;&lt;typename1&gt;&#39; can never be of type &#39;&lt;typename2&gt;&#39;"
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
  - "vbc31430"
  - "bc31430"
helpviewer_keywords: 
  - "BC31430"
ms.assetid: 1d527033-3f6f-4945-b1d3-5ef59a1e1b53
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expression of type &#39;&lt;typename1&gt;&#39; can never be of type &#39;&lt;typename2&gt;&#39;
A `TypeOf`...`Is` expression tests an object reference variable to a data type that it cannot hold.  
  
 In some cases the compiler can determine that a `TypeOf`...`Is` test can only fail, for example if there is no inheritance relationship between two classes.  
  
 The following code can generate this error.  
  
 `Dim refVar as System.Windows.Forms.Form`  
  
 `If TypeOf refVar Is System.Array`  
  
 `End If`  
  
 Because \<xref:System.Windows.Forms.Form*> and \<xref:System.Array*> are totally unrelated types, the compiler can determine that the `TypeOf`...`Is` expression returns `False` for any value of `refVar`.  
  
 **Error ID:** BC31430  
  
### To correct this error  
  
-   Test the variable for a realistic data type, or remove the `TypeOf`...`Is` test altogether.  
  
## See Also  
 [TypeOf Operator (Visual Basic)](../vs140/typeof-operator--visual-basic-.md)   
 [How to: Determine What Type an Object Variable Refers To](../vs140/how-to--determine-what-type-an-object-variable-refers-to--visual-basic-.md)