---
title: "How to: Delete a Registry Key in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.DeleteSetting"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "GetSetting function"
  - "registry, deleting values"
  - "GetAllSettings function"
  - "registry keys, deleting"
  - "registry, deleting keys"
  - "examples [Visual Basic], registry"
ms.assetid: ab9aca0e-42b0-4ff7-8ff9-845a4bfdf9f2
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Delete a Registry Key in Visual Basic
The \<xref:Microsoft.Win32.RegistryKey.DeleteSubKey(System.String)> and \<xref:Microsoft.Win32.RegistryKey.DeleteSubKey(System.String,System.Boolean)> methods can be used to delete registry keys.  
  
## Procedure  
  
#### To delete a registry key  
  
-   Use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method to delete a registry key. This example deletes the key Software/TestApp in the CurrentUser hive. You can change this in the code to the appropriate string, or have it rely on user-supplied information.  
  
     [!code[VbResourceTasks#19](../vs140/codesnippet/VisualBasic/how-to--delete-a-registry-key-in-visual-basic_1.vb)]  
  
## Robust Programming  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method returns an empty string if the key/value pair does not exist.  
  
 The following conditions may cause an exception:  
  
-   The name of the key is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (\<xref:System.ArgumentNullException*>).  
  
-   The user does not have permissions to delete registry keys (\<xref:System.Security.SecurityException*>).  
  
-   The key name exceeds the 255-character limit (\<xref:System.ArgumentException*>).  
  
-   The registry key is read-only (\<xref:System.UnauthorizedAccessException*>).  
  
## .NET Framework Security  
 Registry calls fail if either sufficient run-time permissions are not granted (\<xref:System.Security.Permissions.RegistryPermission*>) or if the user does not have the correct access (as determined by the ACLs) for creating or writing to settings. For example, a local application that has the code access security permission might not have operating system permission.  
  
## See Also  
 \<xref:Microsoft.Win32.RegistryKey.DeleteSubKey*>   
 \<xref:Microsoft.Win32.RegistryKey.DeleteSubKey*>   
 \<xref:Microsoft.Win32.RegistryKey*>   
 [Security and the Registry](../vs140/security-and-the-registry--visual-basic-.md)   
 [Reading from and Writing to the Registry (Visual Basic)](../vs140/reading-from-and-writing-to-the-registry--visual-basic-.md)