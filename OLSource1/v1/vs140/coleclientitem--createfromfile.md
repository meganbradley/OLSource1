---
title: "COleClientItem::CreateFromFile"
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
  - COleClientItem::CreateFromFile
  - COleClientItem.CreateFromFile
  - CreateFromFile
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleClientItem class, creation
  - CreateFromFile method
ms.assetid: 846bab79-0aa3-4be2-8840-910a7071a543
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::CreateFromFile
Call this function to create an embedded OLE item from a file.  
  
## Syntax  
  
```  
  
      BOOL CreateFromFile(  
   LPCTSTR lpszFileName,  
   REFCLSID clsid = CLSID_NULL,  
   OLERENDER render = OLERENDER_DRAW,  
   CLIPFORMAT cfFormat = 0,  
   LPFORMATETC lpFormatEtc = NULL   
);  
```  
  
#### Parameters  
 `lpszFileName`  
 Pointer to the name of the file from which the OLE item is to be created.  
  
 `clsid`  
 Reserved for future use.  
  
 *render*  
 Flag specifying how the server will render the OLE item. For the possible values, see [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `cfFormat`  
 Specifies the Clipboard data format to be cached when creating the OLE item.  
  
 `lpFormatEtc`  
 Pointer to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure used if *render* is **OLERENDER_FORMAT** or **OLERENDER_DRAW**. Provide a value for this parameter only if you want to specify additional format information beyond the Clipboard format specified by `cfFormat`. If you omit this parameter, default values are used for the other fields in the **FORMATETC** structure.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The framework calls this function from [COleInsertDialog::CreateItem](../vs140/coleinsertdialog--createitem.md) if the user chooses OK from the Insert Object dialog box when the Create from File button is selected.  
  
 For more information, see [OleCreateFromFile](http://msdn.microsoft.com/library/windows/desktop/ms690116), [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507), and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleInsertDialog::CreateItem](../vs140/coleinsertdialog--createitem.md)