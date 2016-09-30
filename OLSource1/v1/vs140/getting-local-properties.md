---
title: "Getting Local Properties"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "expression evaluation, getting local properties"
  - "debugging [Debugging SDK], local properties"
  - "expression evaluation, local properties"
ms.assetid: 6c3a79e8-1ba1-4863-97c3-0216c3d9f092
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Getting Local Properties
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Visual Studio calls [IDebugProperty2::EnumChildren](../vs140/idebugproperty2--enumchildren.md) to obtain an [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md) object that provides access to all the locals to be displayed in the **Locals** window. Visual Studio then calls [IEnumDebugPropertyInfo2::Next](../vs140/ienumdebugpropertyinfo2--next.md) to get the information to be displayed for each local. In this example, the class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> implements the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface.  
  
 This implementation of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> performs the following tasks:  
  
1.  Clears the array where the information is to be stored.  
  
2.  Calls [IEnumDebugFields::Next](../vs140/ienumdebugfields--next.md) for each local, storing the returned [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) in the array to be returned. The [IEnumDebugFields](../vs140/ienumdebugfields.md) object was supplied when this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class was instantiated.  
  
## Managed Code  
 This example shows an implementation of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for a method's locals in managed code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code  
 This example shows an implementation of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for a method's locals in unmanaged code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Sample Implementation of Locals](../vs140/sample-implementation-of-locals.md)   
 [Enumerating Locals](../vs140/enumerating-locals.md)