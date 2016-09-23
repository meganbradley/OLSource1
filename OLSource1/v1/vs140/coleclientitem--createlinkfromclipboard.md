---
title: "COleClientItem::CreateLinkFromClipboard"
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
  - COleClientItem::CreateLinkFromClipboard
  - CreateLinkFromClipboard
  - COleClientItem.CreateLinkFromClipboard
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateLinkFromClipboard method
  - COleClientItem class, creation
ms.assetid: 3f1fa953-398c-42c7-b6d3-860da1c79741
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::CreateLinkFromClipboard
Call this function to create a linked item from the contents of the Clipboard.  
  
## Syntax  
  
```  
  
      BOOL CreateLinkFromClipboard(  
   OLERENDER render = OLERENDER_DRAW,  
   CLIPFORMAT cfFormat = 0,  
   LPFORMATETC lpFormatEtc = NULL   
);  
```  
  
#### Parameters  
 *render*  
 Flag specifying how the server will render the OLE item. For the possible values, see [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `cfFormat`  
 Specifies the Clipboard data format to be cached when creating the OLE item.  
  
 `lpFormatEtc`  
 Pointer to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure used if *render* is **OLERENDER_FORMAT** or **OLERENDER_DRAW**. Provide a value for this parameter only if you want to specify additional format information beyond the Clipboard format specified by `cfFormat`. If you omit this parameter, default values are used for the other fields in the **FORMATETC** structure.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You typically call this function from the message handler for the Paste Link command on the Edit menu. (The Paste Link command is enabled in the default implementation of [COleDocument](../vs140/coledocument-class.md) if the Clipboard contains an OLE item that can be linked to.)  
  
 For more information, see [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507) and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::CanPasteLink](../vs140/coleclientitem--canpastelink.md)   
 [COleClientItem::CreateLinkFromData](../vs140/coleclientitem--createlinkfromdata.md)   
 [COleDataObject::AttachClipboard](../vs140/coledataobject--attachclipboard.md)