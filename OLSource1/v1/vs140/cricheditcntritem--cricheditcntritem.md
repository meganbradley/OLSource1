---
title: "CRichEditCntrItem::CRichEditCntrItem"
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
  - "CRichEditCntrItem::CRichEditCntrItem"
  - "CRichEditCntrItem.CRichEditCntrItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditCntrItem class, constructor"
ms.assetid: 2e9d139e-2c34-475d-acb7-8beed6885ece
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCntrItem::CRichEditCntrItem
Call this function to create a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and add it to the container document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *preo*  
 Pointer to an [REOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787946) structure which describes an OLE item. The new <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is constructed around this OLE item. If *preo* is **NULL**, the client item is empty.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the container document that will contain this item. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **NULL**, you must explicitly call [COleDocument::AddItem](../vs140/coledocument--additem.md) to add this client item to a document.  
  
## Remarks  
 This function does not perform any OLE initialization.  
  
 For more information, see the [REOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787946) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditCntrItem Class](../vs140/cricheditcntritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::AddItem](../vs140/coledocument--additem.md)   
 [CRichEditDoc Class](../vs140/cricheditdoc-class.md)