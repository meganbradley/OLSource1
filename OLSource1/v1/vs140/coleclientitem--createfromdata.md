---
title: "COleClientItem::CreateFromData"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleClientItem.CreateFromData
  - CreateFromData
  - COleClientItem::CreateFromData
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleClientItem class, creation
  - CreateFromData method
ms.assetid: 8ed669ea-4f33-4527-9111-3d1b384c333d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::CreateFromData
Call this function to create an embedded item from a `COleDataObject` object.  
  
## Syntax  
  
```  
  
      BOOL CreateFromData(  
   COleDataObject* pDataObject,  
   OLERENDER render = OLERENDER_DRAW,  
   CLIPFORMAT cfFormat = 0,  
   LPFORMATETC lpFormatEtc = NULL   
);  
```  
  
#### Parameters  
 `pDataObject`  
 Pointer to the [COleDataObject](../vs140/coledataobject-class.md) object from which the OLE item is to be created.  
  
 *render*  
 Flag specifying how the server will render the OLE item. For the possible values, see [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `cfFormat`  
 Specifies the Clipboard data format to be cached when creating the OLE item.  
  
 `lpFormatEtc`  
 Pointer to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure used if *render* is **OLERENDER_FORMAT** or **OLERENDER_DRAW**. Provide a value for this parameter only if you want to specify additional format information beyond the Clipboard format specified by `cfFormat`. If you omit this parameter, default values are used for the other fields in the **FORMATETC** structure.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Data transfer operations, such as pasting from the Clipboard or drag-and-drop operations, provide `COleDataObject` objects containing the information offered by a server application. It is usually used in your override of [CView::OnDrop](../vs140/cview--ondrop.md).  
  
 For more information, see [OleCreateFromData](http://msdn.microsoft.com/library/windows/desktop/ms691211), [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507), and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::AttachClipboard](../vs140/coledataobject--attachclipboard.md)   
 [COleClientItem::CreateFromClipboard](../vs140/coleclientitem--createfromclipboard.md)   
 [COleDataObject Class](../vs140/coledataobject-class.md)