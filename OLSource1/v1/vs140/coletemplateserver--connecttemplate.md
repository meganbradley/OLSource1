---
title: "COleTemplateServer::ConnectTemplate"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleTemplateServer.ConnectTemplate"
  - "ConnectTemplate"
  - "COleTemplateServer::ConnectTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConnectTemplate method"
  - "COleTemplateServer class, operations"
ms.assetid: 09a2fb46-8bad-4d03-a5e8-3077f498f637
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleTemplateServer::ConnectTemplate
Connects the document template pointed to by `pDocTemplate` to the underlying [COleObjectFactory](../vs140/coleobjectfactory-class.md) object.  
  
## Syntax  
  
```  
  
      void ConnectTemplate(  
   REFCLSID clsid,  
   CDocTemplate* pDocTemplate,  
   BOOL bMultiInstance   
);  
```  
  
#### Parameters  
 `clsid`  
 Reference to the OLE class ID that the template requests.  
  
 `pDocTemplate`  
 Pointer to the document template.  
  
 `bMultiInstance`  
 Indicates whether a single instance of the application can support multiple instantiations. If **TRUE**, multiple instances of the application are launched for each request to create an object.  
  
## Remarks  
 For more information, see [CLSID Key](http://msdn.microsoft.com/library/windows/desktop/ms691424) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleTemplateServer Class](../vs140/coletemplateserver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)