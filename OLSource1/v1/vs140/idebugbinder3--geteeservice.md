---
title: "IDebugBinder3::GetEEService"
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
  - "IDebugBinder3::GetEEService"
helpviewer_keywords: 
  - "IDebugBinder3::GetEEService method"
ms.assetid: eb07aa40-8cd9-4a52-a4c7-4affd2307a01
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder3::GetEEService
This method returns a requested service.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of a vendor (a null value is acceptable).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of a language (a null value is acceptable).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of the service to obtain.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] An interface to the requested service.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Pass the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for the [IEEVisualizerServiceProvider](../vs140/ieevisualizerserviceprovider.md) interface (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) to see if the Type Visualizer service is available. If so, the expression evaluator can obtain the [IEEVisualizerService](../vs140/ieevisualizerservice.md) interface to support type visualizers. See [Visualizing and Viewing Data](../vs140/visualizing-and-viewing-data.md) for details.  
  
## See Also  
 [IDebugBinder3](../vs140/idebugbinder3.md)   
 [IEEVisualizerServiceProvider](../vs140/ieevisualizerserviceprovider.md)   
 [IEEVisualizerService](../vs140/ieevisualizerservice.md)   
 [Visualizing and Viewing Data](../vs140/visualizing-and-viewing-data.md)