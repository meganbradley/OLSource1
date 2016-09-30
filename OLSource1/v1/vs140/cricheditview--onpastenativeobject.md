---
title: "CRichEditView::OnPasteNativeObject"
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
  - "OnPasteNativeObject"
  - "CRichEditView::OnPasteNativeObject"
  - "CRichEditView.OnPasteNativeObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPasteNativeObject method"
  - "CRichEditView class, overridables"
ms.assetid: f3fe0f3c-ad8f-4051-984f-a7a20d6994d9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnPasteNativeObject
Use this function to load native data from an embedded item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpStg*  
 Pointer to an [IStorage](http://msdn.microsoft.com/library/windows/desktop/aa380015) object.  
  
## Return Value  
 Nonzero if successful; otherwise, 0;  
  
## Remarks  
 Typically, you would do this by creating a [COleStreamFile](../vs140/colestreamfile-class.md) around the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can be attached to an archive and [CObject::Serialize](../vs140/cobject--serialize.md) called to load the data.  
  
 This is an advanced overridable.  
  
 For more information, see [IStorage](http://msdn.microsoft.com/library/windows/desktop/aa380015) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleStreamFile Class](../vs140/colestreamfile-class.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)   
 [CArchive Class](../vs140/carchive-class.md)