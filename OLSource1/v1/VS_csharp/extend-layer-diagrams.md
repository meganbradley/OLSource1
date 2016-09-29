---
title: "Extend layer diagrams"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-techdebt"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "layer diagrams, creating extensions"
  - "layer models"
ms.assetid: 83fca301-b008-485a-87eb-218050e71451
caps.latest.revision: 43
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extend layer diagrams
You can write code to create and update layer diagrams, and to validate the structure of your program code against layer diagrams in Visual Studio. You can add commands that appear in the shortcut (context) menu of the diagrams, customize drag-and-drop gestures, and access the layer model from text templates. You can package these extensions into a Visual Studio Integration Extension (VSIX) and distribute them to other Visual Studio users.  
  
 For more information about layer diagrams, see:  
  
-   [Layer Diagrams: Reference](../VS_csharp/layer-diagrams--reference.md)  
  
-   [Layer Diagrams: Guidelines](../VS_csharp/layer-diagrams--guidelines.md)  
  
-   [How to Create Layer Diagrams from Artifacts](../VS_csharp/create-layer-diagrams-from-your-code.md)  
  
-   [How to Validate Code against Layer Diagrams](../VS_csharp/validate-code-with-layer-diagrams.md)  
  
##  <a name="prereqs"></a> Requirements  
 You must have the following installed on the computer where you want to develop your layer extensions:  
  
-   Visual Studio  
  
-   [Visual Studio SDK](../VS_csharp/visual-studio-sdk.md)  
  
-   [Modeling SDK for Visual Studio 2015](http://www.microsoft.com/download/details.aspx?id=48148)  
  
 You must have a suitable version of Visual Studio installed on the computer where you want to run your layer extensions. For more information, see [Deploying a Layer Modeling Extension](../VS_csharp/deploy-a-layer-model-extension.md).  
  
 To see which versions of Visual Studio support layer diagrams, see [Version support for architecture and modeling tools](../VS_csharp/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
## In This Section  
 [Adding Commands and Gestures to Layer Diagrams](../VS_csharp/add-commands-and-gestures-to-layer-diagrams.md)  
  
 [Adding Custom Architecture Validation to Layer Diagrams](../VS_csharp/add-custom-architecture-validation-to-layer-diagrams.md)  
  
 [Adding Custom Properties to a Layer Diagram](../VS_csharp/add-custom-properties-to-layer-diagrams.md)  
  
 [Navigating and Updating Layer Models in Program Code](../VS_csharp/navigate-and-update-layer-models-in-program-code.md)  
  
 [Deploying a Layer Modeling Extension](../VS_csharp/deploy-a-layer-model-extension.md)  
  
 [Troubleshooting Extensions for Layer Diagrams](../VS_csharp/troubleshoot-extensions-for-layer-diagrams.md)  
  
## See Also  
 [How to Define and Install a Modeling Extension](../VS_csharp/define-and-install-a-modeling-extension.md)   
 [Layer Diagrams: Reference](../VS_csharp/layer-diagrams--reference.md)   
 [Layer Diagrams: Guidelines](../VS_csharp/layer-diagrams--guidelines.md)   
 [How to Create Layer Diagrams from Artifacts](../VS_csharp/create-layer-diagrams-from-your-code.md)   
 [How to Validate Code against Layer Diagrams](../VS_csharp/validate-code-with-layer-diagrams.md)   
 [How to Generate Files from a UML Model](../VS_csharp/generate-files-from-a-uml-model.md)   
 [How to Read a UML Model in Program Code](../VS_csharp/open-a-uml-model-by-using-the-visual-studio-api.md)