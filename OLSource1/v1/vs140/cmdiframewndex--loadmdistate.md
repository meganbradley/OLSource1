---
title: "CMDIFrameWndEx::LoadMDIState"
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
  - "CMDIFrameWndEx::LoadMDIState"
  - "LoadMDIState"
  - "CMDIFrameWndEx.LoadMDIState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadMDIState method"
ms.assetid: 1fdd209d-0fdf-41db-a7c9-c4f56de442d3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::LoadMDIState
Loads the specified layout of MDI Tabbed Groups and the list of previously opened documents.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the profile name.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the load succeeded; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the load failed or there is no data to load.  
  
## Remarks  
 To load or save the state of MDI tabs and groups and the list of opened documents, do the following:  
  
-   Call [CMDIFrameWndEx::SaveMDIState](../vs140/cmdiframewndex--savemdistate.md) when the main frame is being closed  
  
-   Call [CMDIFrameWndEx::LoadMDIState](../vs140/cmdiframewndex--loadmdistate.md) when the main frame is being created. The recommended place for this call is before the main frame is displayed for the first time. Add <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Add <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> after the call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to display the main frame at the position that was stored in the registry.  
  
-   Override <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>- derived class if your application displays documents that are not stored as files. The returned string will be saved in the registry as the document identifier. The base implementation of [CMDIChildWndEx::GetDocumentName](../vs140/cmdichildwndex--getdocumentname.md) returns a value obtained from [CDocument::GetPathName](../vs140/cdocument--getpathname.md).  
  
-   Override [CMDIFrameWndEx::CreateDocumentWindow](../vs140/cmdiframewndex--createdocumentwindow.md) to correctly create documents when they are being loaded from the registry. The first parameter is the string that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returned.  
  
## Example  
 The following example shows how <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#11](../vs140/codesnippet/CPP/cmdiframewndex--loadmdistate_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)