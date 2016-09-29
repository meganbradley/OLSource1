---
title: "Source Control Plug-ins"
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
  - "source control plug-ins, reference"
ms.assetid: 964980ca-21c5-4706-8535-6ea23e1c9cc9
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Source Control Plug-ins
The Source Control Plug-in SDK reference section contains the complete interface specification that enables source control systems to be integrated with [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)]. It specifies the syntax and semantics of the various functions and data types that the source control plug-in must implement to interface with the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] integrated development environment (IDE).  
  
## In This Section  
 [Source Control Plug-in API Functions](../VS_csharp/source-control-plug-in-api-functions.md)  
 Lists functions that must be implemented by the source control plug-in in order to comply with the Source Control Plug-in API.  
  
 [Callback Functions Implemented by the IDE](../VS_csharp/callback-functions-implemented-by-the-ide.md)  
 Describes functions that the source control plug-in uses to pass information back to the IDE while certain commands are executed.  
  
 [Enumerators](../VS_csharp/enumerators.md)  
 Lists the enumerator data types in the Source Control Plug-in API that the source control plug-in must know about.  
  
 [Capability Flags](../VS_csharp/capability-flags.md)  
 Describes the `SCC_CAP_xxx` flags, which are indicate a provider's capabilities.  
  
 [Bitflags Used by Specific Commands](../VS_csharp/bitflags-used-by-specific-commands.md)  
 Lists flags that are useful in the context of particular commands.  
  
 [Error Codes](../VS_csharp/error-codes.md)  
 Lists common error values returned by functions as `SCCTRN`.  
  
 [Strings Used as Keys for Finding a Source Control Plug-in](../VS_csharp/strings-used-as-keys-for-finding-a-source-control-plug-in.md)  
 Describes keys for accessing the registry to find the source control plug-in.  
  
 [MSSCCPRJ.SCC File](../VS_csharp/mssccprj.scc-file.md)  
 Describes a client-side file that contains information opaque to the IDE, but that is used by the source control plug-in to locate the solution or project in version control.  
  
 [Best Practices for Implementing a Source Control Plug-in](../VS_csharp/best-practices-for-implementing-a-source-control-plug-in.md)  
 Provides a collection of important technical reminders to remember while you are implementing the Source Control Plug-in API.  
  
 [Restrictions on String Lengths](../VS_csharp/restrictions-on-string-lengths.md)  
 Describes limitations in the Source Control Plug-in API on the lengths of strings used in various functions.  
  
 [Glossary](../VS_csharp/source-control-plug-in-glossary.md)  
 Provides helpful terms and their definitions for reading the Source Control Plug-in SDK documentation.  
  
 [How to: Turn Off Compatibility Warnings for Source Control Plug-ins](../VS_csharp/how-to--turn-off-compatibility-warnings-for-source-control-plug-ins.md)  
 Describes how to disable warnings.  
  
## Related Sections  
 [Source Control Plug-in Sample](assetId:///61de7d2b-71db-451e-8e3e-d41b11c7a4ca)  
 Provides a sample of source control plug-in functionality.  
  
 [Test Guide for Source Control Plug-ins](../VS_csharp/test-guide-for-source-control-plug-ins.md)  
 Describes testing procedures related to a source control plug-in.  
  
 [Creating a Source Control Plug-in](../VS_csharp/creating-a-source-control-plug-in.md)  
 Discusses how to create a source control plug-in that supplies source control functionality while you are using the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] source control user interface (UI).  
  
 [Visual Studio SDK Reference](../VS_csharp/visual-studio-sdk-reference.md)  
 Presents a list of reference topics.