---
title: "Visual Studio Command Table (.Vsct) Files"
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
  - "VSCT files, overview"
  - "Visual Studio command table configuration files (VSCT), overview"
ms.assetid: 1313adb4-add4-4e74-90e2-f4be522f5259
caps.latest.revision: 26
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Visual Studio Command Table (.Vsct) Files
A command table configuration file is a text file that describes the set of commands that a VSPackage contains. The [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] command table (VSCT) compiler compiles XML-based configuration files (.vsct files) into binary command table output (.cto) files. The resultant .cto files are the same as those that are created by using the command table (CTC) compiler to compile .ctc configuration files. However, XML-based .vsct files has some advantages, such as an XML editor and XML IntelliSense.  
  
 To learn more about the syntax and semantics of .vsct files, see [Designing XML Command Table (.vsct) Files](../VS_csharp/designing-xml-command-table--.vsct--files.md)  
  
## In This Section  
 [Designing XML Command Table (.vsct) Files](../VS_csharp/designing-xml-command-table--.vsct--files.md)  
 Describes how to design .vsct files.  
  
 [How To: Create a New .vsct File](../VS_csharp/how-to--create-a-.vsct-file.md)  
 Compares the methods for creating a .vsct file. Describes the process for manually creating a new .vsct file.  
  
## Related Sections  
 [Command Table Compiler  XML Schema Reference](../VS_csharp/vsct-xml-schema-reference.md)  
 Provides details about each section of the command table XML configuration file.  
  
 [Command Table Configuration (.Ctc) Files](assetId:///3413dda1-f372-4669-bcf0-c64d3463842c)  
 Presents an overview of the deprecated .ctc file format.  
  
 [How VSPackages Contribute User Interface Elements](../VS_csharp/how-vspackages-add-user-interface-elements.md)  
 Describes the command table format specification.  
  
 [Resources in Managed VSPackages](../VS_csharp/resources-in-vspackages.md)  
 Describes how to use managed and unmanaged resources in managed VSPackages.  
  
 [Menus and Toolbars](../VS_csharp/commands--menus--and-toolbars.md)  
 Explains how to create a UI that includes menus, toolbars, and command combo boxes.