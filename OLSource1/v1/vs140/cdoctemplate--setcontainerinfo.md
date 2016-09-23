---
title: "CDocTemplate::SetContainerInfo"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SetContainerInfo
  - CDocTemplate.SetContainerInfo
  - CDocTemplate::SetContainerInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - OLE containers, setting information
  - SetContainerInfo method
  - CDocTemplate class, attributes
  - container information
ms.assetid: fc4cd027-4ee9-406a-8c00-994950f4e525
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDocTemplate::SetContainerInfo
Determines the resources for OLE containers when editing an in-place OLE item.  
  
## Syntax  
  
```  
  
      void SetContainerInfo(  
   UINT nIDOleInPlaceContainer   
);  
```  
  
#### Parameters  
 `nIDOleInPlaceContainer`  
 The ID of the resources used when an embedded object is activated.  
  
## Remarks  
 Call this function to set the resources to be used when an OLE object is in-place activated. These resources may include menus and accelerator tables. This function is usually called in the [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md) function of your application.  
  
 The menu associated with `nIDOleInPlaceContainer` contains separators that allow the menu of the activated in-place item to merge with the menu of the container application. For more information about merging server and container menus, see the article [Menus and Resources (OLE)](../vs140/menus-and-resources--ole-.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::SetServerInfo](../vs140/cdoctemplate--setserverinfo.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)   
 [CMultiDocTemplate::CMultiDocTemplate](../vs140/cmultidoctemplate--cmultidoctemplate.md)