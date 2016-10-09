---
title: "Reading from and Writing to the Registry Using the Microsoft.Win32 Namespace (Visual Basic)"
ms.custom: na
ms.date: "10/06/2016"
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
  - "registry, Visual Basic"
ms.assetid: 4a0dcce0-c27b-4199-baa8-ee4528da6a56
caps.latest.revision: 20
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Reading from and Writing to the Registry Using the Microsoft.Win32 Namespace (Visual Basic)
Although `My.Computer.Registry` should cover your basic needs when programming against the registry, you can also use the \<xref:Microsoft.Win32.Registry> and \<xref:Microsoft.Win32.RegistryKey> classes in the \<xref:Microsoft.Win32> namespace of the [!INCLUDE[dnprdnshort](../VS_visualbasic/includes/dnprdnshort_md.md)].  
  
## Keys in the Registry Class  
 The \<xref:Microsoft.Win32.Registry> class supplies the base registry keys that can be used to access subkeys and their values. The base keys themselves are read-only. The following table lists and describes the seven keys exposed by the \<xref:Microsoft.Win32.Registry> class.  
  
|**Key**|**Description**|  
|-------------|---------------------|  
|\<xref:Microsoft.Win32.Registry.ClassesRoot>|Defines the types of documents and the properties associated with those types.|  
|\<xref:Microsoft.Win32.Registry.CurrentConfig>|Contains hardware configuration information that is not user-specific.|  
|\<xref:Microsoft.Win32.Registry.CurrentUser>|Contains information about the current user preferences, such as environmental variables.|  
|\<xref:Microsoft.Win32.Registry.DynData>|Contains dynamic registry data, such as that used by Virtual Device Drivers.|  
|\<xref:Microsoft.Win32.Registry.LocalMachine>|Contains five subkeys (Hardware, SAM, Security, Software, and System) that hold the configuration data for the local computer.|  
|\<xref:Microsoft.Win32.Registry.PerformanceData>|Contains performance information for software components.|  
|\<xref:Microsoft.Win32.Registry.Users>|Contains information about the default user preferences.|  
  
> [!IMPORTANT]
>  It is more secure to write data to the current user (\<xref:Microsoft.Win32.Registry.CurrentUser>) than to the local computer (\<xref:Microsoft.Win32.Registry.LocalMachine>). A condition that's typically referred to as "squatting" occurs when the key you are creating was previously created by another, possibly malicious, process. To prevent this from occurring, use a method, such as \<xref:Microsoft.Win32.RegistryKey.GetValue*>, that returns `Nothing` if the key does not already exist.  
  
## Reading a Value from the Registry  
 The following code shows how to read a string from HKEY_CURRENT_USER.  
  
 [!code[VbResourceTasks#20](../VS_visualbasic/codesnippet/VisualBasic/reading-from-and-writing-to-the-registry-using-the-microsoft.win32-namespace--visual-basic-_1.vb)]  
  
 The following code reads, increments, and then writes a string to HKEY_CURRENT_USER.  
  
 [!code[VbResourceTasks#21](../VS_visualbasic/codesnippet/VisualBasic/reading-from-and-writing-to-the-registry-using-the-microsoft.win32-namespace--visual-basic-_2.vb)]  
  
## See Also  
 \<xref:System.SystemException>   
 \<xref:System.ApplicationException>   
 \<xref:Microsoft.VisualBasic.MyServices.RegistryProxy>   
 [Try...Catch...Finally Statement](../VS_visualbasic/try...catch...finally-statement--visual-basic-.md)   
 [Reading from and Writing to the Registry](../VS_visualbasic/reading-from-and-writing-to-the-registry--visual-basic-.md)   
 [Security and the Registry](../VS_visualbasic/security-and-the-registry--visual-basic-.md)