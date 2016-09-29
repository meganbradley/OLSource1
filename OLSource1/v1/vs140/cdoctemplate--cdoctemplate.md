---
title: "CDocTemplate::CDocTemplate"
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
  - "CDocTemplate.CDocTemplate"
  - "CDocTemplate::CDocTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocTemplate class, constructor"
  - "templates, constructing"
ms.assetid: 5694de82-c90f-4ca2-83f1-d892c2a6e8dd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::CDocTemplate
Constructs a `CDocTemplate` object.  
  
## Syntax  
  
```  
  
      CDocTemplate (  
   UINT nIDResource,  
   CRuntimeClass* pDocClass,  
   CRuntimeClass* pFrameClass,  
   CRuntimeClass* pViewClass   
);  
```  
  
#### Parameters  
 `nIDResource`  
 Specifies the ID of the resources used with the document type. This may include menu, icon, accelerator table, and string resources.  
  
 The string resource consists of up to seven substrings separated by the '\n' character (the '\n' character is needed as a place holder if a substring is not included; however, trailing '\n' characters are not necessary); these substrings describe the document type. For information on the substrings, see [GetDocString](../vs140/cdoctemplate--getdocstring.md). This string resource is found in the application's resource file. For example:  
  
 `// MYCALC.RC`  
  
 `STRINGTABLE PRELOAD DISCARDABLE`  
  
 `BEGIN`  
  
 `IDR_SHEETTYPE "\nSheet\nWorksheet\nWorksheets (*.myc)\n.myc\n MyCalcSheet\nMyCalc Worksheet"`  
  
 `END`  
  
 Note that the string begins with a '\n' character; this is because the first substring is not used for MDI applications and so is not included. You can edit this string using the string editor; the entire string appears as a single entry in the String Editor, not as seven separate entries.  
  
 `pDocClass`  
 Points to the `CRuntimeClass` object of the document class. This class is a **CDocument**-derived class you define to represent your documents.  
  
 `pFrameClass`  
 Points to the `CRuntimeClass` object of the frame window class. This class can be a `CFrameWnd`-derived class, or it can be `CFrameWnd` itself if you want default behavior for your main frame window.  
  
 `pViewClass`  
 Points to the `CRuntimeClass` object of the view class. This class is a `CView`-derived class you define to display your documents.  
  
## Remarks  
 Use this member function to construct a `CDocTemplate` object. Dynamically allocate a `CDocTemplate` object and pass it to [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md) from the `InitInstance` member function of your application class.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md)   
 [CMultiDocTemplate::CMultiDocTemplate](../vs140/cmultidoctemplate--cmultidoctemplate.md)   
 [CSingleDocTemplate::CSingleDocTemplate](../vs140/csingledoctemplate--csingledoctemplate.md)   
 [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)   
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)