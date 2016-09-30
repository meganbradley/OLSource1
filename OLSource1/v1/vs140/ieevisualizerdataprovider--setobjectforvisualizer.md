---
title: "IEEVisualizerDataProvider::SetObjectForVisualizer"
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
  - "IEEVisualizerDataProvider::SetObjectForVisualizer"
helpviewer_keywords: 
  - "IEEVisualizerDataProvider::SetObjectForVisualizer method"
ms.assetid: 40dad2be-57ff-4f74-9d82-c48039c125c4
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEVisualizerDataProvider::SetObjectForVisualizer
This method changes the object that the visualizer represents.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The object to set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] If there was an error setting the object, this string holds the error message.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] If there was an error, this object holds the exception information.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 It is up to the implementer to determine how error information is returned. However, it is possible that some callers may only look to see if an exception object was returned to know there was an error, so this method should always return an exception object if there was an error. The error string should also be supplied in case the caller wants to make use of it.  
  
## See Also  
 [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md)   
 [IDebugObject](../vs140/idebugobject.md)