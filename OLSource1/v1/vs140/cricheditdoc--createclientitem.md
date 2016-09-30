---
title: "CRichEditDoc::CreateClientItem"
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
  - "CreateClientItem"
  - "CRichEditDoc.CreateClientItem"
  - "CRichEditDoc::CreateClientItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateClientItem method"
ms.assetid: cb7f8109-a294-4a19-af71-355192544a8f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditDoc::CreateClientItem
Call this function to create a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and add it to this document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *preo*  
 Pointer to an [REOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787946) structure which describes an OLE item. The new <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is constructed around this OLE item. If *preo* is **NULL**, the new client item is empty.  
  
## Return Value  
 Pointer to a new [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object which has been added to this document.  
  
## Remarks  
 This function does not perform any OLE initialization.  
  
 For more information, see the [REOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787946) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditDoc Class](../vs140/cricheditdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCntrItem::CRichEditCntrItem](../vs140/cricheditcntritem--cricheditcntritem.md)   
 [COleDocument::AddItem](../vs140/coledocument--additem.md)