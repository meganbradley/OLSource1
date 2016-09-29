---
title: "My.Response Object"
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
  - "My.MyWebExtension.Response"
  - "My.Response"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My.Response object"
ms.assetid: 626359bc-3165-40b4-bfaf-2c610e26eb5b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# My.Response Object
Gets the <xref:System.Web.HttpResponse*> object associated with the <xref:System.Web.UI.Page*>. This object allows you to send HTTP response data to a client and contains information about that response.  
  
## Remarks  
 The `My.Response` object contains the current <xref:System.Web.HttpResponse*> object associated with the page.  
  
 The `My.Response` object is only available for [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] applications.  
  
## Example  
 The following example gets the header collection from the `My.Request` object and uses the `My.Response` object to write it to the ASP.NET page.  
  
 [!code[VbVbalrMyWeb#1](../vs140/codesnippet/VisualBasic/my.response-object_1.aspx)]  
  
## See Also  
 <xref:System.Web.HttpResponse*>   
 [My.Request Object](../vs140/my.request-object.md)