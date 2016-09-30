---
title: "Troubleshooting Code Access Security Exceptions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "CodeAccessPermission class"
  - "CodeAccessSecurityException class"
  - "code access security, troubleshooting"
  - "security [debugger], troubleshooting code access security"
  - "troubleshooting code access security"
ms.assetid: ca368d3b-f6d0-4c89-af59-d94f343fca35
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Code Access Security Exceptions
Permissions control what your code is allowed to do and not do. At the time an application executes, it is given a set of permissions by the runtime. If it has sufficient permissions, it runs properly; otherwise a security exception occurs.  
  
 The permissions your code is given are determined by the location from which the application was launched (for example, the Internet, intranet, or the local computer) and the security settings on the computer on which the application is running. Since these settings can differ from computer to computer, you cannot always anticipate whether or not the code will receive sufficient permissions.  
  
 Requesting permissions ensures that your code will execute if the security policy on the local computer allows it. If you do not request the necessary permissions, you run the risk of your code not executing. For more information on Code Access permissions and requesting them, see [Code Access Permissions](assetId:///e5ae402f-6dda-4732-bbe8-77296630f675) or [NIB: Requesting Permissions](assetId:///0447c49d-8cba-45e4-862c-ff0b59bebdc2). For more information on <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> blocks, see [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md).  
  
 [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] applications can request additional permissions, if needed, using the Security Page in the Application Designer. For more information, see [How to: Set Custom Permissions for a ClickOnce Application](../vs140/how-to--set-custom-permissions-for-a-clickonce-application.md).  
  
 Possible causes of Code Access security exceptions include:  
  
-   **Clipboard.** Pasting from the Clipboard programmatically is a restricted feature of managed code, because the clipboard may contain sensitive information.  
  
-   **Registry or file system access.** Access to the local file system is restricted. If you are accessing a file or resource that is deployed with your assembly, use the code <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to get the path to your assembly.  
  
-   **Network access.** Make sure your assembly uses the same protocol with which your assembly was loaded. Generally, network communication is allowed only to the URL that was the source of the assembly.  
  
-   **Printing.** Software running in the Internet zone can print only by using a common dialog. It is restricted to default-printer use only if it uses a common dialog to allow the user to select a printer.  
  
-   **Serialization.** The ability to rebuild an object from arbitrary data is restricted to code running with full trust. For XML serialization, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> type should technically be useable by partially trusted code. For more information on the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type, see [XmlSerializer Class](https://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlserializer.aspx).  
  
-   **Reflection.** Many of the reflection-related features of the runtime are restricted from use by partially trusted code.  
  
## Testing Code to Determine If It Will Throw a Code Access SecurityException  
 If you have a block of code with the potential to throw a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, use a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block to allow your code to execute if it can, and to work around the failure if it cannot.  
  
 Sometimes you may want to design your application to adjust its behavior depending on the permissions the host system has granted it. For example, you may want to disable a Print command on a menu if the application does not have printing permissions.  
  
 To test for this, you can create an instance of a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>-derived class such as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Then you can execute the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method on the permission inside of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block. If the exception is thrown, then your assembly does not have the permission.  
  
 The following example tests whether the assembly has <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> permission by executing or creating an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and executing its <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method within a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> block to determine whether or not the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is successful.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Code Access Permissions](assetId:///e5ae402f-6dda-4732-bbe8-77296630f675)   
 [NIB: Requesting Permissions](assetId:///0447c49d-8cba-45e4-862c-ff0b59bebdc2)   
 [Code Access Security Basics](assetId:///4eaa6535-d9fe-41a1-91d8-b437cfc16921)