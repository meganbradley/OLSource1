---
title: "Walkthrough: Accessing the DTE Object from an Editor Extension"
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
  - "editors [Visual Studio SDK], new - getting the DTE object"
ms.assetid: c1f40bab-c6ec-45b0-8333-ea5ceb02a39d
caps.latest.revision: 26
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Accessing the DTE Object from an Editor Extension
In VSPackages, you can get the DTE object by calling the [GetService](assetId:///M:Microsoft.VisualStudio.Shell.Package.GetService(System.Type)?qualifyHint=False&autoUpgrade=True) method with the type of the DTE object. In Managed Extensibility Framework (MEF) extensions, you can import <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider*> and then call the [GetService](assetId:///M:Microsoft.VisualStudio.Shell.ServiceProvider.GetService(System.Type)?qualifyHint=False&autoUpgrade=True) method with a type of <xref:EnvDTE.DTE*>.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio Software Development Kit (SDK)](../vs140/visual-studio-sdk.md).  
  
## Getting the DTE Object  
  
#### To get the DTE object from the ServiceProvider  
  
1.  Create a C# VSIX project named `DTETest`. Add an Editor Classifier item template and name it `DTETest`. For more information, see [Creating an Extension with an Editor Item Template](../vs140/creating-an-extension-with-an-editor-item-template.md).  
  
2.  Add the following assembly references to the project:  
  
    -   EnvDTE  
  
    -   EnvDTE80  
  
    -   Microsoft.VisualStudio.Shell.Immutable.10.0  
  
3.  Go to the DTETest.cs file, and add the following `using` directives:  
  
    ```c#  
    using EnvDTE;  
    using EnvDTE80;  
    using Microsoft.VisualStudio.Shell;  
  
    ```  
  
4.  In the `GetDTEProvider` class, import a <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider*>.  
  
    ```c#  
    [Import]  
    internal SVsServiceProvider ServiceProvider = null;  
  
    ```  
  
5.  In the `GetClassifier()` method, add the following code.  
  
    ```c#  
    DTE dte = (DTE)ServiceProvider.GetService(typeof(DTE));  
  
    ```  
  
6.  If you have to use the <xref:EnvDTE80.DTE2*> interface, you can cast the DTE object to it.  
  
## See Also  
 [Editor Extension Points](../vs140/language-service-and-editor-extension-points.md)