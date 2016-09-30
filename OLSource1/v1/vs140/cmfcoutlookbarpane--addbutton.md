---
title: "CMFCOutlookBarPane::AddButton"
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
  - "CMFCOutlookBarPane::AddButton"
  - "AddButton"
  - "CMFCOutlookBarPane.AddButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddButton method"
ms.assetid: 10703171-c7a9-404c-a227-5d5580477192
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarPane::AddButton
Adds a button to the Outlook bar pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the resource identifier of a bitmap.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the button's text.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the button control's ID.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the zero-based index on the outlook bar's page at which to insert the button.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A string resource ID.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the name of the disk image file to load.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the button's text.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A handle to a button's bitmap.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A handle to a buttons' icon.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if a button was added successfully; otherwise <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method to insert a new button into an Outlook bar's page. The button's image can be loaded either from the application resources or from a disk file.  
  
 If the page ID specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is -1, the button is inserted into the first page.  
  
 If the index specified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is -1, the button is added at the end of the page.  
  
## Requirements  
 **Header:** afxoutlookbarpane.h  
  
## See Also  
 [CMFCOutlookBarPane Class](../vs140/cmfcoutlookbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)