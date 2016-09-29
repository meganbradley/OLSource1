---
title: "Declared Element Characteristics (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
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
  - "declared elements, lifetime"
  - "access levels, declared elements"
  - "declared elements, scope"
  - "visibility, declared elements"
  - "elements, programming"
  - "scope, declared elements"
  - "lifetime, declared elements"
  - "declared elements, access level"
  - "data types [Visual Basic], declared elements"
  - "declared elements, visibility"
ms.assetid: 1bc40fb8-b67c-4428-90a4-76b630ae2583
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Declared Element Characteristics (Visual Basic)
A *characteristic* of a declared element is an aspect of that element that affects how code can interact with it. Every declared element has one or more of the following characteristics associated with it:  
  
-   *Data type* — the values the element can hold, and how it stores those values. For more information, see [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md).  
  
-   *Lifetime* — the period of execution time during which the element is available for use. For more information, see [Lifetime in Visual Basic](../vs140/lifetime-in-visual-basic.md).  
  
-   *Scope* — the set of all code that can refer to the element without qualifying its name. For more information, see [How to: Control the Scope of a Variable](../vs140/how-to--control-the-scope-of-a-variable--visual-basic-.md).  
  
-   *Access level* — the permission for code to make use of the element. For more information, see [How to: Control the Availability of a Variable](../vs140/how-to--control-the-availability-of-a-variable--visual-basic-.md).  
  
## Characteristics of the Elements  
 The following table shows the declared elements and the characteristics that apply to each one.  
  
|Element|Data Type|Lifetime|Scope <sup>1</sup>|Access Level|  
|-------------|---------------|--------------|------------------------|------------------|  
|Variable|Yes|Yes|Yes|Yes|  
|Constant|Yes|No|Yes|Yes|  
|Enumeration|Yes|No|Yes|Yes|  
|Structure|No|No|Yes|Yes|  
|Property|Yes|Yes|Yes|Yes|  
|Method|No|Yes|Yes|Yes|  
|Procedure (`Sub` or `Function`)|No|Yes|Yes|Yes|  
|Procedure parameter|Yes|Yes|Yes|No|  
|Function return|Yes|Yes|Yes|No|  
|Operator|Yes|No|Yes|Yes|  
|Interface|No|No|Yes|Yes|  
|Class|No|No|Yes|Yes|  
|Event|No|No|Yes|Yes|  
|Delegate|No|No|Yes|Yes|  
  
 <sup>1</sup> Scope is sometimes referred to as *visibility*.  
  
## See Also  
 [Declared Elements in Visual Basic](../vs140/declared-elements-in-visual-basic.md)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)   
 [Lifetime in Visual Basic](../vs140/lifetime-in-visual-basic.md)   
 [Scope in Visual Basic](../vs140/scope-in-visual-basic.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Data Types in Visual Basic](../vs140/data-types-in-visual-basic.md)   
 [Variable Declaration in Visual Basic](../vs140/variable-declaration-in-visual-basic.md)