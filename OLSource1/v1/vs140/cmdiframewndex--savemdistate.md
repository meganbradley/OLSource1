---
title: "CMDIFrameWndEx::SaveMDIState"
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
  - "CMDIFrameWndEx::SaveMDIState"
  - "CMDIFrameWndEx.SaveMDIState"
  - "SaveMDIState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveMDIState method"
ms.assetid: 8f7ec628-78b0-437e-8ae3-40968618d5eb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::SaveMDIState
Saves the current layout of MDI Tabbed Groups and the list of previously opened documents.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the profile name.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the save succeeded; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the save failed.  
  
## Remarks  
 To load or save the state of MDI tabs and groups and the list of opened documents, do the following:  
  
-   Call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when the main frame is being closed  
  
-   Call [CMDIFrameWndEx::LoadMDIState](../vs140/cmdiframewndex--loadmdistate.md) when the main frame is being created. The recommended location for this call is before the main frame is displayed for the first time.  
  
-   Call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   Call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> after <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to display the main frame at the position that was stored in the registry.  
  
-   Override <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>- derived class if your application displays documents that are not stored as files. The returned string will be saved in the registry as a document identifier. For more information, see [CMDIChildWndEx::GetDocumentName](../vs140/cmdichildwndex--getdocumentname.md).  
  
-   Override [CMDIFrameWndEx::CreateDocumentWindow](../vs140/cmdiframewndex--createdocumentwindow.md) to correctly create documents when they are loaded from the registry. The parameter to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the string that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returned earlier.  
  
## Example  
 The following example shows how <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#15](../vs140/codesnippet/CPP/cmdiframewndex--savemdistate_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)