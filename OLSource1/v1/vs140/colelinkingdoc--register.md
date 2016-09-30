---
title: "COleLinkingDoc::Register"
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
  - "COleLinkingDoc.Register"
  - "COleLinkingDoc::Register"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Register method"
  - "COleLinkingDoc class, operations"
ms.assetid: 5db62f75-3601-46bb-9413-776c2509866f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleLinkingDoc::Register
Informs the OLE system DLLs that the document is open.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pFactory*  
 Pointer to an OLE factory object (can be **NULL**).  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the fully qualified path of the container document.  
  
## Return Value  
 Nonzero if the document is successfully registered; otherwise 0.  
  
## Remarks  
 Call this function when creating or opening a named file to register the document with the OLE system DLLs. There is no need to call this function if the document represents an embedded item.  
  
 If you are using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in your application, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called for you by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>'s implementation of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleLinkingDoc Class](../vs140/colelinkingdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleTemplateServer Class](../vs140/coletemplateserver-class.md)   
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [CDocument::OnNewDocument](../vs140/cdocument--onnewdocument.md)   
 [CDocument::OnOpenDocument](../vs140/cdocument--onopendocument.md)