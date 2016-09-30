---
title: "COleClientItem::CreateLinkFromFile"
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
  - "COleClientItem::CreateLinkFromFile"
  - "CreateLinkFromFile"
  - "COleClientItem.CreateLinkFromFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, creation"
  - "CreateLinkFromFile method"
ms.assetid: 60cd94de-f9c0-4b08-a000-a2e8318efec1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::CreateLinkFromFile
Call this function to create a linked OLE item from a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the name of the file from which the OLE item is to be created.  
  
 *render*  
 Flag specifying how the server will render the OLE item. For the possible values, see [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the Clipboard data format to be cached when creating the OLE item.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure used if *render* is **OLERENDER_FORMAT** or **OLERENDER_DRAW**. Provide a value for this parameter only if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If you omit this parameter, default values are used for the other fields in the **FORMATETC** structure.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The framework calls this function if the user chooses OK from the Insert Object dialog box when the Create from File button is selected and the Link check box is checked. It is called from [COleInsertDialog::CreateItem](../vs140/coleinsertdialog--createitem.md).  
  
 For more information, see [OleCreateLinkToFile](http://msdn.microsoft.com/library/windows/desktop/ms678434), [OLERENDER](http://msdn.microsoft.com/library/windows/desktop/ms691507), and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleInsertDialog::CreateItem](../vs140/coleinsertdialog--createitem.md)