---
title: "COleTemplateServer::UpdateRegistry"
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
  - "COleTemplateServer.UpdateRegistry"
  - "UpdateRegistry"
  - "COleTemplateServer::UpdateRegistry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleTemplateServer class, operations"
  - "UpdateRegistry method"
ms.assetid: b033bf55-cfc9-4876-9a76-20ae8d75675e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleTemplateServer::UpdateRegistry
Loads file-type information from the document-template string and places that information in the OLE system registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A value from the **OLE_APPTYPE** enumeration, which is defined in AFXDISP.H. It can have any one of the following values:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Server has full server user-interface.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Server supports only embedding.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Container supports links to embedded objects.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Object is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-capable.  
  
-   **OAT_DOC_OBJECT_SERVER** Server supports both embedding and the Document Object component model.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A list of entries that is written into the registry only if no entries exist.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A list of entries that is written into the registry regardless of whether any preceding entries exist.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Determines whether the class is to be registered. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **TRUE**, the class is registered with the system registry. Otherwise, it unregisters the class.  
  
## Remarks  
 The registration information is loaded by means of a call to [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md). The substrings retrieved are those identified by the indexes **regFileTypeId**, **regFileTypeName**, and **fileNewName**, as described in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> reference pages.  
  
 If the **regFileTypeId** substring is empty or if the call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> fails for any other reason, this function fails and the file information is not entered in the registry.  
  
 The information in the arguments <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is written to the registry through a call to [AfxOleRegisterServerClass](../vs140/afxoleregisterserverclass.md). The default information, which is registered when the two arguments are **NULL**, is suitable for most applications. For information on the structure of the information in these arguments, see <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleTemplateServer Class](../vs140/coletemplateserver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md)   
 [AfxOleRegisterServerClass](../vs140/afxoleregisterserverclass.md)