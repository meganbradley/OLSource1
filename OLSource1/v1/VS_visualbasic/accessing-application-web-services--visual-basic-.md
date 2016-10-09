---
title: "Accessing Application Web Services (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "Web services, My.WebServices object"
  - "My.WebServices object"
  - "applications [Visual Basic], Web services"
ms.assetid: 8ad5405b-e771-42b1-82d3-ce97af2cea9e
caps.latest.revision: 12
ms.author: "shoag"
manager: "wpickett"
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
# Accessing Application Web Services (Visual Basic)
The `My.WebServices` object provides an instance of each Web service referenced by the current project. Each instance is instantiated on demand. You can access these Web services through the properties of the `My.WebServices` object. The name of the property is the same as the name of the Web service that the property accesses. Any class that inherits from \<xref:System.Web.Services.Protocols.SoapHttpClientProtocol> is a Web service.  
  
## Tasks  
 The following table lists possible ways to access Web services referenced by an application.  
  
|||  
|-|-|  
|To|See|  
|Call a Web service|[My.WebServices Object](../VS_visualbasic/my.webservices-object.md)|  
|Call a Web service asynchronously and handle an event when it completes|[How to: Call a Web Service Asynchronously](../VS_visualbasic/how-to--call-a-web-service-asynchronously--visual-basic-.md)|  
  
## See Also  
 [My.WebServices Object](../VS_visualbasic/my.webservices-object.md)