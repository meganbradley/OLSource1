---
title: "Starting a Build from within the IDE"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "build"
ms.assetid: 936317aa-63b7-4eb0-b9db-b260a0306196
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Starting a Build from within the IDE
Custom project systems must use \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildManagerAccessor*> to start builds. This topic describes the reasons for this and outlines the procedure.  
  
## Parallel Builds and Threads  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] allows parallel builds which requires mediation for access to common resources. Project systems can run builds asynchronously, but such systems must not call build functions from within call backs is provided to the build manager.  
  
 If the project system modifies environment variables, it must set the NodeAffinity of the build to OutOfProc. This means that you cannot use host objects, since they require the in-proc node.  
  
## Using IVSBuildManagerAccessor  
 The code below outlines a method that a project system can use to start a build:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>