---
title: "Signing a XAP File For a LightSwitch Application"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ls.XapSigning
helpviewer_keywords: 
  - security certificates [Visual Studio LightSwitch]
  - signing [Visual Studio LightSwitch]
ms.assetid: 1b31d8ea-b984-4e4e-91e3-0c580b42bedc
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Signing a XAP File For a LightSwitch Application
By signing a XAP (.xap) file for a LightSwitch application, you assure users that the publisher is reliable and the code hasn't been tampered with.  
  
 Users download LightSwitch applications as XAP files, which are compressed files, each of which contains an assembly manifest and one or more assemblies. You sign a XAP file by using a public key certificate (typically referred to just as a certificate), which is a digitally signed statement that binds the value of a public key to the value of a private key that a person, device, or service holds. You typically obtain a certificate from a system administrator.  
  
 A signed XAP file is required for an application that is hosted on Microsoft Azure.  
  
 You can add a certificate from the certificate store on your computer or from a network location that the network administrator provides.  
  
## Adding a Certificate in the Publish Application Wizard  
  
#### To add a certificate  
  
1.  In the **LightSwitch Publish Application Wizard**, go to the **Security Settings** page, choose the **Digital Signature** tab, and then choose **Browse**.  
  
2.  In the **Select File** dialog box, browse to the location of the certificate that you want to use, and then choose the **Open** button.  
  
     Basic information about the certificate appears. You can choose the **View Certificate** button to display more information about the certificate.  
  
## See Also  
 [How to: Deploy a 3-tier Application](../vs140/how-to--deploy-a-three-tier-lightswitch-application.md)   
 [How to: Host an Application Using Windows Azure](../vs140/how-to--host-a-lightswitch-application-on-microsoft-azure.md)