---
title: "IEEVisualizerServiceProvider::CreateVisualizerService"
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
  - "IEEVisualizerServiceProvider::CreateVisualizerService"
helpviewer_keywords: 
  - "IEEVisualizerServiceProvider::CreateVisualizerService method"
ms.assetid: f366f7c9-358d-46c8-993f-32ff86539833
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEVisualizerServiceProvider::CreateVisualizerService
This method creates a visualizer service.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The [IDebugBinder](../vs140/idebugbinder.md) object passed to [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md) object passed to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The [IDebugAddress](../vs140/idebugaddress.md) object passed to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] An object implementing the [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md) interface (supplied by the expression evaluator).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] The created service.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters were all passed to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is to be called only from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> as part of an expression evaluator's support for type visualizers.  
  
## See Also  
 [IEEVisualizerServiceProvider](../vs140/ieevisualizerserviceprovider.md)   
 [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md)   
 [IDebugBinder](../vs140/idebugbinder.md)   
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md)