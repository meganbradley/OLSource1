---
title: "How to: Create a Registry Key and Set Its Value in Visual Basic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - RegistryKey.CreateSubKey
  - RegistryKey.SetValue
dev_langs: 
  - VB
helpviewer_keywords: 
  - registry keys, creating
  - registry, adding values
  - registry, adding keys
  - registry keys, setting values
  - examples [Visual Basic], registry
ms.assetid: d3e40f74-c283-480c-ab18-e5e9052cd814
caps.latest.revision: 34
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Create a Registry Key and Set Its Value in Visual Basic
The `CreateSubKey` method of the `My.Computer.Registry` object can be used to create a registry key.  
  
## Procedure  
  
#### To create a registry key  
  
-   Use the `CreateSubKey` method, specifying which hive to place the key under as well as the name of the key. The parameter `Subkey` is not case-sensitive. This example creates the registry key `MyTestKey` under HKEY_CURRENT_USER.  
  
     [!code[VbResourceTasks#17](../vs140/codesnippet/VisualBasic/how-to--create-a-registry-key-and-set-its-value-in-visual-basic_1.vb)]
  
  
#### To create a registry key and set a value in it  
  
1.  Use the `CreateSubkey` method, specifying which hive to place the key under as well as the name of the key. This example creates the registry key `MyTestKey` under HKEY_CURRENT_USER.  
  
     [!code[VbResourceTasks#17](../vs140/codesnippet/VisualBasic/how-to--create-a-registry-key-and-set-its-value-in-visual-basic_1.vb)]
  
  
2.  Set the value with the `SetValue` method. This example sets the string value. "MyTestKeyValue" to "This is a test value".  
  
     [!code[VbResourceTasks#14](../vs140/codesnippet/VisualBasic/how-to--create-a-registry-key-and-set-its-value-in-visual-basic_2.vb)]
  
  
## Example  
 This example creates the registry key `MyTestKey` under HKEY_CURRENT_USER and then sets the string value `MyTestKeyValue` to `This is a test value`.  
  
 [!code[VbResourceTasks#15](../vs140/codesnippet/VisualBasic/how-to--create-a-registry-key-and-set-its-value-in-visual-basic_3.vb)]
  
  
## Robust Programming  
 Examine the registry structure to find a suitable location for your key. For example, you may want to open the HKEY_CURRENT_USER\Software key of the current user, and create a key with your company's name. Then add the registry values to your company's key.  
  
 When reading the registry from a Web application, the current user depends on the authentication and impersonation implemented in the Web application.  
  
 It is more secure to write data to the user folder (<xref:Microsoft.Win32.Registry.CurrentUser?qualifyHint=False>) rather than to the local computer (<xref:Microsoft.Win32.Registry.LocalMachine?qualifyHint=False>).  
  
 When you create a registry value, you need to decide what to do if that value already exists. Another process, perhaps a malicious one, may have already created the value and have access to it. When you put data in the registry value, the data is available to the other process. To prevent this, use the <xref:Microsoft.Win32.RegistryKey.GetValue?qualifyHint=False> method. It returns `Nothing` if the key does not already exist.  
  
 It is not secure to store secrets, such as passwords, in the registry as plain text, even if the registry key is protected by ACLs (Access Control Lists).  
  
 The following conditions may cause an exception:  
  
-   The name of the key is `Nothing` (<xref:System.ArgumentNullException?qualifyHint=False>).  
  
-   The user does not have permissions to create registry keys (<xref:System.Security.SecurityException?qualifyHint=False>).  
  
-   The key name exceeds the 255-character limit (<xref:System.ArgumentException?qualifyHint=False>).  
  
-   The key is closed (<xref:System.IO.IOException?qualifyHint=False>).  
  
-   The registry key is read-only (<xref:System.UnauthorizedAccessException?qualifyHint=False>).  
  
## .NET Framework Security  
 To run this process, your assembly requires a privilege level granted by the <xref:System.Security.Permissions.RegistryPermission?qualifyHint=False> class. If you are running in a partial-trust context, the process might throw an exception due to insufficient privileges. Similarly, the user must have the correct ACLs for creating or writing to settings. For example, a local application that has the code access security permission might not have operating system permission. For more information, see [Code Access Security Basics](assetId:///4eaa6535-d9fe-41a1-91d8-b437cfc16921).  
  
## See Also  
 <xref:Microsoft.VisualBasic.MyServices.RegistryProxy?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.MyServices.RegistryProxy.CurrentUser?qualifyHint=False>   
 <xref:Microsoft.Win32.RegistryKey.CreateSubKey?qualifyHint=False>   
 [Reading from and Writing to the Registry (Visual Basic)](../vs140/reading-from-and-writing-to-the-registry--visual-basic-.md)   
 [Code Access Security Basics](assetId:///4eaa6535-d9fe-41a1-91d8-b437cfc16921)