---
title: "Covariance and Contravariance (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 59224c46-9931-466b-8c6e-3648c3e609c6
caps.latest.revision: 5
---
# Covariance and Contravariance (Visual Basic)
In Visual Basic, covariance and contravariance enable implicit reference conversion for array types, delegate types, and generic type arguments. Covariance preserves assignment compatibility and contravariance reverses it.  
  
 The following code demonstrates the difference between assignment compatibility, covariance, and contravariance.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Covariance for arrays enables implicit conversion of an array of a more derived type to an array of a less derived type. But this operation is not type safe, as shown in the following code example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Covariance and contravariance support for method groups allows for matching method signatures with delegate types. This enables you to assign to delegates not only methods that have matching signatures, but also methods that return more derived types (covariance) or that accept parameters that have less derived types (contravariance) than that specified by the delegate type. For more information, see [Variance in Delegates (Visual Basic)](../vs140/variance-in-delegates--visual-basic-.md) and [Using Variance in Delegates (Visual Basic)](../vs140/using-variance-in-delegates--visual-basic-.md).  
  
 The following code example shows covariance and contravariance support for method groups.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In .NET Framework 4 or later Visual Basic support covariance and contravariance in generic interfaces and delegates and allow for implicit conversion of generic type parameters. For more information, see [Variance in Generic Interfaces (Visual Basic)](../vs140/variance-in-generic-interfaces--visual-basic-.md) and [Variance in Delegates (Visual Basic)](../vs140/variance-in-delegates--visual-basic-.md).  
  
 The following code example shows implicit reference conversion for generic interfaces.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A generic interface or delegate is called *variant* if its generic parameters are declared covariant or contravariant. Visual Basic enables you to create your own variant interfaces and delegates. For more information, see [Creating Variant Generic Interfaces (Visual Basic)](../vs140/creating-variant-generic-interfaces--visual-basic-.md) and [Variance in Delegates (Visual Basic)](../vs140/variance-in-delegates--visual-basic-.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Variance in Generic Interfaces (Visual Basic)](../vs140/variance-in-generic-interfaces--visual-basic-.md)|Discusses covariance and contravariance in generic interfaces and provides a list of variant generic interfaces in the .NET Framework.|  
|[Creating Variant Generic Interfaces (Visual Basic)](../vs140/creating-variant-generic-interfaces--visual-basic-.md)|Shows how to create custom variant interfaces.|  
|[Using Variance in Interfaces for Generic Collections (Visual Basic)](../vs140/using-variance-in-interfaces-for-generic-collections--visual-basic-.md)|Shows how covariance and contravariance support in the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> interfaces can help you reuse code.|  
|[Variance in Delegates (Visual Basic)](../vs140/variance-in-delegates--visual-basic-.md)|Discusses covariance and contravariance in generic and non-generic delegates and provides a list of variant generic delegates in the .NET Framework.|  
|[Using Variance in Delegates (Visual Basic)](../vs140/using-variance-in-delegates--visual-basic-.md)|Shows how to use covariance and contravariance support in non-generic delegates to match method signatures with delegate types.|  
|[Using Variance for Func and Action Generic Delegates (Visual Basic)](../vs140/using-variance-for-func-and-action-generic-delegates--visual-basic-.md)|Shows how covariance and contravariance support in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> delegates can help you reuse code.|