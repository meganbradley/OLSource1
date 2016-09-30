---
title: "IDebugProperty3::GetCustomViewerList"
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
  - "IDebugProperty3::GetCustomViewerList"
helpviewer_keywords: 
  - "IDebugProperty3::GetCustomViewerList"
ms.assetid: 74490fd8-6f44-4618-beea-dab64961bb8a
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty3::GetCustomViewerList
Gets a list of custom viewers associated with this property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of viewers to skip over.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The number of viewers to retrieve (also specifies the size of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in, out] Array of [DEBUG_CUSTOM_VIEWER](../vs140/debug_custom_viewer.md) structures to be filled in.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] The actual number of viewers returned.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 To support type visualizers, this method forwards the call to the [IEEVisualizerService::GetCustomViewerList](../vs140/ieevisualizerservice--getcustomviewerlist.md) method. If the expression evaluator also supports custom viewers for this property's type, this method can append the appropriate custom viewers to the list.  
  
 See [Type Visualizer and Custom Viewer](../vs140/type-visualizer-and-custom-viewer.md) for details on the differences between type visualizers and custom viewers.  
  
## Example  
 The following example shows how to implement this method for a **CProperty** object that exposes the [IDebugProperty3](../vs140/idebugproperty3.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugProperty3](../vs140/idebugproperty3.md)   
 [DEBUG_CUSTOM_VIEWER](../vs140/debug_custom_viewer.md)   
 [IEEVisualizerService::GetCustomViewerList](../vs140/ieevisualizerservice--getcustomviewerlist.md)   
 [Type Visualizer and Custom Viewer](../vs140/type-visualizer-and-custom-viewer.md)