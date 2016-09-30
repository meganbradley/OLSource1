---
title: "numeric_limits::has_denorm_loss"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.numeric_limits.has_denorm_loss"
  - "limits/std::numeric_limits::has_denorm_loss"
  - "numeric_limits.has_denorm_loss"
  - "numeric_limits::has_denorm_loss"
  - "std::numeric_limits::has_denorm_loss"
  - "has_denorm_loss"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_denorm_loss method"
ms.assetid: d71cfa6c-e830-4c69-8d5a-e299d6ad1394
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::has_denorm_loss
Tests whether loss of accuracy is detected as a denormalization loss rather than as an inexact result.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 **true** if the loss of accuracy is detected as a denormalization loss; **false** if not.  
  
## Remarks  
 The member stores true for a type that determines whether a value has lost accuracy because it is delivered as a denormalized result (too small to represent as a normalized value) or because it is inexact (not the same as a result not subject to limitations of exponent range and precision), an option with IEC 559 floating-point representations that can affect some results.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Whether float objects can detect denormalized loss: 1**  
**Whether double objects can detect denormalized loss: 1**  
**Whether long int objects can detect denormalized loss: 0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)