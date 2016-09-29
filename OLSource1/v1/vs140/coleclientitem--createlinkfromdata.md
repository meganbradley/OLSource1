---
title: "COleClientItem::CreateLinkFromData"
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
  - "CreateLinkFromData"
  - "COleClientItem::CreateLinkFromData"
  - "COleClientItem.CreateLinkFromData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, creation"
  - "CreateLinkFromData method"
ms.assetid: 8c607a28-ccd7-446d-8057-3e48ea6d1c88
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::CreateLinkFromData
Call this function to create a linked item from a `COleDataObject` object.  
  
## Syntax  
  
```  
  
      BOOL CreateLinkFromData(  
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
 Call this during a drop operation when the user indicates a link should be created. It can also be used to handle the Edit Paste command. It is called by the framework in `COleClientItem::CreateLinkFromClipboard` and in [COlePasteSpecialDialog::CreateItem](../vs140/colepastespecialdialog--createitem.md) when the Link option has been selected.  
  
 For more information, see [OleCreateLinkFromData](http://msdn.microsoft.com/library/windows/desktop/ms680731), [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507), and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::AttachClipboard](../vs140/coledataobject--attachclipboard.md)   
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [COleClientItem::CreateLinkFromClipboard](../vs140/coleclientitem--createlinkfromclipboard.md)