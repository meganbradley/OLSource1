---
title: "CMDIFrameWndEx::CreateDocumentWindow"
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
  - "CMDIFrameWndEx.CreateDocumentWindow"
  - "CreateDocumentWindow"
  - "CMDIFrameWndEx::CreateDocumentWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDocumentWindow method"
ms.assetid: 681f72da-ad49-4d90-aadc-1718e0d4b405
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::CreateDocumentWindow
Creates a child document window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A text string that contains a document identifier. Typically, it is the full path of a document file.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a user-defined object. For example, a developer can create an application-specific data structure describing the document and telling how the document should be initialized at startup.  
  
## Return Value  
 A pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method when it loads the list of documents previously saved in the registry.  
  
 Override this method in order to create documents when they are being loaded from the registry.  
  
## Example  
 The following example shows how <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 In this example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> could be the name of a "virtual document" (for example, "Start Page") that is not actually loaded from a disk file. Therefore we need special processing to handle that case.  
  
 [!code[NVC_MFC_VisualStudioDemo#13](../vs140/codesnippet/CPP/cmdiframewndex--createdocumentwindow_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)