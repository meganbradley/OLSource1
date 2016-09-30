---
title: "COleServerDoc::OnClose"
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
  - "COleServerDoc.OnClose"
  - "COleServerDoc::OnClose"
  - "OLECLOSE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, overridables"
  - "OLECLOSE"
  - "OnClose method"
ms.assetid: 41b90af3-1f6f-4cc2-a4f0-0309266fce88
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnClose
Called by the framework when a container requests that the server document be closed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A value from the enumeration <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. This parameter can have one of the following values:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> The file is saved if it has been modified.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> The file is closed without being saved.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> If the file has been modified, the user is prompted about saving it.  
  
## Remarks  
 The default implementation calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 For more information and additional values, see [OLECLOSE](http://msdn.microsoft.com/library/windows/desktop/ms680623) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleException Class](../vs140/coleexception-class.md)   
 [CDocument::OnCloseDocument](../vs140/cdocument--onclosedocument.md)