---
title: "CDocTemplate::GetDocString"
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
  - "GetDocString"
  - "CDocTemplate::GetDocString"
  - "CDocTemplate.GetDocString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "application window title [C++]"
  - "default document names"
  - "default extensions"
  - "windows [C++], titles"
  - "defaults [C++], document names"
  - "CDocTemplate class, operations"
  - "documents [C++], default names"
  - "document types"
  - "GetDocString method"
  - "registration file type"
ms.assetid: 794ce55d-0a48-421e-ac60-8f6640c6185b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::GetDocString
Retrieves a string associated with the document type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that will contain the string when the function returns.  
  
 *index*  
 An index of the substring being retrieved from the string that describes the document type. This parameter can have one of the following values:  
  
-   **CDocTemplate::windowTitle** Name that appears in the application window's title bar (for example, "Microsoft Excel"). Present only in the document template for SDI applications.  
  
-   **CDocTemplate::docName** Root for the default document name (for example, "Sheet"). This root, plus a number, is used for the default name of a new document of this type whenever the user chooses the New command from the File menu (for example, "Sheet1" or "Sheet2"). If not specified, "Untitled" is used as the default.  
  
-   **CDocTemplate::fileNewName** Name of this document type. If the application supports more than one type of document, this string is displayed in the File New dialog box (for example, "Worksheet"). If not specified, the document type is inaccessible using the File New command.  
  
-   **CDocTemplate::filterName** Description of the document type and a wildcard filter matching documents of this type. This string is displayed in the List Files Of Type drop-down list in the File Open dialog box (for example, "Worksheets (*.xls)"). If not specified, the document type is inaccessible using the File Open command.  
  
-   **CDocTemplate::filterExt** Extension for documents of this type (for example, ".xls"). If not specified, the document type is inaccessible using the File Open command.  
  
-   **CDocTemplate::regFileTypeId** Identifier for the document type to be stored in the registration database maintained by Windows. This string is for internal use only (for example, "ExcelWorksheet"). If not specified, the document type cannot be registered with the Windows File Manager.  
  
-   **CDocTemplate::regFileTypeName** Name of the document type to be stored in the registration database. This string may be displayed in dialog boxes of applications that access the registration database (for example, "Microsoft Excel Worksheet").  
  
## Return Value  
 Nonzero if the specified substring was found; otherwise 0.  
  
## Remarks  
 Call this function to retrieve a specific substring describing the document type. The string containing these substrings is stored in the document template and is derived from a string in the resource file for the application. The framework calls this function to get the strings it needs for the application's user interface. If you have specified a filename extension for your application's documents, the framework also calls this function when adding an entry to the Windows registration database; this allows documents to be opened from the Windows File Manager.  
  
 Call this function only if you are deriving your own class from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMultiDocTemplate::CMultiDocTemplate](../vs140/cmultidoctemplate--cmultidoctemplate.md)   
 [CSingleDocTemplate::CSingleDocTemplate](../vs140/csingledoctemplate--csingledoctemplate.md)   
 [CWinApp::RegisterShellFileTypes](../vs140/cwinapp--registershellfiletypes.md)