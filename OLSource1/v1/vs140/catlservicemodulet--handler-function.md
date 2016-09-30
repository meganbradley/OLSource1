---
title: "CAtlServiceModuleT::Handler Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CServiceModule::Handler"
  - "CServiceModule.Handler"
  - "Handler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Handler method"
ms.assetid: 14db5f2a-be87-4774-a296-445cb6fc7b2e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::Handler Function
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is the routine that the service control manager (SCM) calls to retrieve the status of the service and give it various instructions (such as stopping or pausing). The SCM passes an operation code to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to indicate what the service should do. A default ATL-generated service only handles the stop instruction. If the SCM passes the stop instruction, the service tells the SCM that the program is about to stop. The service then calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to post a quit message to itself. This terminates the message loop and the service will ultimately close.  
  
 To handle more instructions, you need to change the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data member initialized in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> constructor. This data member tells the SCM which buttons to enable when the service is selected in the Services Control Panel application.  
  
## See Also  
 [Services](../vs140/atl-services.md)   
 [CAtlServiceModuleT::Handler](../vs140/catlservicemodulet--handler.md)