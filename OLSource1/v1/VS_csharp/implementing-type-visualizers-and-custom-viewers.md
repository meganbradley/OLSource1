---
title: "Implementing Type Visualizers and Custom Viewers"
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
  - "debugging [Debugging SDK], custom viewer"
  - "debugging [Debugging SDK], type visualizer"
ms.assetid: abef18c0-8272-4451-b82a-b4624edaba7d
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Implementing Type Visualizers and Custom Viewers
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Type visualizers and custom viewers allow a user to view data of a particular type in a way that is more meaningful than a simple hexadecimal dump of numbers. An expression evaluator (EE) can associate custom viewers with specific types of data or variables. These custom viewers are implemented by the EE. The EE can also support external type visualizers, which might come from another third-party vendor or even the end user.  
  
## Discussion  
  
### Type Visualizers  
 Visual Studio asks for a list of type visualizers and custom viewers for every object to be displayed in a watch window. An expression evaluator (EE) supplies such a list for every type for which it wants to support type visualizers and custom viewers. Calls to [IDebugProperty3::GetCustomViewerCount](../VS_csharp/idebugproperty3--getcustomviewercount.md) and [IDebugProperty3::GetCustomViewerList](../VS_csharp/idebugproperty3--getcustomviewerlist.md) start the whole process of accessing type visualizers and custom viewers (see [Visualizing and Viewing Data](../VS_csharp/visualizing-and-viewing-data.md) for details on the calling sequence).  
  
### Custom Viewers  
 Custom viewers are implemented in the EE for a specific data type and are represented by the [IDebugCustomViewer](../VS_csharp/idebugcustomviewer.md) interface. A custom viewer is not as flexible as a type visualizer, since it is available only when the EE that implements that particular custom viewer is executing. Implementing a custom viewer is simpler than implementing support for type visualizers. However, supporting type visualizers gives maximum flexibility to the end user for visualizing his or her data. The remainder of this discussion concerns only type visualizers.  
  
## Interfaces  
 The EE implements the following interfaces to support type visualizers, to be consumed by Visual Studio:  
  
-   [IEEVisualizerDataProvider](../VS_csharp/ieevisualizerdataprovider.md)  
  
-   [IPropertyProxyEESide](../VS_csharp/ipropertyproxyeeside.md)  
  
-   [IPropertyProxyProvider](../VS_csharp/ipropertyproxyprovider.md)  
  
-   [IEEDataStorage](../VS_csharp/ieedatastorage.md)  
  
-   [IDebugProperty3](../VS_csharp/idebugproperty3.md)  
  
-   [IDebugObject](../VS_csharp/idebugobject.md)  
  
 The EE consumes the following interfaces to support type visualizers:  
  
-   [IEEVisualizerService](../VS_csharp/ieevisualizerservice.md)  
  
-   [IEEVisualizerServiceProvider](../VS_csharp/ieevisualizerserviceprovider.md)  
  
-   [IDebugBinder3](../VS_csharp/idebugbinder3.md)  
  
## See Also  
 [Writing a Common Language Runtime Expression Evaluator](../VS_csharp/writing-a-common-language-runtime-expression-evaluator.md)   
 [Visualizing and Viewing Data](../VS_csharp/visualizing-and-viewing-data.md)   
 [IDebugCustomViewer](../VS_csharp/idebugcustomviewer.md)