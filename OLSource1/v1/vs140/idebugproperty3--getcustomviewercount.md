---
title: "IDebugProperty3::GetCustomViewerCount"
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
  - "IDebugProperty3::GetCustomViewerCount"
helpviewer_keywords: 
  - "IDebugProperty3::GetCustomViewerCount"
ms.assetid: dc5bb3e4-dc85-46e4-98fa-c6be8583b985
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty3::GetCustomViewerCount
Gets the number of custom viewers that might be available for this property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] The number of custom viewers available for this property.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 In order to support type visualizers, this method forwards the call to the [IEEVisualizerService::GetCustomViewerCount](../vs140/ieevisualizerservice--getcustomviewercount.md) method. If the expression evaluator also supports custom viewers for this property's type, this method adds the number of custom viewers to the returned value.  
  
 For detailed information about the differences between type visualizers and custom viewers, see [Type Visualizer and Custom Viewer](../vs140/type-visualizer-and-custom-viewer.md).  
  
## Example  
 The following example shows how to implement this method for a **CProperty** object that exposes the [IDebugProperty3](../vs140/idebugproperty3.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugProperty3](../vs140/idebugproperty3.md)   
 [IEEVisualizerService::GetCustomViewerCount](../vs140/ieevisualizerservice--getcustomviewercount.md)   
 [Type Visualizer and Custom Viewer](../vs140/type-visualizer-and-custom-viewer.md)