---
title: "CDocTemplate::SetServerInfo"
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
  - SetServerInfo
  - CDocTemplate.SetServerInfo
  - CDocTemplate::SetServerInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - OLE server applications, setting server information
  - SetServerInfo method
  - CDocTemplate class, attributes
ms.assetid: 4cff62bd-5fc1-4f8c-a760-be95afab9bba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDocTemplate::SetServerInfo
Determines the resources and classes when the server document is embedded or edited in-place.  
  
## Syntax  
  
```  
  
      void SetServerInfo(  
   UINT nIDOleEmbedding,  
   UINT nIDOleInPlaceServer = 0,  
   CRuntimeClass* pOleFrameClass = NULL,  
   CRuntimeClass* pOleViewClass = NULL   
);  
```  
  
#### Parameters  
 *nIDOleEmbedding*  
 The ID of the resources used when an embedded object is opened in a separate window.  
  
 `nIDOleInPlaceServer`  
 The ID of the resources used when an embedded object is activated in-place.  
  
 *pOleFrameClass*  
 Pointer to a [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure containing class information for the frame window object created when in-place activation occurs.  
  
 *pOleViewClass*  
 Pointer to a `CRuntimeClass` structure containing class information for the view object created when in-place activation occurs.  
  
## Remarks  
 Call this member function to identify resources that will be used by the server application when the user requests activation of an embedded object. These resources consist of menus and accelerator tables. This function is usually called in the `InitInstance` of your application.  
  
 The menu associated with `nIDOleInPlaceServer` contains separators that allow the server menu to merge with the menu of the container. For more information about merging server and container menus, see the article [Menus and Resources (OLE)](../vs140/menus-and-resources--ole-.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMultiDocTemplate::CMultiDocTemplate](../vs140/cmultidoctemplate--cmultidoctemplate.md)   
 [CDocTemplate::SetContainerInfo](../vs140/cdoctemplate--setcontainerinfo.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)