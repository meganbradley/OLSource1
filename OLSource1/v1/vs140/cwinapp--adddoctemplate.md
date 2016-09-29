---
title: "CWinApp::AddDocTemplate"
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
  - "CWinApp.AddDocTemplate"
  - "AddDocTemplate"
  - "CWinApp::AddDocTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "AddDocTemplate method"
  - "document templates, adding"
ms.assetid: 9bc1fc63-1cff-4301-b8e9-c4bdda3c8fea
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::AddDocTemplate
Call this member function to add a document template to the list of available document templates that the application maintains.  
  
## Syntax  
  
```  
  
      void AddDocTemplate(  
   CDocTemplate* pTemplate   
);  
```  
  
#### Parameters  
 `pTemplate`  
 A pointer to the `CDocTemplate` to be added.  
  
## Remarks  
 You should add all document templates to an application before you call [RegisterShellFileTypes](../vs140/cwinapp--registershellfiletypes.md).  
  
## Example  
 [!code[NVC_MFCWindowing#35](../vs140/codesnippet/CPP/cwinapp--adddoctemplate_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::RegisterShellFileTypes](../vs140/cwinapp--registershellfiletypes.md)   
 [CMultiDocTemplate Class](../vs140/cmultidoctemplate-class.md)   
 [CSingleDocTemplate Class](../vs140/csingledoctemplate-class.md)