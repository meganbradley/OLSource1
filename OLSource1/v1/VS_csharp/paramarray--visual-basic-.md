---
title: "ParamArray (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.ParamArray"
  - "ParamArray"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "ParamArray keyword"
  - "ParamArray keyword, syntax"
ms.assetid: a5f18789-92bd-488f-9c7e-cf3719963635
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ParamArray (Visual Basic)
Specifies that a procedure parameter takes an optional array of elements of the specified type. `ParamArray` can be used only on the last parameter of a parameter list.  
  
## Remarks  
 `ParamArray` allows you to pass an arbitrary number of arguments to the procedure. A `ParamArray` parameter is always declared using [ByVal](../VS_csharp/byval--visual-basic-.md).  
  
 You can supply one or more arguments to a `ParamArray` parameter by passing an array of the appropriate data type, a comma-separated list of values, or nothing at all. For details, see "Calling a ParamArray" in [Parameter Arrays](../VS_csharp/parameter-arrays--visual-basic-.md).  
  
> [!IMPORTANT]
>  Whenever you deal with an array which can be indefinitely large, there is a risk of overrunning some internal capacity of your application. If you accept a parameter array from the calling code, you should test its length and take appropriate steps if it is too large for your application.  
  
 The `ParamArray` modifier can be used in these contexts:  
  
 [Declare Statement](../VS_csharp/declare-statement.md)  
  
 [Function Statement](../VS_csharp/function-statement--visual-basic-.md)  
  
 [Property Statement](../VS_csharp/property-statement.md)  
  
 [Sub Statement](../VS_csharp/sub-statement--visual-basic-.md)  
  
## See Also  
 [Keywords (Visual Basic)](../VS_csharp/keywords--visual-basic-.md)   
 [Parameter Arrays](../VS_csharp/parameter-arrays--visual-basic-.md)