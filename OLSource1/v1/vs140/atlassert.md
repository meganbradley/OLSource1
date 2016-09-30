---
title: "ATLASSERT"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATLASSERT"
  - "ATL.ATLASSERT"
  - "ATL::ATLASSERT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATLASSERT macro"
ms.assetid: 98e3e0fc-77e2-499b-a6f6-b17a21c6fbd3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLASSERT
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro performs the same functionality as the [_ASSERTE](../vs140/_assert--_asserte--_assert_expr-macros.md) macro found in the C run-time library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Expression (including pointers) that evaluates to nonzero or 0.  
  
## Remarks  
 In debug builds, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> evaluates <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and generates a debug report when the result is false.  
  
## Requirements  
 **Header:** atldef.h  
  
## See Also  
 [Debugging and Error Reporting Macros](../vs140/debugging-and-error-reporting-macros.md)   
 [Macros](../vs140/atl-macros.md)