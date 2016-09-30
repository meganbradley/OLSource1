---
title: "IEEVisualizerDataProvider::CanSetObjectForVisualizer"
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
  - "IEEVisualizerDataProvider::CanSetObjectForVisualizer"
helpviewer_keywords: 
  - "IEEVisualizerDataProvider::CanSetObjectForVisualizer method"
ms.assetid: 70fd3c6f-2f82-43a3-993b-c1dc8aa080bf
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEVisualizerDataProvider::CanSetObjectForVisualizer
This method determines whether the visualizer can have the data object it represents updated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Nonzero (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if the object on the visualizer can be updated, zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) if it cannot.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 An object might not be changeable if it is bound to read-only memory, for example.  
  
## See Also  
 [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md)