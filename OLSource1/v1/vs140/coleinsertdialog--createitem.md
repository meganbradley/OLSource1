---
title: "COleInsertDialog::CreateItem"
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
  - "COleInsertDialog::CreateItem"
  - "COleInsertDialog.CreateItem"
  - "CreateItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleInsertDialog class, operations and attributes"
  - "CreateItem method"
ms.assetid: 61b12c70-bd17-465b-946f-edc1a2e88f76
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleInsertDialog::CreateItem
Call this function to create an object of type [COleClientItem](../vs140/coleclientitem-class.md) only if [DoModal](../vs140/coleinsertdialog--domodal.md) returns **IDOK**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the item to be created.  
  
## Return Value  
 Nonzero if item was created; otherwise 0.  
  
## Remarks  
 You must allocate the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object before you can call this function.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleInsertDialog Class](../vs140/coleinsertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::CreateLinkFromFile](../vs140/coleclientitem--createlinkfromfile.md)   
 [COleClientItem::CreateFromFile](../vs140/coleclientitem--createfromfile.md)   
 [COleClientItem::CreateNewItem](../vs140/coleclientitem--createnewitem.md)   
 [COleClientItem::SetDrawAspect](../vs140/coleclientitem--setdrawaspect.md)   
 [COleInsertDialog::GetSelectionType](../vs140/coleinsertdialog--getselectiontype.md)   
 [COleInsertDialog::DoModal](../vs140/coleinsertdialog--domodal.md)