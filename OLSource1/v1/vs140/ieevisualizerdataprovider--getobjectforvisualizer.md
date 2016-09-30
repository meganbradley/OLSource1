---
title: "IEEVisualizerDataProvider::GetObjectForVisualizer"
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
  - "IEEVisualizerDataProvider::GetObjectForVisualizer"
helpviewer_keywords: 
  - "IEEVisualizerDataProvider::GetObjectForVisualizer method"
ms.assetid: bd5376fc-13b4-40b7-9a5d-7ba8289f1b24
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEVisualizerDataProvider::GetObjectForVisualizer
This method gets the object that this visualizer represents.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] The object being represented by this visualizer  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is allowed to return a cached version of the object. If the caller wants to make sure that the object is up to date, then it will call [IEEVisualizerDataProvider::GetNewObjectForVisualizer](../vs140/ieevisualizerdataprovider--getnewobjectforvisualizer.md).  
  
## See Also  
 [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md)   
 [IEEVisualizerDataProvider::GetNewObjectForVisualizer](../vs140/ieevisualizerdataprovider--getnewobjectforvisualizer.md)   
 [IDebugObject](../vs140/idebugobject.md)