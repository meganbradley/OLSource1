---
title: "Reading from and Writing to the Registry Using the Microsoft.Win32 Namespace (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - registry, Visual Basic
ms.assetid: 4a0dcce0-c27b-4199-baa8-ee4528da6a56
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Reading from and Writing to the Registry Using the Microsoft.Win32 Namespace (Visual Basic)
Although `My.Computer.Registry` should cover your basic needs when programming against the registry, you can also use the <xref:Microsoft.Win32.Registry?qualifyHint=False> and <xref:Microsoft.Win32.RegistryKey?qualifyHint=False> classes in the <xref:Microsoft.Win32?qualifyHint=False> namespace of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)].  
  
## Keys in the Registry Class  
 The <xref:Microsoft.Win32.Registry?qualifyHint=False> class supplies the base registry keys that can be used to access subkeys and their values. The base keys themselves are read-only. The following table lists and describes the seven keys exposed by the <xref:Microsoft.Win32.Registry?qualifyHint=False> class.  
  
|**Key**|**Description**|  
|-------------|---------------------|  
|<xref:Microsoft.Win32.Registry.ClassesRoot?qualifyHint=False>|Defines the types of documents and the properties associated with those types.|  
|<xref:Microsoft.Win32.Registry.CurrentConfig?qualifyHint=False>|Contains hardware configuration information that is not user-specific.|  
|<xref:Microsoft.Win32.Registry.CurrentUser?qualifyHint=False>|Contains information about the current user preferences, such as environmental variables.|  
|<xref:Microsoft.Win32.Registry.DynData?qualifyHint=False>|Contains dynamic registry data, such as that used by Virtual Device Drivers.|  
|<xref:Microsoft.Win32.Registry.LocalMachine?qualifyHint=False>|Contains five subkeys (Hardware, SAM, Security, Software, and System) that hold the configuration data for the local computer.|  
|<xref:Microsoft.Win32.Registry.PerformanceData?qualifyHint=False>|Contains performance information for software components.|  
|<xref:Microsoft.Win32.Registry.Users?qualifyHint=False>|Contains information about the default user preferences.|  
  
> [!IMPORTANT]
>  It is more secure to write data to the current user (<xref:Microsoft.Win32.Registry.CurrentUser?qualifyHint=False>) than to the local computer (<xref:Microsoft.Win32.Registry.LocalMachine?qualifyHint=False>). A condition that's typically referred to as "squatting" occurs when the key you are creating was previously created by another, possibly malicious, process. To prevent this from occurring, use a method, such as <xref:Microsoft.Win32.RegistryKey.GetValue?qualifyHint=False>, that returns `Nothing` if the key does not already exist.  
  
## Reading a Value from the Registry  
 The following code shows how to read a string from HKEY_CURRENT_USER.  
  
 [!code[VbResourceTasks#20](../vs140/codesnippet/VisualBasic/reading-from-and-writing-to-the-registry-using-the-microsoft.win32-namespace--visual-basic-_1.vb)]
  
  
 The following code reads, increments, and then writes a string to HKEY_CURRENT_USER.  
  
 [!code[VbResourceTasks#21](../vs140/codesnippet/VisualBasic/reading-from-and-writing-to-the-registry-using-the-microsoft.win32-namespace--visual-basic-_2.vb)]
  
  
## See Also  
 <xref:System.SystemException?qualifyHint=False>   
 <xref:System.ApplicationException?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.MyServices.RegistryProxy?qualifyHint=False>   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Reading from and Writing to the Registry (Visual Basic)](../vs140/reading-from-and-writing-to-the-registry--visual-basic-.md)   
 [Security and the Registry](../vs140/security-and-the-registry--visual-basic-.md)