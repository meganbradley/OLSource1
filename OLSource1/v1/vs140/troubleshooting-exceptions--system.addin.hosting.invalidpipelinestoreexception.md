---
title: "Troubleshooting Exceptions: System.AddIn.Hosting.InvalidPipelineStoreException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "InvalidPipelineStoreException exception"
  - "System.AddIn.Hosting.InvalidPipelineStoreException exception"
ms.assetid: d12556bc-5cfd-481c-a27b-46ee2571e646
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.AddIn.Hosting.InvalidPipelineStoreException
The <xref:System.AddIn.Hosting.InvalidPipelineStoreException*> exception is thrown when a directory is not found and the user does not have permission to access the pipeline root path or an add-in path.  
  
## Remarks  
 Unlike <xref:System.IO.DirectoryNotFoundException*>, this exception does not provide any path information. This prevents a malicious user from deliberately specifying erroneous paths and using the information returned by the exception to determine actual paths.  
  
 The exception is thrown by the following discovery methods that build and update the store of add-in and pipeline information: [FindAddIns](assetId:///M:System.AddIn.Hosting.AddInStore.FindAddIns(System.Type,System.String,System.String[])?qualifyHint=False&autoUpgrade=True),[Rebuild](assetId:///M:System.AddIn.Hosting.AddInStore.Rebuild(System.String)?qualifyHint=False&autoUpgrade=True), [RebuildAddIns](assetId:///M:System.AddIn.Hosting.AddInStore.RebuildAddIns(System.String)?qualifyHint=False&autoUpgrade=True), [Update](assetId:///M:System.AddIn.Hosting.AddInStore.Update(System.String)?qualifyHint=False&autoUpgrade=True), and [UpdateAddIns](assetId:///M:System.AddIn.Hosting.AddInStore.UpdateAddIns(System.String)?qualifyHint=False&autoUpgrade=True).  
  
## See Also  
 <xref:System.AddIn.Hosting.InvalidPipelineStoreException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)