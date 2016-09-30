---
title: "CMDIChildWndEx::GetDocumentName"
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
  - "GetDocumentName"
  - "CMDIChildWndEx::GetDocumentName"
  - "CMDIChildWndEx.GetDocumentName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocumentName method"
ms.assetid: 6e2be2f9-08a8-4d52-a477-388e2422a094
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::GetDocumentName
Returns the name of the document that is displayed in the MDI child window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a string that contains the name of a document.  
  
## Remarks  
 A document is what the MDI child window displays. Generally, the window displays data that is loaded from or saved to a file. Therefore, the name of the document is the name of the file. The default implementation of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns a string obtained from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 If the window displays a document that is not loaded from a file, override this method in a derived class and return a unique document identifier.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called by the framework when it saves the state of all opened documents. The returned string is written to the registry.  
  
 When the framework is restoring state later, the document name is read from the registry and passed to [CMDIFrameWndEx::CreateDocumentWindow](../vs140/cmdiframewndex--createdocumentwindow.md). Override this method in a [CMDIFrameWndEx](../vs140/cmdiframewndex-class.md)-derived class and create or open a document that has this name and read in the file that has this name. If the document is not based on a file, create the document based on the document identifier itself. You should do the preceding actions only if you intend to save and restore documents.  
  
## Example  
 The following example demonstrates the use of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method. This code snippet comes from the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#17](../vs140/codesnippet/CPP/cmdichildwndex--getdocumentname_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)