---
title: "Troubleshooting Exceptions: System.Security.SecurityException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - EHSecurity
dev_langs: 
  - JScript
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - System.Security.SecurityException class
  - SecurityException class
ms.assetid: 7679ef74-dd15-439f-bfeb-0fb45f8b2373
caps.latest.revision: 30
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: System.Security.SecurityException
A <xref:System.Security.SecurityException?qualifyHint=False> exception is thrown when a security error is detected.  
  
## Associated Tips  
 Adjust the permission level of the assembly via the property page.  
 For more information, see <xref:Microsoft.VisualStudio.VCProjectEngine.VCConfiguration.SqlPermissionLevel?qualifyHint=False>.  
  
 Store application data in isolated storage.  
 Isolated storage is a data storage that provides isolation and safety by defining standardized ways of associating code with saved data. For more information, [Isolated Storage](assetId:///aff939d7-9e49-46f2-a8cd-938d3020e94e).  
  
 If using <xref:System.Windows.Forms.OpenFileDialog?qualifyHint=False> , use the <xref:System.Windows.Forms.OpenFileDialog.OpenFile?qualifyHint=False> method to open or save a file.  
 This allows the application to perform in a partial-trust situation.  
  
 Make sure the application is reading and writing to existing event logs on the local computer.  
 The application may not have sufficient permissions to create logs on or write to non-local computers.  
  
 If calling unmanaged libraries, use equivalent managed libraries.  
 An equivalent API may exist in the Framework. For more information, see [Troubleshooting Interoperability](../vs140/troubleshooting-interoperability--visual-basic-.md).  
  
 Use safe windows.  
 The <xref:System.Security.Permissions.UIPermissionWindow?qualifyHint=False> enumeration specifies the type of windows that code is allowed to use.  
  
 Allow users to print through the <xref:System.Windows.Forms.PrintDialog?qualifyHint=False> component.  
 This allows the application to perform in a partial-trust situation. For more information, see <xref:System.Windows.Forms.PrintDialog?qualifyHint=False>.  
  
 Print to the default printer.  
 This allows the application to perform in a partial-trust situation. You may be trying to access a printer to which you do not have rights.  
  
 Retrieve data from the same Web server from which it was deployed.  
 This allows the application to perform in a partial-trust situation.  
  
 When deploying an Office solution, check to make sure you have fulfilled all necessary security requirements.  
 For more information see [Specific Security Considerations for Office Solutions](assetId:///6a8b3e12-26c6-4ee2-a37e-d5bc8df9c5d1).  
  
 If an assembly implementing the custom security object references other assemblies, add the referenced assemblies to the full trust assembly list.  
 For more information, see [Code Access Security Policy Tool (Caspol.exe)](assetId:///d2bf6123-7b0c-4e60-87ad-a39a1c3eb2e0).  
  
## See Also  
 <xref:System.Security.SecurityException?qualifyHint=False>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)