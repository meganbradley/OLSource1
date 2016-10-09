---
title: "Granting Trust to Office Solutions"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "security [Office development in Visual Studio], trust"
  - "inclusion lists [Office development in Visual Studio], about inclusion lists"
  - "trust [Office development in Visual Studio], 2007 Office system"
  - "granting trust [Office development in Visual Studio]"
ms.assetid: 6c33e614-d367-4556-9e76-0f302ad0f929
caps.latest.revision: 37
ms.author: "normesta"
manager: "ghogen"
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
# Granting Trust to Office Solutions
  Granting trust to Office solutions means modifying the security policy of each target computer to trust the solution assembly, application manifest, deployment manifest, and document. Trust can be granted to the Office solution by either you or the end user.  
  
 You can grant full trust to the Office solution by signing the application and deployment manifests.  
  
 End users can grant trust to the Office solution by making a trust decision in the [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] trust prompt.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
##  <a name="Signing"></a> Trusting the Solution by Signing the Application and Deployment Manifests  
 All application and deployment manifests for Office solutions must be signed with a certificate that identifies the publisher. Certificates provide a basis for making trust decisions.  
  
 A temporary certificate is created for you and granted trust at build time so the solution will run while you debug it. If you publish a solution that is signed with a temporary certificate, the end user will be prompted to make a trust decision.  
  
 If you sign the solution with a known and trusted certificate, the solution will automatically be installed without prompting the end user to make a trust decision. For more information about how to obtain a certificate for signing, see [ClickOnce and Authenticode](../Topic/ClickOnce%20and%20Authenticode.md). After a certificate is obtained, the certificate must be explicitly trusted by adding it to the Trusted Publishers list. For more information, see [How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications](../Topic/How%20to:%20Add%20a%20Trusted%20Publisher%20to%20a%20Client%20Computer%20for%20ClickOnce%20Applications.md).  
  
 If a developer signs the solution with a temporary certificate, an administrator can re-sign the customization with a known and trusted certificate by using the Manifest Generation and Editing Tool (mage.exe), which is one of the Microsoft .NET Framework tools. For more information about signing solutions, see [How to: Sign Office Solutions](../VS_officedev/how-to--sign-office-solutions.md) and [How to: Sign Application and Deployment Manifests](../Topic/How%20to:%20Sign%20Application%20and%20Deployment%20Manifests.md).  
  
##  <a name="TrustPrompt"></a> Trusting the Solution by Using the ClickOnce Trust Prompt  
 [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] prompts the end user to make the trust decision if there is no organization-wide policy that trusts the solution's certificate. If the end user grants trust to the solution, an inclusion list entry is created that contains a URL and a public key to store this trust decision. When a trusted customization is run later, the end user is not prompted again.  
  
 Administrators can disable the [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] trust prompt or require that the prompt occur only for solutions that are signed with an Authenticode certificate. For more information about how to change these settings for the MyComputer, LocalIntranet, Internet, TrustedSites, and UntrustedSites zones, see [How to: Configure the ClickOnce Trust Prompt Behavior](../Topic/How%20to:%20Configure%20the%20ClickOnce%20Trust%20Prompt%20Behavior.md).  
  
## See Also  
 [Securing Office Solutions](../VS_officedev/securing-office-solutions.md)   
 [Granting Trust to Documents](../VS_officedev/granting-trust-to-documents.md)   
 [Troubleshooting Office Solution Security](../VS_officedev/troubleshooting-office-solution-security.md)   
 [Specific Security Considerations for Office Solutions](../VS_officedev/specific-security-considerations-for-office-solutions.md)  
  
  