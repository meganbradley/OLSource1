---
title: "Getting Local Values"
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
  - "expression evaluation, local values"
  - "debugging [Debugging SDK], local values"
  - "expression evaluation, getting local values"
ms.assetid: a10b0764-65ac-476f-bf42-b4a9c38e20de
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Getting Local Values
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 To obtain the value of a local, Visual Studio calls [IDebugProperty2::GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md) for that local. In this implementation, the class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> implements the IDebugProperty2 interface for each local.  
  
 This implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> performs the following tasks:  
  
1.  Obtains the local's name, property, and attributes from the [FIELD_INFO](../vs140/field_info.md) structure filled in when the class was instantiated and initialized.  
  
2.  Obtains the local's type from the [IDebugField](../vs140/idebugfield.md) object.  
  
3.  Obtains the local's value from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. This field is bound to the memory location of the local using the [IDebugBinder](../vs140/idebugbinder.md) object and the value is obtained from the resulting [IDebugObject](../vs140/idebugobject.md) object.  
  
4.  Returns all requested properties in a [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structure.  
  
## Managed Code  
 This example shows an implementation of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for a method's local in managed code. It also shows a helper function, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, that is used to get the field's type. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is shown in [Evaluating Locals](../vs140/evaluating-locals.md). The helper function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (not shown) simply converts a field's [FIELD_MODIFIERS](../vs140/field_modifiers.md) flags to [DBG_ATTRIB_FLAGS](../vs140/dbg_attrib_flags.md) values.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code  
 This example shows an implementation of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for a method's local in unmanaged code. It also shows two helper functions, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that are used to get the field's type and value, respectively. Note that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>s are used for the field's value and type as a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can handle a wide variety of value types. In this implementation, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns an [IDebugField](../vs140/idebugfield.md) object that is later converted to a value in a call to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (which is shown in [Evaluating Locals](../vs140/evaluating-locals.md)).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Sample Implementation of Locals](../vs140/sample-implementation-of-locals.md)   
 [Getting Local Properties](../vs140/getting-local-properties.md)   
 [Evaluation Context](../vs140/evaluation-context.md)