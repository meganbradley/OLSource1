---
title: "Reading from and Writing to the Registry (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My.Computer.Registry object, tasks"
  - "registry, writing to"
  - "registry, reading"
ms.assetid: a13da106-185b-41d7-b23c-416da65e21e4
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reading from and Writing to the Registry (Visual Basic)
This topic describes task and conceptual topics that are associated with the registry.  
  
 When programming in [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)], you can choose to access the registry by means of either the functions provided by [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] or the registry classes of the .NET Framework. The registry hosts information from the operating system as well as information from applications hosted on the machine. Working with the registry may compromise security by allowing inappropriate access to system resources or protected information.  
  
## In This Section  
 [How to: Create a Registry Key and Set Its Value in Visual Basic](../VS_csharp/how-to--create-a-registry-key-and-set-its-value-in-visual-basic.md)  
 Describes how to use the `CreateSubKey` and `SetValue` methods of the `My.Computer.Registry` object to create a registry key and set its value.  
  
 [How to: Read a Value from a Registry Key in Visual Basic](../VS_csharp/how-to--read-a-value-from-a-registry-key-in-visual-basic.md)  
 Describes how to use the `GetValue` method of the `My.Computer.Registry` object to read a value from a registry key.  
  
 [How to: Delete a Registry Key in Visual Basic](../VS_csharp/how-to--delete-a-registry-key-in-visual-basic.md)  
 Describes how to use the `DeleteSubKey` method of the `My.Computer.Registry.CurrentUser` property to delete a registry key.  
  
 [Reading from and Writing to the Registry Using the Microsoft.Win32 Namespace](../VS_csharp/reading-from-and-writing-to-the-registry-using-the-microsoft.win32-namespace--visual-basic-.md)  
 Describes how to use the `Registry` and `RegistryKey` classes of the [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] to access the registry.  
  
 [Security and the Registry](../VS_csharp/security-and-the-registry--visual-basic-.md)  
 Discusses security issues involving the registry.  
  
## Related Sections  
 <xref:Microsoft.VisualBasic.MyServices.RegistryProxy*>  
 Lists and explains members of the `My.Computer.Registry` object.  
  
 <xref:Microsoft.Win32.Registry*>  
 Presents an overview of the `Registry` class, along with links to individual keys and members.