---
title: "How to: Sign Office Solutions"
ms.custom: na
ms.date: "09/30/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "certificates [Office development in Visual Studio], Office solutions"
  - "security [Office development in Visual Studio], signing Office solutions"
  - "signing manifests [Office development in Visual Studio]"
ms.assetid: d3df5ee6-f1b7-47ed-b7ee-8985679ee3af
caps.latest.revision: 18
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Sign Office Solutions
  If you sign a solution, you can grant trust to the solution using the certificate as evidence. You can use the same certificate for multiple solutions, and all the solutions will be trusted with no additional security policy updates.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 If you manually edit application and deployment manifests by using the Manifest Generation and Editing Tool (mage.exe and mageui.exe), you must re-sign the manifests before you can use them. For more information, see [How to: Re-sign Application and Deployment Manifests](../Topic/How%20to:%20Re-sign%20Application%20and%20Deployment%20Manifests.md).  
  
## Signing by Using a Certificate  
 A certificate is a file that contains a unique key and the identity of the solution publisher. You can purchase certificates from a certificate authority, or create your own certificate and have a certificate authority sign it.  
  
 Visual Studio signs Office solutions with a temporary certificate to enable debugging. You should not use the temporary certificate in deployed solutions as evidence.  
  
#### To sign an Office solution by using a certificate  
  
1.  On the **Project** menu, click *SolutionName***Properties**.  
  
2.  Click the **Signing** tab.  
  
3.  Select **Sign the ClickOnce manifests**.  
  
4.  Locate the certificate by clicking **Select from Store** or **Select from File** and navigating to the certificate.  
  
5.  To verify that the correct certificate is being used, click **More Details** to view the certificate information.  
  
## See Also  
 [Securing Office Solutions](../VS_officedev/securing-office-solutions.md)   
 [Granting Trust to Office Solutions](../VS_officedev/granting-trust-to-office-solutions.md)   
 [Signing Page, Project Designer](../Topic/Signing%20Page,%20Project%20Designer.md)  
  
  