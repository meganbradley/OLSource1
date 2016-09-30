---
title: "Troubleshooting Exceptions: System.Deployment.Application.InvalidDeploymentException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "InvalidDeploymentException class"
ms.assetid: 4361e053-8eaf-44e3-b8ac-95516d8d1832
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Deployment.Application.InvalidDeploymentException
An \<xref:System.Deployment.Application.InvalidDeploymentException*> exception is thrown when the application or its application and deployment manifests are not valid.  
  
## Associated Tips  
 **Make sure the manifests for this application are valid.**  
 An application manifest is an XML file that describes and identifies the shared and private side-by-side assemblies that an application should bind to at run time. These should be the same assembly versions that were used to test the application. Application manifests may also describe metadata for files that are private to the application.  
  
 **Use the ClickOnce feature to deploy the application.**  
 Use ClickOnce to publish Windows applications to a Web server or network file share for simplified installation. For more information, see [ClickOnce Security and Deployment](../vs140/clickonce-security-and-deployment.md).  
  
## See Also  
 \<xref:System.Deployment.Application.InvalidDeploymentException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Troubleshooting ClickOnce Deployments](../vs140/troubleshooting-clickonce-deployments.md)   
 [ClickOnce Deployment for Windows Forms](assetId:///1451fce9-1965-4a03-b4d3-831b5fe4ad66)