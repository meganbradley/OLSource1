---
title: "&lt;customErrorReporting&gt; Element (ClickOnce Deployment)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<customErrorReporting> element [ClickOnce deployment manifest]"
ms.assetid: 7d31816e-c692-46b5-9cc9-753284b3bcda
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;customErrorReporting&gt; Element (ClickOnce Deployment)
Specifies a URI to show when an error occurs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This element is optional. Without it, [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] displays an error dialog box showing the exception stack. If the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is present, [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] will instead display the URI indicated by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter. The target URI will include the outer exception class, the inner exception class, and the inner exception message as parameters.  
  
 Use this element to add error reporting functionality to your application. Since the generated URI includes information about the type of error, your Web site can parse that information and display, for example, an appropriate troubleshooting screen.  
  
## Example  
 The following snippet shows the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element, together with the generated URI it might produce.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md)