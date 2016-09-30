---
title: "COleInsertDialog::GetDrawAspect"
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
  - "COleInsertDialog::GetDrawAspect"
  - "COleInsertDialog.GetDrawAspect"
  - "GetDrawAspect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleInsertDialog class, operations and attributes"
  - "GetDrawAspect method"
ms.assetid: 780b329f-cd59-4239-a141-431a66d6aabd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleInsertDialog::GetDrawAspect
Call this function to determine if the user chose to display the selected item as an icon.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The method needed to render the object.  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> Returned if the Display As Icon check box was not checked.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Returned if the Display As Icon check box was checked.  
  
## Remarks  
 Call this function only if [DoModal](../vs140/coleinsertdialog--domodal.md) returns **IDOK**.  
  
 For more information on drawing aspect, see [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) data structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleInsertDialog Class](../vs140/coleinsertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleInsertDialog::DoModal](../vs140/coleinsertdialog--domodal.md)   
 [COleInsertDialog::COleInsertDialog](../vs140/coleinsertdialog--coleinsertdialog.md)