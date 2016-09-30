---
title: "COleInsertDialog::GetSelectionType"
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
  - "GetSelectionType"
  - "COleInsertDialog::GetSelectionType"
  - "COleInsertDialog.GetSelectionType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelectionType method"
  - "selection"
  - "COleInsertDialog class, operations and attributes"
ms.assetid: 71254b87-a1ff-4d7d-8360-bf00f272fc40
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleInsertDialog::GetSelectionType
Call this function to get the selection type chosen when the Insert Object dialog box was dismissed by choosing **OK**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Type of selection made.  
  
## Remarks  
 The return type values are specified by the **Selection** enumeration type declared in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 Brief descriptions of these values follow:  
  
-   **COleInsertDialog::createNewItem** The Create New radio button was selected.  
  
-   **COleInsertDialog::insertFromFile** The Create From File radio button was selected and the Link check box was not checked.  
  
-   **COleInsertDialog::linkToFile** The Create From File radio button was selected and the Link check box was checked.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleInsertDialog Class](../vs140/coleinsertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleInsertDialog::DoModal](../vs140/coleinsertdialog--domodal.md)   
 [COleInsertDialog::COleInsertDialog](../vs140/coleinsertdialog--coleinsertdialog.md)