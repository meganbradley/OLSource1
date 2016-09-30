---
title: "COleServerDoc::COleServerDoc"
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
  - "COleServerDoc::COleServerDoc"
  - "COleServerDoc.COleServerDoc"
  - "COleServerDoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, constructor"
  - "COleServerDoc class, construction"
ms.assetid: 7726aafa-1da1-410f-8e1b-0378c8242544
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::COleServerDoc
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object without connecting with the OLE system DLLs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You must call [COleLinkingDoc::Register](../vs140/colelinkingdoc--register.md) to open communications with OLE. If you are using [COleTemplateServer](../vs140/coletemplateserver-class.md) in your application, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called for you by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>'s implementation of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleLinkingDoc::Register](../vs140/colelinkingdoc--register.md)