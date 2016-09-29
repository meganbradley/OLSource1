---
title: "Troubleshooting LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "troubleshooting [Visual Studio LightSwitch]"
ms.assetid: 4f37f6b2-9539-4177-9299-841e45703ea3
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting LightSwitch
This topic contains information about typically encountered issues and the steps that are required to resolve them.  
  
> [!NOTE]
>  For issues that are not listed here, you may be able to find information or obtain help in the [LightSwitch Forums](http://go.microsoft.com/fwlink/?LinkId=132604) on the MSDN website.  
  
## An exception occurred when building the database for the application  
 This error might occur after you move a project from one location to another on disk. To build the database, you must log in with an account that has **Modify** permissions for the *FilePath*\Bin\Data\Temp directory, where *FilePath* is the path to your project. Iinherited permissions from a group such as Administrators are'nt sufficient; your account must have been granted **Modify** permissions explicitly.  
  
#### To fix the error  
  
1.  In File Explorer, browse to the \Bin\Data\Temp directory for your project.  
  
2.  Open the shortcut menu for the Temp folder, and then choose **Properties**.  
  
3.  In the **Temp Properties** dialog box, choose the **Security** tab, and then choose the **Edit** button.  
  
     The **Permissions for Temp** dialog box opens.  
  
4.  In the **Group or user name** list, choose your user account.  
  
    > [!IMPORTANT]
    >  Permissions that are inherited from a group such as Administrators aren't sufficient; your account must have been granted **Modify** permissions explicitly.  
  
5.  In the **Permissions** list, in the **Allow** column, select the **Modify** check box, and then choose the **OK** button.  
  
## Key file error when you open a shared project  
 When opening a project that is stored in a Source Code Control repository, you may encounter one of several errors related to importing a key file. For projects that are signed with a certificate, the certificate must be present on every development computer that will check out the project.  
  
#### To fix the error  
  
1.  Close the project, and undo the checkout in your Source Code Control repository.  
  
2.  Copy the certificate (.pfx) file with which the project was signed, and then save that copy to the local computer.  
  
    > [!NOTE]
    >  You will also need the private key password for the certificate.  
  
3.  In **Solution Explorer**, open the shortcut menu for the .pfx file, and then choose **Install PFX**.  
  
4.  In the **Certificate Import Wizard**, choose the **Next** button.  
  
5.  On the **File to Import** page, verify the path of the certificate file, and then choose the **Next** button.  
  
6.  On the **Password** page, enter the private key password for the certificate, and then choose the **Next** button.  
  
7.  On the **Certificate Store** page, choose the **Automatically select the certificate store based on the type of certificate** option button, and then choose the **Next** button.  
  
8.  Choose the **Finish** button to install the certificate.  
  
     After the certificate is installed, you can check out and open the project.  
  
## See Also  
 [Troubleshooting LightSwitch Deployment](../vs140/troubleshooting-lightswitch-deployment.md)   
 [Community: Connecting with Other LightSwitch Developers](../vs140/community--connecting-with-other-lightswitch-developers.md)