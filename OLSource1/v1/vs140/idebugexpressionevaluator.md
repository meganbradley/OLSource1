---
title: "IDebugExpressionEvaluator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugExpressionEvaluator"
helpviewer_keywords: 
  - "IDebugExpressionEvaluator interface"
ms.assetid: 0636d8c3-625a-49fa-94b6-516f22b7e1bc
caps.latest.revision: 18
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluator
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface represents the expression evaluator.  
  
## Syntax  
  
```  
IDebugExpressionEvaluator : IUnknown  
```  
  
## Notes for Implementers  
 The expression evaluator must implement this interface.  
  
## Notes for Callers  
 To obtain this interface, instantiate the expression evaluator through the `CoCreateInstance` method by using the class ID (CLSID) of the evaluator. See the Example.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugExpressionEvaluator`.  
  
|Method|Description|  
|------------|-----------------|  
|[Parse](../vs140/idebugexpressionevaluator--parse.md)|Converts an expression string to a parsed expression.|  
|[GetMethodProperty](../vs140/idebugexpressionevaluator--getmethodproperty.md)|Gets the local variables, arguments, and other properties of a method.|  
|[GetMethodLocationProperty](../vs140/idebugexpressionevaluator--getmethodlocationproperty.md)|Converts a method location and offset into a memory address.|  
|[SetLocale](../vs140/idebugexpressionevaluator--setlocale.md)|Determines which language to use to create printable results.|  
|[SetRegistryRoot](../vs140/idebugexpressionevaluator--setregistryroot.md)|Sets the registry root. Used for side-by-side debugging.|  
  
## Remarks  
 In a typical situation, the debug engine (DE) instantiates the expression evaluator (EE) as a result of a call to [IDebugExpressionContext2::ParseText](../vs140/idebugexpressioncontext2--parsetext.md). Because the DE knows the language and vendor of the EE it wants to use, the DE gets the EE's CLSID from the registry (the [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md) function, `GetEEMetric`, helps with this retrieval).  
  
 After the EE is instantiated, the DE calls [IDebugExpressionEvaluator::Parse](../vs140/idebugexpressionevaluator--parse.md) to parse the expression and store it in an [IDebugParsedExpression](../vs140/idebugparsedexpression.md) object. Later, a call to [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md) evaluates the expression.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Example  
 This example shows how to instantiate the expression evaluator given a symbol provider and an address in the source code. This example uses a function, `GetEEMetric`, from the [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md) library, dbgmetric.lib.  
  
```cpp#  
IDebugExpressionEvaluator GetExpressionEvaluator(IDebugSymbolProvider pSymbolProvider,  
                                                 IDebugAddress *pSourceAddress)  
{  
    // This is typically defined globally but is specified here just  
    // for this example.  
    static const WCHAR strRegistrationRoot[] = L"Software\\Microsoft\\VisualStudio\\8.0Exp";  
  
    IDebugExpressionEvaluator *pEE = NULL;  
    if (pSymbolProvider != NULL && pSourceAddress != NULL) {  
        HRESULT hr         = S_OK;  
        GUID  languageGuid = { 0 };  
        GUID  vendorGuid   = { 0 };  
  
        hr = pSymbolProvider->GetLanguage(pSourceAddress,  
                                          &languageGuid,  
                                          &vendorGuid);  
        if (SUCCEEDED(hr)) {  
            CLSID clsidEE      = { 0 };  
            CComPtr<IDebugExpressionEvaluator> spExpressionEvaluator;  
            // Get the expression evaluator's CLSID from the registry.  
            ::GetEEMetric(languageGuid,  
                          vendorGuid,  
                          metricCLSID,  
                          &clsidEE,  
                          strRegistrationRoot);  
            if (!IsEqualGUID(clsidEE,GUID_NULL)) {  
                // Instantiate the expression evaluator.  
                spExpressionEvaluator.CoCreateInstance(clsidEE);  
            }  
            if (spExpressionEvaluator != NULL) {  
                pEE = spExpressionEvaluator.Detach();  
            }  
        }  
    }  
    return pEE;  
}  
```  
  
## See Also  
 [Expression Evaluation Interfaces](../vs140/expression-evaluation-interfaces.md)   
 [IDebugExpressionContext2::ParseText](../vs140/idebugexpressioncontext2--parsetext.md)   
 [IDebugParsedExpression](../vs140/idebugparsedexpression.md)   
 [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md)   
 [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md)