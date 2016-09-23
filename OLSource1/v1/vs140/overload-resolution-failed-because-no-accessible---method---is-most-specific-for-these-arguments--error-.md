---
title: "Overload resolution failed because no accessible &#39;&lt;method&gt;&#39; is most specific for these arguments:&lt;error&gt;"
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
  - bc30521
  - vbc30521
helpviewer_keywords: 
  - resolution failure
  - BC30521
  - overload resolution failed
ms.assetid: b8b41fa0-a64b-4e74-8443-be3afd2b6f11
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Overload resolution failed because no accessible &#39;&lt;method&gt;&#39; is most specific for these arguments:&lt;error&gt;
You have made a call to an overloaded method, but the compiler has found two or more overloads with parameter lists to which your argument list can be converted, and it cannot select among them.  
  
 The compiler attempts to match the data types in the calling argument list and the overload parameter list as closely as possible. It requires a widening conversion from every one of your arguments to its corresponding parameter, whether the type checking switch ([Option Strict Statement](../vs140/option-strict-statement.md)) is `On` or `Off`.  
  
 If the compiler finds more than one overload satisfying the widening requirement, it then looks for the overload that is most specific for the argument data types, that is, that calls for the least amount of widening. It generates this error message when one overload is more specific for one argument's data type while another overload is more specific for another argument's data type. For more information and an example, see [Overload Resolution](../vs140/overload-resolution--visual-basic-.md).  
  
 **Error ID:** BC30521  
  
### To correct this error  
  
1.  Review all the overloads for the method and determine which one you want to call.  
  
2.  In your calling statement, make the data types of the arguments match the data types of the parameters defined for the desired overload. You might have to use the [CType Function](../vs140/ctype-function--visual-basic-.md) to convert one or more data types to the defined types.  
  
## See Also  
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Considerations in Overloading Procedures](../vs140/considerations-in-overloading-procedures--visual-basic-.md)   
 [Overload Resolution](../vs140/overload-resolution--visual-basic-.md)   
 [Overloads](../vs140/overloads--visual-basic-.md)   
 [Overloaded Properties and Methods](../vs140/overloaded-properties-and-methods--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [CType Function](../vs140/ctype-function--visual-basic-.md)