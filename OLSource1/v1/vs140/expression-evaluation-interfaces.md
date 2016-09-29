---
title: "Expression Evaluation Interfaces"
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
  - "expression evaluation, interfaces"
ms.assetid: 2d259f60-2cd7-460e-b02d-24a8fb202850
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Expression Evaluation Interfaces
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 The following are the Expression Evaluation Interfaces for the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Debugging SDK.  
  
## Discussion  
 These interfaces are used to evaluate expressions in a call stack during break mode. They are implemented only for common language run-time expression evaluators (EE).  
  
 Each interface in the table shows the component that can implement it from the following list:  
  
-   Debug Engine (DE)  
  
-   Expression Evaluator (EE)  
  
-   Visual Studio (VS)  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugAlias](../vs140/idebugalias.md)|EE|Represents a numeric alias for a variable.|  
|[IDebugAlias2](../vs140/idebugalias2.md)|EE|Represents a numeric alias for a variable, and enables an expression evaluator (EE) to obtain the application domain for the alias.|  
|[IDebugArrayObject](../vs140/idebugarrayobject.md)|EE|Represents an array object.|  
|[IDebugArrayObject2](../vs140/idebugarrayobject2.md)|EE|Represents a managed array object, and allows an expression evaluator (EE) to determine the base index (lower bounds) for the array.|  
|[IDebugBinder](../vs140/idebugbinder.md)|DE|Represents a binder that binds debug symbols to actual addresses in memory.|  
|[IDebugBinder3](../vs140/idebugbinder3.md)|DE|Same as the [IDebugBinder](../vs140/idebugbinder.md) interface but provides access to types, aliases, and custom visualizers.|  
|[IDebugExpressionEvaluator](../vs140/idebugexpressionevaluator.md)|EE|Represents the expression evaluator.|  
|[IDebugExpressionEvaluator2](../vs140/idebugexpressionevaluator2.md)|EE|Represents an enhanced version of an expression evaluator (EE).|  
|[IDebugExpressionEvaluator3](../vs140/idebugexpressionevaluator3.md)|EE|Represents an expression evaluator (EE) with an enhanced parser tree.|  
|[IDebugFunctionObject](../vs140/idebugfunctionobject.md)|EE|Represents a function.|  
|[IDebugFunctionObject2](../vs140/idebugfunctionobject2.md)|EE|Represents a function and enhances the [IDebugFunctionObject](../vs140/idebugfunctionobject.md) interface.|  
|[IDebugIDECallback](../vs140/idebugidecallback.md)|DE|Enables an expression evaluator (EE) to display a message in the debugger's output window.|  
|[IDebugManagedObject](../vs140/idebugmanagedobject.md)|EE|Represents a managed code object.|  
|[IDebugObject](../vs140/idebugobject.md)|EE|Base interface that represents any symbol bound to a memory address.|  
|[IDebugObject2](../vs140/idebugobject2.md)|EE|Same as the [IDebugObject](../vs140/idebugobject.md) interface but provides access to additional information.|  
|[IDebugParsedExpression](../vs140/idebugparsedexpression.md)|EE|Represents a parsed expression ready to be evaluated.|  
|[IDebugPointerObject](../vs140/idebugpointerobject.md)|EE|Represents a pointer.|  
|[IDebugPointerObject3](../vs140/idebugpointerobject3.md)|EE|Represents a pointer in a parse tree, and extends the **IDebugPointerObject** interface.|  
|[IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md)|EE|Provides the ability to modify a type's value through a type visualizer.|  
|[IEEVisualizerService](../vs140/ieevisualizerservice.md)|VS|Provides access to custom viewers and type visualizers.|  
|[IEEVisualizerServiceProvider](../vs140/ieevisualizerserviceprovider.md)|VS|Provides the ability to create an [IEEVisualizerService](../vs140/ieevisualizerservice.md) object.|  
|[IEnumDebugObjects](../vs140/ienumdebugobjects.md)|EE|Represents a collection of [IDebugObject](../vs140/idebugobject.md) objects.|  
  
## See Also  
 [API Reference](../vs140/api-reference--visual-studio-debugging-.md)   
 [Writing a CLR Expression Evaluator](../vs140/writing-a-common-language-runtime-expression-evaluator.md)   
 [Type Visualizer and Custom Viewer](../vs140/type-visualizer-and-custom-viewer.md)