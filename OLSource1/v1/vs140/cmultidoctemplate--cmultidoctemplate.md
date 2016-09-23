---
title: "CMultiDocTemplate::CMultiDocTemplate"
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
  - CMultiDocTemplate.CMultiDocTemplate
  - CMultiDocTemplate::CMultiDocTemplate
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMultiDocTemplate class, constructor
  - CMultiDocTemplate constructor
ms.assetid: 221af7d5-ba28-49ec-95dd-5af90d1cb645
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMultiDocTemplate::CMultiDocTemplate
Constructs a `CMultiDocTemplate` object.  
  
## Syntax  
  
```  
  
      CMultiDocTemplate(  
   UINT nIDResource,  
   CRuntimeClass* pDocClass,  
   CRuntimeClass* pFrameClass,  
   CRuntimeClass* pViewClass   
);  
```  
  
#### Parameters  
 `nIDResource`  
 Specifies the ID of the resources used with the document type. This may include menu, icon, accelerator table, and string resources.  
  
 The string resource consists of up to seven substrings separated by the '\n' character (the '\n' character is needed as a place holder if a substring is not included; however, trailing '\n' characters are not necessary); these substrings describe the document type. For information on the substrings, see [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md). This string resource is found in the application's resource file. For example:  
  
 `// MYCALC.RC`  
  
 `STRINGTABLE PRELOAD DISCARDABLE`  
  
 `BEGIN`  
  
 `IDR_SHEETTYPE "\nSheet\nWorksheet\nWorksheets (*.myc)\n.myc\n MyCalcSheet\nMyCalc Worksheet"`  
  
 `END`  
  
 Note that the string begins with a '\n' character; this is because the first substring is not used for MDI applications and so is not included. You can edit this string using the string editor; the entire string appears as a single entry in the String Editor, not as seven separate entries.  
  
 For more information about these resource types, see [Resource Editors](../vs140/resource-editors.md).  
  
 `pDocClass`  
 Points to the `CRuntimeClass` object of the document class. This class is a **CDocument**-derived class you define to represent your documents.  
  
 `pFrameClass`  
 Points to the `CRuntimeClass` object of the frame-window class. This class can be a `CMDIChildWnd`-derived class, or it can be `CMDIChildWnd` itself if you want default behavior for your document frame windows.  
  
 `pViewClass`  
 Points to the `CRuntimeClass` object of the view class. This class is a `CView`-derived class you define to display your documents.  
  
## Remarks  
 Dynamically allocate one `CMultiDocTemplate` object for each document type that your application supports and pass each one to `CWinApp::AddDocTemplate` from the `InitInstance` member function of your application class.  
  
## Example  
 [!code[NVC_MFCDocView#92](../vs140/codesnippet/CPP/cmultidoctemplate--cmultidoctemplate_1.cpp)]
  
  
 Here is a second example.  
  
 [!code[NVC_MFCDocView#93](../vs140/codesnippet/CPP/cmultidoctemplate--cmultidoctemplate_2.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMultiDocTemplate Class](../vs140/cmultidoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md)   
 [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)   
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)