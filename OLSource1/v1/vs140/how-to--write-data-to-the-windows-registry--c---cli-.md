---
title: "How to: Write Data to the Windows Registry (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Write Data to the Windows Registry (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "registry, writing to"
  - "Visual C++, writing to Windows Registry"
ms.assetid: 3d40b978-4baa-4779-bfe3-47e2917b757f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write Data to the Windows Registry (C++-CLI)
The following code example uses the \<xref:Microsoft.Win32.Registry.CurrentUser*> key to create a writable instance of the \<xref:Microsoft.Win32.RegistryKey*> class corresponding to the **Software** key. The \<xref:Microsoft.Win32.RegistryKey.CreateSubKey*> method is then used to create a new key and add to key/value pairs.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can use the .NET Framework to access the registry with the \<xref:Microsoft.Win32.Registry*> and [RegistryKey](https://msdn.microsoft.com/en-us/library/microsoft.win32.registrykey.aspx) classes, which are both defined in the \<xref:Microsoft.Win32*> namespace. The **Registry** class is a container for static instances of the \<xref:Microsoft.Win32.RegistryKey*> class. Each instance represents a root registry node. The instances are \<xref:Microsoft.Win32.Registry.ClassesRoot*>, \<xref:Microsoft.Win32.Registry.CurrentConfig*>, \<xref:Microsoft.Win32.Registry.CurrentUser*>, \<xref:Microsoft.Win32.Registry.LocalMachine*>, and \<xref:Microsoft.Win32.Registry.Users*>.  
  
## See Also  
 [How to: Read Data from the Windows Registry (C++/CLI)](../vs140/how-to--read-data-from-the-windows-registry--c---cli-.md)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)