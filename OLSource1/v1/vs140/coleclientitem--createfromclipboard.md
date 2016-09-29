---
title: "COleClientItem::CreateFromClipboard"
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
  - "COleClientItem::CreateFromClipboard"
  - "COleClientItem.CreateFromClipboard"
  - "CreateFromClipboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, creation"
  - "CreateFromClipboard method"
ms.assetid: 65d11c12-6407-4a91-8289-9120f3b1d506
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::CreateFromClipboard
Call this function to create an embedded item from the contents of the Clipboard.  
  
## Syntax  
  
```  
  
      BOOL CreateFromClipboard(  
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
 You typically call this function from the message handler for the Paste command on the Edit menu. (The Paste command is enabled by the framework if the [CanPaste](../vs140/coleclientitem--canpaste.md) member function returns nonzero.)  
  
 For more information, see [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507) and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::AttachClipboard](../vs140/coledataobject--attachclipboard.md)   
 [COleClientItem::CreateFromData](../vs140/coleclientitem--createfromdata.md)   
 [COleClientItem::CanPaste](../vs140/coleclientitem--canpaste.md)